'use strict';
app.factory('authService', ['$http', '$q', 'localStorageService', function ($http, $q, localStorageService) {
    var authServiceFactory = {};

    var _authentication = {
        isAuth: false,
        userName: ""
    };

    var _saveRegistration = function (registration) {

        _logOut();

        return $http.post('/api/account/register', registration).then(function (response) {
            return response;
        });
    };

    var _login = function (loginData) {
        var deferred = $q.defer();

        var data = "grant_type=password&username=Tim&password=password";

        $http({ url: '/token?grant_type=password&username=Tim&password=password', method: 'POST' })
            .success(function (data) {
                console.log(data)
            });

        //$http.post('/token', data).success(function (data) {
        //    console.log(data)
        //});

        //$http.post('/token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
        //    .success(function (response) {

        //        localStorageService.setItem('authorizationData', { token: response.access_token, userName: loginData.userName });

        //        _authentication.isAuth = true;
        //        _authentication.userName = loginData.userName;

        //        deferred.resolve(response);

        //    }).error(function (err, status) {
        //        _logOut();
        //        deferred.reject(err);
        //    });

        return deferred.promise;
    };

    var _logOut = function () {

        localStorageService.removeItem('authorizationData');

        _authentication.isAuth = false;
        _authentication.userName = "";
    };

    var _fillAuthData = function () {

        var authData = localStorageService.getItem('authorizationData');
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