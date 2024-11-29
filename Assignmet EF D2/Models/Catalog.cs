using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet_EF_D2.Models
{
    public class Catalog
    {
        [Key]
        public int Catalog_Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual List<News>News { get; set; }=new List<News>();
        public override string ToString()
        {
            return $"{Name}_{Description}";
        }


    }
}
