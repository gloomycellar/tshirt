'use strict';

angular.module('tshirtApp')
    .controller('main', function ($scope, $location, productService) {
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
    });