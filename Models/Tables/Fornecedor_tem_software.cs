using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetsManagement.Models.Tables
{
    public class Fornecedor_tem_software
    {
        [Required]
        int Fornecedor_ID { get; set; }

        [Required]
        int Software_ID { get; set; }
    }
}
