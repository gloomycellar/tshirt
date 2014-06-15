'use strict';

angular.module('testAngularJsApp')
    .controller('MainCtrl', function ($scope, tshirtsService) {
        tshirtsService.get(function (data) { console.log(data); $scope.tshirts = data; });
    });