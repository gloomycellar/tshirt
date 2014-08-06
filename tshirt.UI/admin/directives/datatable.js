app.directive('datatable', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            element.dataTable();
        }
    };
});