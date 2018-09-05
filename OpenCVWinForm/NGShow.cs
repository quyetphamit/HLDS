using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenCVWinForm
{
    public partial class NGShow : Form
    {
        public NGShow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Tomato;
                this.Label1.ForeColor = Color.Yellow;
                this.Lb_inform_NG.ForeColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.White;
                this.Label1.ForeColor = Color.Red;
                this.Lb_inform_NG.ForeColor = Color.Red;
            }
        }

        private void NGShow_Load(object sender, EventArgs e)
        {

        }
    }
}
