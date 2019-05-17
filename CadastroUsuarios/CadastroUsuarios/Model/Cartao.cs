using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.Model
{
    public class Cartao
    {
        public Cartao()
        {

        }

        [Key]
        public String ID { get; set; }

        public DateTime? Validade { get; set; }

        public String Motivo { get; set; }

        public DateTime? Nascimento { get; set; }

        public String Cpf { get; set; }

        public String Nome { get; set; }
    }
}
