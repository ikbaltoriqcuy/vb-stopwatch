Public Class StopWastch
    Dim add As String
    Dim kursor As Point
    Dim pindah As Boolean = False
    Dim f As Point
    Dim C As String
    Dim time As String
    Dim s As Boolean
    Public k As Point
    Dim n(4) As Integer
    Dim enabled As Boolean = False



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If s = False Then
            Timer1.Enabled = True
            Button1.Image = ImageList2.Images.Item(0)
            s = True
            C = ""
        Else
            Timer1.Enabled = False
            Button1.Image = ImageList2.Images.Item(1)
            s = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If C <> "Reverse" Then
            PictureBox1.Image = ImageList1.Images.Item(0)
            PictureBox2.Image = ImageList1.Images.Item(0)
            PictureBox3.Image = ImageList1.Images.Item(0)
            n(1) += +1

            If n(1) = 60 Then
                n(1) = 0
                n(2) += 1
                If n(2) = 60 Then
                    n(2) = 0
                    n(3) += 1
                End If
            End If
            PictureBox1.Image = ImageList1.Images.Item(n(1))
            PictureBox2.Image = ImageList1.Images.Item(n(2))
            PictureBox3.Image = ImageList1.Images.Item(n(3))
            time = "->" & Str(n(3)) & ":" & Str(n(2)) & ":" & Str(n(1))

        Else
            PictureBox1.Image = ImageList1.Images.Item(0)
            PictureBox2.Image = ImageList1.Images.Item(0)
            PictureBox3.Image = ImageList1.Images.Item(0)
            n(1) += 1
            If n(1) = 60 Then
                n(1) = 0
                n(2) += 1
                If n(2) = 60 Then
                    n(2) = 0
                    n(3) += 1
                End If
            End If
            PictureBox1.Image = ImageList1.Images.Item(n(3))
            PictureBox2.Image = ImageList1.Images.Item(n(2))
            PictureBox3.Image = ImageList1.Images.Item(n(1))
            time = "->" & Str(n(3)) & ":" & Str(n(2)) & ":" & Str(n(1))
        End If
    End Sub

    Private Sub Form1_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        pindah = True
        kursor = New Point(e.X, e.Y)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim posisi(3) As Point

        If pindah Then
            posisi(1) = Me.PointToScreen(New Point(e.X, e.Y))
            posisi(2) = Me.PointToScreen(New Point(e.X + 130, e.Y + 10))
            kursor.Offset(Me.Location)
            Me.Location = posisi(1)
            Form2.Location = posisi(2)
        End If


    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        pindah = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Static n As Boolean

        If n = False Then
            C = "Reverse"
            n = True
        Else
            C = "Revers"
            n = false
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub SettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem.Click
        Me.DesktopLocation = k
        If Form2.Visible = True Then
            Me.DesktopLocation = New Point(DesktopLocation.X - 243, DesktopLocation.Y)
            Form2.DesktopLocation = New Point(1077, DesktopLocation.Y + 10)
        End If
    End Sub




    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Interval = 1000

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer1.Interval = 100
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Timer1.Interval = 10
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        k = New Point(DesktopLocation.X + 1180, DesktopLocation.Y + 50)
        Me.DesktopLocation = k
        Form2.DesktopLocation = k
    End Sub



    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        If s = True Then
            PictureBox1.Image = ImageList1.Images.Item(0)
            PictureBox2.Image = ImageList1.Images.Item(0)
            PictureBox3.Image = ImageList1.Images.Item(0)
            n(1) = 0
            n(2) = 0
            n(3) = 0
            Timer1.Enabled = False
            s = False
            Button1.Image = ImageList2.Images.Item(1)

        Else
            PictureBox3.Image = ImageList1.Images.Item(0)
            PictureBox1.Image = ImageList1.Images.Item(0)
            PictureBox2.Image = ImageList1.Images.Item(0)
            n(1) = 0
            n(2) = 0
            n(3) = 0

        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Opacity = 1
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Opacity = 0.9
        Form2.Opacity = 0.9
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Opacity = 0.85
        Form2.Opacity = 0.85
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Me.Opacity = 0.8
        Form2.Opacity = 0.8
    End Sub

    
    Private Sub AlwaysOnTheTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlwaysOnTheTopToolStripMenuItem.Click

        If enabled = False Then

            Me.TopMost = True
            Form2.TopMost = True
            enabled = True
            AlwaysOnTheTopToolStripMenuItem.Checked = True
        Else
            Me.TopMost = False
            Form2.TopMost = False
            enabled = False
            AlwaysOnTheTopToolStripMenuItem.Checked = False
        End If
        
    End Sub
End Class