$(function () {
    // initialize Masonry after all images have loaded 
    var $container = $('.divMasonryContainer');
    $container.imagesLoaded(function () {
        $container.fadeIn();
        $container.masonry(
            {
                itemSelector: '.homePageImage',
                isAnimated: true,
                columnWidth: '.homePageImage',
                gutter: 3,
            }).fadeIn();
    });
});

//This will make the current menu item active.
//I had to do this because the bootstrap thinks that query strings don't count.  So 
//because my portfolio pages are all based on query strings, all the menu items showed as active.  
//This javascript fixes that, and makes only the selected menu item active.
$(document).ready(function () {
    var url = window.location;
    $(".nav li").removeClass('active');
    // Will only work if string in href matches with location
    $('ul.nav a[href="' + url + '"]').parent().addClass('active');

    // Will also work for relative and absolute hrefs
    $('ul.nav a').filter(function () {
        return this.href == url;
    }).parent().addClass('active').parent().parent().addClass('active');
});


(function (i, s, o, g, r, a, m) {
    i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
        (i[r].q = i[r].q || []).push(arguments)
    }, i[r].l = 1 * new Date(); a = s.createElement(o),
    m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
})(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

ga('create', 'UA-9571004-2', 'auto');
ga('send', 'pageview');