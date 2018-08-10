using ClearChoice.DAL;
using ClearChoice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClearChoice.Controllers
{
    public class CadastrarController : Controller
    {
        // GET: Cadastrar
        public ActionResult CadastrarPFView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarPFView(string txtNome, string txtEmail, string txtLogin, string txtRG, string txtSenha)
        {
            PessoaFisica pf = new PessoaFisica()
            {
                Nome = txtNome,
                Email = txtEmail,
                Login = txtLogin,
                RG = txtRG,
                Senha = txtSenha
                
            };

            if (CadastrarDAO.CadastrarPF(pf))
            {
                ViewBag.Message = "Cadastro Efetuado!";
                RedirectToAction("Index", "Home");
            }else
            {
                ViewBag.Message = "Erro ao cadastrar!";
            }

            return View();

        }
        [HttpGet]

        public ActionResult CadastrarPJView(string txtNome, string txtEmail, string txtLogin, string txtCNPJ, string txtSenha)
        {
            PessoaJuridica pj = new PessoaJuridica()
            {
                CNPJ = txtCNPJ,
                Nome = txtNome,
                Email = txtEmail,
                Login = txtLogin,
                Senha = txtSenha
            };

            if (CadastrarDAO.CadastrarPJ(pj))
            {
                ViewBag.Message = "Empresa cadastrada com sucesso!";
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Empresa já cadastrada!";
            return View();
        }
    }
}