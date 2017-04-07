var UserPermissions = angular.module('perm', []);
UserPermissions.factory('userPermissions', ['$http', 'url_prefix', function ($http, url_prefix) {

    var permissions = [];
    var activeDirectoryUserId = 0;
    var userPermissions = {};

    //$http.get(url_prefix + '/api/ActiveDirectory/GetDataFromActiveDirectoryUser').then(function (responsead) {

    //    activeDirectoryUserId = responsead.data.id;

    //});

    userPermissions.GetPermissions = function (id) {     

        
        

    };

    userPermissions.Can = function (p, array) {

        for (var i = 0; i < array.length; i++) {
            if (array[i].Type === p) {
                return true;
            }
        }

        return false;
        

    };

    return userPermissions;

}]);



