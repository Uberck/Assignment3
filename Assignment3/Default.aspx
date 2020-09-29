<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 283px">
        &nbsp;
            <asp:Label ID="lblTitle" runat="server" Text="Please enter a number less than 15:"></asp:Label>
&nbsp;<br />
&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="txtInput" runat="server" Height="16px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate Factorial" />
            <br />
            <br />
            <asp:Label ID="lblAnswer" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
