Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '初始最大数字
        Num = 55
        State.Text = "当前设定的最大数字：" & Num
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        Randomize()

        If Num < 1 Then
            MsgBox("请设定大于0的数", vbOKOnly + vbCritical, "错误")
        Else '符合条件后开始timer是否启用的判定
            '停止另外两个Timer
            Timer2.Enabled = False
            Timer3.Enabled = False
            If Timer1.Enabled = True Then '若timer已启用，则点击按钮停止timer，否则点击按钮启用timer
                Timer1.Enabled = False
                Num1.ForeColor = Color.Red
                Num2.ForeColor = Color.Red
                Num3.ForeColor = Color.Red
            Else
                Num1.ForeColor = Color.Black
                Num2.ForeColor = Color.Black
                Num3.ForeColor = Color.Black
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '生成任意范围随机数：int((上限-下限+1)*rnd +1)
        a = Int(Num * Rnd() + 1)
        Num1.Text = a
        Num2.Text = ""
        Num3.Text = ""
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        Randomize()

        If Num < 2 Then
            MsgBox("请设定大于1的数", vbOKOnly + vbCritical, "错误")
            '判断是否大于1，否则报错
        Else
            Timer1.Enabled = False
            Timer3.Enabled = False
            If Timer2.Enabled = True Then
                Timer2.Enabled = False
                Num1.ForeColor = Color.Red
                Num2.ForeColor = Color.Red
                Num3.ForeColor = Color.Red
            Else
                Timer2.Enabled = True
                Num1.ForeColor = Color.Black
                Num2.ForeColor = Color.Black
                Num3.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Do
            a = Int(Num * Rnd() + 1)
            b = Int(Num * Rnd() + 1)
        Loop Until a <> b
        Num1.Text = a
        Num2.Text = b
        Num3.Text = ""
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        Randomize()

        If Num < 3 Then
            MsgBox("请设定大于2的数", vbOKOnly + vbCritical, "错误")
        Else
            Timer1.Enabled = False
            Timer2.Enabled = False
            If Timer3.Enabled = True Then
                Timer3.Enabled = False
                Num1.ForeColor = Color.Red
                Num2.ForeColor = Color.Red
                Num3.ForeColor = Color.Red
            Else
                Timer3.Enabled = True
                Num1.ForeColor = Color.Black
                Num2.ForeColor = Color.Black
                Num3.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Do
            a = Int(Num * Rnd() + 1)
            b = Int(Num * Rnd() + 1)
            c = Int(Num * Rnd() + 1)
        Loop Until a <> b And b <> c And a <> c
        Num1.Text = a
        Num2.Text = b
        Num3.Text = c
    End Sub

    Private Sub SetNum_Click(sender As Object, e As EventArgs) Handles SetNum.Click
        '停止三个timer
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        '重设数字选项，点击后开启form2
        Form2.ShowDialog() '以模态方式创建form2
    End Sub


    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        '停止三个timer
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        '清空文本
        Num1.Text = ""
        Num2.Text = ""
        Num3.Text = ""
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        State.Text = "当前设定的最大数字：" & Num
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        '停止三个timer
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        '点击后开启form3
        Form3.ShowDialog() '以模态方式创建form3
    End Sub
End Class
