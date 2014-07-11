'use strict';
app.factory('testService', ['$http', '$q', 'localStorageService', function ($http, $q, localStorageService) {

    var serviceBase = 'http://localhost:8088/';

    var authServiceFactory = {};

    var _authentication = {
        isAuth: false,
        userName: ""
    };

    var _login = function () {

        var data = "grant_type=password&username=Tim&password=password";

        var deferred = $q.defer();
        $http.post(serviceBase + 'token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).success(function (response) {
            console.log(response);
        });

        return deferred.promise;

    };

    authServiceFactory.login = _login;
    
    return authServiceFactory;
}]);