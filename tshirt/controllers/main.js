'use strict';

angular.module('testAngularJsApp')
    .controller('MainCtrl', function ($scope, greeting) {
        greeting.getMessage(function (data) { $scope.greeting = data; });
    });