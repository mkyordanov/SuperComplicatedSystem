using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperComplicatedSystem.Models
{
    public class equipmentType
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(20)]
        public string name { get; set; }

        


    }
}