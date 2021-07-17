<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="e_commerce.Categorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a   class="btn btn-primary" href="Agregar-Categoria.aspx">Agregar categoría</a>
    <hr />

    <div class="card-deck">

        <asp:Repeater ID="rpCategorias" runat="server">
            <ItemTemplate>

                <div class="card">
                    <img class="card-img-top" src="img/categorias/<%# Eval("Nombre")%>.png" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Nombre") %></h5>
                        <p class="card-text">ID: <%# Eval("ID") %></p>
                        <a   class="btn btn-primary" href="/Modificar-categoria.aspx?idcat=<%# Eval("ID") %>">Modificar</a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>



    </div>
</asp:Content>
