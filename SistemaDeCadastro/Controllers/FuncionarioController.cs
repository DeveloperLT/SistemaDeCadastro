using SistemaDeCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaDeCadastro.Controllers
{
    #region - Método para ler Funcionários
    //GET Funcionario/GETFuncionario
    public class FuncionarioController : Controller
    {
        public JsonResult GetFuncionario()
        {
            using (var db = new FuncionariosEntities())
            {
                List<Funcionario> listarFuncionarios = db.Funcionarios.ToList();
                return Json(listarFuncionarios, JsonRequestBehavior.AllowGet);
            }
        }
    }
    #endregion

}
