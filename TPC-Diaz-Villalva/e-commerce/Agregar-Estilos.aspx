<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Agregar-Estilos.aspx.cs" Inherits="e_commerce.Agregar_Estilos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>AGREGAR ESTILO</h2>

    

    <!-- Text input-->

    <div class="form-group">
        <label class="col-md-4 control-label" for="product_name">NOMBRE</label>
        <div class="col-md-4">
            <asp:TextBox ID="tbx_nombre" CssClass="form-control input-group-lg" runat="server" />
        </div>
    </div>
    


    <!-- Button -->
    <div class="form-group">
        <div class="col-md-4">
            <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
            <a class="btn btn-primary" href="Estilos.aspx">Cancelar</a>
        </div>
    </div>
</asp:Content>
