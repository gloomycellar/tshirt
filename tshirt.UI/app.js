'use strict';

var app = angular
  .module('tshirtApp', ['ngRoute', 'LocalStorageModule', 'ui.bootstrap'])
  .config(function ($routeProvider) {
      $routeProvider
        .when('/', {
            templateUrl: 'views/main.html',
            controller: 'mainController'
        })
        .when('/productdetails/:productId', {
            templateUrl: 'views/productdetails.html',
            controller: 'productDetailsController'
        })
        .when('/cart', {
            templateUrl: 'views/cart.html',
            controller: 'cartController'
        })
        .when('/checkout', {
            templateUrl: 'views/checkout.html',
            controller: 'checkoutController'
        })
        .when('/register', {
            templateUrl: 'views/register.html',
            controller: 'authController'
        })
        .otherwise({
            redirectTo: '/'
        });

      //$routeProvider.when("/home", {
      //    controller: "homeController",
      //    templateUrl: "views/home.html"
      //});

      //$routeProvider.when("/login", {
      //    controller: "loginController",
      //    templateUrl: "views/login.html"
      //});

      //$routeProvider.when("/signup", {
      //    controller: "signupController",
      //    templateUrl: "views/signup.html"
      //});

      //$routeProvider.when("/orders", {
      //    controller: "ordersController",
      //    templateUrl: "views/orders.html"
      //});

      //$routeProvider.otherwise({ redirectTo: "/" });
  });

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);

