

$('.ver-listado').click(function () {

    $('.dropdown-menu').addClass('ver');
    $(this).next('.sub-menu-desplegable').slideToggle();
   
});


$('.el-menu').click(function () {

   

    if ($('.nav-link .fas').hasClass('fa-times')) {
        $('.nav-link .fas').addClass('fa-bars');
        $('.nav-link .fas').removeClass('fa-times');
    }

    else {
        $('.nav-link .fas').removeClass('fa-bars');
        $('.nav-link .fas').addClass('fa-times');
    }

    $('.dropdown-menu').removeClass('ver');
    $('.dropdown-menu').slideToggle();
});


$(window).scroll(function () {

  

    if ($(window).scrollTop() == 0) {

        $('.navegador').removeClass('scroll-nav');
        $('.logo').show();
        $('.scroll-logo').hide();
    }

    else {
        $('.navegador').addClass('scroll-nav');
        $('.logo').hide();
        $('.scroll-logo').show();
    }

});


$(document).ready(function () {
    var url = window.location;
    $('.nav-item').removeClass('active');
    $('.nav-item a').each(function () {
        if (this.href == url) {
            $(this).parent().addClass('active');
        }
    });
});


$('.carrito').click(function () {

    $('.carrito-lleno').css({"left":"0"})
});

$('.carrito-lleno #cerrar-carrito').click(function () {

    $('.carrito-lleno').css({ "left": "-1000px" })
});


$('.salvar-articulo').click(function () {

    alert("hola");

});