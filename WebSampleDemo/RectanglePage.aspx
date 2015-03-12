<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RectanglePage.aspx.cs" Inherits="WebSampleDemo.RectanglePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="InputLable" runat="server" Text="Input Rectangle Coordinates"></asp:Label>
&nbsp;<asp:TextBox ID="InputTextbox" runat="server" Width="375px"></asp:TextBox>
&nbsp;<asp:Button ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" Text="Submit" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>

</body>
</html>
