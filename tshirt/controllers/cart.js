'use strict';

angular.module('tshirtApp')
    .controller('cart', function ($scope, $routeParams, cartService) {
        $scope.cart = cartService;
    });