'use strict';

angular.module('testAngularJsApp')
    .controller('main', function ($scope, $location, productService) {
        var promise = productService.getProducts();
        promise.then(function (data) {            
            $scope.tshirtsActive = data.splice(0, 4);
            $scope.tshirts = data;
        });

        $scope.showDetails = function (id) {
            $location.path("/productdetails/" + id);
        };
    });