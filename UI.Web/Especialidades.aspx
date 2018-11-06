<%@ Page Title="Especialidades" Theme="TemaPropio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
     <asp:Panel ID="gridPanel" runat ="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Id Especialidad" DataField="Id" />
                <asp:BoundField HeaderText="Descripción" DataField="Desc_especialidad" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                
            </Columns>

        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>

    <asp:Panel CssClass="col-md-6" ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="idLabel" runat="server" Text="Id Especialidad: "></asp:Label>
        <asp:TextBox ID="idTextBox" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripción: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rqvDescripcion" runat="server" ControlToValidate="descripcionTextBox" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
     </asp:Panel>

    <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidationGroup="AllValidators">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>

</asp:Content>
