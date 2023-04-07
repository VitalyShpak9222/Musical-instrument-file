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
        private static Random random = new Random();

        public static DataTable GetDataTabel(List<Violin> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn().ColumnName = "Тип");
            dt.Columns.Add(new DataColumn().ColumnName = "Название");
            dt.Columns.Add(new DataColumn().ColumnName = "Цена");
            dt.Columns.Add(new DataColumn().ColumnName = "Дата изготовления");
            dt.Columns.Add(new DataColumn().ColumnName = "ФИО");
            dt.Columns.Add(new DataColumn().ColumnName = "Путь к аудиофайлу");
            Random random = new Random();
            foreach (Violin violin in list)
            {
                dt.Rows.Add("Скрипка", violin.Name, violin.Price, violin.Age, violin.Master.GetFNM(), $"{Environment.CurrentDirectory}\\ViolinsVolume\\Violin{random.Next(1,4)}.wav");
            }
            return dt;
        }

        public static DataTable GetDataTabel(List<Drum> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn().ColumnName = "Тип");
            dt.Columns.Add(new DataColumn().ColumnName = "Название");
            dt.Columns.Add(new DataColumn().ColumnName = "Цена");
            dt.Columns.Add(new DataColumn().ColumnName = "Дата изготовления");
            dt.Columns.Add(new DataColumn().ColumnName = "ФИО");
            dt.Columns.Add(new DataColumn().ColumnName = "Путь к аудиофайлу");
            foreach (Drum drum in list)
            {
                dt.Rows.Add("Барабаны", drum.Name, drum.Price, drum.Age, drum.Master.GetFNM(), $"{Environment.CurrentDirectory}\\DrumsVolume\\drum{random.Next(1, 6)}.wav");
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
            dt.Columns.Add(new DataColumn().ColumnName = "Тип");
            dt.Columns.Add(new DataColumn().ColumnName = "Название");
            dt.Columns.Add(new DataColumn().ColumnName = "Цена");
            dt.Columns.Add(new DataColumn().ColumnName = "Дата изготовления");
            dt.Columns.Add(new DataColumn().ColumnName = "ФИО");
            dt.Columns.Add(new DataColumn().ColumnName = "Путь к аудиофайлу");
            foreach (Flute flute in list)
            {
                dt.Rows.Add("Флейта", flute.Name, flute.Price, flute.Age, flute.Master.GetFNM(), $"{Environment.CurrentDirectory}\\FlutesVolume\\flute{random.Next(1, 7)}.wav");
            }
            return dt;
        }
    }
}
