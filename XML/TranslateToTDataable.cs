using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    internal static class TranslateToTDataable
    {
        public static DataTable GetDataTabel(List<Violin> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            foreach (Violin violin in list)
            {
                dt.Rows.Add(violin.Name, violin.Price, violin.Age, violin.Master.GetFNM());
            }
            return dt;
        }

        public static DataTable GetDataTabel(List<Drum> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            foreach (Drum drum in list)
            {
                dt.Rows.Add(drum.Name, drum.Price, drum.Age, drum.Master.GetFNM());
            }
            return dt;
        }

        public static DataTable GetDataTabel(List<Master> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            foreach (Master master in list)
            {
                dt.Rows.Add(master.Id, master.Name, master.Surname, master.Midlename);
            }
            return dt;
        }

        public static DataTable GetDataTabel(List<Flute> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            dt.Columns.Add(new DataColumn());
            foreach (Flute flute in list)
            {
                dt.Rows.Add(flute.Name, flute.Price, flute.Age, flute.Master.GetFNM());
            }
            return dt;
        }
    }
}
