<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Crear-cuenta.aspx.cs" Inherits="e_commerce.Crear_cuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="vh-100" style="background-color: #eee;">
        <div class="container h-100">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-lg-12 col-xl-11">
                    <div class="card text-black" style="border-radius: 25px;">
                        <div class="card-body p-md-5">
                            <div class="row justify-content-center">
                                <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

                                    <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Registrarse</p>

                                    <form class="mx-1 mx-md-4">

                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <%--<input type="text" id="txtNombre" class="form-control" />--%>
                                                <asp:TextBox type="text" id="txtNombre" class="form-control" runat="server" />
                                                <label class="form-label" for="form3Example1c">Nombre</label>
                                            </div>
                                            <div class="form-outline flex-fill mb-0">
                                                <%--<input type="text" id="txtApellido" class="form-control" />--%>
                                                 <asp:TextBox type="text" id="txtApellido" class="form-control" runat="server" />
                                                <label class="form-label" for="form3Example1c">Apellido</label>
                                            </div>
                                        </div>

                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <%--<input type="email" id="txtEmail" class="form-control" />--%>
                                                <asp:TextBox type="text" id="txtMail" class="form-control" runat="server" />
                                                <label class="form-label" for="form3Example3c">Mail</label>
                                            </div>
                                        </div>

                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <%--<input type="password" id="txtContraseña1" class="form-control" />--%>
                                                <asp:TextBox type="password" id="txtContraseña1" class="form-control" runat="server" />
                                                <label class="form-label" for="form3Example4c">Contraseña</label>
                                            </div>
                                        </div>

                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-key fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <%--<input type="password" id="txtContraseña2" class="form-control" />--%>
                                                <asp:TextBox type="password" id="txtContraseña2" class="form-control" runat="server" />
                                                <label class="form-label" for="form3Example4cd">Repetir Contraseña</label>
                                            </div>
                                        </div>


                                        <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                                            <%--<button type="button" class="btn btn-primary btn-lg" id="btnCrearCuenta">Crear cuenta</button>--%>
                                            <asp:LinkButton Text="Crear Cuenta" ID="btnCrearCuenta" OnClick="btnCrearCuenta_Click" class="btn btn-primary btn-lg" runat="server" />
                                        </div>

                                    </form>

                                </div>
                                <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">

                                    <img src="https://cdn-icons-png.flaticon.com/512/3837/3837739.png" class="img-fluid" alt="Sample image">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
