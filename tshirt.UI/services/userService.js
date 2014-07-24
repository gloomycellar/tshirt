app.factory("userService", function ($http, $q, configService) {
    return {
        getUserInfo: function () {
            var deferred = $q.defer();
            $http.post(configService.serviceBase + '/Account/UserDetails').then(function (results) {
                deferred.resolve(results);
            });
            return deferred.promise;
        }
    };
});