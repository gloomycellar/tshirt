'use strict';

var app = angular
  .module('adminApp', [
    'ngCookies',
    'ngResource',
    'ngSanitize',
    'ngRoute'
  ])
  .config(function ($routeProvider) {
      $routeProvider
        .when('/', {
            templateUrl: 'views/admin.html',
            controller: 'AdminCtrl'
        })
        .otherwise({
            redirectTo: '/'
        });
  });