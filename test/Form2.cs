using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int i = 1;
        int initlblY = 71;
        int inittxtY = 99;
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            Boolean condition=true;
            int nbr = int.Parse(txt_enf.Text);
            
            
            if (nbr > 6)
            {
                Label lbl = new Label();
                lbl.Left = 55;
                lbl.Top = 190;
                lbl.Text = "Vérifier le nombre d'enfants";
                this.Controls.Add(lbl);
                condition = false;

            }
             if (txt_nom.Text.Equals(""))
            {
                Label lbl = new Label();
                lbl.Left = 55;
                lbl.Top = 115;
                lbl.Text = "Entrer un nom valide";
                this.Controls.Add(lbl);
                condition = false;
            }

            if (condition &&nbr >0)
            {
                label1.Hide();
                txt_nom.Hide();
                txt_enf.Hide();
                label2.Hide();
                for (int j = 0; j < nbr; j++)
                {
                    Label lbl = new Label();
                    TextBox txt = new TextBox();
                    txt.Top = inittxtY;
                    txt.Left = 106;
                    txt.Width = 142;
                    lbl.Left = 106;
                    lbl.Top = initlblY;
                    lbl.Width = 50;
                    lbl.BackColor = Color.Goldenrod;
                    txt.Name = "txt_Enf" + this.i.ToString();
                    lbl.Text = "Enfant " + this.i.ToString();
                    lbl.Name = "lbl_enf" + this.i.ToString();
                    this.Controls.Add(lbl);
                    this.Controls.Add(txt);
                    i++;
                    inittxtY += 72;
                    initlblY += 72;

                }
                if (nbr > 4)
                    btn_val.Top = 450;
                else if (nbr > 2 && nbr < 4)
                {
                    btn_val.Top = 291;
                }
                else
                {
                    btn_val.Top = 130;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            TextBox txt = new TextBox();
            int initlblY = 228;
            int inittxtY = 255;
            //int nbr = int.Parse(txt_enf.Text);
            
                
                lbl.Top = initlblY;
                lbl.Left = 16;
                lbl.Text = "Enfant " + this.i.ToString();
                lbl.Name = "lbl_enf" + this.i.ToString();           
                inittxtY += 72;
                initlblY += 72;
            
            this.Controls.Add(lbl);
            i++;
        }
    }
}
