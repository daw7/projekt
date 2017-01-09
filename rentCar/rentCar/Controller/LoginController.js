angular.module('App').controller('LoginController', function ($scope, LoginService) {
    //var LoginController = function ($scope, LoginService) {
//angular.module('App', ['ngRoute', 'ui.bootstrap', 'chart.js']).controller('LoginController', function ($scope, LoginService) {


    //initilize user data object
    $scope.LoginData = {
        Email: '',
        Password: ''
    }
    $scope.msg = "siema";
    //LoginController.$inject = ['$scope'];
    $scope.Submited = false;
    $scope.IsLoggedIn = false;
    $scope.IsFormValid = false;

    //Check whether the form is valid or not using $watch
    $scope.$watch("myForm.$valid", function (TrueOrFalse) {
        $scope.IsFormValid = TrueOrFalse;   //returns true if form valid
    });

    $scope.LoginForm = function () {
        $scope.Submited = true;
        if ($scope.IsFormValid) {
            LoginService.getUserDetails($scope.Login).then(function (d) {
                console.log(d.data.Login);
                debugger;
                if (d.data.Login != null) {
                    debugger;
                    $scope.IsLoggedIn = true;
                    $scope.msg = "You successfully Loggedin Mr/Ms "; //+ d.data.FullName;
                }
                else {
                    alert("Invalid credentials buddy! try again");
                }
            });
        }
    }
})
    .factory("LoginService", function ($http) {
        //initilize factory object.
        var fact = {};
        fact.getUserDetails = function (d) {
            debugger;
            return $http({
                url: '/Home/Login/getLoginData',
                method: 'POST',
                data: JSON.stringify(d),
                headers: { 'content-type': 'application/json' }
            });
        };
        return fact;
    });