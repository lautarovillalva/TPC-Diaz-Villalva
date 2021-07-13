<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Almacen.aspx.cs" Inherits="e_commerce.Almacen" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <a   class="btn btn-primary" href="Agregar-Articulo.aspx">Agregar Articulo</a>
    <hr />
      <asp:Repeater ID="rpAdminArticulo" runat="server">
            <ItemTemplate>
      <div class="row articulos">

                        <!-- Pie Chart -->
                        <div class="col-xl-12 col-lg-5">
                            <div class="card shadow mb-4">
                                <!-- Card Header - Dropdown -->
                                <div
                                    class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                    <h6 class="m-0 font-weight-bold text-primary"><%# Eval("Nombre") %></h6>
                                    <div class="dropdown no-arrow">
                                        <a class="dropdown-toggle" href="#" role="button" id="dropdownMenuLink"
                                            data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                            <i class="fas fa-ellipsis-v fa-sm fa-fw text-gray-400"></i>
                                        </a>
                                        <div class="dropdown-menu dropdown-menu-right shadow animated--fade-in"
                                            aria-labelledby="dropdownMenuLink">
                                            <div class="dropdown-header">Dropdown Header:</div>
                                            <a class="dropdown-item" href="/Modificar-articulo.aspx?idprod=<%# Eval("ID") %>">Modificar</a>
                                            <a class="dropdown-item" href="#">Clonar</a>
                                            <div class="dropdown-divider"></div>
                                            <a class="dropdown-item" href="#">Eliminar</a>
                                        </div>
                                    </div>
                                </div>
                                <!-- Card Body -->
                                <div class="card-body">
                                    <img src="<%# Eval("Imagen") %>" class="card-img-top" alt="...">
                                    <div class="descripcion">
                                        <p>
                                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries
                                        </p>
                                          
                                        <div class="caracteristicas">
                                           <span>Medida  <b> <%# Eval("medida") %> </b></span>
                                           <span>Categoria <b>  <%# Eval("categoria") %></b></span>
                                           <span>Estilo <b> <%# Eval("estilo") %></b> </span>
                                           <span>Composicion <b> <%# Eval("composicion") %></b> </span>
                                           <span>Color <i style="background: <%# Eval("color") %>" class="fas fa-circle color"></i></span>
                                        </div>
                                    </div>

                                

                                </div>
                            </div>
                        </div>
                    </div>

         </ItemTemplate>
    </asp:Repeater>
</asp:Content>
