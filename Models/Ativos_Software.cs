using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetsManagement.Models
{
    public class Ativos_Software
    {
        [Key]
        Guid ID { get; set; } = Guid.NewGuid();

        [Required]
        public int Produto_ID { get; set; }

        public Funcionario Funcionario { get; set; }

        [Required]
        public Fornecedor Fornecedor Fornecedor { get; set; }
    }
}
