<%@ Page Title="Docentes Cursos" Theme="TemaPropio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocentesCursos.aspx.cs" Inherits="UI.web.DocentesCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="Id" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField HeaderText="IdCurso" DataField="IdCurso" />
                <asp:BoundField HeaderText="IdDocente" DataField="IdDocente" />
                <asp:BoundField HeaderText="Cargo" DataField="Cargo" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <br />
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="nombreLabel" runat="server" Text="Id Dictado"></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Id Curso: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="cursos" DataTextField="Id" DataValueField="Id">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="cursos" runat="server" SelectMethod="GetAll" TypeName="Negocio.CursoLogic"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAll" TypeName="Negocio.CursoLogic"></asp:ObjectDataSource>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="Id Docente:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="docentes" DataTextField="Id" DataValueField="Id">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="docentes" runat="server" SelectMethod="GetByTipo" TypeName="Negocio.PersonasLogic">
            <SelectParameters>
                <asp:Parameter DefaultValue="2" Name="tipo" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetByTipo" TypeName="Negocio.PersonasLogic">
            <SelectParameters>
                <asp:Parameter DefaultValue="2" Name="tipo" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="habilitadoLabel" runat="server" Text="Cargo:"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem Value="Práctica">Práctica</asp:ListItem>
            <asp:ListItem Value="Teoría">Teoría</asp:ListItem>
        </asp:DropDownList>
    </asp:Panel>
    <br />
    <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidationGroup="AllValidators">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
