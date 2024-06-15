Imports System.Runtime.InteropServices

Public Class WinAPI

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure

    <DllImport("dwmapi.dll")> _
    Private Shared Function DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef margins As MARGINS) As Integer
    End Function

    Private Declare Function DwmIsCompositionEnabled Lib "dwmapi" (ByRef pfEnabled As Long) As Long


    Public Shared Sub SetAeroGlass(ctl As Control)

        If IsSystemAeroGlassEnabled() Then
            ctl.BackColor = Color.Black
            Dim margins As New MARGINS()

            margins.leftWidth = -1
            margins.rightWidth = -1
            margins.topHeight = -1
            margins.bottomHeight = -1

            DwmExtendFrameIntoClientArea(ctl.Handle, margins)

        End If

    End Sub

    Public Shared Function IsSystemAeroGlassEnabled() As Boolean

        Dim glassState As Long

        Try
            DwmIsCompositionEnabled(glassState)
        Catch
            glassState = 0
        End Try

        Return CBool(glassState)


    End Function


End Class
