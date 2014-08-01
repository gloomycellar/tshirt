'use strict';

app.controller('checkoutController', function ($scope, $location, authService, userService, cartService) {
    
    userService.getUserInfo().then(function (response) {
        $scope.userInfo = response.data;
    },
    function (err) {
        console.log(err);
        //$scope.loginMessage = err.error_description;
    });

    $scope.confirmOrder = function () {
        cartService.saveState();
    }
});