using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Polaris4.Models
{
    public class Eszkoz
    {

        public int Id { get; set; }
        [Required]
        public int GBSzam { get; set; }
        [StringLength(50)]
        public string GyariSzam { get; set; }
        public int EszkozSzam { get; set; }


    }
}