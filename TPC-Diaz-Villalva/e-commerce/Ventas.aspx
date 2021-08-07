<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="e_commerce.Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="table">
        <thead>
            <tr>
                <th scope="col">ID VENTA</th>
                <th scope="col">FECHA</th>
                <th scope="col">USUARIO</th>
                <th scope="col">TOTAL $</th>
                <th scope="col">ESTADO</th>
                <th scope="col"></th>
            </tr>
        </thead>
        <tbody>

            <asp:Repeater ID="rpVentas" runat="server">
                <ItemTemplate>

                    <tr>
                        <th scope="row"><%# Eval("id") %></th>
                        <td><%# Eval("fecha") %></td>
                        <td><%# Eval("usuario") %></td>
                        <td><%# Eval("total") %></td>
                        <td><%# Eval("estado") %></td>
                        <td><a class="btn btn-primary" href="/Detalle-venta.aspx?idventa=<%# Eval("ID") %>">Detalles</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>


        </tbody>
    </table>
</asp:Content>
