using ClearChoice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClearChoice.DAL
{
    public class CadastrarDAO
    {
        private static Context ctx = SingletonContext.GetContext();

        public static Pessoa BuscarPessoaLogin(PessoaFisica pf)
        {
            return ctx.Pessoas.FirstOrDefault(x => x.Login.Equals(pf.RG));
        }

        public static bool CadastrarPF(PessoaFisica pf)
        {
            if (BuscarPessoaLogin(pf) != null)
            {
                return false;
            }

            ctx.Pessoas.Add(pf);
            ctx.SaveChanges();
            return true;
        }


    }
}