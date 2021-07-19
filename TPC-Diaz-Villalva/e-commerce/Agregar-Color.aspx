<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Agregar-Color.aspx.cs" Inherits="e_commerce.Agregar_Color" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>AGREGAR COLOR</h2>



    <!-- Text input-->
    <div class="container">
        <div class="form-group">
            <div class="row">

                <!-- Text input-->
                <div class="col-sm">

                    <div class="form-group">
                        <label class="col-md-4 control-label" for="product_name">NOMBRE</label>
                        <div class="col-md-4">
                            <asp:TextBox ID="tbx_nombre" CssClass="form-control input-group-lg" runat="server" />
                        </div>
                    </div>
                </div>
                                <div class="col-sm">

                    <div class="form-group">
                        <label class="col-md-4 control-label" for="product_name">CÓDIGO</label>
                        <div class="col-md-4">
                            <asp:TextBox ID="tbx_codigo" CssClass="form-control input-group-lg" runat="server" />
                        </div>
                    </div>
                </div>

            </div>



            <!-- Button -->
            <div class="form-group">
                <div class="col-md-4">
                    <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                    <a class="btn btn-primary" href="Colores.aspx">Cancelar</a>
                </div>
            </div>


        </div>
    </div>
</asp:Content>
