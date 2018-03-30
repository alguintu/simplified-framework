Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing

Public NotInheritable Class CenteredMessageBox
    Implements IDisposable
    Private mTries As Integer = 0
    Private mOwner As Form

    Public Sub New(owner As Form)
        mOwner = owner
        owner.BeginInvoke(New MethodInvoker(AddressOf findDialog))
    End Sub

    Private Sub findDialog()
        ' Enumerate windows to find the message box
        If mTries < 0 Then
            Return
        End If
        Dim callback As New NativeMethods.EnumThreadWndProc(AddressOf checkWindow)
        If NativeMethods.EnumThreadWindows(NativeMethods.GetCurrentThreadId(), callback, IntPtr.Zero) Then
            If System.Threading.Interlocked.Increment(mTries) < 10 Then
                mOwner.BeginInvoke(New MethodInvoker(AddressOf findDialog))
            End If
        End If
    End Sub

    Private Function checkWindow(hWnd As IntPtr, lp As IntPtr) As Boolean
        ' Checks if <hWnd> is a dialog
        Dim sb As New StringBuilder(260)
        NativeMethods.GetClassName(hWnd, sb, sb.Capacity)
        If sb.ToString() <> "#32770" Then
            Return True
        End If
        ' Got it
        Dim frmRect As New Rectangle(mOwner.Location, mOwner.Size)
        Dim dlgRect As DialogRectangle
        NativeMethods.GetWindowRect(hWnd, dlgRect)
        NativeMethods.MoveWindow(hWnd, frmRect.Left + (frmRect.Width - dlgRect.Right + dlgRect.Left) \ 2, frmRect.Top + (frmRect.Height - dlgRect.Bottom + dlgRect.Top) \ 2, dlgRect.Right - dlgRect.Left, dlgRect.Bottom - dlgRect.Top, True)
        Return False
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        mTries = -1
    End Sub
End Class
