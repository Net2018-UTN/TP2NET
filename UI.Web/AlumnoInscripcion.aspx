<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoInscripcion.aspx.cs" Inherits="UI.web.AlumnoInscripcion" Theme="TemaPropio"%>

<asp:Content ID="Content" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="alumnosInscripcionsGridView" runat="server" AutoGenerateColumns="False" DataSourceID="inscripciones" DataKeyNames="Id" OnSelectedIndexChanged="alumnosInscripcionsGridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="IdCurso" HeaderText="IdCurso" SortExpression="IdCurso" />
                <asp:BoundField DataField="IdAlumno" HeaderText="IdAlumno" SortExpression="IdAlumno" />
                <asp:BoundField DataField="Condicion" HeaderText="Condicion" SortExpression="Condicion" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" SortExpression="Nota" />
                <asp:CommandField ButtonType="Button" ControlStyle-CssClass="btn btn-success" SelectText="Seleccionar" ShowSelectButton="True" />

            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="inscripciones" runat="server" SelectMethod="GetAll" TypeName="Negocio.AlumnosInscripcionesLogic"></asp:ObjectDataSource>
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>

    </asp:Panel>

    <asp:Panel ID="formPanel" runat="server" Visible="False">
         <asp:Label ID="Label3" runat="server" Text="Id"></asp:Label>
         <asp:TextBox ID="txtId" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Alumno"></asp:Label>
        <asp:DropDownList ID="ddlAlumnos" runat="server" DataSourceID="alumnos" DataTextField="Legajo" DataValueField="Id" AppendDataBoundItems="True">
            <asp:ListItem Text="Seleccionar"/>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvAlumno" runat="server" ErrorMessage="Debe seleccionar una opcion" ForeColor="Red" ControlToValidate="ddlAlumnos" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
        <asp:ObjectDataSource ID="alumnos" runat="server" SelectMethod="GetAll" TypeName="Negocio.PersonasLogic"></asp:ObjectDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Curso"></asp:Label>
        <asp:DropDownList ID="ddlCursos" runat="server" DataSourceID="cursos" DataTextField="Id" DataValueField="Id" AppendDataBoundItems="True">
            <asp:ListItem Text="Seleccionar"/>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvCurso" runat="server" ErrorMessage="Debe seleccionar una opcion" ForeColor="Red" ControlToValidate="ddlCursos" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
        <asp:ObjectDataSource ID="cursos" runat="server" SelectMethod="GetAll" TypeName="Negocio.CursoLogic"></asp:ObjectDataSource>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nota"></asp:Label>
        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNota" runat="server" ErrorMessage="El campo no puede estar vacío" ForeColor="Red" ControlToValidate="txtNota" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>

        <br />
        <asp:Label ID="Label5" runat="server" Text="Condicion"></asp:Label>
        <asp:TextBox ID="txtCondicion" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCondicion" runat="server" ErrorMessage="El campo no puede estar vacío" ControlToValidate="txtCondicion" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>

    </asp:Panel>

    <asp:Panel ID="formActionsPanel" runat="server" Visible="False">
        <asp:LinkButton ID="aceptarLinkButton" CssClass="btn btn-primary" runat="server" ValidationGroup="AllValidators" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" CssClass="btn btn-secondary" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>



</asp:Content>
