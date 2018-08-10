using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClearChoice.Model
{
    [Table("Pessoas")]
    public class Pessoa:BaseModel
    {
        
        public string Email { get; set; }
        public string Login { get; set; }

        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}