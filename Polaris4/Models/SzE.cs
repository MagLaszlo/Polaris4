using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Polaris4.Models
{
    public class SzE
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string SzENev { get; set; }
        [Required]
        public int SzEKod { get; set; }

    }
}