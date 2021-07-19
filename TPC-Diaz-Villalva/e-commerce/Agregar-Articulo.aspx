<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Agregar-Articulo.aspx.cs" Inherits="e_commerce.Agregar_Articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


            <!-- Form Name -->
            <h2>AGREGAR ARTICULO</h2>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_id">ID </label>
                <div class="col-md-4">
                    <asp:Label Text="" ID="lbl_id" runat="server" />
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_name">NOMBRE</label>
                <div class="col-md-4">
                    <asp:TextBox ID="tbx_nombre" CssClass="form-control input-group-lg" runat="server" />
                </div>
            </div>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_name">PRECIO </label>
                <div class="col-md-4">
                    <asp:TextBox ID="tbx_precio" CssClass="form-control input-group-lg" runat="server" />
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_name">CANTIDAD </label>
                <div class="col-md-4">
                    <asp:TextBox ID="tbx_cantidad" CssClass="form-control input-group-lg" runat="server" />
                </div>
            </div>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_name">URL IMAGEN </label>
                <div class="col-md-4">
                    <asp:TextBox ID="tbx_imagen" CssClass="form-control input-group-lg" runat="server" />
                </div>
            </div>

            <!-- Select Basic -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_categorie">CATEGORIA</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddl_categorias" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <!-- Select Basic -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_categorie">ESTILO</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddl_estilos" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <!-- Select Basic -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_categorie">COMPOSICIÓN</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddl_composiciones" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <!-- Select Basic -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_categorie">MEDIDA</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddl_medidas" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <!-- Select Basic -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="product_categorie">COLOR</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddl_colores" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>

            <!-- Button -->
            <div class="form-group">
                <div class="col-md-4">
                    <asp:Button ID="btnAgregar"  OnClick="btnAgregar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                    <a class="btn btn-primary" href="Almacen.aspx">Cancelar</a>
                </div>
            </div>
</asp:Content>
