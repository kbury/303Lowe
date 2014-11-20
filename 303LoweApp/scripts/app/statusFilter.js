LoweApp.filter('status', function () {
    return function (statusId) {
        if (statusId == 1)
            return 'Submitted';
        else
            return 'Approved';
    }
});