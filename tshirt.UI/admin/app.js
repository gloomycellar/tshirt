'use strict';

var app = angular.module("adminApp", ["ngRoute"]).config(function ($routeProvider) {
    $routeProvider
    .when('/', {
        templateUrl: 'views/admin.html',
        controller: 'adminCotroller'
    })
    .otherwise({
        redirectTo: '/'
    });
});