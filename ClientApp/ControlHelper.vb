Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Module ControlHelper
    Public Sub ApplyRoundedCorners(control As Control, radius As Integer)
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(control.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, control.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        control.Region = New Region(path)
    End Sub
End Module
