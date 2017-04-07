



(function () {
    'use strict';

 


    angular.module('app' )

  

    .config(function(paginationTemplateProvider, url_prefix ) {
  
        paginationTemplateProvider.setPath( url_prefix + '/bower_components/angular-dir-pagination/dirPagination.tpl.html');
    })

    .controller('TreeController', ['$scope', '$http', 'url_prefix', 'common', 'filterFilter', 'userPermissions', function ($scope, $http, url_prefix, common, filterFilter, userPermissions) {
       



    }])


    })();