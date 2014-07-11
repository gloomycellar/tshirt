
////var app = angular.module('AngularAuthApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar']);
//var app = angular.module('tshirtApp', ['ngRoute', 'LocalStorageModule']);

////app.config(function ($routeProvider) {

////    $routeProvider.when("/login", {
////        controller: "loginController",
////        templateUrl: "/views/login.html"
////    });

////    $routeProvider.otherwise({ redirectTo: "/login" });

////});

//app.config(function ($routeProvider) {

//    $routeProvider.when("/login", {
//        controller: "testController",
//        templateUrl: "/views/test_login.html"
//    });

//    $routeProvider.otherwise({ redirectTo: "/login" });

//});

//app.config(function ($httpProvider) {
//    $httpProvider.interceptors.push('authInterceptorService');
//});

//app.run(['authService', function (authService) {
//    authService.fillAuthData();
//}]);



//var app = angular.module('AngularAuthApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar']);
var app = angular.module('tshirtApp', ['ngRoute', 'LocalStorageModule']);

//app.config(function ($routeProvider) {

//    $routeProvider.when("/login", {
//        controller: "loginController",
//        templateUrl: "/views/login.html"
//    });

//    $routeProvider.otherwise({ redirectTo: "/login" });

//});

app.config(function ($routeProvider) {

    $routeProvider.when("/login", {
        controller: "testController",
        templateUrl: "/views/test_login.html"
    });

    $routeProvider.otherwise({ redirectTo: "/login" });

});

//app.config(function ($httpProvider) {
//    $httpProvider.interceptors.push('authInterceptorService');
//});

//app.run(['authService', function (authService) {
//    authService.fillAuthData();
//}]);


