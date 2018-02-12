using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise3_1.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public double Balance { get; set; }
        public virtual ICollection<Purchases> Purchases { get; set; }
    }
}