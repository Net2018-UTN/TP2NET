<%@ Page Title="Planes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.web.Planes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
     <asp:Panel ID="gridPanel" runat ="server" Height="193px">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="Descripcion" DataField="DescPlan" />
                <asp:BoundField HeaderText="Especialidad" DataField="IdEspecialidad" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>

        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server" Height="50px">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>

    <asp:Panel ID="formPanel" CssClass="input-group" Visible="false" runat="server" Height="79px">
            <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
            <asp:TextBox ID="descripcionTextBox" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="idEspecialidadLabel" runat="server" Text="Especialidad: "></asp:Label>
            <asp:TextBox ID="idEspecialidadTextBox" CssClass="form-control" runat="server"></asp:TextBox>
    </asp:Panel>

    <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" CssClass="btn btn-success" OnClick="AceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" CssClass="btn btn-secondary" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>

</asp:Content>

