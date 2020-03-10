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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_enf = new System.Windows.Forms.TextBox();
            this.btn_ret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_val
            // 
            this.btn_val.BackColor = System.Drawing.Color.Gold;
            this.btn_val.Location = new System.Drawing.Point(265, 111);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(79, 27);
            this.btn_val.TabIndex = 0;
            this.btn_val.Text = "Valider";
            this.btn_val.UseVisualStyleBackColor = false;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_nom.Location = new System.Drawing.Point(47, 92);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(142, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(77, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de Marié";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(70, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre d\'enfant";
            // 
            // txt_enf
            // 
            this.txt_enf.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_enf.Location = new System.Drawing.Point(47, 167);
            this.txt_enf.Name = "txt_enf";
            this.txt_enf.Size = new System.Drawing.Size(142, 20);
            this.txt_enf.TabIndex = 4;
            // 
            // btn_ret
            // 
            this.btn_ret.BackColor = System.Drawing.Color.Gold;
            this.btn_ret.Location = new System.Drawing.Point(-2, -1);
            this.btn_ret.Name = "btn_ret";
            this.btn_ret.Size = new System.Drawing.Size(79, 27);
            this.btn_ret.TabIndex = 5;
            this.btn_ret.Text = "<-";
            this.btn_ret.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(368, 574);
            this.Controls.Add(this.btn_ret);
            this.Controls.Add(this.txt_enf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.btn_val);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_enf;
        private System.Windows.Forms.Button btn_ret;
    }
}