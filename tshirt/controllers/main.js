'use strict';

angular.module('testAngularJsApp')
    .controller('MainCtrl', function ($scope, greeting) {
        greeting.getMessage(function (data) {
            var obj = data;
            console.log(obj);
            $scope.greeting = obj.message;
        });
    });