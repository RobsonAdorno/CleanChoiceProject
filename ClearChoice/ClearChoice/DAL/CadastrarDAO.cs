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

        //------------------------------------------------------------- Daqui p baixo é apenas transações com pessoas fisicas ------------------------

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

        //----------------------------------------------- Daqui p baixo é apenas pessoas juridicas ------------------------------------------------

        public static Pessoa VerificarPorCNPJ(PessoaJuridica pj)
        {
            return ctx.Pessoas.FirstOrDefault(x => x.Login.Equals(pj.Login));
        }

        public static bool CadastrarPJ(PessoaJuridica pj)
        {
            if (VerificarPorCNPJ(pj) != null)
            {
                return false;
            }

            ctx.Pessoas.Add(pj);
            ctx.SaveChanges();
            return true;
        }


    }
}