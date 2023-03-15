Imports System.Net
Imports System.Net.Mail
Imports System.Net.Configuration
Public Class SendEmail
    Inherits System.Web.UI.Page

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        SendEmail(txtmsg.Text)
    End Sub

    Protected Sub SendEmail(p As String)
        Dim strTo = "coromanowebmaster@gmail.com"
        Dim strSubject = "SUBJECT"
        Dim strBody = p

        Dim smtpSection As SmtpSection = CType(ConfigurationManager.GetSection("system.net/mailSettings/smtp"), SmtpSection)
        Using mm As MailMessage = New MailMessage(smtpSection.From, strTo)
            mm.Subject = strSubject
            mm.Body = strBody
            mm.IsBodyHtml = True
            Dim smtp As SmtpClient = New SmtpClient
            smtp.Host = smtpSection.Network.Host
            smtp.EnableSsl = smtpSection.Network.EnableSsl
            Dim networkCred As NetworkCredential = New NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password)
            smtp.UseDefaultCredentials = smtpSection.Network.DefaultCredentials
            smtp.Credentials = networkCred
            smtp.Port = smtpSection.Network.Port
            smtp.Send(mm)
            txtmsg.Text = ""
            lblStatus.Text = "Your email has been sent sucessfully."
        End Using
    End Sub

    Private Sub SendEmail(p1 As String, p2 As String)
        Throw New NotImplementedException
    End Sub
End Class