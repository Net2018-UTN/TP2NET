<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CambiarClave.aspx.cs" Inherits="UI.Web.CambiarClave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div style="width:800px; margin:0 auto;">
        <asp:Label ID="lblClaveVieja" runat="server" Text="Clave vieja:"></asp:Label>
        <asp:TextBox ID="txtClaveVieja" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvClaveVieja" runat="server" ControlToValidate="txtClaveVieja" Display="Dynamic" ErrorMessage="La clave no puede estar vacía" ForeColor="Red" ValidationGroup="ValClave"></asp:RequiredFieldValidator>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="La clave ingresada es incorrecta" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="lblClaveNueva" runat="server" Text="Clave nueva:"></asp:Label>
        <asp:TextBox ID="txtClaveNueva" runat="server" TextMode="Password" ValidationGroup="ValClave"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvClaveNueva" runat="server" ControlToValidate="txtClaveNueva" Display="Dynamic" ErrorMessage="La clave nueva no puede estar vacía" ForeColor="Red" ValidationGroup="ValClave"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblRepetirClave" runat="server" Text="Repetir clave nueva:"></asp:Label>
        <asp:TextBox ID="txtRepetirClave" runat="server" TextMode="Password" ValidationGroup="ValClave"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvRepetirClave" runat="server" ControlToValidate="txtRepetirClave" Display="Dynamic" ErrorMessage="La repetición de la clave no puede estar vacía" ForeColor="Red" ValidationGroup="ValClave"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="cvClave" runat="server" ControlToCompare="txtClaveNueva" ControlToValidate="txtRepetirClave" Display="Dynamic" ErrorMessage="Las claves ingresadas no coinciden" ForeColor="Red" ValidationGroup="ValClave"></asp:CompareValidator>
        <br />
        <asp:Label ID="lblMensaje" runat="server" Text="La clave ha sido actualizada." Visible="False"></asp:Label>
        <br />
        <asp:LinkButton ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" ValidationGroup="ValClave">Aceptar</asp:LinkButton>
        &nbsp;&nbsp;
        <asp:LinkButton ID="btnCancelar" runat="server" OnClick="btnCancelar_Click">Cancelar</asp:LinkButton>
        &nbsp;
    </div>
</asp:Content>
