using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace XML
{
    public partial class XMLForm : Form
    {
        private static XMLDocument document = new XMLDocument();
        private Dictionary<string, DataTable> dataSourseTabel = new Dictionary<string, DataTable>();
        private static bool flagDownload = false;

        public XMLForm()
        {
            InitializeComponent();
        }

        private void ComplementTree(List<Violin> violins)
        {
            foreach (Violin violin in violins)
            {
                treeView1.Nodes[0].Nodes[0].Nodes.Add(violin.Name);
            }
        }

        private void ComplementTree(List<Drum> drums)
        {
            foreach (Drum drum in drums)
            {
                treeView1.Nodes[0].Nodes[1].Nodes.Add(drum.Name);
            }
        }

        private void ComplementTree(List<Flute> flutes)
        {
            foreach (Flute flute in flutes)
            {
                treeView1.Nodes[0].Nodes[2].Nodes.Add(flute.Name);
            }
        }

        private void ComplementTree(List<Master> masters)
        {
            foreach (Master master in masters)
            {
                treeView1.Nodes[1].Nodes.Add(master.GetFNM());
            }
        }

        private void WorkXml_Load(object sender, EventArgs e)
        {
            string[] arrayVariant = document.GetArrayType();
            foreach (string item in arrayVariant)
            {
                comboBoxTabelVariant.Items.Add(item);
            }
            document.SetViolin(WorkSerisation.ReaderViolinList());
            document.SetDrum(WorkSerisation.ReaderDrumList());
            document.SetMaster(WorkSerisation.ReaderMasterList());
            document.SetFlute(WorkSerisation.ReaderFluteList());
            dataSourseTabel.Add(arrayVariant[0], TranslateToTDataable.GetDataTabel(document.GetViolins()));
            dataSourseTabel.Add(arrayVariant[1], TranslateToTDataable.GetDataTabel(document.GetDrums()));
            dataSourseTabel.Add(arrayVariant[2], TranslateToTDataable.GetDataTabel(document.GetMasters()));
            dataSourseTabel.Add(arrayVariant[3], TranslateToTDataable.GetDataTabel(document.GetFlutes()));
            LoadMasters();
            ComplementTree(document.GetViolins());
            ComplementTree(document.GetDrums());
            ComplementTree(document.GetMasters());
            ComplementTree(document.GetFlutes());
        }

        private void LoadMasters()
        {
            comboBoxMasters.Items.Clear();
            foreach (Master item in document.GetMasters())
            {
                comboBoxMasters.Items.Add($"{item.Id}: {item.Name} {item.Surname} {item.Midlename}");
            }
        }

        private Master GetActiveMasterNewInstrument()
        {
            int id = int.Parse(comboBoxMasters.Text.Split(':')[0]);
            Master master = new Master();
            foreach (Master item in document.GetMasters())
            {
                if (item.Id == id)
                {
                    master = item;
                }
            }
            return master;
        }

        private void Click_radiobuttonInstrument()
        {
            tabControlAddElement.SelectedTab = tabPageAddInstrument;
        }

        private void Click_radiobuttonMaster()
        {
            tabControlAddElement.SelectedTab = tabPageAddMaster;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            WorkSerisation.WriterViolinList(document.GetViolins());
            WorkSerisation.WriterDrumList(document.GetDrums());
            WorkSerisation.WriterMasterList(document.GetMasters());
            this.Close();
        }

        private void radioButtonMasters_CheckedChanged(object sender, EventArgs e)
        {
            Click_radiobuttonMaster();
        }

        private void radioButtonViolins_CheckedChanged(object sender, EventArgs e)
        {
            Click_radiobuttonInstrument();
        }

        private void radioButtonDrums_CheckedChanged(object sender, EventArgs e)
        {
            Click_radiobuttonInstrument();
        }

        private void radioButtonFlutes_CheckedChanged(object sender, EventArgs e)
        {
            Click_radiobuttonInstrument();
        }

        private void comboBoxTabelVariant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string variant = comboBoxTabelVariant.SelectedItem.ToString();
            dataGridView1.DataSource = dataSourseTabel[variant];
        }

        private void buttonToRegistrationInstrument_Click(object sender, EventArgs e)
        {
            string name = textBoxNameInstrument.Text;
            int? id = document.GetMaxIdViolin() + 1;
            decimal price = decimal.Parse(textBoxPriceInstrument.Text);
            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            Master master = GetActiveMasterNewInstrument();
            if (name == null || textBoxPriceInstrument.Text == null || master == null)
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                if (radioButtonViolins.Checked == true)
                {
                    document.SetViolin(new Violin(name, id, price, date, master));
                    dataSourseTabel[document.GetArrayType()[0]] = TranslateToTDataable.GetDataTabel(document.GetViolins());
                }
                else if (radioButtonDrums.Checked == true)
                {
                    document.SetDrum(new Drum(name, id, price, date, master));
                    dataSourseTabel[document.GetArrayType()[1]] = TranslateToTDataable.GetDataTabel(document.GetDrums());
                }
                else if (radioButtonFlutes.Checked == true)
                {
                    document.SetFlute(new Flute(name, id, price, date, master));
                    dataSourseTabel[document.GetArrayType()[3]] = TranslateToTDataable.GetDataTabel(document.GetDrums());
                }
                MessageBox.Show("Данные добавлены");
            }
        }

        private void buttonToRegistrationMaster_Click(object sender, EventArgs e)
        {
            string name = textBoxNameMaster.Text;
            string surname = textBoxSurnameMaster.Text;
            string midlename = textBoxMidlenameMaster.Text;
            int id = document.GetMaxIdMaster() + 1;
            if (name == null || surname == null || midlename == null)
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                document.SetMaster(new Master(id, name, surname, midlename));
                dataSourseTabel[document.GetArrayType()[2]] = TranslateToTDataable.GetDataTabel(document.GetMasters());
                LoadMasters();
                MessageBox.Show("Данные добавлены");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBoxTabelVariant.Text != document.GetArrayType()[2]) 
            {
                int indexLine = e.RowIndex;
                InstrumentForm form = InstrumentForm.GetInstrument();
                string type = dataGridView1.Rows[indexLine].Cells[0].Value.ToString();
                string name = dataGridView1.Rows[indexLine].Cells[1].Value.ToString();
                string price = dataGridView1.Rows[indexLine].Cells[2].Value.ToString();
                string age = dataGridView1.Rows[indexLine].Cells[3].Value.ToString();
                string fnm = dataGridView1.Rows[indexLine].Cells[4].Value.ToString();
                string link = dataGridView1.Rows[indexLine].Cells[5].Value.ToString();
                form.SetInfoForm(type, name, age, price, fnm, link);
                form.Show();
            }
        }
    }
}
