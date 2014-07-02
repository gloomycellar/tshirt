'use strict';

var app = angular
  .module('tshirtApp', [
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
        .when('/checkout', {
            templateUrl: 'views/checkout.html',
            controller: 'checkout'
        })
        .when('/register', {
            templateUrl: 'views/register.html',
            controller: 'register'
        })
        .otherwise({
            redirectTo: '/'
        });
  });