'use strict';

angular.module('testAngularJsApp')
    .controller('productDetails', function ($scope, $routeParams, productService) {
        productService.getProduct($routeParams.productId).then(function (data) {
            $scope.product = data;
        });
    });