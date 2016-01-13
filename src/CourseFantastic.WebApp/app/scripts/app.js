'use strict';

/**
 * @ngdoc overview
 * @name appNameApp
 * @description
 * # appNameApp
 *
 * Main module of the application.
 */
angular
  .module('appNameApp', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch',
    'jcs-autoValidate',
  	'angular-ladda',
    'kendo.directives'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl',
        controllerAs: 'main'
      })
      .when('/about', {
        templateUrl: 'views/about.html',
        controller: 'AboutCtrl',
        controllerAs: 'about'
      })
      .when("/person/index", {
        templateUrl: 'views/person-index.html',
        controller: "PersonsController",
        controllerAs: 'people'
      })
      .otherwise({
        redirectTo: '/'
      });
  });

  angular.module('appNameApp')
    .run(function (defaultErrorMessageResolver) {
  		defaultErrorMessageResolver.getErrorMessages().then(function (errorMessages) {
  			errorMessages['badDate'] = 'You must enter a date with day/month/year';
  			errorMessages['tooOld'] = 'You must be max {0} years old to use this site';
  			errorMessages['badUsername'] = 'Username can only contain numbers and letters and _';
  		});
  	}
  );

  kendo.culture('en-AU');
