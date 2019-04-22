

funcionarioApp.controller('funcionarioCtrl', function ($scope, funcionarioService) {

    carregarFuncionarios();

    function carregarFuncionarios() {

        var listarFuncionarios = funcionarioService.getTodosFuncionarios();
        listarFuncionarios.then(function (d) {

            $scope.Funcionarios = d.data;

        },
            function () {
                alert("Ocorreu um erro ao tentar listar todos os funcionários");
            });
        
    }

});