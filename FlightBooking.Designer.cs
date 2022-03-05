namespace FlightBooking
{
    partial class FlightBooking
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
            this.Lblfrom = new System.Windows.Forms.Label();
            this.Txtfrom = new System.Windows.Forms.TextBox();
            this.Txtto = new System.Windows.Forms.TextBox();
            this.Lblto = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.Docno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtfirstname = new System.Windows.Forms.TextBox();
            this.Lbfn = new System.Windows.Forms.Label();
            this.Txtlastname = new System.Windows.Forms.TextBox();
            this.Lbln = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Passport = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lblfrom
            // 
            this.Lblfrom.AutoSize = true;
            this.Lblfrom.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblfrom.Location = new System.Drawing.Point(163, 46);
            this.Lblfrom.Name = "Lblfrom";
            this.Lblfrom.Size = new System.Drawing.Size(46, 19);
            this.Lblfrom.TabIndex = 0;
            this.Lblfrom.Text = "From";
            this.Lblfrom.Click += new System.EventHandler(this.Lblfrom_Click);
            // 
            // Txtfrom
            // 
            this.Txtfrom.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtfrom.Location = new System.Drawing.Point(232, 39);
            this.Txtfrom.Name = "Txtfrom";
            this.Txtfrom.Size = new System.Drawing.Size(125, 26);
            this.Txtfrom.TabIndex = 1;
            this.Txtfrom.TextChanged += new System.EventHandler(this.Txtfrom_TextChanged);
            // 
            // Txtto
            // 
            this.Txtto.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtto.Location = new System.Drawing.Point(496, 39);
            this.Txtto.Name = "Txtto";
            this.Txtto.Size = new System.Drawing.Size(161, 26);
            this.Txtto.TabIndex = 3;
            this.Txtto.TextChanged += new System.EventHandler(this.Txtto_TextChanged);
            // 
            // Lblto
            // 
            this.Lblto.AutoSize = true;
            this.Lblto.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblto.Location = new System.Drawing.Point(432, 46);
            this.Lblto.Name = "Lblto";
            this.Lblto.Size = new System.Drawing.Size(26, 19);
            this.Lblto.TabIndex = 2;
            this.Lblto.Text = "To";
            this.Lblto.Click += new System.EventHandler(this.Lblto_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(276, 88);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Travel Document";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Docno
            // 
            this.Docno.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docno.Location = new System.Drawing.Point(630, 311);
            this.Docno.Name = "Docno";
            this.Docno.Size = new System.Drawing.Size(100, 26);
            this.Docno.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Document Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txtfirstname
            // 
            this.Txtfirstname.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtfirstname.Location = new System.Drawing.Point(232, 263);
            this.Txtfirstname.Name = "Txtfirstname";
            this.Txtfirstname.Size = new System.Drawing.Size(100, 26);
            this.Txtfirstname.TabIndex = 10;
            // 
            // Lbfn
            // 
            this.Lbfn.AutoSize = true;
            this.Lbfn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbfn.Location = new System.Drawing.Point(74, 263);
            this.Lbfn.Name = "Lbfn";
            this.Lbfn.Size = new System.Drawing.Size(85, 19);
            this.Lbfn.TabIndex = 9;
            this.Lbfn.Text = "First Name";
            // 
            // Txtlastname
            // 
            this.Txtlastname.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtlastname.Location = new System.Drawing.Point(630, 256);
            this.Txtlastname.Name = "Txtlastname";
            this.Txtlastname.Size = new System.Drawing.Size(100, 26);
            this.Txtlastname.TabIndex = 12;
            // 
            // Lbln
            // 
            this.Lbln.AutoSize = true;
            this.Lbln.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbln.Location = new System.Drawing.Point(449, 263);
            this.Lbln.Name = "Lbln";
            this.Lbln.Size = new System.Drawing.Size(81, 19);
            this.Lbln.TabIndex = 11;
            this.Lbln.Text = "Last Name\r\n";
            this.Lbln.Click += new System.EventHandler(this.Lbln_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Document Issue Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Document Expiry Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Baggage";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(232, 428);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "kgs";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(-1, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(799, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Book (without Paying)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.Passport);
            this.groupBox1.Location = new System.Drawing.Point(223, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 28);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(118, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Id-Card\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Passport
            // 
            this.Passport.AutoSize = true;
            this.Passport.Location = new System.Drawing.Point(6, 8);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(66, 17);
            this.Passport.TabIndex = 22;
            this.Passport.TabStop = true;
            this.Passport.Text = "Passport";
            this.Passport.UseVisualStyleBackColor = true;
            this.Passport.CheckedChanged += new System.EventHandler(this.Passportl_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 368);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(630, 369);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // FlightBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtlastname);
            this.Controls.Add(this.Lbln);
            this.Controls.Add(this.Txtfirstname);
            this.Controls.Add(this.Lbfn);
            this.Controls.Add(this.Docno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Txtto);
            this.Controls.Add(this.Lblto);
            this.Controls.Add(this.Txtfrom);
            this.Controls.Add(this.Lblfrom);
            this.Name = "FlightBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightBooking";
            this.Load += new System.EventHandler(this.FlightBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblfrom;
        private System.Windows.Forms.TextBox Txtfrom;
        private System.Windows.Forms.TextBox Txtto;
        private System.Windows.Forms.Label Lblto;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Docno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtfirstname;
        private System.Windows.Forms.Label Lbfn;
        private System.Windows.Forms.TextBox Txtlastname;
        private System.Windows.Forms.Label Lbln;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton Passport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

