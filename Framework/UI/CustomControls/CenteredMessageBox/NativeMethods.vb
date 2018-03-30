Imports System.Runtime.InteropServices
Imports System.Text


Friend NotInheritable Class NativeMethods
    ' P/Invoke declarations
    Public Delegate Function EnumThreadWndProc(hWnd As IntPtr, lp As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean

    <DllImport("user32.dll")> _
    Friend Shared Function EnumThreadWindows(tid As Integer, callback As EnumThreadWndProc, lp As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("kernel32.dll")> _
    Friend Shared Function GetCurrentThreadId() As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)> _
    Friend Shared Function GetClassName(hWnd As IntPtr, buffer As StringBuilder, buflen As Integer) As <MarshalAs(UnmanagedType.I4)> Integer
    End Function

    <DllImport("user32.dll")> _
    Friend Shared Function GetWindowRect(hWnd As IntPtr, ByRef rc As DialogRectangle) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("user32.dll")> _
    Friend Shared Function MoveWindow(hWnd As IntPtr, x As Integer, y As Integer, w As Integer, h As Integer, repaint As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
End Class