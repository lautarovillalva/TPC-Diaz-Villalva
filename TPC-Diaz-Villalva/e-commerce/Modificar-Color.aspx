<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Panel.Admin.Master" AutoEventWireup="true" CodeBehind="Modificar-Color.aspx.cs" Inherits="e_commerce.Modificar_Color" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Form Name -->
    <h2>Modificar Color</h2>



    <!-- Text input-->
    <div class="container">
        <div class="form-group">
            <div class="row">
                <div class="col-sm">

                    <label class="col-md-4 control-label">ID: <%:anterior.ID %></label>
                </div>

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
                    <asp:Button ID="btnModificar" OnClick="btnModificar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                    <a class="btn btn-primary" href="Colores.aspx">Cancelar</a>
                </div>
            </div>


        </div>
    </div>

</asp:Content>
