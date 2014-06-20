'use strict';

angular.module('testAngularJsApp')
    .controller('MainCtrl', function ($scope, tshirtsService) {
        var promise = tshirtsService.get();
        promise.then(function (data) {
            var result = [], size = 4;
            while (data.length > 0)
                result.push(data.splice(0, size));
            console.log(result);
            $scope.tshirtGroups = result;
        });        
    });