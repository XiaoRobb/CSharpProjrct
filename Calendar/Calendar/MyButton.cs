using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Calendar
{
    class MyButton:Button
    {
        private Panel panel = new Panel();
        public Label label1 = new Label();
        public Label label2 = new Label();
        public Color preColor;
        public MyButton():base()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Height = 40;
            this.Width = 40;
            panel.SetBounds(0, 0, 40, 40);
            label1.Text = "1";
            label1.SetBounds(10, 4,20,20);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new Font("隶书",8, FontStyle.Bold);
            label1.BackColor = Color.Transparent;           
            label2.Text = "十二";
            label2.Font = new Font("隶书", 8, FontStyle.Bold);
            label2.SetBounds(2, 26, 36, 12);
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.BackColor = Color.Transparent;
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.BackColor = Color.FromArgb(0, 0, 100, 0);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            preColor = this.BackColor;
            this.BackColor = Color.FromArgb(50, 50, 200, 0);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = preColor;
        }
    }
}
