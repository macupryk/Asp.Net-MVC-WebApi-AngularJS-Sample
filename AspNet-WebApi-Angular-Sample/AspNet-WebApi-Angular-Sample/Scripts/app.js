(function () {
    'use strict';

    angular
        .module('Angularapp', [
        // Angular modules 
        'ngAnimate',
        'ui.bootstrap',
        'ngRoute'])
        .controller('AccordionDemoCtrl', function ($scope, $http) {

            $scope.items = [];

            $scope.addItem = function () {

                $http.get('/api/service/GetAllLang')
                    .then(function (response) {
                        $scope.items = response.data;
                    }, function (response) {
                        alert(response.data);
                    });
            };
            $scope.clearItem = function () {
                $scope.items = null;
            }
        })
})();