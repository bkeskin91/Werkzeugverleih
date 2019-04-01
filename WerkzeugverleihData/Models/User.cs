using System;
using System.Collections.Generic;
using System.Text;

namespace WerkzeugverleihData.Models
{
    public class User
    {
        public int ID { get; set; }

        public String Name { get; set; }

        public IEnumerable<Checkout> Checkouts { get; set; }
    }
}
