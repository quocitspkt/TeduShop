using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Department { get; set; }
        [Required]
        [MaxLength(100)]
        public string Skype { get; set; }
        [Required]
        [MaxLength(100)]
        public string Mobile { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Yahoo { get; set; }
        [Required]
        [MaxLength(100)]
        public string Facebook { get; set; }
       
        public bool? Status { get; set; }
    }
}
