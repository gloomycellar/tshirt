app.directive('datatable', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {            
            scope.$watch("options.aaData", function () {
                var dataTable = element.dataTable(scope.options);
            })            
        },
        scope: {
            options: "=options"
        }
    };
});