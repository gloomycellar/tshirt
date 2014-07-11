app.factory("productService", function ($http, $q, configService) {
    return {
        getProducts: function () {
            return this.performCall("/products");
        },

        getProduct: function (id) {
            return this.performCall("/products/" + id)
        },

        performCall: function (url) {
            var deffered = $q.defer();
            $http.get(configService.serviceBase + url, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
            .success(function (data, status, headers, config) {
                deffered.resolve(data);
            }).error(function (data, status, headers, config) {
                deffered.reject(status);
            });

            return deffered.promise
        }
    };
});