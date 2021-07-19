<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Colores.aspx.cs" Inherits="e_commerce.Colores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="col-2">
    <a class="btn btn-primary" href="Agregar-Color.aspx">Agregar Color</a>
        </div>
    <hr />

    <div class="col-2">

        <ul class="list-group">
            <asp:Repeater ID="rpColores" runat="server">
                <ItemTemplate>


                    <a href="/Modificar-color.aspx?idcol=<%# Eval("ID") %>" class="list-group-item list-group-item-action"><%# Eval("ID") %> - <%# Eval("Nombre") %><div class="color" style="background-color: <%# Eval("Codigo") %>"></div>
                    </a>


                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
