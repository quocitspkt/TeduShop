using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistic")]
    public class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }
        public DateTime VisitedDate { get; set; }
        public string IPAddress { get; set; }
    }
}
