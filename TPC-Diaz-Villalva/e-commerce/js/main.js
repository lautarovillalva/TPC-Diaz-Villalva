﻿

$('.ver-listado').click(function () {

    $('.dropdown-menu').addClass('ver');
    $(this).next('.sub-menu-desplegable').slideToggle();
   
});


$('.nav-link').click(function () {

   

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

1
2
3
4
5

