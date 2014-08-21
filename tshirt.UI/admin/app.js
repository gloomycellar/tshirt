'use strict';

var app = angular.module("adminApp", ["ngRoute", 'LocalStorageModule']).config(function ($routeProvider) {
    $routeProvider
    .when('/', {
        templateUrl: 'views/admin.html',
        controller: 'adminCotroller'
    })
    .when('/products', {
        templateUrl: 'views/products.html',
        controller: 'productController'
    })
    .when('/login', {
        templateUrl: 'views/login.html',
        controller: 'loginController'
    })
    .otherwise({
        redirectTo: '/'
    });
});

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);
