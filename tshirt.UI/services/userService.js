app.factory("userService", function ($http, $q, configService) {
    return {
        getUserInfo: function () {
            var deferred = $q.defer();
            $http.get(configService.serviceBase + '/Account/UserDetails').then(function (results) {
                deferred.resolve(results);
            });
            return deferred.promise;
        },

        saveUserInfo: function (userInfo) {
            return $http.post(configService.serviceBase + '/account/UserDetails', userInfo).then(function (response) {
                return response;
            });
        }
    };
});