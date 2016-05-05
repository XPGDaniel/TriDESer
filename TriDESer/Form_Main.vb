Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class Form_Main

    Private Sub Button_Gen_Click(sender As Object, e As EventArgs) Handles Button_Gen.Click
        Dim mCSP As SymmetricAlgorithm = New TripleDESCryptoServiceProvider()
        Dim Key As String = "riYAqVYNQY4JAFsAYFDPeD+atXzNVgzW"
        Dim IV As String = "dWkqBI9PsZY="
        Dim ct As ICryptoTransform
        Dim ms As MemoryStream
        Dim cs As CryptoStream
        Dim byt As Byte()
        mCSP.Clear()
        mCSP.Key = Convert.FromBase64String(Key)
        mCSP.IV = Convert.FromBase64String(IV)
        mCSP.Mode = CipherMode.ECB
        mCSP.Padding = PaddingMode.PKCS7



        Select Case Button_CryptMode.Text
            Case "Decrypt"
                ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV)
                byt = Convert.FromBase64String(TextBox_Input.Text.Trim)
            Case Else
                ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV)
                byt = Encoding.UTF8.GetBytes(TextBox_Input.Text.Trim)
        End Select

        ms = New MemoryStream()
        cs = New CryptoStream(ms, ct, CryptoStreamMode.Write)
        cs.Write(byt, 0, byt.Length)
        cs.FlushFinalBlock()
        cs.Close()
        ms.Close()
        cs.Dispose()
        ms.Dispose()
        mCSP.Dispose()



        Select Case Button_CryptMode.Text
            Case "Decrypt"
                TextBox_Output.Text = Encoding.UTF8.GetString(ms.ToArray())
            Case Else
                TextBox_Output.Text = Convert.ToBase64String(ms.ToArray())
        End Select

    End Sub

    Private Sub TextBox_Output_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox_Output.MouseClick
        BeginInvoke(DirectCast(Sub() TextBox_Output.SelectAll(), Action))
    End Sub

    Private Sub TextBox_Input_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox_Input.MouseClick
        BeginInvoke(DirectCast(Sub() TextBox_Input.SelectAll(), Action))
    End Sub

    Private Sub Button_CryptMode_Click(sender As Object, e As EventArgs) Handles Button_CryptMode.Click
        Select Case Button_CryptMode.Text
            Case "Encrypt"
                Button_CryptMode.Text = "Decrypt"
            Case "Decrypt"
                Button_CryptMode.Text = "Encrypt"
        End Select
    End Sub
End Class
