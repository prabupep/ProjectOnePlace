//CONSTANTS
LabelText = {
    add_new_project: 'New Project',
    select_project: 'Select from list'
};

Files = [{ FilePath: '$:/EMS/test/test', Status: '' }, { FilePath: '$:/EMS/test/test', Status: '' }]

//NEW RELEASE REQUEST
ngApp.controller('releasenewrequest', function ($scope, $http) {
    // CONSTANTS
    $scope.showaddproject = false;
    $scope.files = Files;
    $scope.NewProject = LabelText.add_new_project;

    var promise = $http.get(apiUrls.GetProjects);
    promise.then(function (data) {
        $scope.projects = data.data;
    });
    // EVENTS OR FUNCTIONS
    $scope.addprojectclick = function () {
        $scope.showaddproject = !$scope.showaddproject;
        if ($scope.showaddproject)
        { $scope.NewProject = LabelText.select_project }
        else { $scope.NewProject = LabelText.add_new_project }

    };

    $scope.addTfsDetail = function () {


    }


    $scope.addnewproject = function () {
        var promise = $http.post(apiUrls.AddProject, $scope.project);
        promise.then(function (data) {
            var result = data;
        });

    };
});


//GET LIST OF RELEASE REQUEST
ngApp.controller('releaserequestlist', function ($scope, $http) {
    $scope.name = 'Project one place'
});



