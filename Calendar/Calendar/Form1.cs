using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calendar
{
    public partial class Form1 : Form
    {
        MyMonth myMonth;
        List<MyButton> myButtons = new List<MyButton>();
        public Form1()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.Transparent;
            this.panel2.BackColor = Color.Transparent;
            myMonth = new MyMonth(DateTime.Now.Year, DateTime.Now.Month);
            myButtons.Add(this.myButton1);
            myButtons.Add(this.myButton2);
            myButtons.Add(this.myButton3);
            myButtons.Add(this.myButton4);
            myButtons.Add(this.myButton5);
            myButtons.Add(this.myButton6);
            myButtons.Add(this.myButton7);
            myButtons.Add(this.myButton8);
            myButtons.Add(this.myButton9);
            myButtons.Add(this.myButton10);
            myButtons.Add(this.myButton11);
            myButtons.Add(this.myButton12);
            myButtons.Add(this.myButton13);
            myButtons.Add(this.myButton14);
            myButtons.Add(this.myButton15);
            myButtons.Add(this.myButton16);
            myButtons.Add(this.myButton17);
            myButtons.Add(this.myButton18);
            myButtons.Add(this.myButton19);
            myButtons.Add(this.myButton20);
            myButtons.Add(this.myButton21);
            myButtons.Add(this.myButton22);
            myButtons.Add(this.myButton23);
            myButtons.Add(this.myButton24);
            myButtons.Add(this.myButton25);
            myButtons.Add(this.myButton26);
            myButtons.Add(this.myButton27);
            myButtons.Add(this.myButton28);
            myButtons.Add(this.myButton29);
            myButtons.Add(this.myButton30);
            myButtons.Add(this.myButton31);
            myButtons.Add(this.myButton32);
            myButtons.Add(this.myButton33);
            myButtons.Add(this.myButton34);
            myButtons.Add(this.myButton35);
            label11.Text = DateTime.Now.ToString("yyyy/MM/dd");
            myButton36.label1.Hide();
            myButton36.label2.Hide();
            myButton36.Height = 32;
            myButton36.Width = 32;
            myButton37.label1.Hide();
            myButton37.label2.Hide();
            myButton37.Height = 32;
            myButton37.Width = 32;
            myButton38.label1.Hide();
            myButton38.label2.Hide();
            myButton38.Height = 32;
            myButton38.Width = 32;
            myButton39.label1.Hide();
            myButton39.label2.Hide();
            myButton39.Height = 32;
            myButton39.Width = 32;
            ChangeCalendar();
            label9.DataBindings.Add("Text", myMonth, "Year");
            label12.DataBindings.Add("Text", myMonth, "Month");
        }
        public void ChangeCalendar()
        {
            int week=CalcDate.CalcWeek(myMonth.Year, myMonth.Month,1);//当前月份第一天为星期几
            int i = 0;
            while(i<35)
            {
                
                if (i < week)
                {
                    myButtons[i].Hide();
                }
                else if ((i- week) < myMonth.Days)
                {
                    int num = i - (week - 1);
                    myButtons[i].label1.Text = num.ToString();
                    if (myMonth.Year == DateTime.Now.Year && myMonth.Month == DateTime.Now.Month && num == DateTime.Now.Day) 
                    {
                        myButtons[i].BackColor = Color.FromArgb(100, 0, 0, 0);
                    }

                }
                else
                    myButtons[i].Hide();
                i++;
            }
        }

        private void myButton38_Click(object sender, EventArgs e)
        {
            myMonth.Month++;
            ChangeCalendar();
        }
    }
}
