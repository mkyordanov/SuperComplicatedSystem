using SuperComplicatedSystem.Models.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperComplicatedSystem.Models
{
    public class Components
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public ComponentTypes Type { get; set; }
        [Required]
        [MaxLength(20)]
        public string Model { get; set; }
        [Required]
        public virtual List<PC> PCs { get; set; }
    }
}