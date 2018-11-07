<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarClave.aspx.cs" Inherits="UI.Web.Recuperar" %>

<!DOCTYPE html>

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    <asp:Label ID="lblusu" runat="server" ForeColor="Red" Text="El usuario ingresado no existe" Visible="False"></asp:Label>
    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="val">El usuario no puede estar vacío</asp:RequiredFieldValidator>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnRecuperar" runat="server" OnClick="btnRecuperar_Click" Text="Recuperar" ValidationGroup="val" />
    <asp:Label ID="lblMail" runat="server" Text="Label" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="btnVolver" runat="server" OnClick="btnVolver_Click" Visible="False">Volver</asp:LinkButton>
    
    </div>
    </form>
</body>
