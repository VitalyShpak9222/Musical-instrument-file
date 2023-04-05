using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    internal class XMLDocument
    {
        private enum TypeS 
        {
            Скрипки,
            Барабаны,
            Мастера,
            Флейты
        }
        private static List<Violin> Violins { get; set; }
        private static List<Drum> Drums { get; set; }
        private static List<Master> Masters { get; set; }
        private static List<Flute> Flutes { get; set; }

        public XMLDocument()
        {
            Violins = new List<Violin>();
            Drums = new List<Drum>();
            Masters = new List<Master>();
            Flutes = new List<Flute>();
        }

        public int? GetMaxIdViolin() 
        {
            int count = Violins.Count;
            int?[] id = new int?[count];
            for (int i = 0; i < count; i++)
            {
                id.Append(Violins[i].GetId());
            }
            return id.Max();
        }

        public int? GetMaxIdDrum()
        {
            int count = Drums.Count;
            int?[] id = new int?[count];
            for (int i = 0; i < count; i++)
            {
                id.Append(Drums[i].GetId());
            }
            return id.Max();
        }

        public int GetMaxIdMaster()
        {
            int count = Masters.Count;
            int[] id = new int[count];
            for (int i = 0; i < count; i++)
            {
                id[i] =Masters[i].GetId();
            }
            return id.Max();
        }

        public int? GetMaxIdFlute()
        {
            int count = Flutes.Count;
            int?[] id = new int?[count];
            for (int i = 0; i < count; i++)
            {
                id[i] = Flutes[i].GetId();
            }
            return id.Max();
        }

        public string[] GetArrayType() 
        {
            return Enum.GetNames(typeof(TypeS));
        }

        public List<Master> GetMasters()
        {
            return Masters;
        }

        public List<Violin> GetViolins() 
        {
            return Violins;
        }

        public List<Drum> GetDrums()
        {
            return Drums;
        }

        public List<Flute> GetFlutes()
        {
            return Flutes;
        }

        public void SetViolin(Violin violin)
        {
            Violins.Add(violin);
        }

        public void SetViolin(List<Violin> violin)
        {
            Violins = violin;
        }

        public void SetDrum(Drum drum)
        {
            Drums.Add(drum);
        }

        public void SetDrum(List<Drum> drum)
        {
            Drums = drum;
        }

        public void SetMaster(Master master)
        {
            Masters.Add(master);
        }

        public void SetMaster(List<Master> master)
        {
            Masters = master;
        }

        public void SetFlute(Flute flute)
        {
            Flutes.Add(flute);
        }

        public void SetFlute(List<Flute> flute)
        {
            Flutes = flute;
        }
    }
}
