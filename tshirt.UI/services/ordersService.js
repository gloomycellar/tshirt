'use strict';
app.factory('ordersService', function ($http) {
    var serviceBase = "http://localhost:8088/";
    var ordersServiceFactory = {};

    var _getOrders = function () {
        return $http.get(serviceBase + 'api/orders').then(function (results) {
            return results;
        });
    };

    ordersServiceFactory.getOrders = _getOrders;

    return ordersServiceFactory;

});