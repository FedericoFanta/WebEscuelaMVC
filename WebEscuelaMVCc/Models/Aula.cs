using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebEscuelaMVCc.Validations;

namespace WebEscuelaMVCc.Models
{
    public class Aula
    {
        public int id { get; set; }
        [Required]
        [CheckValidNum]
        public int Numero { get; set; }
        [Required]
        public string Estado { get; set; }  
    }
}