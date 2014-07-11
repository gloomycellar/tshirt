'use strict';

app.controller('main', function ($scope, $location, productService, authService) {
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
    }
});