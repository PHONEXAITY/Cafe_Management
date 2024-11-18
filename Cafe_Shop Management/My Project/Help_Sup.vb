
Imports System.Runtime.InteropServices

Public Class Help_Sup
    Private Const SW_SHOWNORMAL As Integer = 1

    <DllImport("shell32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ShellExecute(
        ByVal hwnd As IntPtr,
        ByVal lpOperation As String,
        ByVal lpFile As String,
        ByVal lpParameters As String,
        ByVal lpDirectory As String,
        ByVal nShowCmd As Integer
    ) As IntPtr
    End Function
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim emailAddress As String = "mailto:phoneyang1@gmail.com"
            ShellExecute(IntPtr.Zero, "open", emailAddress, Nothing, Nothing, SW_SHOWNORMAL)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Dim phoneNumber As String = "+8562095837391" ' Replace with the desired phone number
            Dim whatsappUrl As String = "https://wa.me/" & phoneNumber

            ' Open the default web browser with the WhatsApp URL
            ShellExecute(IntPtr.Zero, "open", whatsappUrl, Nothing, Nothing, SW_SHOWNORMAL)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If txt_comment.Text = "" Then
            MessageBox.Show("Please Enter Your Problem")
        Else

            MessageBox.Show("Send Success")
            txt_comment.Clear()

        End If
    End Sub
End Class