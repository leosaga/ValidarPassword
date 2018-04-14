Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 20
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub



    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Dim may, min, num, x As Integer
        Dim l As String

        For x = 0 To TextBox1.Text.Length - 1
            'substring(tijera corta cada letra)
            l = TextBox1.Text.Substring(x, 1)
            '
            If l >= "0" And l <= "9" Then
                num += 1
            End If
            If l >= "a" And l <= "z" Then

                min += 1

            End If
            If l >= "A" And l <= "Z" Then

                may = may + 1
            End If
        Next

        If num < 2 Then
            MsgBox("contraseña invalidad minimo dos de numeros")
            TextBox1.Focus()
            Exit Sub
        End If
        If min < 2 Then
            MsgBox("contraseña invalidad minimo dos minuscula")
            TextBox1.Focus()
            Exit Sub
        End If
        If may < 2 Then
            MsgBox("contraseña invalidad minimo dos mayusculas")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox1.Text.Length < 8 Then
            MsgBox("contraseña invalidad requiere al menos 8 caracteres ")
            TextBox1.Focus()
            Exit Sub
        End If

        MsgBox("contreseña correcta")

    End Sub

End Class
