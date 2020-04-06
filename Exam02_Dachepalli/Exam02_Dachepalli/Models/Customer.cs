using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam02_Dachepalli.Models
{
    public enum Rating
    {
        FIVE, FOUR, THREE, TWO, ONE
    }
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public Rating? Rating { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}