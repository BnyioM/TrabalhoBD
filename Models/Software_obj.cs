using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq.XContainer;

namespace ITAssetsManagement.Models
{
    internal class Software_obj
    {
        public string Nome { get; set}
        public List<string> Funcionarios { get; set; }
        public List<string> Licencas { get; set; }
        public List<XElement> Descricao { get; set; }
    }
}
