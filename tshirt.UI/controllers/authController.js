'use strict';
app.controller('authController', ['$scope', '$location', 'authService', 'configService', function ($scope, $location, authService, configService) {
    $scope.config = configService;

    $scope.loginMessage = "";
    $scope.loginData = {
        email: "",
        password: ""
    };

    $scope.login = function () {
        authService.login($scope.loginData).then(function (response) {
            $location.path('/');
        },
         function (err) {
             $scope.loginMessage = err.error_description;
         });
    };

    $scope.savedSuccessfully = false;
    $scope.registerMessage = "";
    $scope.registration = {
        firstName: "",
        lastName: "",
        password: "",
        email: ""
    };

    $scope.signUp = function () {
        authService.saveRegistration($scope.registration).then(function (response) {
            $scope.loginData.email = $scope.registration.email;
            $scope.loginData.password = $scope.registration.password;
            $scope.login();
        },
         function (response) {
             var errors = [];
             for (var key in response.data.modelState) {
                 for (var i = 0; i < response.data.modelState[key].length; i++) {
                     errors.push(response.data.modelState[key][i]);
                 }
             }
             $scope.registerMessage = "Failed to register user due to:" + errors.join(' ');
         });
    };
}]);