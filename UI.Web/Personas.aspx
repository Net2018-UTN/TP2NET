<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.web.Personas" Theme="TemaPropio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridViewPanel" runat="server">
            <asp:GridView ID="PersonasGridView" runat="server" AutoGenerateColumns="False" DataSourceID="listaPersonas" OnSelectedIndexChanged="PersonasGridView_SelectedIndexChanged" DataKeyNames="Id">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Legajo" HeaderText="Legajo" SortExpression="Legajo" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                    <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                    <asp:BoundField DataField="TipoPersona" HeaderText="TipoPersona" SortExpression="TipoPersona" />
                    <asp:BoundField DataField="Id_plan" HeaderText="Id_plan" SortExpression="Id_plan" />
                    <asp:CommandField ButtonType="Button" ControlStyle-CssClass="btn btn-success" SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="listaPersonas" runat="server" SelectMethod="GetAll" TypeName="Negocio.PersonasLogic"></asp:ObjectDataSource>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <br />
    <asp:Panel CssClass="row" ID="formPanel" runat="server" Visible="False">
        <asp:Panel runat="server" CssClass="col">
            <asp:Label ID="Label1" runat="server" Text="Id" Enabled="False" AssociatedControlID="txtId"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Legajo" Enabled="False" AssociatedControlID="txtLegajo"></asp:Label>
            <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLegajo" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nombre" Enabled="False" AssociatedControlID="txtNombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Apellido" Enabled="False" AssociatedControlID="txtApellido"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtApellido" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Email" Enabled="False" AssociatedControlID="txtEmail"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El mail no es válido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ValidationGroup="AllValidators"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtEmail" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
        </asp:Panel>
        <asp:Panel runat="server" CssClass="col">
            <asp:Label ID="Label6" runat="server" Text="Direccion" Enabled="False" AssociatedControlID="txtDireccion"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDireccion" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Telefono" Enabled="False" AssociatedControlID="txtTelefono"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server" TextMode="Phone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtTelefono" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Fecha Nacimiento" Enabled="False" AssociatedControlID="txtFechaNacimiento"></asp:Label>
            <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Tipo de Persona" Enabled="False" AssociatedControlID="txtTipoPersona"></asp:Label>
            <asp:TextBox ID="txtTipoPersona" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtTipoPersona" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Plan" AssociatedControlID="ddlPlan"></asp:Label>
            <asp:DropDownList ID="ddlPlan" runat="server" DataSourceID="planes" DataTextField="DescPlan" DataValueField="Id" AppendDataBoundItems="True">
                <asp:ListItem>Seleccionar</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvPlan" runat="server" ControlToValidate="ddlPlan" ErrorMessage="Debe seleccionar una opcion" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <asp:ObjectDataSource ID="planes" runat="server" SelectMethod="GetAll" TypeName="Negocio.PlanesLogic"></asp:ObjectDataSource>
            <br />
        </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="formActionsPanel" runat="server" Visible="False">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" ValidationGroup="AllValidators" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
