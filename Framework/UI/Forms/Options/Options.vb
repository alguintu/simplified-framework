Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Public Class Options
    Public Sub New()
        InitializeComponent()
        AddHandler LookAndFeel.StyleChanged, AddressOf UpdateUI
        UpdateUI()
    End Sub

    Protected Sub UpdateUI()
        panelPages.Appearance.BorderColor = GetSkinBorderColor(UserLookAndFeel.Default.ActiveLookAndFeel)
        panelAccordion.Appearance.BorderColor = GetSkinBorderColor(UserLookAndFeel.Default.ActiveLookAndFeel)
    End Sub

    Protected Overridable Sub SetTags()
    End Sub

    Private Sub AddCategoryPageToPanel(page As Object)
        panelPages.Controls.Add(page)
        page.Dock = DockStyle.Fill
    End Sub

    Private Function Instantiate(ByVal t As System.Type) As Object
        Return t.GetConstructor(New System.Type() {}).Invoke(New Object() {})
    End Function

    Private Function IsTypeOfType(type As Type) As Boolean
        Return GetType(Type).IsAssignableFrom(type)
    End Function

    Private Sub ShowCategoryPage(element As AccordionControlElement)
        SuspendLayout()
        If element.Tag IsNot Nothing AndAlso IsTypeOfType(element.Tag.GetType) Then
            Dim p = Instantiate(element.Tag)
            CType(p, OptionPage).UoW = Me.UnitOfWork
            element.Tag = p
            AddCategoryPageToPanel(p)
        End If
        If element.Tag IsNot Nothing Then CType(element.Tag, XtraUserControl).BringToFront()
        ResumeLayout()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim valid As Boolean = True
        ReValidateChildren()
        For Each element As AccordionControlElement In accordion.Elements(0).Elements
            If element.Tag IsNot Nothing AndAlso Not IsTypeOfType(element.Tag.GetType) Then
                valid = CType(element.Tag, OptionPage).IsPageValid
                If Not valid Then
                    accordion.SelectElement(element)
                    Exit For
                End If
            End If
        Next
        If valid Then
            SaveChanges()
            Me.Close()
        End If
    End Sub

    Private Sub SaveChanges()
        If UnitOfWork.InTransaction Then
            UnitOfWork.CommitChanges()
        End If
    End Sub

    Private Sub ReValidateChildren()
        Me.ValidateChildren()
        For Each element As AccordionControlElement In accordion.Elements
            If element.Tag IsNot Nothing AndAlso Not IsTypeOfType(element.Tag.GetType) Then
                CType(element.Tag, OptionPage).ValidateChildren()
            End If
        Next
    End Sub

    Private Sub accordion_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.ElementClickEventArgs) Handles accordion.ElementClick
        ShowCategoryPage(e.Element)
    End Sub
End Class