using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    [Serializable]
    public class Violin : Instrument
    {
        public Violin() : base() { }
        public Violin(string name, int? id, decimal price, DateTime age, Master master) : base(name, id, price, age, master) { }
    }
}
