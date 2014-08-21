'use strict';

app.controller('productController', function ($scope, $location, productService) {
    productService.getProducts().then(function (data) {
        $scope.options.aaData = data;
    });

    $scope.options = {
        aoColumns: [
            { "data": "id", "sTitle" : "Id" },
            { "data": "name", "sTitle": "Name" },
            { "data": "price", "sTitle": "Price" },
            { "data": "availability", "sTitle": "Availability" },
            { "data": "category", "sTitle": "Category" },
            { "data": "description", "sTitle": "Description" }
        ],
        bJQueryUI: true,
        bDestroy: true
    };
});
