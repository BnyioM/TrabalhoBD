using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetsManagement.Models.Tables
{
    public class Funcionarios
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public long CPF { get; set; }

        public string Nome { get; set; }
        public long RG { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }

    }
}
