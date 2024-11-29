using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet_EF_D2.Models
{
    //[Table("Authors")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Author_Id { get; set; }
        public string Name { get; set; }
        public DateOnly JoinDate { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public string? Bref { get; set; }

        public virtual List<News> news { set; get; } = new List<News>();

        public override string ToString()
        {
            return $"{Name}-{JoinDate}-{Username}";
        }
    }
}
