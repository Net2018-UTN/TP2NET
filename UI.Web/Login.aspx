<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.web.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 330px; width: 831px">
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1">
            <asp:Label ID="lblBienvenido" runat="server" Text="¡Bienvenido al Sistema!"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style1">
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                    </td>
                    <td class="auto-style1">
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style1">
            <asp:Label ID="lblClavel" runat="server" Text="Clave"></asp:Label>
                    </td>
                    <td class="auto-style1">
            <asp:TextBox ID="txtClave" Type="Password" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
            
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lnkRecordarClave" runat="server" OnClick="lnkRecordarClave_Click">Olvide clave</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
