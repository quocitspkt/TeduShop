using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        public virtual PostTag PostTag { get; set; }
        public virtual ProductTag ProductTag { get; set; }
    }
}