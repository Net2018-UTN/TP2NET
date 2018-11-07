<%@ Page Title="Curso" Theme="TemaPropio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="UI.web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <asp:Panel ID="gridPanel" runat ="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged1">
            <Columns>
                <asp:BoundField HeaderText="idMateria" DataField="idMateria" />
                <asp:BoundField HeaderText="idComision" DataField="idComision" />
                <asp:BoundField HeaderText="anioCalendario" DataField="anioCalendario" />
                <asp:BoundField HeaderText="cupo" DataField="cupo" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>

    <asp:Panel ID="formPanel" CssClass="row" Visible="false" runat="server">
        <asp:Panel runat="server" CssClass="col-md-6">
            <asp:Label ID="idMateriaLabel" runat="server" Text="idMateria: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataValueField="Id" Height="34px" Width="121px">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="Negocio.MateriaLogic"></asp:ObjectDataSource>
            <br />
            <asp:Label ID="idComisionLabel" runat="server" Text="idComision: "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Id" DataValueField="Id">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAll" TypeName="Negocio.ComisionLogic"></asp:ObjectDataSource>
            <br />
            <asp:Label ID="anioCalendarioLabel" runat="server" Text="anioCalenadario: "></asp:Label>
            <asp:TextBox ID="anioCalendarioTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="cupoLabel" runat="server" Text="cupo: "></asp:Label>
            <asp:TextBox ID="cupoTextBox" runat="server"></asp:TextBox>
            <br />
        </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="formActionsPanel" runat="server" Visible="false">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>

</asp:Content>