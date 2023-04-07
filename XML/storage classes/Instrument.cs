using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Instrument
    {
        public string Name { get; set; }
        public int? Id { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Age { get; set; }
        public Master Master { get; set; }

        public Instrument()
        {
            Name = null;
            Id = null;
            Price = null;
            Age = null;
        }

        public Instrument(string name, int? id, decimal price, DateTime age, Master master)
        {
            Name = name;
            Id = id;
            Price = price;
            Age = age;
            this.Master = master;
        }

        public int? GetId()
        {
            return Id;
        }

        public decimal? GetPrice()
        {
            return Price;
        }

        public DateTime? GetAge()
        {
            return Age;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetAge(DateTime age)
        {
            Age = age;
        }
    }
}
