using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcTip_Click(object sender, EventArgs e)
        {
            try {
                double total = Convert.ToDouble(totalBox.Text);
                double tipP = Convert.ToDouble(tipPercent.Text);
                double tipAmount = tipP * total;
                double totalAmount = total + tipAmount;
                MessageBox.Show("Your tip would be " + tipAmount + ", for a grand total of " + totalAmount+ "!");
            } catch
            {
                MessageBox.Show("Error, enter monetary values!");
            }
        }
    }
}
