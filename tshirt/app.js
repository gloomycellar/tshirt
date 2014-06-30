﻿'use strict';

var app = angular
  .module('testAngularJsApp', [
    'ngCookies',
    'ngResource',
    'ngSanitize',
    'ngRoute'
  ])
  .config(function ($routeProvider) {
      $routeProvider
        .when('/', {
            templateUrl: 'views/main.html',
            controller: 'main'
        })
        .when('/productdetails/:productId', {
            templateUrl: 'views/productdetails.html',
            controller: 'productDetails'
        })
        .when('/cart', {
            templateUrl: 'views/cart.html',
            controller: 'cart'
        })
        .otherwise({
            redirectTo: '/'
        });
  });