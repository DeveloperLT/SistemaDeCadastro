

funcionarioApp.service('funcionarioService', function ($http)) {

    this.getTodosFuncionarios = function () {
        return $http.get("/Funcionario/GetFuncionario");
    }
})