(function () {
    'use strict';
    var controllerId = 'test';
    angular.module('app')

    .controller(controllerId, ['common', test]);






    function test(common) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.title = 'Test';

        activate();

        function activate() {
            common.activateController([], controllerId)
                .then(function () { log('Activated Test View'); });
        }
    }
})();