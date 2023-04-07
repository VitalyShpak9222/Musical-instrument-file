
namespace XML
{
    partial class XMLForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Скрипки");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Барабаны");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Флейты");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Музыкальные инструменты", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Мастера");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControlCenter = new System.Windows.Forms.TabControl();
            this.tabPageTabel = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxTabelVariant = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageAddInfo = new System.Windows.Forms.TabPage();
            this.tabControlAddElement = new System.Windows.Forms.TabControl();
            this.tabPageAddInstrument = new System.Windows.Forms.TabPage();
            this.buttonToRegistrationInstrument = new System.Windows.Forms.Button();
            this.comboBoxMasters = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelMaster = new System.Windows.Forms.Label();
            this.labelDataCreate = new System.Windows.Forms.Label();
            this.textBoxPriceInstrument = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxNameInstrument = new System.Windows.Forms.TextBox();
            this.labelNamement = new System.Windows.Forms.Label();
            this.tabPageAddMaster = new System.Windows.Forms.TabPage();
            this.buttonToRegistrationMaster = new System.Windows.Forms.Button();
            this.labelMidlenameMaster = new System.Windows.Forms.Label();
            this.textBoxMidlenameMaster = new System.Windows.Forms.TextBox();
            this.labelSurnameMaster = new System.Windows.Forms.Label();
            this.textBoxSurnameMaster = new System.Windows.Forms.TextBox();
            this.labelNamementMaster = new System.Windows.Forms.Label();
            this.textBoxNameMaster = new System.Windows.Forms.TextBox();
            this.radioButtonMasters = new System.Windows.Forms.RadioButton();
            this.radioButtonDrums = new System.Windows.Forms.RadioButton();
            this.radioButtonFlutes = new System.Windows.Forms.RadioButton();
            this.radioButtonViolins = new System.Windows.Forms.RadioButton();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlCenter.SuspendLayout();
            this.tabPageTabel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageAddInfo.SuspendLayout();
            this.tabControlAddElement.SuspendLayout();
            this.tabPageAddInstrument.SuspendLayout();
            this.tabPageAddMaster.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlCenter);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 720);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(203, 720);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Location = new System.Drawing.Point(4, 681);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(195, 36);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(5, 175);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "Violins";
            treeNode11.Text = "Скрипки";
            treeNode12.Name = "Drums";
            treeNode12.Text = "Барабаны";
            treeNode13.Name = "Flutes";
            treeNode13.Text = "Флейты";
            treeNode14.Name = "MusicInstrument";
            treeNode14.Text = "Музыкальные инструменты";
            treeNode15.Name = "Maters";
            treeNode15.Text = "Мастера";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(193, 499);
            this.treeView1.TabIndex = 1;
            // 
            // tabControlCenter
            // 
            this.tabControlCenter.Controls.Add(this.tabPageTabel);
            this.tabControlCenter.Controls.Add(this.tabPageAddInfo);
            this.tabControlCenter.Controls.Add(this.tabPageSettings);
            this.tabControlCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCenter.ItemSize = new System.Drawing.Size(180, 50);
            this.tabControlCenter.Location = new System.Drawing.Point(0, 0);
            this.tabControlCenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlCenter.Name = "tabControlCenter";
            this.tabControlCenter.SelectedIndex = 0;
            this.tabControlCenter.Size = new System.Drawing.Size(1073, 720);
            this.tabControlCenter.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlCenter.TabIndex = 0;
            // 
            // tabPageTabel
            // 
            this.tabPageTabel.Controls.Add(this.tableLayoutPanel2);
            this.tabPageTabel.Location = new System.Drawing.Point(4, 54);
            this.tabPageTabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTabel.Name = "tabPageTabel";
            this.tabPageTabel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTabel.Size = new System.Drawing.Size(1065, 662);
            this.tabPageTabel.TabIndex = 1;
            this.tabPageTabel.Text = "Таблица";
            this.tabPageTabel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxTabelVariant, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.61702F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1059, 658);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBoxTabelVariant
            // 
            this.comboBoxTabelVariant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTabelVariant.FormattingEnabled = true;
            this.comboBoxTabelVariant.Location = new System.Drawing.Point(3, 2);
            this.comboBoxTabelVariant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTabelVariant.Name = "comboBoxTabelVariant";
            this.comboBoxTabelVariant.Size = new System.Drawing.Size(1053, 24);
            this.comboBoxTabelVariant.TabIndex = 0;
            this.comboBoxTabelVariant.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTabelVariant_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 612);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabPageAddInfo
            // 
            this.tabPageAddInfo.Controls.Add(this.tabControlAddElement);
            this.tabPageAddInfo.Controls.Add(this.radioButtonMasters);
            this.tabPageAddInfo.Controls.Add(this.radioButtonDrums);
            this.tabPageAddInfo.Controls.Add(this.radioButtonFlutes);
            this.tabPageAddInfo.Controls.Add(this.radioButtonViolins);
            this.tabPageAddInfo.Location = new System.Drawing.Point(4, 54);
            this.tabPageAddInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddInfo.Name = "tabPageAddInfo";
            this.tabPageAddInfo.Size = new System.Drawing.Size(956, 662);
            this.tabPageAddInfo.TabIndex = 3;
            this.tabPageAddInfo.Text = "Добавлеие элементов";
            this.tabPageAddInfo.UseVisualStyleBackColor = true;
            // 
            // tabControlAddElement
            // 
            this.tabControlAddElement.Controls.Add(this.tabPageAddInstrument);
            this.tabControlAddElement.Controls.Add(this.tabPageAddMaster);
            this.tabControlAddElement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlAddElement.ItemSize = new System.Drawing.Size(1, 1);
            this.tabControlAddElement.Location = new System.Drawing.Point(157, 15);
            this.tabControlAddElement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlAddElement.Name = "tabControlAddElement";
            this.tabControlAddElement.SelectedIndex = 0;
            this.tabControlAddElement.Size = new System.Drawing.Size(787, 639);
            this.tabControlAddElement.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlAddElement.TabIndex = 6;
            // 
            // tabPageAddInstrument
            // 
            this.tabPageAddInstrument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAddInstrument.Controls.Add(this.buttonToRegistrationInstrument);
            this.tabPageAddInstrument.Controls.Add(this.comboBoxMasters);
            this.tabPageAddInstrument.Controls.Add(this.dateTimePicker1);
            this.tabPageAddInstrument.Controls.Add(this.labelMaster);
            this.tabPageAddInstrument.Controls.Add(this.labelDataCreate);
            this.tabPageAddInstrument.Controls.Add(this.textBoxPriceInstrument);
            this.tabPageAddInstrument.Controls.Add(this.labelPrice);
            this.tabPageAddInstrument.Controls.Add(this.textBoxNameInstrument);
            this.tabPageAddInstrument.Controls.Add(this.labelNamement);
            this.tabPageAddInstrument.Location = new System.Drawing.Point(4, 5);
            this.tabPageAddInstrument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddInstrument.Name = "tabPageAddInstrument";
            this.tabPageAddInstrument.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddInstrument.Size = new System.Drawing.Size(779, 630);
            this.tabPageAddInstrument.TabIndex = 0;
            this.tabPageAddInstrument.UseVisualStyleBackColor = true;
            // 
            // buttonToRegistrationInstrument
            // 
            this.buttonToRegistrationInstrument.Location = new System.Drawing.Point(259, 544);
            this.buttonToRegistrationInstrument.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToRegistrationInstrument.Name = "buttonToRegistrationInstrument";
            this.buttonToRegistrationInstrument.Size = new System.Drawing.Size(291, 49);
            this.buttonToRegistrationInstrument.TabIndex = 10;
            this.buttonToRegistrationInstrument.Text = "Добавить";
            this.buttonToRegistrationInstrument.UseVisualStyleBackColor = true;
            this.buttonToRegistrationInstrument.Click += new System.EventHandler(this.buttonToRegistrationInstrument_Click);
            // 
            // comboBoxMasters
            // 
            this.comboBoxMasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMasters.FormattingEnabled = true;
            this.comboBoxMasters.Location = new System.Drawing.Point(64, 245);
            this.comboBoxMasters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMasters.Name = "comboBoxMasters";
            this.comboBoxMasters.Size = new System.Drawing.Size(655, 28);
            this.comboBoxMasters.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 190);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(655, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaster.Location = new System.Drawing.Point(60, 222);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(72, 20);
            this.labelMaster.TabIndex = 6;
            this.labelMaster.Text = "Мастер";
            // 
            // labelDataCreate
            // 
            this.labelDataCreate.AutoSize = true;
            this.labelDataCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataCreate.Location = new System.Drawing.Point(60, 167);
            this.labelDataCreate.Name = "labelDataCreate";
            this.labelDataCreate.Size = new System.Drawing.Size(174, 20);
            this.labelDataCreate.TabIndex = 4;
            this.labelDataCreate.Text = "Дата изготовления";
            // 
            // textBoxPriceInstrument
            // 
            this.textBoxPriceInstrument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceInstrument.Location = new System.Drawing.Point(64, 137);
            this.textBoxPriceInstrument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPriceInstrument.Name = "textBoxPriceInstrument";
            this.textBoxPriceInstrument.Size = new System.Drawing.Size(655, 27);
            this.textBoxPriceInstrument.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(60, 114);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 20);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxNameInstrument
            // 
            this.textBoxNameInstrument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameInstrument.Location = new System.Drawing.Point(64, 82);
            this.textBoxNameInstrument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameInstrument.Name = "textBoxNameInstrument";
            this.textBoxNameInstrument.Size = new System.Drawing.Size(655, 27);
            this.textBoxNameInstrument.TabIndex = 1;
            // 
            // labelNamement
            // 
            this.labelNamement.AutoSize = true;
            this.labelNamement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNamement.Location = new System.Drawing.Point(60, 60);
            this.labelNamement.Name = "labelNamement";
            this.labelNamement.Size = new System.Drawing.Size(91, 20);
            this.labelNamement.TabIndex = 0;
            this.labelNamement.Text = "Название";
            // 
            // tabPageAddMaster
            // 
            this.tabPageAddMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAddMaster.Controls.Add(this.buttonToRegistrationMaster);
            this.tabPageAddMaster.Controls.Add(this.labelMidlenameMaster);
            this.tabPageAddMaster.Controls.Add(this.textBoxMidlenameMaster);
            this.tabPageAddMaster.Controls.Add(this.labelSurnameMaster);
            this.tabPageAddMaster.Controls.Add(this.textBoxSurnameMaster);
            this.tabPageAddMaster.Controls.Add(this.labelNamementMaster);
            this.tabPageAddMaster.Controls.Add(this.textBoxNameMaster);
            this.tabPageAddMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageAddMaster.Location = new System.Drawing.Point(4, 5);
            this.tabPageAddMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddMaster.Name = "tabPageAddMaster";
            this.tabPageAddMaster.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddMaster.Size = new System.Drawing.Size(779, 630);
            this.tabPageAddMaster.TabIndex = 1;
            this.tabPageAddMaster.UseVisualStyleBackColor = true;
            // 
            // buttonToRegistrationMaster
            // 
            this.buttonToRegistrationMaster.Location = new System.Drawing.Point(261, 552);
            this.buttonToRegistrationMaster.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToRegistrationMaster.Name = "buttonToRegistrationMaster";
            this.buttonToRegistrationMaster.Size = new System.Drawing.Size(291, 49);
            this.buttonToRegistrationMaster.TabIndex = 11;
            this.buttonToRegistrationMaster.Text = "Добавить";
            this.buttonToRegistrationMaster.UseVisualStyleBackColor = true;
            this.buttonToRegistrationMaster.Click += new System.EventHandler(this.buttonToRegistrationMaster_Click);
            // 
            // labelMidlenameMaster
            // 
            this.labelMidlenameMaster.AutoSize = true;
            this.labelMidlenameMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMidlenameMaster.Location = new System.Drawing.Point(52, 144);
            this.labelMidlenameMaster.Name = "labelMidlenameMaster";
            this.labelMidlenameMaster.Size = new System.Drawing.Size(91, 20);
            this.labelMidlenameMaster.TabIndex = 5;
            this.labelMidlenameMaster.Text = "Отчество";
            // 
            // textBoxMidlenameMaster
            // 
            this.textBoxMidlenameMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMidlenameMaster.Location = new System.Drawing.Point(56, 167);
            this.textBoxMidlenameMaster.Name = "textBoxMidlenameMaster";
            this.textBoxMidlenameMaster.Size = new System.Drawing.Size(670, 27);
            this.textBoxMidlenameMaster.TabIndex = 4;
            // 
            // labelSurnameMaster
            // 
            this.labelSurnameMaster.AutoSize = true;
            this.labelSurnameMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurnameMaster.Location = new System.Drawing.Point(52, 91);
            this.labelSurnameMaster.Name = "labelSurnameMaster";
            this.labelSurnameMaster.Size = new System.Drawing.Size(87, 20);
            this.labelSurnameMaster.TabIndex = 3;
            this.labelSurnameMaster.Text = "Фамилия";
            // 
            // textBoxSurnameMaster
            // 
            this.textBoxSurnameMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurnameMaster.Location = new System.Drawing.Point(56, 114);
            this.textBoxSurnameMaster.Name = "textBoxSurnameMaster";
            this.textBoxSurnameMaster.Size = new System.Drawing.Size(670, 27);
            this.textBoxSurnameMaster.TabIndex = 2;
            // 
            // labelNamementMaster
            // 
            this.labelNamementMaster.AutoSize = true;
            this.labelNamementMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNamementMaster.Location = new System.Drawing.Point(52, 40);
            this.labelNamementMaster.Name = "labelNamementMaster";
            this.labelNamementMaster.Size = new System.Drawing.Size(42, 20);
            this.labelNamementMaster.TabIndex = 1;
            this.labelNamementMaster.Text = "Имя";
            // 
            // textBoxNameMaster
            // 
            this.textBoxNameMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameMaster.Location = new System.Drawing.Point(56, 63);
            this.textBoxNameMaster.Name = "textBoxNameMaster";
            this.textBoxNameMaster.Size = new System.Drawing.Size(670, 27);
            this.textBoxNameMaster.TabIndex = 0;
            // 
            // radioButtonMasters
            // 
            this.radioButtonMasters.AutoSize = true;
            this.radioButtonMasters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMasters.Location = new System.Drawing.Point(28, 106);
            this.radioButtonMasters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMasters.Name = "radioButtonMasters";
            this.radioButtonMasters.Size = new System.Drawing.Size(103, 24);
            this.radioButtonMasters.TabIndex = 5;
            this.radioButtonMasters.Text = "Мастера";
            this.radioButtonMasters.UseVisualStyleBackColor = true;
            this.radioButtonMasters.CheckedChanged += new System.EventHandler(this.radioButtonMasters_CheckedChanged);
            // 
            // radioButtonDrums
            // 
            this.radioButtonDrums.AutoSize = true;
            this.radioButtonDrums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonDrums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDrums.Location = new System.Drawing.Point(28, 49);
            this.radioButtonDrums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDrums.Name = "radioButtonDrums";
            this.radioButtonDrums.Size = new System.Drawing.Size(114, 24);
            this.radioButtonDrums.TabIndex = 3;
            this.radioButtonDrums.Text = "Барабаны";
            this.radioButtonDrums.UseVisualStyleBackColor = true;
            this.radioButtonDrums.CheckedChanged += new System.EventHandler(this.radioButtonDrums_CheckedChanged);
            // 
            // radioButtonFlutes
            // 
            this.radioButtonFlutes.AutoSize = true;
            this.radioButtonFlutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFlutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFlutes.Location = new System.Drawing.Point(28, 79);
            this.radioButtonFlutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFlutes.Name = "radioButtonFlutes";
            this.radioButtonFlutes.Size = new System.Drawing.Size(98, 24);
            this.radioButtonFlutes.TabIndex = 2;
            this.radioButtonFlutes.Text = "Флейты";
            this.radioButtonFlutes.UseVisualStyleBackColor = true;
            this.radioButtonFlutes.CheckedChanged += new System.EventHandler(this.radioButtonFlutes_CheckedChanged);
            // 
            // radioButtonViolins
            // 
            this.radioButtonViolins.AutoSize = true;
            this.radioButtonViolins.Checked = true;
            this.radioButtonViolins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonViolins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonViolins.Location = new System.Drawing.Point(28, 18);
            this.radioButtonViolins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonViolins.Name = "radioButtonViolins";
            this.radioButtonViolins.Size = new System.Drawing.Size(100, 24);
            this.radioButtonViolins.TabIndex = 1;
            this.radioButtonViolins.TabStop = true;
            this.radioButtonViolins.Text = "Скрипки";
            this.radioButtonViolins.UseVisualStyleBackColor = true;
            this.radioButtonViolins.CheckedChanged += new System.EventHandler(this.radioButtonViolins_CheckedChanged);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.tableLayoutPanel3);
            this.tabPageSettings.Controls.Add(this.labelSettings);
            this.tabPageSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageSettings.Location = new System.Drawing.Point(4, 54);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(956, 662);
            this.tabPageSettings.TabIndex = 4;
            this.tabPageSettings.Text = "Настройки";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(950, 557);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSettings
            // 
            this.labelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettings.Location = new System.Drawing.Point(3, 3);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(950, 99);
            this.labelSettings.TabIndex = 1;
            this.labelSettings.Text = "Настройки";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(195, 163);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // XMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XMLForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WorkXml_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlCenter.ResumeLayout(false);
            this.tabPageTabel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageAddInfo.ResumeLayout(false);
            this.tabPageAddInfo.PerformLayout();
            this.tabControlAddElement.ResumeLayout(false);
            this.tabPageAddInstrument.ResumeLayout(false);
            this.tabPageAddInstrument.PerformLayout();
            this.tabPageAddMaster.ResumeLayout(false);
            this.tabPageAddMaster.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlCenter;
        private System.Windows.Forms.TabPage tabPageTabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TabPage tabPageAddInfo;
        private System.Windows.Forms.RadioButton radioButtonDrums;
        private System.Windows.Forms.RadioButton radioButtonFlutes;
        private System.Windows.Forms.RadioButton radioButtonViolins;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxTabelVariant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonMasters;
        private System.Windows.Forms.TabControl tabControlAddElement;
        private System.Windows.Forms.TabPage tabPageAddInstrument;
        private System.Windows.Forms.TabPage tabPageAddMaster;
        private System.Windows.Forms.TextBox textBoxNameInstrument;
        private System.Windows.Forms.Label labelNamement;
        private System.Windows.Forms.Label labelMaster;
        private System.Windows.Forms.Label labelDataCreate;
        private System.Windows.Forms.TextBox textBoxPriceInstrument;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMasters;
        private System.Windows.Forms.Button buttonToRegistrationInstrument;
        private System.Windows.Forms.Button buttonToRegistrationMaster;
        private System.Windows.Forms.Label labelMidlenameMaster;
        private System.Windows.Forms.TextBox textBoxMidlenameMaster;
        private System.Windows.Forms.Label labelSurnameMaster;
        private System.Windows.Forms.TextBox textBoxSurnameMaster;
        private System.Windows.Forms.Label labelNamementMaster;
        private System.Windows.Forms.TextBox textBoxNameMaster;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
