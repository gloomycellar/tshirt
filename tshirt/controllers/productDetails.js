'use strict';

angular.module('testAngularJsApp')
    .controller('productDetails', function ($scope, $routeParams, productService, cartService) {
        productService.getProduct($routeParams.productId).then(function (data) {
            $scope.product = data;            
        });

        $scope.quontity = 1;

        $scope.addToCart = function (product, quontity) {
            cartService.add(product, quontity);
        };
    });