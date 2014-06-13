app.factory("greeting", function ($http) {
    return {
        getMessage: function (successcb) {
            $http({ method: "GET", url: "/api/values" })
            .success(function (data, status, headers, config) {
                console.log(data);
                console.log(status);
                console.log(headers);
                console.log(config);

                console.log("AAA");

                successcb(data)
            });
        }
    };
});