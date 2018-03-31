Imports System.Windows.Forms
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraSplashScreen
Imports Simplified.Framework.Interfaces
Imports Simplified.Framework.Logic

Namespace Core
    Public NotInheritable Class UiManager
        Private WithEvents M As RibbonForm
        Private WithEvents R As RibbonControl
        Private WithEvents N As OfficeNavigationBar
        Private WithEvents F As NavigationFrame

        Private Shared ReadOnly _instance As New Lazy(Of UiManager)(Function() New UiManager(), Threading.LazyThreadSafetyMode.ExecutionAndPublication)
        Public Shared ReadOnly Property Instance() As UiManager
            Get
                Return _instance.Value
            End Get
        End Property
        Public ReadOnly Property MainForm As RibbonForm
            Get
                Return M
            End Get
        End Property
        Public ReadOnly Property Ribbon As RibbonControl
            Get
                Return R
            End Get
        End Property
        Public ReadOnly Property Status As RibbonStatusBar
            Get
                Return R.StatusBar
            End Get
        End Property
        Public ReadOnly Property NavBar As OfficeNavigationBar
            Get
                Return N
            End Get
        End Property
        Public ReadOnly Property Frame As NavigationFrame
            Get
                Return F
            End Get
        End Property
        Public ReadOnly Property CurrentView As ModuleBase
        Private PeekList As Dictionary(Of String, Peek)

        Public Sub LockView(lock As Boolean)
            Ribbon.Enabled = Not lock
        End Sub

        Public Sub Setup(main As IMainForm, ribbon As RibbonControl, navBar As OfficeNavigationBar, navFrame As NavigationFrame)
            M = main
            R = ribbon
            N = navBar
            F = navFrame
            PeekList = New Dictionary(Of String, Peek)
        End Sub

        Public Sub AddModule(name As String, view As Object)
            If view IsNot Nothing Then
                Dim item = New NavigationBarItem() With {.Text = name, .Tag = view}
                NavBar.Items.Add(item)
                If view.GetType.Equals(GetType(ModuleGroup)) Then
                    PeekList.Add(name, view.Peek)
                    view.NavItem = item
                End If
            End If
        End Sub

        Private Sub NavigationBar_SelectedItemChanging(sender As Object, e As SelectedItemChangingEventArgs) Handles N.SelectedItemChanging
            If e.Item.Tag Is Nothing Then
                e.Cancel = True
            Else
                SplashScreenManager.ShowForm(MainForm, GetType(WaitForm), True, True, False)
                SplashScreenManager.Default.SetWaitFormCaption((e.Item.Text).ToString.SeparateCamelCase())
                If e.Item.Tag.GetType.Equals(GetType(ModuleGroup)) Then
                    Dim group = DirectCast(e.Item.Tag, ModuleGroup)
                    e.Item.Tag = SetupPage(group.CurrentView, group)
                ElseIf Not e.Item.Tag.GetType.Equals(GetType(NavigationPage)) AndAlso Not e.Item.Tag.isValueCreated() Then
                    Dim iModule = CType(e.Item.Tag.Value(), ModuleBase)
                    e.Item.Tag = SetupPage(iModule, iModule)
                End If
                SplashScreenManager.CloseForm(False)
            End If
        End Sub

        Private Sub NavigationBar_SelectedItemChanged(sender As Object, e As NavigationBarItemEventArgs) Handles N.SelectedItemChanged
            Dim nextView As ModuleBase = Nothing
            If e.Item.Tag.Tag.GetType.Equals(GetType(ModuleGroup)) Then
                nextView = e.Item.Tag.Tag.CurrentView
            ElseIf e.Item.Tag.Tag.GetType.IsSubclassOf(GetType(ModuleBase)) Then
                nextView = e.Item.Tag.Tag
            End If
            If nextView Is Nothing Then Return
            SwitchView(nextView, e.Item.Tag)
        End Sub

        Public Function SetupPage(v As ModuleBase, tag As Object) As NavigationPage
            Dim page = New NavigationPage() With {.Tag = tag}
            Frame.Pages.Add(page)
            Return page
        End Function

        Public Sub SwitchView(nextView As ModuleBase, page As NavigationPage)
            MainForm.SuspendLayout()
            MergeRibbons(nextView)
            page.Controls.Clear()
            page.Controls.Add(nextView)
            Frame.SelectedPage = page
            _CurrentView = nextView
            CurrentView.Dock = DockStyle.Fill
            CurrentView.Show()
            CurrentView.Focus()
            MainForm.ResumeLayout()
            N.HidePeekForm()
        End Sub

        Public Sub SwitchView(item As NavigationBarItem)
            NavBar.SelectedItem = item
        End Sub

        Private Sub MergeRibbons(nextView As ModuleBase)
            Ribbon.UnMergeRibbon()
            If nextView.HasRibbon Then Ribbon.MergeRibbon(nextView.Ribbon)
            If CurrentView IsNot Nothing Then If CurrentView.HasStatusBar Then Ribbon.StatusBar.UnMergeStatusBar()
            If nextView.HasStatusBar Then Status.MergeStatusBar(nextView.Status)
        End Sub

        Private Sub ShowPeek(ByVal sender As Object, ByVal e As QueryPeekFormContentEventArgs) Handles N.QueryPeekFormContent
            Try
                Dim peek = PeekList.Item(e.Item.Text)
                e.Control = peek
            Catch ex As Exception
            End Try
        End Sub

        Public Shared Function Instantiate(ByVal t As Type) As Object
            Return t.GetConstructor(New Type() {}).Invoke(New Object() {})
        End Function

        Public Shared Function IsTypeOfType(type As Type) As Boolean
            Return GetType(Type).IsAssignableFrom(type)
        End Function

        Public Sub ShowFirstView()
            If NavBar.Items.Count > 0 Then NavBar.SelectedItem = NavBar.Items.First()
        End Sub
    End Class
End Namespace