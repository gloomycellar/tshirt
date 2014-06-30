app.factory("productService", function ($http, $q) {
    return {
        getProducts: function () {
            return this.performCall({ method: "GET", url: "/api/products" });
        },

        getProduct: function (id) {
            return this.performCall({ method: "GET", url: "/api/products/" + id })
        },

        performCall: function (options) {
            var deffered = $q.defer();
            $http(options)
            .success(function (data, status, headers, config) {
                deffered.resolve(data);
            }).error(function (data, status, headers, config) {
                deffered.reject(status);
            });

            return deffered.promise
        }
    };
});