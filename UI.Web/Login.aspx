<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.web.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />

    <title>Login</title>
    <style type="text/css">
    </style>
</head>
<body>
    <h2 class="text-center ">Bienvenido al sistema</h2>
    <form id="formLogin" runat="server" class="container">
        <div class="row">
            <div class="col-md-12">
                <asp:Label CssClass="auto-style1" ID="Label1" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class ="col-md-12">
                <asp:Label CssClass="auto-style1" ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox ID="txtClave" CssClass="form-control" Type="Password" runat="server"></asp:TextBox>
            </div>
        </div>
        <asp:Button type="button" class="btn btn-primary" ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    </form>
    </body>
</html>
