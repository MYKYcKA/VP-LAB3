namespace Lab3
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.AppartmentcheckBox5 = new System.Windows.Forms.CheckBox();
            this.BuildingcheckBox1 = new System.Windows.Forms.CheckBox();
            this.StreetcheckBox2 = new System.Windows.Forms.CheckBox();
            this.CitycheckBox3 = new System.Windows.Forms.CheckBox();
            this.AddresscheckBox4 = new System.Windows.Forms.CheckBox();
            this.PhoneNumbercheckBox2 = new System.Windows.Forms.CheckBox();
            this.BirthDatecheckBox1 = new System.Windows.Forms.CheckBox();
            this.SurnamecheckBox2 = new System.Windows.Forms.CheckBox();
            this.NamecheckBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchtextBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(549, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SearchClick);
            // 
            // AppartmentcheckBox5
            // 
            this.AppartmentcheckBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppartmentcheckBox5.AutoSize = true;
            this.AppartmentcheckBox5.Checked = true;
            this.AppartmentcheckBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppartmentcheckBox5.Location = new System.Drawing.Point(574, 94);
            this.AppartmentcheckBox5.Name = "AppartmentcheckBox5";
            this.AppartmentcheckBox5.Size = new System.Drawing.Size(98, 20);
            this.AppartmentcheckBox5.TabIndex = 46;
            this.AppartmentcheckBox5.Text = "Appartment";
            this.AppartmentcheckBox5.UseVisualStyleBackColor = true;
            // 
            // BuildingcheckBox1
            // 
            this.BuildingcheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BuildingcheckBox1.AutoSize = true;
            this.BuildingcheckBox1.Checked = true;
            this.BuildingcheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BuildingcheckBox1.Location = new System.Drawing.Point(486, 94);
            this.BuildingcheckBox1.Name = "BuildingcheckBox1";
            this.BuildingcheckBox1.Size = new System.Drawing.Size(77, 20);
            this.BuildingcheckBox1.TabIndex = 45;
            this.BuildingcheckBox1.Text = "Building";
            this.BuildingcheckBox1.UseVisualStyleBackColor = true;
            // 
            // StreetcheckBox2
            // 
            this.StreetcheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StreetcheckBox2.AutoSize = true;
            this.StreetcheckBox2.Checked = true;
            this.StreetcheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StreetcheckBox2.Location = new System.Drawing.Point(397, 94);
            this.StreetcheckBox2.Name = "StreetcheckBox2";
            this.StreetcheckBox2.Size = new System.Drawing.Size(64, 20);
            this.StreetcheckBox2.TabIndex = 44;
            this.StreetcheckBox2.Text = "Street";
            this.StreetcheckBox2.UseVisualStyleBackColor = true;
            // 
            // CitycheckBox3
            // 
            this.CitycheckBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CitycheckBox3.AutoSize = true;
            this.CitycheckBox3.Checked = true;
            this.CitycheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CitycheckBox3.Location = new System.Drawing.Point(308, 94);
            this.CitycheckBox3.Name = "CitycheckBox3";
            this.CitycheckBox3.Size = new System.Drawing.Size(51, 20);
            this.CitycheckBox3.TabIndex = 43;
            this.CitycheckBox3.Text = "City";
            this.CitycheckBox3.UseVisualStyleBackColor = true;
            // 
            // AddresscheckBox4
            // 
            this.AddresscheckBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddresscheckBox4.AutoSize = true;
            this.AddresscheckBox4.Checked = true;
            this.AddresscheckBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddresscheckBox4.Location = new System.Drawing.Point(222, 94);
            this.AddresscheckBox4.Name = "AddresscheckBox4";
            this.AddresscheckBox4.Size = new System.Drawing.Size(80, 20);
            this.AddresscheckBox4.TabIndex = 42;
            this.AddresscheckBox4.Text = "Address";
            this.AddresscheckBox4.UseVisualStyleBackColor = true;
            // 
            // PhoneNumbercheckBox2
            // 
            this.PhoneNumbercheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhoneNumbercheckBox2.AutoSize = true;
            this.PhoneNumbercheckBox2.Checked = true;
            this.PhoneNumbercheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PhoneNumbercheckBox2.Location = new System.Drawing.Point(486, 59);
            this.PhoneNumbercheckBox2.Name = "PhoneNumbercheckBox2";
            this.PhoneNumbercheckBox2.Size = new System.Drawing.Size(116, 20);
            this.PhoneNumbercheckBox2.TabIndex = 41;
            this.PhoneNumbercheckBox2.Text = "PhoneNumber";
            this.PhoneNumbercheckBox2.UseVisualStyleBackColor = true;
            // 
            // BirthDatecheckBox1
            // 
            this.BirthDatecheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BirthDatecheckBox1.AutoSize = true;
            this.BirthDatecheckBox1.Checked = true;
            this.BirthDatecheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BirthDatecheckBox1.Location = new System.Drawing.Point(397, 58);
            this.BirthDatecheckBox1.Name = "BirthDatecheckBox1";
            this.BirthDatecheckBox1.Size = new System.Drawing.Size(84, 20);
            this.BirthDatecheckBox1.TabIndex = 40;
            this.BirthDatecheckBox1.Text = "BirthDate";
            this.BirthDatecheckBox1.UseVisualStyleBackColor = true;
            // 
            // SurnamecheckBox2
            // 
            this.SurnamecheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnamecheckBox2.AutoSize = true;
            this.SurnamecheckBox2.Checked = true;
            this.SurnamecheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SurnamecheckBox2.Location = new System.Drawing.Point(308, 59);
            this.SurnamecheckBox2.Name = "SurnamecheckBox2";
            this.SurnamecheckBox2.Size = new System.Drawing.Size(83, 20);
            this.SurnamecheckBox2.TabIndex = 39;
            this.SurnamecheckBox2.Text = "Surname";
            this.SurnamecheckBox2.UseVisualStyleBackColor = true;
            // 
            // NamecheckBox1
            // 
            this.NamecheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NamecheckBox1.AutoSize = true;
            this.NamecheckBox1.Checked = true;
            this.NamecheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NamecheckBox1.Location = new System.Drawing.Point(236, 59);
            this.NamecheckBox1.Name = "NamecheckBox1";
            this.NamecheckBox1.Size = new System.Drawing.Size(66, 20);
            this.NamecheckBox1.TabIndex = 38;
            this.NamecheckBox1.Text = "Name";
            this.NamecheckBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Include:";
            // 
            // SearchtextBox1
            // 
            this.SearchtextBox1.AccessibleDescription = "";
            this.SearchtextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchtextBox1.Location = new System.Drawing.Point(180, 21);
            this.SearchtextBox1.Name = "SearchtextBox1";
            this.SearchtextBox1.Size = new System.Drawing.Size(236, 22);
            this.SearchtextBox1.TabIndex = 36;
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
            this.comboBox1.Location = new System.Drawing.Point(422, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 35;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 363);
            this.dataGridView1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(678, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Average age:";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 497);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeDTOBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox AppartmentcheckBox5;
        private System.Windows.Forms.CheckBox BuildingcheckBox1;
        private System.Windows.Forms.CheckBox StreetcheckBox2;
        private System.Windows.Forms.CheckBox CitycheckBox3;
        private System.Windows.Forms.CheckBox AddresscheckBox4;
        private System.Windows.Forms.CheckBox PhoneNumbercheckBox2;
        private System.Windows.Forms.CheckBox BirthDatecheckBox1;
        private System.Windows.Forms.CheckBox SurnamecheckBox2;
        private System.Windows.Forms.CheckBox NamecheckBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SearchtextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appartmentDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
    }
}