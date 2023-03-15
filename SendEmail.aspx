<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SendEmail.aspx.vb" Inherits="SendingMail.SendEmail" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <asp:TextBox ID="txtmsg" runat="server" Height="300px"  Width="500px" TextMode="MultiLine"></asp:TextBox><br /><br />

        <asp:Button ID="btnSendMail" runat="server" Text="Send" /> <br /><br />

        <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>


    </div>
    </form>
</body>
</html>
