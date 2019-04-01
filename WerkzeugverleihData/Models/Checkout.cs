using System;
using System.Collections.Generic;
using System.Text;

namespace WerkzeugverleihData.Models
{
    public class Checkout
    {
        public int ID { get; set; }

        public Werkzeug Werkzeug { get; set; }
        public User User { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
