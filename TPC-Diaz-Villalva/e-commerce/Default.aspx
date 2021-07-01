<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="e_commerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="https://arredo.vteximg.com.br/arquivos/240621-ar_indumentaria-desktop.png?v=637602213289770000" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://arredo.vteximg.com.br/arquivos/160621-ar-cortinas-desktop.png?v=637594535154530000" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://arredo.vteximg.com.br/arquivos/250621-ar-10extra-desktop.png?v=637602645138770000" class="d-block w-100" alt="...">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>



    <div class="container categorias">

        <h2>Categorías favoritas</h2>

        <div class="row">

        <% foreach (Dominio.Categoria categoria in lista)
            { %>

            <div class="col-sm">
               <a href="#"><img src="img/categorias/<%: categoria.Nombre%>.png" /></a>
            </div>
       
       <%} %>
        </div>
   </div>



   <div class="banner-1"></div>


</asp:Content>
