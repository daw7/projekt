var App = angular.module('App', ['ngRoute', 'ui.bootstrap', 'chart.js']);

App.controller('MainController', MainController);
App.controller('LoginController', LoginController);
App.controller('AboutController', AboutController);
App.controller('SignupController', SignupController);


var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider
        .when("/#/", {
            templateUrl: ""
         })
         .when("/about", {
             templateUrl: "rentCar/Views/About.html"
         })
        .when("/login", {
            templateUrl: "rentCar/Views/Login.html"
        })
        .when("/signup", {
            templateUrl: "rentCar/Views/Signup.html"
        })
       .otherwise({
           redirectTo: function () {
               return '/';
           }
       });
}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

App.config(configFunction);