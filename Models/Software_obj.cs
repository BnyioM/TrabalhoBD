using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITAssetsManagement.Models
{
    internal class Software_obj
    {
        public int ID { get; set; }
        public int Software_ID { get; set; }
        public string Software_Nome { get; set; }
        public string Funcionario_Nome { get; set; }
        public string Licenca { get; set; }
    }
}
