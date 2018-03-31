Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraSplashScreen

Namespace Core
    Public Class ModuleGroup
        Public Property Peek As Peek
        Public Property GroupName As String
        Public Property NavItem As NavigationBarItem
        Private _CurrentView As ModuleBase
        Public Property CurrentView As ModuleBase
            Get
                If _CurrentView Is Nothing Then
                    SplashScreenManager.ShowForm(UiManager.Instance.MainForm, GetType(WaitForm), True, True, False)
                    _CurrentView = Instantiate(Peek.NavBar.Items.First.Tag)
                    Peek.NavBar.Items.First.Tag = _CurrentView
                    SplashScreenManager.CloseForm(False)
                End If
                Return _CurrentView
            End Get
            Set(value As ModuleBase)
                _CurrentView = value
            End Set
        End Property

        Sub New(name As String, modules As Dictionary(Of String, Object))
            Peek = New Peek(name, Me, modules)
        End Sub

        Public Function Instantiate(v As Object) As ModuleBase
            Return If(UiManager.IsTypeOfType(v.GetType), UiManager.Instantiate(v), v)
        End Function

        Public ReadOnly Property PeekHandler As NavBarLinkEventHandler
            Get
                Return AddressOf PeekLinkClicked
            End Get
        End Property

        Public Sub PeekLinkClicked(sender As Object, e As NavBarLinkEventArgs)
            CurrentView = Instantiate(e.Link.Item.Tag)
            e.Link.Item.Tag = CurrentView
            If NavItem.Tag Is Me Then NavItem.Tag = UiManager.Instance.SetupPage(CurrentView, Me)
            If UiManager.Instance.NavBar.SelectedItem Is NavItem Then
                UiManager.Instance.SwitchView(CurrentView, NavItem.Tag)
            Else
                UiManager.Instance.SwitchView(NavItem)
            End If
        End Sub
    End Class
End Namespace