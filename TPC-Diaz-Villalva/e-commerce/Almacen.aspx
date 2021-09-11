<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Almacen.aspx.cs" Inherits="e_commerce.Almacen" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <a class="btn-nuevo-articulo" href="Agregar-Articulo.aspx"> <i class="fas fa-plus"></i><i class="fas fa-box-open"></i></a>


    <ul class="nav nav-tabs nav-admin-articulos" id="myTab" role="tablist">
         <li class="nav-item" role="presentation">
              <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Articulos visibles</a>
          </li>
          <li class="nav-item" role="presentation">
             <a class="nav-link" id="Papelera-tab" data-toggle="tab" href="#Papelera" role="tab" aria-controls="Papelera" aria-selected="false">Papelera</a>
          </li>
       
     </ul>




    <div class="tab-content" id="myTabContent">
       <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">

           <br />

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <contenttemplate>

            <asp:Repeater ID="rpAdminArticulo" runat="server">
            <ItemTemplate>
                <div class="row articulos">

                        <!-- Pie Chart -->
                        <div class="col-xl-12 col-lg-5">
                            <div class="card shadow mb-4">
                                <!-- Card Header - Dropdown -->
                                <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">

                                    <h6 class="m-0 font-weight-bold text-primary"><%# Eval("Nombre") %></h6>

                                    <div class="dropdown no-arrow">
                                        <a class="dropdown-toggle" href="#" role="button" id="dropdownMenuLink"
                                            data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                            <i class="fas fa-ellipsis-v fa-sm fa-fw text-gray-400"></i>
                                        </a>
                                        <div class="dropdown-menu dropdown-menu-right shadow animated--fade-in"
                                            aria-labelledby="dropdownMenuLink">
                                            <div class="dropdown-header">Dropdown Header:</div>

                                            <!-- MODIFICAR ARTICULO -->
                                            <a class="dropdown-item" href="/Modificar-articulo.aspx?idprod=<%# Eval("ID") %>">Modificar</a>

                                            <!-- MODIFICAR CLONAR -->
                                            <a class="dropdown-item" href="#">Clonar</a>
                                            <div class="dropdown-divider"></div>

                                            <!-- MOVER A LA PAPELERA -->
                                            <asp:Button class="dropdown-item" ID="btnEliminarProducto" runat="server" Text="Borrar" OnCommand="btnEliminarProducto_Command" CommandArgument='<%# Eval("ID") %>' CommandName="eventoEliminar"  UseSubmitBehavior="False"/>
                                        </div>
                                    </div>
                                </div>
                                <!-- Card Body -->
                                <div class="card-body">
                                    <img src="<%# Eval("Imagen") %>" class="card-img-top" alt="...">

                                    <div class="descripcion">
                                        <p>
                                            HOLA Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries
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

             </contenttemplate>
            </asp:UpdatePanel>

       </div>
       <div class="tab-pane fade" id="Papelera" role="tabpanel" aria-labelledby="Papelera-tab">

               <br />

      <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <contenttemplate>


               <!-- ELIMINAR SELECCION -->
               <asp:Button ID="btnEliminarSeleccion" runat="server" Text="Eliminar Articulos" OnClick="btnEliminarSeleccion_Click" UseSubmitBehavior="False"/>
               <asp:Label ID="Label1" runat="server" Text="Aca va el texto"></asp:Label>

            <asp:Repeater ID="rpAdminArticuloPapelera" runat="server">
            <ItemTemplate>

                <div class="row articulos">
                        <!-- Pie Chart -->
                        <div class="col-xl-12 col-lg-5">
                            <div class="card articulo-eliminado shadow mb-4">
                                <!-- Card Header - Dropdown -->
                                <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">


                                    <div class="titulo-borrador">
                                        <asp:CheckBox ID="chkSeleccion"  runat="server"  ViewStateMode="Enabled"  ValidateRequestMode="Enabled" />
                                       <h6 class="m-0 font-weight-bold text-primary"><%# Eval("Nombre") %></h6>
                                    </div>


                                    <div class="dropdown no-arrow">
                                        <a class="dropdown-toggle" href="#" role="button" id="dropdownMenuLink"
                                            data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                            <i class="fas fa-ellipsis-v fa-sm fa-fw text-gray-400"></i>
                                        </a>
                                        <div class="dropdown-menu dropdown-menu-right shadow animated--fade-in"
                                            aria-labelledby="dropdownMenuLink">
                                            <div class="dropdown-header">Dropdown Header:</div>

                                            <!-- SALVAR ARTICULO -->
                                            <asp:Button class="dropdown-item salvar-articulo" ID="btnSalvar" runat="server" Text="Salvar articulo"  OnCommand="btnSalvar_Command" CommandArgument='<%# Eval("ID") %>' CommandName="eventoEliminar"  UseSubmitBehavior="False" />

                                            <!-- ELIMINAR CLONAR -->
                                            <asp:Button class="dropdown-item" ID="btnEliminar" runat="server" Text="Eliminar definitivamente" />

                                            
                                        </div>
                                    </div>
                                </div>
                                <!-- Card Body -->
                                <div class="card-body">
                                    <img src="<%# Eval("Imagen") %>" class="card-img-top" alt="...">

                                    <div class="descripcion">
                                        <p>
                                            HOLA Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries
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

             </contenttemplate>
            </asp:UpdatePanel>
           
       </div>
        
         
    </div>




      

     


   

</asp:Content>
