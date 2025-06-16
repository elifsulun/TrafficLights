using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class TrafficLightsTimer : Form
    {
        public TrafficLightsTimer()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();

            if (counter == 1)
            {
                panel1.BackColor = Color.OrangeRed;
            }
            if (counter == 31)
            {
                panel2.BackColor = Color.Yellow;
            }
            if (counter == 41)
            {
                panel3.BackColor = Color.LightGreen;            
            }
            if (counter == 71)
            {
                timer1.Stop();
            }
        }
    }
}
