'use strict';

/**
 * @ngdoc function
 * @name appNameApp.controller:AboutCtrl
 * @description
 * # AboutCtrl
 * Controller of the appNameApp
 */
angular.module('appNameApp')
  .controller('AboutCtrl', function ($scope, $http) {
    this.awesomeThings = [
      'HTML5 Boilerplate',
      'AngularJS',
      'Karma'
    ];

    $scope.formModel = {};
    $scope.submitting = false;
    $scope.submitted = false;
    $scope.has_error = false;

    var maxDate = new Date();
    var currentYear = maxDate.getFullYear();
    maxDate.setFullYear(currentYear - 16);

    var minDate = new Date();
    minDate.setFullYear(currentYear - 70);

    $scope.dobOptions = {
      min: minDate,
      max: maxDate
    };

    $scope.onSubmit = function () {
      $scope.submitting = true;
      console.log("Hey i'm submitted!");
      console.log($scope.formModel);

        $http.post('http://localhost:1887/api/people/', $scope.formModel).
        success(function (data) {
          console.log(":)");
          $scope.submitting = false;
          $scope.submitted = true;
          $scope.has_error = false;
        }).error(function(data) {
          console.log(":(");
          $scope.submitting = false;
          $scope.submitted = false;
          $scope.has_error = true;
        });

    };
  });
