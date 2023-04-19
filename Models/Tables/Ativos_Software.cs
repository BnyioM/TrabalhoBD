using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetsManagement.Models.Tables
{
    public class Ativos_Software
    {
        [Key]
        Guid ID { get; set; } = Guid.NewGuid();

        [Required]
        public int Produto_ID { get; set; }
        public int Funcionario_ID { get; set; } 
        public int Fornecedor_ID { get; set; }
        public string Licenca { get; set; }
    }
}
