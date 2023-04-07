using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XML
{
    internal static class WorkSerisation
    {

        public static void WriterViolinList(List<Violin> violins) 
        {
 
            XmlSerializer formatter = new XmlSerializer(typeof(List<Violin>));
            // сохранение массива в файл
            using (FileStream fs = new FileStream("Violins.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, violins);
            }
        }

        public static void WriterDrumList(List<Drum> drums)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(List<Drum>));
            // сохранение массива в файл
            using (FileStream fs = new FileStream("Drums.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, drums);
            }
        }

        public static void WriterMasterList(List<Master> masters)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(List<Master>));
            // сохранение массива в файл
            using (FileStream fs = new FileStream("Masters.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, masters);
            }
        }

        public static void WriterFluteList(List<Flute> flutes)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(List<Flute>));
            // сохранение массива в файл
            using (FileStream fs = new FileStream("Flutes.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, flutes);
            }
        }

        public static List<Violin> ReaderViolinList()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Violin>));
            using (FileStream fs = new FileStream("Violins.xml", FileMode.OpenOrCreate))
            {
                List<Violin> newViolins = formatter.Deserialize(fs) as List<Violin>;
                return newViolins;
            }
        }

        public static List<Drum> ReaderDrumList()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Drum>));
            using (FileStream fs = new FileStream("Drums.xml", FileMode.OpenOrCreate))
            {
                List<Drum> newDrums = formatter.Deserialize(fs) as List<Drum>;
                return newDrums;
            }
        }

        public static List<Master> ReaderMasterList()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Master>));
            using (FileStream fs = new FileStream("Masters.xml", FileMode.OpenOrCreate))
            {
                List<Master> newMasters = formatter.Deserialize(fs) as List<Master>;
                return newMasters;
            }
        }

        public static List<Flute> ReaderFluteList()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Flute>));
            using (FileStream fs = new FileStream("Flutes.xml", FileMode.OpenOrCreate))
            {
                List<Flute> newFlutes = formatter.Deserialize(fs) as List<Flute>;
                return newFlutes;
            }
        }
    }
}
