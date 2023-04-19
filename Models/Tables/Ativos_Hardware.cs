using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITAssetsManagement.Models.Tables
{
    public class Ativos_Hardware
    {

        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();

        [Required]
        public int Hardware_ID { get; set; }

        public XElement Manutencao { get; set; }
        public int Funcionario_ID {get; set; }

        public int Fornecedor_ID { get; set; }
    }
}
