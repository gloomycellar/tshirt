'use strict';

angular.module('testAngularJsApp')
    .controller('cart', function ($scope, $routeParams, cartService) {
        $scope.cart = cartService;
    });