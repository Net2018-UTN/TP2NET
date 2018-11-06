<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MateriasAlumno.aspx.cs" Inherits="UI.Web.InscripcionesAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div style="width:800px; margin:0 auto;">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="DescripcionMateria" HeaderText="Materia" />
                <asp:BoundField DataField="DescripcionCurso" HeaderText="Curso" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" />
                <asp:BoundField DataField="Condicion" HeaderText="Condición" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
