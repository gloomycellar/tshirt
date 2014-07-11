﻿'use strict';
app.factory('authService', ['$http', '$q', 'localStorageService', 'configService', function ($http, $q, localStorageService, configService) {

    var authServiceFactory = {};

    var _authentication = {
        isAuth: false,
        email: ""
    };

    var _saveRegistration = function (registration) {

        _logOut();

        return $http.post(configService.serviceBase + '/account/register', registration).then(function (response) {
            return response;
        });

    };

    var _login = function (loginData) {

        var data = "grant_type=password&username=" + loginData.email + "&password=" + loginData.password;

        var deferred = $q.defer();

        $http.post(configService.serviceBase + '/token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).success(function (response) {

            console.log(response);

            localStorageService.set('authorizationData', { token: response.access_token, email: loginData.email });

            _authentication.isAuth = true;
            _authentication.email = loginData.email;

            deferred.resolve(response);

        }).error(function (err, status) {
            _logOut();
            deferred.reject(err);
        });

        return deferred.promise;

    };

    var _logOut = function () {

        localStorageService.remove('authorizationData');

        _authentication.isAuth = false;
        _authentication.userName = "";

    };

    var _fillAuthData = function () {

        var authData = localStorageService.get('authorizationData');
        if (authData) {
            _authentication.isAuth = true;
            _authentication.userName = authData.userName;
        }

    }

    authServiceFactory.saveRegistration = _saveRegistration;
    authServiceFactory.login = _login;
    authServiceFactory.logOut = _logOut;
    authServiceFactory.fillAuthData = _fillAuthData;
    authServiceFactory.authentication = _authentication;

    return authServiceFactory;
}]);