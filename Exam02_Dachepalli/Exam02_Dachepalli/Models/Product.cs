using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Exam02_Dachepalli.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}