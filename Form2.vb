Public Class Form2
    Dim add As String
    Dim kursor As Point
    Dim pindah As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        StopWastch.DesktopLocation = New Point(1180, 50)
        Beep()
    End Sub


    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        pindah = True
        kursor = New Point(e.X, e.Y)
    End Sub

    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim posisi(3) As Point

        If pindah Then
            posisi(1) = Me.PointToScreen(New Point(e.X, e.Y))
            posisi(2) = Me.PointToScreen(New Point(e.X + 140, e.Y + 10))
            kursor.Offset(Me.Location)
            StopWastch.Location = posisi(1)
            Me.Location = posisi(2)
        End If


    End Sub

    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        pindah = False

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DesktopLocation = k
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        copy = ""
        Beep()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If copy = "" Then
            On Error Resume Next
            MsgBox("file is empty", vbInformation)
        Else
            Clipboard.SetText(copy)
            MsgBox("File Was Copy", vbInformation)

        End If
        Beep()
    End Sub

   
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class