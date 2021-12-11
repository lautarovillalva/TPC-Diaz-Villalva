<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Compras-realizadas.aspx.cs" Inherits="e_commerce.Compras_realizadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




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
                        <%--<td><a class="btn btn-primary" href="/Detalle-venta.aspx?idventa=<%# Eval("ID") %>">Detalles</a></td>--%>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>


        </tbody>
    </table>


</asp:Content>
