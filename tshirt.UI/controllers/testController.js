'use strict';
app.controller('loginController', ['$scope', '$location', 'authService', function ($scope, $location, testService) {

    $scope.login = function () {

        authService.login().then(function (response) {
        });
    };

}]);