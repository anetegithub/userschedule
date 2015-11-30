/// <reference path="jquery-1.9.1.js" />
/// <reference path="linq.js" />
$(document).ready(function () {
    var SelectedMenu = $('#selectedMenu').val();
    var Element = Enumerable.From($('.navbar-nav > li > a').toArray())
        .Where(function (x) {
            return $(x).html() == SelectedMenu;
        })
        .ToArray()[0];
    $(Element).parent().addClass('active');
})