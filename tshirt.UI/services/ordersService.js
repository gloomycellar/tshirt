'use strict';
app.factory('ordersService', ['$http', function ($http) {

    //var serviceBase = 'http://localhost:26264/';
    //var serviceBase = 'http://ngauthenticationapi.azurewebsites.net/';
    var serviceBase = "http://localhost:8088/";

    var ordersServiceFactory = {};

    var _getOrders = function () {

        return $http.get(serviceBase + 'api/orders').then(function (results) {
            return results;
        });
    };

    ordersServiceFactory.getOrders = _getOrders;

    return ordersServiceFactory;

}]);