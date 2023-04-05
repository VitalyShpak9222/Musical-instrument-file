using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    [Serializable]
    public class Drum : Instrument
    {
        public Drum() : base() { }
        public Drum(string name, int? id, decimal price, DateTime age, Master master) : base(name, id, price, age, master) { }
    }
}
