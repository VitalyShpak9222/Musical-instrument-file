using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    [Serializable]
    public class Master
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Midlename { get; set; }

        public Master()
        {
            Id = -1;
            Name = null;
            Surname = null;
            Midlename = null;
        }

        public Master(int id, string name, string surname, string midlename)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Midlename = midlename;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetFNM()
        {
            return $"{Surname} {Name} {Midlename}";
        }
    }
}
