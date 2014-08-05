app.directive('metismenu', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            element.metisMenu();
        }
    };
});