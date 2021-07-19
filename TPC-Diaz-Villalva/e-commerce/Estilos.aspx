<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Estilos.aspx.cs" Inherits="e_commerce.Estilos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="col-2">
    <a class="btn btn-primary" href="Agregar-Estilos.aspx">Agregar Estilo</a>
        </div>
    <hr />
    <div class="col-2">
        <ul class="list-group">
            <asp:Repeater ID="rpEstilos" runat="server">
                <ItemTemplate>


                    <a href="/Modificar-estilo.aspx?idest=<%# Eval("ID") %>" class="list-group-item list-group-item-action"><%# Eval("ID") %> - <%# Eval("Nombre") %></a>


                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
