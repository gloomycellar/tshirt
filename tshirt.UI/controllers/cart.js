'use strict';

app.controller('cart', function ($scope, $routeParams, cartService) {
        $scope.cart = cartService;
    });