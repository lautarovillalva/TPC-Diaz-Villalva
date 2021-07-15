<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Modificar-articulo.aspx.cs" Inherits="e_commerce.Modificar_articulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
          <contenttemplate>

    <form class="form-horizontal">
        <fieldset>

        <div class="modificar"> 

            <div class="titulo">
              <h2 class=" mb-1 text-gray-800">Modifiar articulo - ID  <asp:Label Text="" ID="lbl_id" runat="server" />  </h2>
            </div>
            

            <div class="row ">
                 <div class="col-xl-3">
                      

                       <!-- Text input-->
                        <img src="<%: URLimagen %>"  />
                     <div class=" dropdown">
                         <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown"
                            role="button" data-toggle="dropdown" aria-haspopup="true"
                            aria-expanded="false">
                             URL de la imagen
                        </a>
                            <div class="dropdown-menu  dropdown-menu-right shadow "
                                                    aria-labelledby="navbarDropdown">
                                <asp:TextBox ID="tbx_imagen" CssClass="form-control input-group-lg" runat="server" OnTextChanged="tbx_imagen_TextChanged" UseSubmitBehavior="False" AutoPostBack="True" />
                                           
                               <div class="dropdown-divider"></div>
                               <a class="dropdown-item" href="#">Ampliar imagen</a>
                           </div>
                       </div>
      
                 </div>

                 <div class="col">

                     <div class="container">
                         <div class="row">
                           <div class="col">
                               <!-- Text input-->
                               <div class="form-group">
                                   <label class="col-md-4 control-label" for="product_name">Nombre</label>
                                   <div class="col-md-12">
                                       <asp:TextBox ID="tbx_nombre" CssClass="form-control input-group-lg" runat="server" />
                                   </div>
                               </div>
                           </div>

                          <div class="col">
                              <!-- Text input-->
                              <div class="form-group">
                                  <label class="col-md-4 control-label" for="product_name">CANTIDAD </label>
                                  <div class="col-md-12">
                                      <asp:TextBox ID="tbx_cantidad" CssClass="form-control input-group-lg" runat="server" />
                                  </div>
                              </div>
                           </div>

                           <div class="col">
                              <!-- Text input-->
                              <div class="form-group">
                                  <label class="col-md-4 control-label" for="product_name">Precio </label>
                                  <div class="col-md-12">
                                      <asp:TextBox ID="tbx_precio" CssClass="form-control input-group-lg" runat="server" />
                                  </div>
                              </div>
                           </div>

                        
                         </div>
                         <div class="row">
                           <div class="col">

                                 <label class="col-md-4 control-label" for="product_name">Descripcion </label>
                                  <div class="col-md-12">
                                      <textarea rows="4"  class="form-control input-group-lg"></textarea>
                                  </div>
                              
                           </div>
                       </div>
                 </div>
            </div>

          </div>

          
          <br /> 
         <hr />

         <div class="row ">

             <div class="container">
                         <div class="row">
                           <div class="col">
                              
                                <!-- Select Basic -->
                               <div class="form-group">
                                   <label class="col-md-12 control-label" for="product_categorie">CATEGORIA</label>
                            
                                    <div class="col-md-12">
                                       <asp:DropDownList ID="ddl_categorias" CssClass="form-control" runat="server">
                                       </asp:DropDownList>
                                    </div>
                                 
                               </div>
                           </div>

                          <div class="col">
                                  <!-- Select Basic -->
                                <div class="form-group">
                                    <label class="col-md-4 control-label" for="product_categorie">ESTILO</label>
                                    <div class="col-md-12">
                                        <asp:DropDownList ID="ddl_estilos" CssClass="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                           </div>

                           <div class="col">

                                   <!-- Select Basic -->
                               <div class="form-group">
                                   <label class="col-md-4 control-label" for="product_categorie">COMPOSICIÓN</label>
                                   <div class="col-md-12">
                                       <asp:DropDownList ID="ddl_composiciones" CssClass="form-control" runat="server">
                                       </asp:DropDownList>
                                   </div>
                               </div>
                            
                           </div>

                           <div class="col">

                               <!-- Select Basic -->
                               <div class="form-group">
                                   <label class="col-md-4 control-label" for="product_categorie">MEDIDA</label>
                                   <div class="col-md-12">
                                       <asp:DropDownList ID="ddl_medidas" CssClass="form-control" runat="server">
                                       </asp:DropDownList>
                                   </div>
                               </div>
                           </div>
                        
                         </div>
                         <div class="row">
                           <div class="col">

                                <!-- Select Basic -->
                                <div class="form-group">
                                    <label class="col-md-4 control-label" for="product_categorie">COLOR</label>
                                    <div class="col-md-12">
                                        <asp:DropDownList ID="ddl_colores" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddl_colores_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                           </div>

                          <div class="col">
                              <div style="background-color:<%: color %>" class="color-articulo"> </div>
                          </div>
                          <div class="col-md-6">
                                 <!-- Button -->
                               <div class="form-group botones-modificar">
                                 <asp:Button ID="btnGuardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                                 <a class="btn btn-primary" href="Almacen.aspx">Cancelar</a>
                               </div>
                           </div>

                       </div>
                 </div>
         
         </div>

          </div>
           
        </fieldset>
    </form>

              </contenttemplate>

        </asp:UpdatePanel>

</asp:Content>
