﻿'use strict';
app.factory('authService', ['$http', '$q', 'localStorageService', 'configService', function ($http, $q, localStorageService, configService) {
    var authServiceFactory = {};

    var authentication = {
        isAuth: false,
        email: ""
    };

    var saveRegistration = function (registration) {
        logOut();

        return $http.post(configService.serviceBase + '/account/register', registration).then(function (response) {
            return response;
        });
    };

    var login = function (loginData) {
        var data = "grant_type=password&username=" + loginData.email + "&password=" + loginData.password;
        var deferred = $q.defer();
        $http.post(configService.serviceBase + '/token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
            .success(function (response) {
                localStorageService.set('authorizationData', { token: response.access_token, email: loginData.email });
                authentication.isAuth = true;
                authentication.email = loginData.email;
                deferred.resolve(response);
            }).error(function (err, status) {
                logOut();
                deferred.reject(err);
            });

        return deferred.promise;
    };

    var logOut = function () {
        localStorageService.remove('authorizationData');
        authentication.isAuth = false;
        authentication.userName = "";
    };

    var fillAuthData = function () {
        var authData = localStorageService.get('authorizationData');
        if (authData) {
            authentication.isAuth = true;
            authentication.userName = authData.userName;
        }
    }

    authServiceFactory.saveRegistration = saveRegistration;
    authServiceFactory.login = login;
    authServiceFactory.logOut = logOut;
    authServiceFactory.fillAuthData = fillAuthData;
    authServiceFactory.authentication = authentication;

    return authServiceFactory;
}]);