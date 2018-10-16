<%@ Page Title="Comisiones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comision.aspx.cs" Inherits="UI.web.Comision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat ="server" Height="149px">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="Descp" DataField="Descp" />
                <asp:BoundField HeaderText="Año" DataField="Anio" />
                <asp:BoundField HeaderText="Id Plan" DataField="Id_plan" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                
            </Columns>

        </asp:GridView>

    </asp:Panel>
      <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
     <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="descpLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="descpTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="anioLabel" runat="server" Text="Año: "></asp:Label>
        <asp:TextBox ID="anioTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="id_planLabel" runat="server" Text="Id Plan: "></asp:Label>
        <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>
        <br />
        
    </asp:Panel>
     <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>


