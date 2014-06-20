app.factory("tshirtsService", function ($http, $q) {
    return {
        get: function () {
            deffered = $q.defer();
            $http({ method: "GET", url: "/api/tshirts" })
            .success(function (data, status, headers, config) {
                deffered.resolve(data);
            }).error(function (data, status, headers, config) {
                deffered.reject(status);
            });

            return deffered.promise
        }
    };
});