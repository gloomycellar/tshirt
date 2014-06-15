app.factory("tshirtsService", function ($http) {
    return {
        get: function (successcb) {
            $http({ method: "GET", url: "/api/tshirts" })
            .success(function (data, status, headers, config) {
                successcb(data)
            });
        }
    };
});