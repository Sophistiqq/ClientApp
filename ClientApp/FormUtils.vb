Imports System.Runtime.InteropServices

Module FormUtils

    ' Import Windows API functions to handle window movement
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Public Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Public Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    ' Function to enable moving the form when a specific button is held down
    Public Sub EnableFormMovement(ByVal form As Form, ByVal moveButton As PictureBox)
        ' Attach the MouseDown event to the button
        AddHandler moveButton.MouseDown, Sub(sender As Object, e As MouseEventArgs)
                                             ' Call the Windows API function to capture the mouse and enable dragging
                                             ReleaseCapture()
                                             SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
                                         End Sub
    End Sub

End Module
