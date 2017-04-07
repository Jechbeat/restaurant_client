(function () {
    'use strict';

    var app = angular.module('app'); 

    var url_prefixL = '/ClientApp';
    // Collect the routes
    app.constant('routes', getRoutes(url_prefixL));
    app.constant('url_prefix', url_prefixL); 
    
    // Configure the routes and route resolvers
    app.config(['$routeProvider', 'routes', routeConfigurator]);
    function routeConfigurator($routeProvider, routes) {

        routes.forEach(function (r) {
            $routeProvider.when(r.url, r.config);
        });
        $routeProvider.otherwise({ redirectTo: '/' });
    }
     
    // Define the routes 
    function getRoutes(url_prefix) {       
        return [
            {
                url: '/',
                config: {
                    templateUrl: url_prefix + '/app/dashboard/dashboard.html',
                    title: 'dashboard',
                    settings: {
                        nav: 1,
                        content: '<i class="fa fa-dashboard"></i> Dashboard'
                    }
                }
            }, {
                url: '/admin',
                config: {
                    title: 'admin',
                    templateUrl: url_prefix + '/app/admin/admin.html',
                    settings: {
                        nav: 2,
                        content: '<i class="fa fa-lock"></i> Admin'
                    }
                }
            },
         {
             url: '/test',
             config: {
                 title: 'test',
                 templateUrl: url_prefix + '/app/test/test.html',
                 settings: {
                     nav: 3,
                     content: '<i class="fa fa-lock"></i> Test'
                 }
             }
         },
            {
                url: '/clientapp',
                config: {
                    title: 'Client App',
                    templateUrl: url_prefix + '/app/tree/tree.html',
                    settings: {
                        nav: 4,
                        content: '<i class="fa fa-user"></i> clientapp'
                    }
                }
            }

        ];
    }
})();