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