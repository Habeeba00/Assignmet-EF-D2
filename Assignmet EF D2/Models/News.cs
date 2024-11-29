using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet_EF_D2.Models
{
    public class News
    {
        [Key]
        public int News_Id { get; set; }
        public string? Bref { get; set; }
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey("catalog")]
        public int Catalog_Id { get; set; }
        [ForeignKey("author")]
        public int Auther_Id { get; set; }

        public virtual Author author { get; set; }
        public virtual Catalog catalog { get; set; }





    }
}
