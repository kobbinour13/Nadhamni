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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            axCalendar51.DayColor = Color.DarkGray;
            axCalendar51.DayCaptionForeColor = Color.Black;
            axCalendar51.DayCaptionBackColor = Color.Gold;
            axCalendar51.MonthYearBackColor = Color.DarkGray;
            axCalendar51.MonthYearForeColor = Color.Gold;
            
            axCalendar51.CtlBackColor = Color.DeepSkyBlue;


        }

        private void cld_OnDayClick(object sender, AxCALENDARLib._DCalendarEvents_OnDayClickEvent e)
        {
            
        }

        private void axCalendar51_OnDayClick(object sender, AxCALENDARLib5._DCalendarEvents5_OnDayClickEvent e)
        {
                  }

        private void button1_Click(object sender, EventArgs e)
        {
            axCalendar51.MonthYearBackColor=Color.BlueViolet;
            
        }

        private void btn_succ_Click(object sender, EventArgs e)
        {
            

            if (axCalendar51.Month < 12)
                axCalendar51.Month++;
            else
            {
                axCalendar51.Month = 1;
                axCalendar51.Year++;
            }
            
        }

        private void btn_pred_Click(object sender, EventArgs e)
        {
            if (axCalendar51.Month >1)
                axCalendar51.Month--;
            else
            {
                axCalendar51.Month = 12;
                axCalendar51.Year--;
            }

        }

        
        

        private void btn_go_Click(object sender, EventArgs e)
        {

            switch (dtp.Value.Month.ToString())
            {
                case "1":
                    axCalendar51.Month = 1;
                    break;
                case "2":
                    axCalendar51.Month = 2;
                    break;
                case "3":
                    axCalendar51.Month = 3;
                    break;
                case "4":
                    axCalendar51.Month = 4;
                    break;
                case "5":
                    axCalendar51.Month = 5;
                    break;
                case "6":
                    axCalendar51.Month = 6;
                    break;
                case "7":
                    axCalendar51.Month = 7;
                    break;
                case "8":
                    axCalendar51.Month = 8;
                    break;
                case "9":
                    axCalendar51.Month = 9;
                    break;
                case "10":
                    axCalendar51.Month = 10;
                    break;
                case "11":
                    axCalendar51.Month = 11;
                    break;
                case "12":
                    axCalendar51.Month = 12;
                    break;
            }
            int b = dtp.Value.Year;

            axCalendar51.Year = (short)b;
            axCalendar51.SetText(5, "1-bonjour  \n2-nour \n3-kzdbud");
            //axCalendar51.SetText(3, "1-bonjour  \n ");
            axCalendar51.SetText(3, "\n milan");

        }
    }
}
