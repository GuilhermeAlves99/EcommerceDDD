using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Product")]
    public class Products:Notifies
    {
        [Column("PRD_ID")]
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Column("PRD_NAME")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column("PRD_VALUE")]
        [Display(Name = "Value")]
        public decimal Value { get; set; }

        [Column("PRD_STATUS")]
        [Display(Name = "Status")]
        public bool Status { get; set; }
    }
}
