Imports System.Windows.Forms
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
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

        Public Sub LockView(lock As Boolean)
            Ribbon.Enabled = Not lock
        End Sub

        Public Sub Setup(main As IMainForm, ribbon As RibbonControl, navBar As OfficeNavigationBar, navFrame As NavigationFrame)
            M = main
            R = ribbon
            N = navBar
            F = navFrame
        End Sub

        Public Sub AddModule(name As String, view As Object)
            If view IsNot Nothing Then
                NavBar.Items.Add(New NavigationBarItem() With {.Text = name, .Tag = view})
            End If
        End Sub

        Private Sub NavigationBar_SelectedItemChanging(sender As Object, e As SelectedItemChangingEventArgs) Handles N.SelectedItemChanging
            If e.Item.Tag Is Nothing Then
                e.Cancel = True
            ElseIf Not e.Item.Tag.isValueCreated() Then
                SplashScreenManager.ShowForm(GetType(WaitForm), True, True)
                SplashScreenManager.Default.SetWaitFormCaption((e.Item.Text).ToString.SeparateCamelCase())
                Dim iModule = CType(e.Item.Tag.Value(), ModuleBase)
                Dim page = New NavigationPage() With {.Tag = iModule}
                page.Controls.Add(iModule)
                Frame.Pages.Add(page)
                e.Item.Tag = page
                SplashScreenManager.CloseForm(False)
            End If
        End Sub

        Private Sub NavigationBar_SelectedItemChanged(sender As Object, e As NavigationBarItemEventArgs) Handles N.SelectedItemChanged
            If e.Item.Tag.Tag.GetType.IsSubclassOf(GetType(ModuleBase)) Then
                MainForm.SuspendLayout()
                If e.Item.Tag.Tag.HasRibbon Then Ribbon.MergeRibbon(e.Item.Tag.Tag.Ribbon)
                If CurrentView IsNot Nothing Then If CurrentView.HasStatusBar Then Ribbon.StatusBar.UnMergeStatusBar()
                If e.Item.Tag.Tag.HasStatusBar Then Status.MergeStatusBar(e.Item.Tag.Tag.StatusBar)
                _CurrentView = e.Item.Tag.Tag
                e.Item.Tag.Tag.Dock = DockStyle.Fill
                Frame.SelectedPage = e.Item.Tag
                MainForm.ResumeLayout()
                _CurrentView.Focus()
            End If
        End Sub



        Private Sub ShowPeek(ByVal sender As Object, ByVal e As QueryPeekFormContentEventArgs) Handles N.QueryPeekFormContent
            If e.Item.Tag Is Nothing Then Return
            If e.Item.Tag.GetType.Equals(GetType(NavigationPage)) AndAlso e.Item.Tag.Tag IsNot Nothing AndAlso e.Item.Tag.Tag.Peek IsNot Nothing Then
                e.Control = e.Item.Tag.Tag.Peek
            End If
        End Sub

        Public ReadOnly Property SubModuleSwitcher As NavBarLinkEventHandler
            Get
                Return AddressOf PeekLinkClicked
            End Get
        End Property

        Private Function Instantiate(ByVal t As Type) As Object
            Return t.GetConstructor(New Type() {}).Invoke(New Object() {})
        End Function

        Private Function IsTypeOfType(type As Type) As Boolean
            Return GetType(Type).IsAssignableFrom(type)
        End Function

        Public Sub PeekLinkClicked(sender As Object, e As NavBarLinkEventArgs)
            If e.Link.Item.Tag Is Nothing Then Return
            e.Link.Item.Tag = SwitchSubModule(e.Link.Item.Tag, CType(sender.Tag, Peek).Owner)
            N.HidePeekForm()
        End Sub

        Private Function SwitchSubModule(v As Object, owner As ModuleBase) As ModuleBase
            SplashScreenManager.ShowForm(GetType(WaitForm), True, True)
            MainForm.SuspendLayout()

            Dim view As ModuleBase = If(IsTypeOfType(v.GetType), Instantiate(v), v)
            If CurrentView IsNot view Then
                If view.HasRibbon Then Ribbon.MergeRibbon(view.Ribbon)
                If CurrentView IsNot Nothing Then If CurrentView.HasStatusBar Then Ribbon.StatusBar.UnMergeStatusBar()
                If view.HasStatusBar Then Status.MergeStatusBar(view.Status)
                Dim item As NavigationBarItem = NavBar.Items.ToList.Find(Function(i) i.Tag.Tag.Equals(owner))
                Dim page As NavigationPage = item.Tag
                If Not page.Controls.Contains(view) Then page.Controls.Add(view)
                view.Dock = DockStyle.Fill
                CurrentView.Hide()
                _CurrentView = view
                view.Show()
                If Not Frame.SelectedPage.Equals(page) Then Frame.SelectedPage = page
            End If

            MainForm.ResumeLayout()
            SplashScreenManager.CloseForm(False)

            Return view
        End Function


        Public Sub ShowFirstView()
            If NavBar.Items.Count > 0 Then NavBar.SelectedItem = NavBar.Items.First()
        End Sub

    End Class
End Namespace