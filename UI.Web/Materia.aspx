<%@ Page Title="Materia" Theme="TemaPropio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materia.aspx.cs" Inherits="UI.web.Materia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat ="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Materia" DataField="DescMateria" />
                <asp:BoundField HeaderText="Horas semanales" DataField="HsSemanales" />
                <asp:BoundField HeaderText="Horas totales" DataField="HsTotales" />
                <asp:BoundField HeaderText="Plan" DataField="IdPlan" />
                <asp:CommandField ButtonType="Button" ControlStyle-CssClass="btn btn-success" SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>

        </asp:GridView>
    </asp:Panel>
    <br />
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <br />
    <asp:Panel ID="formPanel" Visible="false" CssClass="row" runat="server">
        <asp:Panel runat="server" CssClass="col">
            <asp:Label ID="descMateriaLabel" runat="server" Text="Materia: " AssociatedControlID="descMateriaTextBox"></asp:Label>
            <asp:TextBox ID="descMateriaTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDescMateria" runat="server" ControlToValidate="descMateriaTextBox" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="hsSemanalesLabel" runat="server" Text="Horas semanales: " AssociatedControlID="hsSemanalesTextBox"></asp:Label>
            <asp:TextBox ID="hsSemanalesTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvHsSemanales" runat="server" ControlToValidate="hsSemanalesTextBox" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="hsTotalesLabel" runat="server" Text="Horas totales: " AssociatedControlID="hsTotalesTextBox"></asp:Label>
            <asp:TextBox ID="hsTotalesTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rgvHsTotales" runat="server" ControlToValidate="hsTotalesTextBox" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="idPlanLabel" runat="server" Text="Plan: " AssociatedControlID="idPlanTextBox"></asp:Label>
            <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvIdPlan" runat="server" ControlToValidate="idPlanTextBox" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />           
        </asp:Panel>
    </asp:Panel>
    <br />
    <asp:Panel ID="formActionsPanel" runat="server" Visible="False">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidationGroup="AllValidators">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            position: relative;
            display: block;
            padding-left: 1.25rem;
            left: -1px;
            top: 0px;
            width: 180px;
        }
    </style>
</asp:Content>