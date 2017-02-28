<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Units Coversion</title>
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 style="font-size: xx-large; text-align: center"><span class="auto-style1"><strong>Units Coversion</strong></span><br />
            <br />
    
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <asp:DropDownList ID="dList1" runat="server"></asp:DropDownList>
    
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged" Height="25px"></asp:TextBox>
        <asp:DropDownList ID="dList2" runat="server"> </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Conversion" />
    
        </h1>
        <asp:Label ID="Label1" runat="server"  Text=""></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>