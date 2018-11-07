<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MateriasDocente.aspx.cs" Inherits="UI.Web.InscripcionesDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div style="width:800px; margin:0 auto;">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="DescripcionMateria" HeaderText="Materia" />
                <asp:BoundField DataField="DescripcionCurso" HeaderText="Curso" />
                <asp:BoundField DataField="DescripcionComision" HeaderText="Comisión" />
                <asp:BoundField DataField="Cupo" HeaderText="Cupo" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                <asp:BoundField DataField="AñoCalendario" HeaderText="Ciclo Lectivo" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
