namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axCalendar51 = new AxCALENDARLib5.AxCalendar5();
            this.btn_succ = new System.Windows.Forms.Button();
            this.btn_pred = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar51)).BeginInit();
            this.SuspendLayout();
            // 
            // axCalendar51
            // 
            this.axCalendar51.AllowDrop = true;
            this.axCalendar51.Enabled = true;
            this.axCalendar51.Location = new System.Drawing.Point(0, 0);
            this.axCalendar51.Name = "axCalendar51";
            this.axCalendar51.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCalendar51.OcxState")));
            this.axCalendar51.Size = new System.Drawing.Size(867, 662);
            this.axCalendar51.TabIndex = 3;
            this.axCalendar51.UseWaitCursor = true;
            this.axCalendar51.OnDayClick += new AxCALENDARLib5._DCalendarEvents5_OnDayClickEventHandler(this.axCalendar51_OnDayClick);
            // 
            // btn_succ
            // 
            this.btn_succ.Location = new System.Drawing.Point(711, 53);
            this.btn_succ.Name = "btn_succ";
            this.btn_succ.Size = new System.Drawing.Size(75, 23);
            this.btn_succ.TabIndex = 4;
            this.btn_succ.Text = ">";
            this.btn_succ.UseVisualStyleBackColor = true;
            this.btn_succ.Click += new System.EventHandler(this.btn_succ_Click);
            // 
            // btn_pred
            // 
            this.btn_pred.Location = new System.Drawing.Point(630, 53);
            this.btn_pred.Name = "btn_pred";
            this.btn_pred.Size = new System.Drawing.Size(75, 23);
            this.btn_pred.TabIndex = 5;
            this.btn_pred.Text = "<";
            this.btn_pred.UseVisualStyleBackColor = true;
            this.btn_pred.Click += new System.EventHandler(this.btn_pred_Click);
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(501, 53);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 23);
            this.btn_go.TabIndex = 6;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(305, 56);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(160, 20);
            this.dtp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 660);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.btn_pred);
            this.Controls.Add(this.btn_succ);
            this.Controls.Add(this.axCalendar51);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar51)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_succ;
        private System.Windows.Forms.Button btn_pred;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.DateTimePicker dtp;
        private AxCALENDARLib5.AxCalendar5 axCalendar51;
    }
}

