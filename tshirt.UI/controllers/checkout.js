'use strict';

app.controller('checkout', function ($scope, $location, authService, userService) {
    $scope.newUserLoginType = "register";
    $scope.checkoutData = {
    };

    userService.getUserInfo().then(function (response) {
        $scope.userInfo = response.data;
    },
    function (err) {
        console.log(err);
        //$scope.loginMessage = err.error_description;
    });
});