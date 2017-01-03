var MainController = function ($scope) {

    //$scope.cos = "Cos!";

    $scope.models = {
        locations: [
                   { id: "1", Location: "Flota - cennik z VAT"},
                   { id: "2", Location: "Wynajem krótkoterminowy" },
                   { id: "3", Location: "Wynajem długoterminowy samochodów" },
                   { id: "4", Location: "Wynajem samochodu z kierowcą" },
                   { id: "5", Location: "Warunki wynajmu" },
                   { id: "6", Location: "Wynajem samochodu z OC sprawcy" },
        ]
    };

    $scope.selectedLocation = $scope.models.locations[0];

    $scope.changeLocation = function (loc) {
        $scope.selectedLocation = loc;
    }

};

MainController.$inject = ['$scope'];