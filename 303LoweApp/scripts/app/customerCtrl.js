var LoweApp = angular.module('LoweApp', []);

LoweApp.controller('CustomerCtrl', ['$http', '$scope', function ($http, $scope) {

    $http.get('http://localhost:50817/getCustomers').success(onGetCustomersSuccess);

    $scope.downloadCustomerTransactions = function () {
        $http.get('http://localhost:50817/getTransactions/' + $scope.currentCustomer.id).success(onGetTransactionsSuccess);
    };

    function onGetCustomersSuccess(data) {
        $scope.customers = data;
        $scope.currentCustomer = data[0];

        $scope.downloadCustomerTransactions();
    }

    function onGetTransactionsSuccess(data) {
        $scope.currentCustomerTransactions = data;
    }

}]);