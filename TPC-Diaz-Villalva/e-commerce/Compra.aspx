<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Compra.aspx.cs" Inherits="e_commerce.Compra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <%if (carrito.articulos.Count != 0)
        { %>




    <div class="container">

        <% if (Session["usuario"] == null)
            {%>
        <hr />
        <div class="container">
            <h2>¿No tienes cuenta? <a href="/login.aspx">Iniciá sesión</a> o <a href="Crear-cuenta.aspx">Regístrate</a>!</h2>
        </div>
        <% }
            else
            {%>
        <h2>¡Hola <%:usuario.Nombre %>! Que bueno es verte de nuevo.</h2>


        <%} %>
        <hr />

        <table class="table">
            <thead>
                <tr>
                    <th scope="col">#Número</th>
                    <th scope="col">Artículo</th>
                    <th scope="col">Cantidad</th>
                    <th scope="col">Precio unitario $</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater runat="server" ID="rpCarrito">
                    <ItemTemplate>

                        <tr>
                            <th scope="row"><%#Eval("ID") %></th>
                            <td><%#Eval("Nombre") %></td>
                            <td>


                                <div class="btn-group" role="group" aria-label="Basic mixed styles example">
                                    <asp:Button ID="btnSumar" class="btn btn-outline-warning" runat="server" Text="+1" CommandArgument='<%#Eval("ID") %>' CommandName="eventoSumar" OnCommand="btnSumar_Command" UseSubmitBehavior="false" />
                                    <button type="button" class="btn btn-light" disabled><%#Eval("Cantidad") %></button>
                                    <asp:Button ID="btnRestar" runat="server" class="btn btn-outline-warning" Text="-1" CommandArgument='<%#Eval("ID") %>' CommandName="eventoRestar" OnCommand="btnRestar_Command" UseSubmitBehavior="false" />
                                </div>




                            </td>
                            <td>$ <%#Eval("Precio") %></td>

                        </tr>




                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:Label ID="lblTotal" runat="server" Text="" class="fs-2"></asp:Label>
            <div class="container">

                <% if (carrito.cantidadArticulos()!=0)
                    {%>

                <asp:Button ID="btnVaciarCarrito" OnClick="btnVaciarCarrito_Click" class="btn btn-warning" runat="server" Text="Vaciar carrito" />


                <% }%>

                <% if (Session["usuario"] != null && Session["lista"] != null)
                    {%>
                <asp:Button ID="btnFinalizarCompra" class="btn btn-success" OnClick="btnFinalizarCompra_Click" runat="server" Text="Finalizar compra" />

                <% }%>
            </div>
    </div   >
    <%}
        else
        {%>


        <img src="https://www.imichile.cl/wp-content/uploads/2021/02/carro-vacio.png" />
        <h3>El carrito se encuentra vacío</h3>

    <%} %>
</asp:Content>
