using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarqueeLabelProject
{
    public partial class MarqueeLabel : UserControl
    {
        public MarqueeLabel()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minLeft = this.label1.Width * -1;
            
            yPos = (this.Height / 2) - (label1.Height / 2);

            if (xPos <= minLeft) xPos = this.Width;
            this.label1.Location = new Point(xPos, yPos);
            xPos -= 2;
        }

        private int xPos;
        private int yPos;

        public Color PrimaryColor
        {
            get { return label1.BackColor; }
            set { label1.BackColor = value; this.BackColor = value; }
        }

        public Color SecondaryColor
        {
            get { return label1.ForeColor; }
            set { label1.ForeColor = value; }
        }

        public string TextDisplay
        {
            get { return label1.Text; }
            set { this.label1.Text = value; }
        }
        public int MarqueeSpeed
        {
            get { return timer1.Interval; }
            set { timer1.Interval = value; }
        }
        

    }
}
