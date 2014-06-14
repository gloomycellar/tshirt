app.factory("greeting", function ($http) {
    return {
        getMessage: function (successcb) {
            $http({ method: "GET", url: "/api/values" })
            .success(function (data, status, headers, config) {
                successcb(data)
            });
        }
    };
});