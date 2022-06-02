namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BirthdateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BuildingtextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StreettextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AppartmenttextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchtextBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NamecheckBox1 = new System.Windows.Forms.CheckBox();
            this.SurnamecheckBox2 = new System.Windows.Forms.CheckBox();
            this.BirthDatecheckBox1 = new System.Windows.Forms.CheckBox();
            this.PhoneNumbercheckBox2 = new System.Windows.Forms.CheckBox();
            this.BuildingcheckBox1 = new System.Windows.Forms.CheckBox();
            this.StreetcheckBox2 = new System.Windows.Forms.CheckBox();
            this.CitycheckBox3 = new System.Windows.Forms.CheckBox();
            this.AddresscheckBox4 = new System.Windows.Forms.CheckBox();
            this.AppartmentcheckBox5 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FromFileButton = new System.Windows.Forms.Button();
            this.ToFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.buildingDataGridViewTextBoxColumn,
            this.appartmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(504, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.AccessibleDescription = "";
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(524, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.AccessibleDescription = "";
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(646, 27);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "PhoneNumber";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.AccessibleDescription = "";
            this.PhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(646, 87);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.PhoneNumberTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthdate";
            // 
            // BirthdateTextBox
            // 
            this.BirthdateTextBox.AccessibleDescription = "";
            this.BirthdateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdateTextBox.Location = new System.Drawing.Point(524, 87);
            this.BirthdateTextBox.Name = "BirthdateTextBox";
            this.BirthdateTextBox.Size = new System.Drawing.Size(100, 22);
            this.BirthdateTextBox.TabIndex = 5;
            this.BirthdateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NOPTextBox_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Building";
            // 
            // BuildingtextBox1
            // 
            this.BuildingtextBox1.AccessibleDescription = "";
            this.BuildingtextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingtextBox1.Location = new System.Drawing.Point(646, 207);
            this.BuildingtextBox1.Name = "BuildingtextBox1";
            this.BuildingtextBox1.Size = new System.Drawing.Size(100, 22);
            this.BuildingtextBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Street";
            // 
            // StreettextBox
            // 
            this.StreettextBox.AccessibleDescription = "";
            this.StreettextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StreettextBox.Location = new System.Drawing.Point(524, 207);
            this.StreettextBox.Name = "StreettextBox";
            this.StreettextBox.Size = new System.Drawing.Size(100, 22);
            this.StreettextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "City";
            // 
            // CitytextBox
            // 
            this.CitytextBox.AccessibleDescription = "";
            this.CitytextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CitytextBox.Location = new System.Drawing.Point(646, 147);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.Size = new System.Drawing.Size(100, 22);
            this.CitytextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.AccessibleDescription = "";
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Location = new System.Drawing.Point(524, 147);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddressTextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Appartment";
            // 
            // AppartmenttextBox
            // 
            this.AppartmenttextBox.AccessibleDescription = "";
            this.AppartmenttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AppartmenttextBox.Location = new System.Drawing.Point(524, 270);
            this.AppartmenttextBox.Name = "AppartmenttextBox";
            this.AppartmenttextBox.Size = new System.Drawing.Size(100, 22);
            this.AppartmenttextBox.TabIndex = 17;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(646, 258);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 34);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(524, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Surname",
            "BirthDate",
            "PhoneNumber",
            "Address",
            "City",
            "Street",
            "Building",
            "Appartment"});
            this.comboBox1.Location = new System.Drawing.Point(254, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // SearchtextBox1
            // 
            this.SearchtextBox1.AccessibleDescription = "";
            this.SearchtextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchtextBox1.Location = new System.Drawing.Point(12, 27);
            this.SearchtextBox1.Name = "SearchtextBox1";
            this.SearchtextBox1.Size = new System.Drawing.Size(236, 22);
            this.SearchtextBox1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Include:";
            // 
            // NamecheckBox1
            // 
            this.NamecheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NamecheckBox1.AutoSize = true;
            this.NamecheckBox1.Checked = true;
            this.NamecheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NamecheckBox1.Location = new System.Drawing.Point(68, 65);
            this.NamecheckBox1.Name = "NamecheckBox1";
            this.NamecheckBox1.Size = new System.Drawing.Size(66, 20);
            this.NamecheckBox1.TabIndex = 24;
            this.NamecheckBox1.Text = "Name";
            this.NamecheckBox1.UseVisualStyleBackColor = true;
            // 
            // SurnamecheckBox2
            // 
            this.SurnamecheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnamecheckBox2.AutoSize = true;
            this.SurnamecheckBox2.Checked = true;
            this.SurnamecheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SurnamecheckBox2.Location = new System.Drawing.Point(140, 65);
            this.SurnamecheckBox2.Name = "SurnamecheckBox2";
            this.SurnamecheckBox2.Size = new System.Drawing.Size(83, 20);
            this.SurnamecheckBox2.TabIndex = 25;
            this.SurnamecheckBox2.Text = "Surname";
            this.SurnamecheckBox2.UseVisualStyleBackColor = true;
            // 
            // BirthDatecheckBox1
            // 
            this.BirthDatecheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BirthDatecheckBox1.AutoSize = true;
            this.BirthDatecheckBox1.Checked = true;
            this.BirthDatecheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BirthDatecheckBox1.Location = new System.Drawing.Point(229, 64);
            this.BirthDatecheckBox1.Name = "BirthDatecheckBox1";
            this.BirthDatecheckBox1.Size = new System.Drawing.Size(84, 20);
            this.BirthDatecheckBox1.TabIndex = 26;
            this.BirthDatecheckBox1.Text = "BirthDate";
            this.BirthDatecheckBox1.UseVisualStyleBackColor = true;
            // 
            // PhoneNumbercheckBox2
            // 
            this.PhoneNumbercheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhoneNumbercheckBox2.AutoSize = true;
            this.PhoneNumbercheckBox2.Checked = true;
            this.PhoneNumbercheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PhoneNumbercheckBox2.Location = new System.Drawing.Point(318, 65);
            this.PhoneNumbercheckBox2.Name = "PhoneNumbercheckBox2";
            this.PhoneNumbercheckBox2.Size = new System.Drawing.Size(116, 20);
            this.PhoneNumbercheckBox2.TabIndex = 27;
            this.PhoneNumbercheckBox2.Text = "PhoneNumber";
            this.PhoneNumbercheckBox2.UseVisualStyleBackColor = true;
            // 
            // BuildingcheckBox1
            // 
            this.BuildingcheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BuildingcheckBox1.AutoSize = true;
            this.BuildingcheckBox1.Checked = true;
            this.BuildingcheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BuildingcheckBox1.Location = new System.Drawing.Point(318, 100);
            this.BuildingcheckBox1.Name = "BuildingcheckBox1";
            this.BuildingcheckBox1.Size = new System.Drawing.Size(77, 20);
            this.BuildingcheckBox1.TabIndex = 31;
            this.BuildingcheckBox1.Text = "Building";
            this.BuildingcheckBox1.UseVisualStyleBackColor = true;
            // 
            // StreetcheckBox2
            // 
            this.StreetcheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StreetcheckBox2.AutoSize = true;
            this.StreetcheckBox2.Checked = true;
            this.StreetcheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StreetcheckBox2.Location = new System.Drawing.Point(229, 100);
            this.StreetcheckBox2.Name = "StreetcheckBox2";
            this.StreetcheckBox2.Size = new System.Drawing.Size(64, 20);
            this.StreetcheckBox2.TabIndex = 30;
            this.StreetcheckBox2.Text = "Street";
            this.StreetcheckBox2.UseVisualStyleBackColor = true;
            // 
            // CitycheckBox3
            // 
            this.CitycheckBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CitycheckBox3.AutoSize = true;
            this.CitycheckBox3.Checked = true;
            this.CitycheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CitycheckBox3.Location = new System.Drawing.Point(140, 100);
            this.CitycheckBox3.Name = "CitycheckBox3";
            this.CitycheckBox3.Size = new System.Drawing.Size(51, 20);
            this.CitycheckBox3.TabIndex = 29;
            this.CitycheckBox3.Text = "City";
            this.CitycheckBox3.UseVisualStyleBackColor = true;
            // 
            // AddresscheckBox4
            // 
            this.AddresscheckBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddresscheckBox4.AutoSize = true;
            this.AddresscheckBox4.Checked = true;
            this.AddresscheckBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddresscheckBox4.Location = new System.Drawing.Point(54, 100);
            this.AddresscheckBox4.Name = "AddresscheckBox4";
            this.AddresscheckBox4.Size = new System.Drawing.Size(80, 20);
            this.AddresscheckBox4.TabIndex = 28;
            this.AddresscheckBox4.Text = "Address";
            this.AddresscheckBox4.UseVisualStyleBackColor = true;
            // 
            // AppartmentcheckBox5
            // 
            this.AppartmentcheckBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppartmentcheckBox5.AutoSize = true;
            this.AppartmentcheckBox5.Checked = true;
            this.AppartmentcheckBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppartmentcheckBox5.Location = new System.Drawing.Point(406, 100);
            this.AppartmentcheckBox5.Name = "AppartmentcheckBox5";
            this.AppartmentcheckBox5.Size = new System.Drawing.Size(98, 20);
            this.AppartmentcheckBox5.TabIndex = 32;
            this.AppartmentcheckBox5.Text = "Appartment";
            this.AppartmentcheckBox5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(381, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SearchClick);
            // 
            // FromFileButton
            // 
            this.FromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromFileButton.Location = new System.Drawing.Point(524, 379);
            this.FromFileButton.Name = "FromFileButton";
            this.FromFileButton.Size = new System.Drawing.Size(222, 34);
            this.FromFileButton.TabIndex = 34;
            this.FromFileButton.Text = "Load from file";
            this.FromFileButton.UseVisualStyleBackColor = true;
            this.FromFileButton.Click += new System.EventHandler(this.LoadFileClick);
            // 
            // ToFileButton
            // 
            this.ToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToFileButton.Location = new System.Drawing.Point(524, 433);
            this.ToFileButton.Name = "ToFileButton";
            this.ToFileButton.Size = new System.Drawing.Size(222, 34);
            this.ToFileButton.TabIndex = 35;
            this.ToFileButton.Text = "Save to file";
            this.ToFileButton.UseVisualStyleBackColor = true;
            this.ToFileButton.Click += new System.EventHandler(this.SaveFileClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // buildingDataGridViewTextBoxColumn
            // 
            this.buildingDataGridViewTextBoxColumn.DataPropertyName = "Building";
            this.buildingDataGridViewTextBoxColumn.HeaderText = "Building";
            this.buildingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingDataGridViewTextBoxColumn.Name = "buildingDataGridViewTextBoxColumn";
            // 
            // appartmentDataGridViewTextBoxColumn
            // 
            this.appartmentDataGridViewTextBoxColumn.DataPropertyName = "Appartment";
            this.appartmentDataGridViewTextBoxColumn.HeaderText = "Appartment";
            this.appartmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appartmentDataGridViewTextBoxColumn.Name = "appartmentDataGridViewTextBoxColumn";
            // 
            // employeeDTOBindingSource
            // 
            this.employeeDTOBindingSource.DataSource = typeof(Lab3.EmployeeDTO);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.ToFileButton);
            this.Controls.Add(this.FromFileButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AppartmentcheckBox5);
            this.Controls.Add(this.BuildingcheckBox1);
            this.Controls.Add(this.StreetcheckBox2);
            this.Controls.Add(this.CitycheckBox3);
            this.Controls.Add(this.AddresscheckBox4);
            this.Controls.Add(this.PhoneNumbercheckBox2);
            this.Controls.Add(this.BirthDatecheckBox1);
            this.Controls.Add(this.SurnamecheckBox2);
            this.Controls.Add(this.NamecheckBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SearchtextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AppartmenttextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BuildingtextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StreettextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CitytextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthdateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeDTOBindingSource;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BirthdateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BuildingtextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StreettextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CitytextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AppartmenttextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SearchtextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox NamecheckBox1;
        private System.Windows.Forms.CheckBox SurnamecheckBox2;
        private System.Windows.Forms.CheckBox BirthDatecheckBox1;
        private System.Windows.Forms.CheckBox PhoneNumbercheckBox2;
        private System.Windows.Forms.CheckBox BuildingcheckBox1;
        private System.Windows.Forms.CheckBox StreetcheckBox2;
        private System.Windows.Forms.CheckBox CitycheckBox3;
        private System.Windows.Forms.CheckBox AddresscheckBox4;
        private System.Windows.Forms.CheckBox AppartmentcheckBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FromFileButton;
        private System.Windows.Forms.Button ToFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

