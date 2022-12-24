Imports System.Text.RegularExpressions


Public Class Register
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim userEmail = TBEmail.Text
        Dim userPassword = TBPassword.Text
        Dim userName = TBName.Text
        Dim userConfPassword = TBConfPassword.Text

        FormValidation(userEmail, userPassword, userConfPassword, userName)

    End Sub

    Private Function EmailValidation(emailInput As String) As Boolean
        Return Regex.IsMatch(emailInput, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
    End Function

    Private Sub FormValidation(userEmail As String, userPassword As String, userConfPassword As String, userName As String)
        If userEmail.Length > 0 And userPassword.Length > 6 And EmailValidation(userEmail) And userPassword = userConfPassword Then
            Dim isPosted As Boolean = Login.Users.postUser(userName, userEmail, userPassword)
            If isPosted Then
                MessageBox.Show("Akun berhasil didaftarkan !")
                Me.Close()
            Else
                MessageBox.Show(Login.Users.errMessage)
            End If
        ElseIf Not userPassword = userConfPassword Then
            MessageBox.Show("Konfirmasi Password tidak cocok")
        ElseIf userPassword.Length < 6 Then
            MessageBox.Show("Panjang Password harus lebih dari 6 karakter")
        ElseIf Not EmailValidation(userEmail) Then
            MessageBox.Show("Format Email tidak valid")
        ElseIf userEmail.Length < 1 And userPassword.Length < 1 Then
            MessageBox.Show("Lengkapi data registrasi")
        End If
    End Sub


End Class