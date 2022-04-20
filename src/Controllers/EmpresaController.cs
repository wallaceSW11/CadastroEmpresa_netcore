using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISS.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace CadastroEmpresa_netcore.Controllers
{
    [ApiController]
    [Route("empresa")]
    public class EmpresaController : ControllerBase
    {
        private List<Empresa> _empresas = new List<Empresa>();
        public EmpresaController()
        {
            PreencherListaEmpresa();
        }
        private void PreencherListaEmpresa()
        {
            _empresas.Add(new Empresa("123456789000111", "The Best Interprise", "true", "Terê City", "WebISS2"));
            _empresas.Add(new Empresa("564545489000112", "The fufa loka", "false", "Rio", "SigISS"));
            _empresas.Add(new Empresa("787534589000113", "Eu te avisei", "true", "Sampa", "Fiorilli"));
            _empresas.Add(new Empresa("787878998000114", "Volto já", "true", "Floripa", "FloripaWS"));

        }

        [HttpGet]
        public ActionResult<List<Empresa>> ObterEmpresas()
        {
            return Ok(_empresas);
        }

        [HttpGet("{cnpj}")]
        public ActionResult<Empresa> ObterEmpresaPorCNPJ(string cnpj)
        {
            Empresa empresa = new Empresa(_empresas.Find(e => e.CNPJ == cnpj));

            if (empresa == null) return NotFound();

            return Ok(empresa);
        }

        [HttpPost]
        public ActionResult CadastrarEmpresa([FromBody] Empresa empresa)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var empresaNova = new Empresa(empresa);

            _empresas.Add(empresaNova);

            return Ok();
        }


    }
}