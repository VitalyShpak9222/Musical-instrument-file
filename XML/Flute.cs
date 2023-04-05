using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Flute:Instrument
    {
        public Flute() : base() { }

        public Flute(string name, int? id, decimal price, DateTime date, Master master) : base(name, id, price, date, master) { }
    }
}
