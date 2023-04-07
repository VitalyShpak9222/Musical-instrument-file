using System;
using System.Collections.Generic;
using System.Linq;

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

        public Object[][] GetAll() 
        {
            List<Object[]> list = new List<Object[]>();
            int countViolin = Violins.Count();
            int countDrum = Drums.Count();
            int countMaster = Masters.Count();
            int countFlute = Flutes.Count();
            List<Object> timeListClass = new List<Object>();
            for (int i = 0; i < countViolin; i++)
            {
                timeListClass.Add((Object)Violins[i]);
            }
            list.Add(timeListClass.ToArray());
            timeListClass.Clear();
            for (int i = 0; i < countDrum; i++)
            {
                timeListClass.Add((Object)Drums[i]);
            }
            list.Add(timeListClass.ToArray());
            timeListClass.Clear();
            for (int i = 0; i < countMaster; i++)
            {
                timeListClass.Add((Object)Masters[i]);
            }
            list.Add(timeListClass.ToArray());
            timeListClass.Clear();
            for (int i = 0; i < countFlute; i++)
            {
                timeListClass.Add((Object)Flutes[i]);
            }
            list.Add(timeListClass.ToArray());
            return list.ToArray();
        }

        public void AddElenet(Violin violin)
        {
            Violins.Add(violin);
        }

        public void AddElenet(List<Violin> violin)
        {
            Violins = violin;
        }

        public void AddElenet(Drum drum)
        {
            Drums.Add(drum);
        }

        public void AddElenet(List<Drum> drum)
        {
            Drums = drum;
        }

        public void AddElenet(Master master)
        {
            Masters.Add(master);
        }

        public void AddElenet(List<Master> master)
        {
            Masters = master;
        }

        public void AddElenet(Flute flute)
        {
            Flutes.Add(flute);
        }

        public void AddElenet(List<Flute> flute)
        {
            Flutes = flute;
        }
    }
}
