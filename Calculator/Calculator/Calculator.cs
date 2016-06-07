using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            var value1 = Convert.ToInt32(txtValue1.Text);
            var value2 = Convert.ToInt32(txtValue2.Text);
            var result = value1 + value2;
            txtResult.Text = result.ToString();

        }

        private void btnCalmin_Click(object sender, EventArgs e)
        {
            var value1min = Convert.ToInt32(txtValue1Min.Text);
            var value2min = Convert.ToInt32(txtValue2Min.Text);
            var resultmin = value1min - value2min;
            txtResultMin.Text = resultmin.ToString();
        }

        private void btnCalim_Click(object sender, EventArgs e)
        {
            var value1im = Convert.ToInt32(txtValue1Im.Text);
            var value2im = Convert.ToInt32(txtValue2Im.Text);
            var resultim    = value1im * value2im;
            txtResultIm.Text = resultim.ToString();

        }

        private void btnCaldiv_Click(object sender, EventArgs e)
        {
            var value1div = Convert.ToDouble(txtValue1div.Text);
            var value2div = Convert.ToDouble(txtValue2div.Text);
            double resultdiv = value1div/value2div;
            txtResultdiv.Text = resultdiv.ToString();
        }

    }
}
