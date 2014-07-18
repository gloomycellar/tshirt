'use strict';

app.controller('cart', function ($scope, $routeParams, $location, cartService) {
    $scope.cart = cartService;

    $scope.continue = function () { $location.path('/'); };

    $scope.remove = function (id) {
        var item = cartService.getItem(id);
        cartService.remove(item.product, item.quontity);
    };

    $scope.checkout = function () { $location.path("/checkout") };
});