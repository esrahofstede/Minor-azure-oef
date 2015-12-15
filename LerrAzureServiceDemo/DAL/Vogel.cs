using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Vogel")]
    public class Vogel
    {
        [Key]
        public long ID { get; set; }
        public string Naam { get; set; }

    }
}
