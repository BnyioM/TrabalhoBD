using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITAssetsManagement.Models.Tables
{
    public class Unidade
    {
        [Required]
        public string Nome { get; set; }
        [Key]
        public int ID { get; set; }
        [Required]
        public long CEP { get; set; }
        [Required]
        public string Endereco { get; set; }
    }
}
