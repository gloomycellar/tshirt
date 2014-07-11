'use strict';

var app = angular
  .module('tshirtApp', ['ngRoute', 'LocalStorageModule'])
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
            controller: 'authController'
        })
        .otherwise({
            redirectTo: '/'
        });

      $routeProvider.when("/home", {
          controller: "homeController",
          templateUrl: "views/home.html"
      });

      $routeProvider.when("/login", {
          controller: "loginController",
          templateUrl: "views/login.html"
      });

      $routeProvider.when("/signup", {
          controller: "signupController",
          templateUrl: "views/signup.html"
      });

      $routeProvider.when("/orders", {
          controller: "ordersController",
          templateUrl: "views/orders.html"
      });

      //$routeProvider.otherwise({ redirectTo: "/" });
  });

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);

