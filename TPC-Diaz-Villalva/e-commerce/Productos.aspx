<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="e_commerce.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div class="banner-video">
        <iframe src="https://player.vimeo.com/video/441604150?autoplay=1&loop=1&muted=1" frameborder="0"></iframe>
        <h2>Elegilo por tu comodidad, rutina y hogar.</h2>
   </div>


    <div class="container-fluid banner-2">
  <div class="row">
    <div class="col-sm">
      3 Cuotas sin interés <br />
12 cuotas en compras superiores a $6499
    </div>
    <div class="col-sm">
      Envío gratis <br />
a partir de $6999
    </div>
    <div class="col-sm">
      Retiro gratis <br />
en sucursales seleccionadas
    </div>
  </div>
</div>
   


    <div class="container-fluid productos">
         <div class="row row-cols-1 row-cols-md-4">
              
             <asp:Repeater ID="rpArticulos" runat="server">
                 <ItemTemplate>

             <div class="col mb-3">
                <div class="card h-100">
                     <img src="<%# Eval("Imagen") %>" class="card-img-top" alt="...">
                     <div class="card-body">
                        <h5 class="card-title"><%# Eval("Nombre") %></h5>
                        <span class="precio">$ <%# Eval("Precio") %></span>

                      </div>
                </div>
            </div>

                </ItemTemplate>
            </asp:Repeater>

         </div>
   </div>


         



</asp:Content>
