using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonProjesi
{
    public partial class ProgresBarım : Form
    {
        public ProgresBarım()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 5;
            pbar.Text = pbar.Value.ToString() + "%";
            if (pbar.Value == 100)
            {
                timer1.Enabled = false;
                //Application.Exit();
                this.Hide();
                
                
                
            }
        }

        private void ProgresBarım_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
