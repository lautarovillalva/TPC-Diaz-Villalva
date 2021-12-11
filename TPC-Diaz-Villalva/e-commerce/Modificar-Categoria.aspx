<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Modificar-Categoria.aspx.cs" Inherits="e_commerce.Modificar_Categoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <!-- Form Name -->
    <h2>Modificar Categoría</h2>

    <!-- Text input-->
    <div class="form-group">
        <label class="col-md-4 control-label">ID: <%:anterior.ID %></label>
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
        <label class="col-md-4 control-label" for="product_name">IMAGEN </label>
        <div class="col-md-4">
             
            <input type="file" name="name" value="" />
        </div>
    </div>


    <!-- Button -->
    <div class="form-group">
        <div class="col-md-4">
            <asp:Button ID="btnModificar" OnClick="btnModificar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
            <asp:Button ID="btnVisible" OnClick="btnVisible_Click" CssClass="btn btn-primary" Text="Cambiar visualización" runat="server" />

            <a class="btn btn-primary" href="Almacen.aspx">Cancelar</a>
        </div>
    </div>

</asp:Content>
