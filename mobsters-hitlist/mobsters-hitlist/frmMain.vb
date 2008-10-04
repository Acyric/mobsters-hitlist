Imports System.Runtime.InteropServices
Public Class frmMain
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Long
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Long
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Public Const MOUSEEVENTF_LEFTUP = &H4 ' left button up
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20 ' middle button down
    Public Const MOUSEEVENTF_MIDDLEUP = &H40 ' middle button up
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8 ' right button down
    Public Const MOUSEEVENTF_RIGHTUP = &H10 ' right button up
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2
    Public refreshX As Integer
    Public refreshY As Integer
    Public attackX As Integer
    Public attackY As Integer
    Private Declare Sub ReleaseCapture Lib "user32" ()
    Private Declare Sub SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        MsgBox("The Bot is armed. It will run whenever Caps Lock is turned on")
        tRefresh.Interval = txtDelay.Text
        tRefresh.Enabled = True
        tRefresh.Start()
        btnStart.Enabled = False
        System.Windows.Forms.SendKeys.Send("CAPSLOCK")
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tRefresh.Tick
        If System.Console.CapsLock Then
            SetCursorPos(refreshX, refreshY)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Dim I As Integer
            Do While I < 1500
                I += 0.75
            Loop
            I = 0
            SetCursorPos(attackX, attackY)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Do While I < 1500
                I += 0.75
            Loop
            I = 0
            SetCursorPos(attackX, attackY)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Do While I < 1500
                I += 0.75
            Loop
            I = 0
            SetCursorPos(attackX, attackY)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Do While I < 1500
                I += 0.75
            Loop
            I = 0
            SetCursorPos(attackX, attackY)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Control Or Keys.Alt Or Keys.Shift Or Keys.G
                End
        End Select
    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        MsgBox("Move the mouse over the refresh button and hit the space bar")
        refreshX = MousePosition.X
        refreshY = MousePosition.Y
        btnRefresh.ForeColor = Color.DarkGreen
        If btnAttack.ForeColor = Color.DarkGreen Then
            btnStart.Enabled = True
        End If
    End Sub
    Private Sub btnAttack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttack.Click
        MsgBox("Move the mouse over the attack button and hit the space bar")
        attackX = MousePosition.X
        attackY = MousePosition.Y
        btnAttack.ForeColor = Color.DarkGreen
        If btnRefresh.ForeColor = Color.DarkGreen Then
            btnStart.Enabled = True
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
    Private Sub frmMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle.ToInt32, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        End If
    End Sub

    Private Sub txtDelay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelay.TextChanged
        If txtDelay.Text = "" Then
            txtDelay.Text = 1
        End If
        tRefresh.Interval = txtDelay.Text
    End Sub
End Class
