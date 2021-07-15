<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="e_commerce.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lunarsoft - App Web</title>
    <link href="~/img/ico.png" rel="shortcut icon" type="image/x-icon" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
    <link href="css/login.css" rel="stylesheet" />
</head>
      
<body>


    <section class="login">

     <div class="container-fluid ">
          <div class="row">
             <div class="col-5 banner">

             </div>
             <div class="col-sm formulario">

                  

                   <form id="form1" runat="server">
                       <img  src="img/logo-color.png"/>
                      <div class="input">
                          <label>Usuario o correo electronico</label>
                          <asp:TextBox ID="txtUsuario" runat="server" ></asp:TextBox>
                      </div>
                      <div class="input">
                           <label>Contraseña</label>
                          <asp:TextBox TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>
                      </div>
                      <div class="input">    
                          <asp:Button ID="btnLogin" OnClick="btnLogin_Click" runat="server" Text="LOGIN" />
                      </div>
                      
                   </form>
            </div>

          </div>
     </div>

    </section>
   

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
   <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns" crossorigin="anonymous"></script>

</body>
</html>
