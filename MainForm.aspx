<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="Calculator.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <center>
        <asp:TextBox ID="tb1" runat="server" Width="224px" Height="34px"></asp:TextBox>
        <asp:TextBox ID="tb2" runat="server" Width="213px" Height="34px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="tb3" runat="server" Width="213px" Height="34px" Visible="False"></asp:TextBox>
        <br/>  
        <asp:Label ID="label1" runat="server" Text="  "></asp:Label>
        <br/>  
            <asp:Button ID="Button1" runat="server" Text="1" Width="56px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="2" Width="56px" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="3" Width="56px" OnClick="Button3_Click" />
            <asp:Button ID="Button11" runat="server" Text="/" Width="56px" OnClick="Button11_Click" />
            <br>
            <asp:Button ID="Button4" runat="server" Text="4" Width="56px" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="5" Width="56px" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="6" Width="56px" OnClick="Button6_Click" />
            <asp:Button ID="Button12" runat="server" Text="*" Width="56px" OnClick="Button12_Click" />
            <br/>
            <asp:Button ID="Button7" runat="server" Text="7" Width="56px" OnClick="Button7_Click" />
            <asp:Button ID="Button8" runat="server" Text="8" Width="56px" OnClick="Button8_Click"/>
            <asp:Button ID="Button9" runat="server" Text="9" Width="56px" OnClick="Button9_Click"/>
            <asp:Button ID="Button10" runat="server" Text="+" Width="56px" OnClick="Button10_Click"/>
            <br/>
            <asp:Button ID="Button13" runat="server" Text="C" Width="56px" OnClick="Button13_Click"/>
            <asp:Button ID="Button14" runat="server" Text="0" Width="56px" OnClick="Button14_Click"/>
            <asp:Button ID="Button15" runat="server" Text="," Width="56px" OnClick="Button15_Click"/>
            <asp:Button ID="Button16" runat="server" Text="-" Width="56px" OnClick="Button16_Click" />
            <br/>
            <asp:Button ID="Button17" runat="server" Text="=" Width="235px" OnClick="Button17_Click" />
            </div>
        </center>
    </form>
</body>
</html>
