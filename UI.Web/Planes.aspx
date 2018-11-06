<%@ Page Title="Planes" Theme="TemaPropio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.web.Planes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
     <asp:Panel ID="gridPanel" runat ="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="Descripcion" DataField="DescPlan" />
                <asp:BoundField HeaderText="Especialidad" DataField="IdEspecialidad" />
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
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Panel runat="server" CssClass="col-md-6">
            <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
            <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="descripcionTextBox" Display="Dynamic" EnableTheming="False" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators">El campo no puede estar vacío</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="idEspecialidadLabel" runat="server" Text="Especialidad: "></asp:Label>
            <asp:DropDownList ID="cbEspecialidad" runat="server" DataSourceID="especialidad" DataTextField="Desc_especialidad" DataValueField="Id">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="especialidad" runat="server" SelectMethod="GetAll" TypeName="Negocio.EspecialidadLogic"></asp:ObjectDataSource>
        </asp:Panel>
    </asp:Panel>
    <br />
    <asp:Panel ID="formActionsPanel" runat="server" Visible="False">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidationGroup="AllValidators">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>

</asp:Content>

