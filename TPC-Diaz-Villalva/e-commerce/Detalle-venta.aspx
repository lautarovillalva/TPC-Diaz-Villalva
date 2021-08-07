<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Detalle-venta.aspx.cs" Inherits="e_commerce.Detalle_venta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label Text="" ID="lbl_idventa" runat="server" />
    <asp:Label Text="" ID="lbl_usuario" runat="server" />
    <asp:Label Text="" ID="lbl_fecha" runat="server" />

    <table class="table">
        <thead>
            <tr>
                <th scope="col">ID PRODUCTO</th>
                <th scope="col">NOMBRE</th>
                <th scope="col">PRECIO $</th>
                <th scope="col">CANTIDAD</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rpArticulos" runat="server">
                <ItemTemplate>

                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("Nombre") %></td>
                        <td><%# Eval("Precio") %></td>
                        <td><%# Eval("Cantidad") %></td>
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

    <div class="container">
        <div class="row">
            <div class="col-3">

                <h2>TOTAL: $<%:venta.Total %></h2>
            </div>
            <div class="col-3">
                <asp:DropDownList ID="ddl_estado" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="NOMBRE" DataValueField="ID"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LUNARSOFT_DBConnectionString %>" SelectCommand="SELECT * FROM [ESTADOS]"></asp:SqlDataSource>
            </div>
            <div class="col-5">
                <asp:Button ID="btnGuardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                <a class="btn btn-primary" href="Ventas.aspx">Cancelar</a>

            </div>
        </div>
    </div>




</asp:Content>
