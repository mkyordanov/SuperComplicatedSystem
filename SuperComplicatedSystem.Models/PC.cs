using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperComplicatedSystem.Models
{
    public class PC
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string name { get; set; }
        [Required]
        public virtual List<Components> components { get; set;}
     

    }
}
