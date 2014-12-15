<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" Width="178px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="But7" runat="server" Text="7" Width="29px" OnClick="But7_Click" style="height: 21px" />
&nbsp;
        <asp:Button ID="But8" runat="server" Text="8" Width="29px" OnClick="But8_Click" />
&nbsp;
        <asp:Button ID="But9" runat="server" Text="9" Width="29px" OnClick="But9_Click" />
&nbsp;
        <asp:Button ID="ButDivide" runat="server" Text="/" Width="29px" OnClick="ButDivide_Click" />
        <br />
        <br />
        <asp:Button ID="But4" runat="server" Text="4" Width="29px" OnClick="But4_Click" />
&nbsp;
        <asp:Button ID="But5" runat="server" Text="5" Width="29px" OnClick="But5_Click" />
&nbsp;
        <asp:Button ID="But6" runat="server" Text="6" Width="29px" OnClick="But6_Click" />
&nbsp;
        <asp:Button ID="ButMulti" runat="server" Text="*" Width="29px" OnClick="ButMulti_Click" />
        <br />
        <br />
        <asp:Button ID="But1" runat="server" Text="1" Width="29px" OnClick="But1_Click" />
&nbsp;
        <asp:Button ID="But2" runat="server" Text="2" Width="29px" OnClick="But2_Click" />
&nbsp;
        <asp:Button ID="But3" runat="server" Text="3" Width="29px" OnClick="But3_Click" />
&nbsp;
        <asp:Button ID="ButMinus" runat="server" Text="-" Width="29px" OnClick="ButMinus_Click" />
        <br />
        <br />
        <asp:Button ID="But0" runat="server" Text="0" Width="29px" OnClick="But0_Click" />
&nbsp;<asp:Button ID="Butclear" runat="server" Text="清空" Width="47px" OnClick="Butclear_Click" style="height: 21px" />
        <asp:Button ID="Butsum" runat="server" Text="计算" Width="40px" OnClick="Butsum_Click" />
&nbsp;
        <asp:Button ID="ButPlus" runat="server" Text="+" Width="29px" OnClick="ButPlus_Click" />
        <br />
    </form>
</body>
</html>
