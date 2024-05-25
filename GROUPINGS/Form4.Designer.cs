namespace GROUPINGS
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullnametextbox = new System.Windows.Forms.TextBox();
            this.gendercombobox = new System.Windows.Forms.ComboBox();
            this.comboxcourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboxyrlevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboxsem = new System.Windows.Forms.ComboBox();
            this.comboxschoolyr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txsubdesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txnumunit = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboxsubcode = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(104, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LAST NAME, FIRST NAME MI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(372, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GENDER";
            // 
            // fullnametextbox
            // 
            this.fullnametextbox.Location = new System.Drawing.Point(45, 119);
            this.fullnametextbox.Name = "fullnametextbox";
            this.fullnametextbox.Size = new System.Drawing.Size(302, 20);
            this.fullnametextbox.TabIndex = 4;
            // 
            // gendercombobox
            // 
            this.gendercombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercombobox.FormattingEnabled = true;
            this.gendercombobox.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.gendercombobox.Location = new System.Drawing.Point(353, 119);
            this.gendercombobox.Name = "gendercombobox";
            this.gendercombobox.Size = new System.Drawing.Size(99, 21);
            this.gendercombobox.TabIndex = 5;
            this.gendercombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboxcourse
            // 
            this.comboxcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxcourse.FormattingEnabled = true;
            this.comboxcourse.Items.AddRange(new object[] {
            "BSCS",
            "BSHM",
            "BSTM",
            "BSBA",
            "BEED",
            "BSED MATH",
            "BSED ENGLISH",
            "AB POLSCI"});
            this.comboxcourse.Location = new System.Drawing.Point(81, 173);
            this.comboxcourse.Name = "comboxcourse";
            this.comboxcourse.Size = new System.Drawing.Size(99, 21);
            this.comboxcourse.TabIndex = 6;
            this.comboxcourse.SelectedIndexChanged += new System.EventHandler(this.cbcourse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year Level:";
            // 
            // comboxyrlevel
            // 
            this.comboxyrlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxyrlevel.FormattingEnabled = true;
            this.comboxyrlevel.Items.AddRange(new object[] {
            "FIRST YEAR",
            "SECOND YEAR",
            "THIRD YEAR",
            "FOURTH YEAR"});
            this.comboxyrlevel.Location = new System.Drawing.Point(81, 203);
            this.comboxyrlevel.Name = "comboxyrlevel";
            this.comboxyrlevel.Size = new System.Drawing.Size(99, 21);
            this.comboxyrlevel.TabIndex = 9;
            this.comboxyrlevel.SelectedIndexChanged += new System.EventHandler(this.cbyearlvl_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Semester";
            // 
            // comboxsem
            // 
            this.comboxsem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxsem.FormattingEnabled = true;
            this.comboxsem.Items.AddRange(new object[] {
            "FIRST SEMESTER",
            "SECOND SEMESTER"});
            this.comboxsem.Location = new System.Drawing.Point(81, 231);
            this.comboxsem.Name = "comboxsem";
            this.comboxsem.Size = new System.Drawing.Size(99, 21);
            this.comboxsem.TabIndex = 11;
            this.comboxsem.SelectedIndexChanged += new System.EventHandler(this.cbsem_SelectedIndexChanged);
            // 
            // comboxschoolyr
            // 
            this.comboxschoolyr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxschoolyr.FormattingEnabled = true;
            this.comboxschoolyr.Items.AddRange(new object[] {
            "2021-2022",
            "2022-2023"});
            this.comboxschoolyr.Location = new System.Drawing.Point(81, 268);
            this.comboxschoolyr.Name = "comboxschoolyr";
            this.comboxschoolyr.Size = new System.Drawing.Size(99, 21);
            this.comboxschoolyr.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "School Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(224, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Subject Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(199, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Subject Description";
            // 
            // txsubdesc
            // 
            this.txsubdesc.Location = new System.Drawing.Point(304, 207);
            this.txsubdesc.Name = "txsubdesc";
            this.txsubdesc.Size = new System.Drawing.Size(217, 20);
            this.txsubdesc.TabIndex = 18;
            this.txsubdesc.TextChanged += new System.EventHandler(this.txsubdesc_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(212, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Number of Units:";
            // 
            // txnumunit
            // 
            this.txnumunit.Location = new System.Drawing.Point(304, 236);
            this.txnumunit.Name = "txnumunit";
            this.txnumunit.Size = new System.Drawing.Size(217, 20);
            this.txnumunit.TabIndex = 20;
            this.txnumunit.TextChanged += new System.EventHandler(this.txnumunit_TextChanged);
            this.txnumunit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberofunits_KeyPress);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.ForeColor = System.Drawing.Color.Transparent;
            this.Register.Location = new System.Drawing.Point(81, 323);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(111, 31);
            this.Register.TabIndex = 21;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.ForeColor = System.Drawing.Color.Transparent;
            this.Clear.Location = new System.Drawing.Point(201, 323);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(111, 31);
            this.Clear.TabIndex = 22;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(321, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboxsubcode
            // 
            this.comboxsubcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxsubcode.FormattingEnabled = true;
            this.comboxsubcode.Items.AddRange(new object[] {
            "BSCS",
            "BSHM",
            "BSTM",
            "BSBA",
            "BEED",
            "BSED MATH",
            "BSED ENGLISH",
            "AB POLSCI"});
            this.comboxsubcode.Location = new System.Drawing.Point(304, 173);
            this.comboxsubcode.Name = "comboxsubcode";
            this.comboxsubcode.Size = new System.Drawing.Size(217, 21);
            this.comboxsubcode.TabIndex = 25;
            this.comboxsubcode.SelectedIndexChanged += new System.EventHandler(this.comboxsubcode_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 90);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(98, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(426, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "ST.CLARE COLLEGE OF CALOOCAN CITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "REGISTRATION FORM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GROUPINGS.Properties.Resources._339766450_594246562647170_9038727475169988314_n_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 84);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 23);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(238, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Date Now:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 395);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboxsubcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.txnumunit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txsubdesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboxschoolyr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboxsem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboxyrlevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboxcourse);
            this.Controls.Add(this.gendercombobox);
            this.Controls.Add(this.fullnametextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullnametextbox;
        private System.Windows.Forms.ComboBox gendercombobox;
        private System.Windows.Forms.ComboBox comboxcourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboxyrlevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboxsem;
        private System.Windows.Forms.ComboBox comboxschoolyr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txsubdesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txnumunit;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboxsubcode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}