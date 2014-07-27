'use strict';

app.controller('main', function ($scope, $location, productService, authService) {

    $scope.location = $location;

    productService.getProducts().then(function (data) {
        var result = [],
            iterator = 0

        while (data.length > 0 && iterator < 2) {
            result.push(data.splice(0, 4));
            iterator++;
        }
        $scope.tshirtArrays = result;
    });

    $scope.showDetails = function (id) {
        $location.path("/productdetails/" + id);
    };

    $scope.redirect = function (page) {
        $location.path(page);
    };

    $scope.authentication = authService.authentication;

    $scope.logOut = function () {
        authService.logOut();
        $location.path('/');
    };

    $scope.getPageHeader = function () {
        var controllerName = $location.path().split("/")[1].toLowerCase();

        switch (controllerName) {
            case "cart": return "Your Cart";
            case "checkout": return "Checkout";
            case "register": return "Login or Register";
            case "productdetails": return "Product Details";
            default: return "empty header";
        }
    }
});