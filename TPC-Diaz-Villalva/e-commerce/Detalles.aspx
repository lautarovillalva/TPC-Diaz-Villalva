<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="e_commerce.Detalles" %>
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


    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <contenttemplate>

    <div class="detalle">

          <div class="card mb-3">
             <div class="row no-gutters">
                 <div class="col-md-6">
                   <img src="<%: detalleArticulo.Imagen %>" alt="...">
                 </div>
                 <div class="col-md">
                   <div class="card-body">
                      <h5 class="card-title"><%: detalleArticulo.Nombre %></h5>
                       <span class="precio">$<%: detalleArticulo.Precio %></span>

                    

                       <div class="barra-color">
                           <span>Color</span>
                           <div class="color" style="background-color: <%: detalleArticulo.color %>"  "></div>
                       </div>

                       <br />

                       <ul class="nav nav-tabs" id="myTab" role="tablist">
                           <li class="nav-item" role="presentation">
                               <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Comprar</a>
                           </li>
                           <li class="nav-item" role="presentation">
                              <a class="nav-link" id="contact-tab" data-toggle="tab" href="#contact" role="tab" aria-controls="contact" aria-selected="false">Descripción</a>
                           </li>
                           <li class="nav-item" role="presentation">
                               <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">Mas caracteristicas</a>
                           </li>
                      </ul>

                      <div class="tab-content" id="myTabContent">
                           <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">

                               <div class="botones">
                                   <asp:Button ID="btnComprar" runat="server" Text="Comprar ahora" />
                                   <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" runat="server" UseSubmitBehavior="False" Text="Agregar al carrito" />
                               </div>

                           </div>
                           <div class="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="contact-tab">
                               <br />
                               <p>
                                   <%:BuscarDescripcion(detalleArticulo.ID) %>
<%--                                   Juego de sábanas liso de colores, compuesto por microfibra. Estilo y diseño para la cama de los más chicos.  <br />
Medidas: Para colchón de hasta 0.90 m de ancho x 1.90 m de largo x 0.20 m de alto.  <br />
Incluye: 3 piezas.--%>

                               </p>
                           </div>
                           <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                               <div class="caracteristicas">
                                   <span>Medida <b> <%: detalleArticulo.medida %></b></span>
                                   <span>Estilo <b><%: detalleArticulo.estilo %></b></span>
                                   <span>Categoria <b><%: detalleArticulo.categoria %></b></span>
                               </div>
                           </div>
                           
                      </div>
                     
                   </div>
                </div> 
             </div>
          </div>

    </div>

  
        </contenttemplate>
    </asp:UpdatePanel>
</asp:Content>
