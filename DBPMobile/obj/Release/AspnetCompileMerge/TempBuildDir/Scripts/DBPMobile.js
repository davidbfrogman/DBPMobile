$(function () {
    // initialize Masonry after all images have loaded 
    var $container = $('.divMasonryContainer');
    $container.imagesLoaded(function () {
        $container.fadeIn();
        $container.masonry(
            {
                itemSelector: '.homePageImage',
                isAnimated: true,
                columnWidth: 1,
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

$(document).ready(function () {
    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-9571004-2']);
    _gaq.push(['_trackPageview']);
    (function () {
        var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
    })();
});