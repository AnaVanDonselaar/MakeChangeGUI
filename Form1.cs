using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeChangeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int inputCash;
            int calc20;
            int calc10;
            int calc5;
            int calc1;

            int.TryParse(txtInput.Text, out inputCash);

            calc20 = inputCash / 20;
            calc10 = inputCash % 20 / 10;
            calc5 = inputCash % 10 / 5;
            calc1 = inputCash % 5;

            txtOutput.Text = inputCash.ToString() + " is " + calc20.ToString() + " twenties " + calc10.ToString() + " tens " + calc5.ToString() + " fives " + calc1.ToString() + " ones.";
        }
    }
}
