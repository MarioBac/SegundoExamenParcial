<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SegundoExamenParcial._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Torneo de videojuuegos&nbsp;</h1>
        <p class="lead">Ingresar participante:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Ingresar nivel de experiencia:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Ingrese el nombre del videojuego:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Ingrese el genero del videojuego:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar los videojuegos" />
        </p>
        <p class="lead">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Guardar participantes" />
        </p>
        <p class="lead">&nbsp;</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
