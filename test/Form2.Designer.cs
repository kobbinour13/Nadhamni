namespace test
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
            this.btn_val = new System.Windows.Forms.Button();
            this.rbo = new System.Windows.Forms.RadioButton();
            this.dtp_wife = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rbn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnbr = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_val
            // 
            this.btn_val.BackColor = System.Drawing.Color.Gold;
            this.btn_val.Location = new System.Drawing.Point(150, 320);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(72, 27);
            this.btn_val.TabIndex = 0;
            this.btn_val.Text = "Valider";
            this.btn_val.UseVisualStyleBackColor = false;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // rbo
            // 
            this.rbo.AutoSize = true;
            this.rbo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rbo.ForeColor = System.Drawing.SystemColors.Control;
            this.rbo.Location = new System.Drawing.Point(97, 230);
            this.rbo.Margin = new System.Windows.Forms.Padding(2);
            this.rbo.Name = "rbo";
            this.rbo.Size = new System.Drawing.Size(51, 23);
            this.rbo.TabIndex = 50;
            this.rbo.TabStop = true;
            this.rbo.Text = "Oui";
            this.rbo.UseVisualStyleBackColor = true;
            this.rbo.CheckedChanged += new System.EventHandler(this.rbo_CheckedChanged);
            // 
            // dtp_wife
            // 
            this.dtp_wife.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtp_wife.Location = new System.Drawing.Point(170, 148);
            this.dtp_wife.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_wife.Name = "dtp_wife";
            this.dtp_wife.Size = new System.Drawing.Size(176, 20);
            this.dtp_wife.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(29, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Date of birth :";
            // 
            // rbn
            // 
            this.rbn.AutoSize = true;
            this.rbn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rbn.ForeColor = System.Drawing.SystemColors.Control;
            this.rbn.Location = new System.Drawing.Point(224, 230);
            this.rbn.Margin = new System.Windows.Forms.Padding(2);
            this.rbn.Name = "rbn";
            this.rbn.Size = new System.Drawing.Size(55, 23);
            this.rbn.TabIndex = 40;
            this.rbn.TabStop = true;
            this.rbn.Text = "Non";
            this.rbn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(93, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 21);
            this.label6.TabIndex = 47;
            this.label6.Text = "Avez vous des enfants";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(155, 124);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 1);
            this.panel5.TabIndex = 46;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 21);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(193, 10);
            this.panel6.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(0, 24);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 1);
            this.panel7.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(0, 24);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 1);
            this.panel8.TabIndex = 24;
            // 
            // txt_last
            // 
            this.txt_last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.txt_last.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_last.Location = new System.Drawing.Point(158, 101);
            this.txt_last.Margin = new System.Windows.Forms.Padding(2);
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(148, 19);
            this.txt_last.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(49, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Last Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(155, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 1);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 24;
            // 
            // txt_first
            // 
            this.txt_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.txt_first.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_first.Location = new System.Drawing.Point(158, 64);
            this.txt_first.Margin = new System.Windows.Forms.Padding(2);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(148, 19);
            this.txt_first.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(50, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "First Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 38;
            // 
            // txtnbr
            // 
            this.txtnbr.Location = new System.Drawing.Point(143, 233);
            this.txtnbr.Name = "txtnbr";
            this.txtnbr.Size = new System.Drawing.Size(79, 20);
            this.txtnbr.TabIndex = 52;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(2, 17);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 21);
            this.label18.TabIndex = 43;
            this.label18.Text = "First Name :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.Location = new System.Drawing.Point(113, 19);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 19);
            this.textBox3.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(2, 51);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 21);
            this.label17.TabIndex = 50;
            this.label17.Text = "Date of birth :";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker3.Location = new System.Drawing.Point(113, 52);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker3.TabIndex = 51;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Jardin d\'enfant",
            "Ecole",
            "College",
            "Lycée",
            "Faculté"});
            this.comboBox4.Location = new System.Drawing.Point(146, 89);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(2, 89);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 21);
            this.label16.TabIndex = 54;
            this.label16.Text = "Niveau Scolaire :";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gold;
            this.panel11.Controls.Add(this.label16);
            this.panel11.Controls.Add(this.comboBox4);
            this.panel11.Controls.Add(this.dateTimePicker3);
            this.panel11.Controls.Add(this.label17);
            this.panel11.Controls.Add(this.textBox3);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Location = new System.Drawing.Point(53, 392);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(293, 131);
            this.panel11.TabIndex = 54;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(385, 581);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txtnbr);
            this.Controls.Add(this.rbo);
            this.Controls.Add(this.dtp_wife);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_last);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_val);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.RadioButton rbo;
        private System.Windows.Forms.DateTimePicker dtp_wife;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnbr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel11;
    }
}