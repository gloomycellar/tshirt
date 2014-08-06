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
    .otherwise({
        redirectTo: '/'
    });
});