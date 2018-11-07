<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalificarAlumnos.aspx.cs" Inherits="UI.Web.CalificarAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div style="width:800px; margin:0 auto;">
        <asp:GridView ID="gridView" runat="server" DataKeyNames ="IdInscripcion" AutoGenerateColumns="False" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="DescripcionMateria" HeaderText="Materia" />
                <asp:BoundField DataField="DescripcionCurso" HeaderText="Curso" />
                <asp:BoundField DataField="DescripcionComision" HeaderText="Comisión" />
                <asp:BoundField DataField="ApellidoNombre" HeaderText="Apellido y Nombre" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" />
                <asp:BoundField DataField="Condicion" HeaderText="Condición" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
        <asp:Panel ID="formPanel" runat="server" Visible="False">
            <asp:Label ID="lblNota" runat="server" Text="Nota:"></asp:Label>
            <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNota" runat="server" ControlToValidate="txtNota" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="valNota">La nota no puede estar vacía</asp:RequiredFieldValidator>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="La nota debe ser un entero entre 1 y 10" Visible="False"></asp:Label>
        </asp:Panel>
        <asp:LinkButton ID="btnEditar" runat="server" OnClick="btnEditar_Click">Editar</asp:LinkButton>
        <br />
        <asp:LinkButton ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" ValidationGroup="valNota">Aceptar</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnCancelar" runat="server" OnClick="btnCancelar_Click">Cancelar</asp:LinkButton>
    </div>
</asp:Content>
