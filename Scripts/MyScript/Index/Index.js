
(function(){

    var myApp = window.myAppModul;
    myAppModul.controller('HeroSection', function ($scope) {

    });

    myApp.controller("subscribedController", function ($scope, $http) {



    });
    myApp.controller("aboutController", function ($scope, $http) {

        $scope.PlayVideo = function(){
            e.preventDefault();

            var link = "https://www.youtube.com/embed/r7N9R9tnYu0?autoplay=true";
            var frame = "<iframe width='535' height='159' src=" + link + " frameborder='0' allowfullscreen webkitallowfullscreen ></iframe>";
            $(".video_place").append(frame);

        };


    });

    

   




    ////start the angular, for 1.3 using ngRoute otherwise, using []
    var myAppModul = angular.module('myApp', ['ngRoute']);
    //window.angularStart = angular.module('myApp', ['ngRoute']);
    //start the controller
    myAppModul.controller('IndexController', function ($scope) {
        var message = {
            text: "this is a test."
        };

        

        $scope.message = message;
        $scope.items = [
                        { name: "john", id: "2" },
                        { name: "jack",id:"1"},
        ];
    });

    myAppModul.controller('FormController', function ($scope) {

        $scope.youCheckedIt = true;

        $scope.funding = { startingEstimate: 0, money:0 };

        $scope.computeNeeded = function () {
            $scope.funding.money = $scope.funding.startingEstimate * 10;
        };

        $scope.$watch('funding.startingEstimate', $scope.computeNeeded);

        $scope.requestSubmit = function () {
            alert("button clicked");
        };

        $scope.reset = function () {
            alert("button reset clicked");
            return false;
        };

        $scope.students = [
            {name:"Lucy",id:"1"},
            {name:"Lily",id:"2"}
        ];

        $scope.IdShow = true;
        $scope.IdHide = false;
        $scope.ngcondition = "condition";

       
    });
     

    myAppModul.controller('cartController', function ($scope, $http) {

        $scope.bill = { };
        
        $scope.items = [
        { title: "shoes", quantity: 1, price: 1.00 },
        { title: "T-shirt", quantity: 1, price: 4.56 }
        ];

      var calculation = function () {
            var total = 0;
            angular.forEach($scope.items, function (value,key) {
                total = value.price * value.quantity + total;
            });

            console.log("total is: " + total);
            $scope.bill.total = total;
            $scope.bill.discount = total > 100 ? 10 : 0;
            $scope.bill.subtotal = total - $scope.bill.discount;
        };
 
        //this newValue not working as it shows it is undefined
      //function calculateDiscount(newValue, oldValue,scope) {
      //    console.log("newValue: " + newValue);
      //    $scope.bill.discount = newValue > 100 ? 10 : 0;
      //}
      //$scope.$watch($scope.bill.total, calculateDiscount,true);
         
      $scope.$watch("items", calculation,true);
      $scope.btnHttpTest = function () {
          $http.post("/Home/GetAngularRequest/").success(function (data, status, headers, config) {
              console.log(data);
              $scope.items = data;

          });
      };

      myAppModul.directive("btn-directive", function () {
          return {
              link: function (scope, element, attr, controller) {
                  element.on("click", function () {
                      console.log("element: "+element + " clicked");
                      alert("btn-directive clicks");
                  });
              }
          }

      });


    });



})();

 