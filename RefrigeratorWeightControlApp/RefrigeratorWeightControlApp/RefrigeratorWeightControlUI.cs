using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorWeightControlApp
{
    public partial class RefrigeratorWeightControlUI : Form
    {
        public RefrigeratorWeightControlUI()
        {
            InitializeComponent();
        }

        Weight aWeight=new Weight();
        private void saveButton_Click(object sender, EventArgs e)
        {
            aWeight.MaximumWeightCapasity = Convert.ToDouble(maxWeightTextBox.Text);
            remainWeightTextBox.Text = aWeight.RemainWeight.ToString();
            currentWeightTextBox.Text = aWeight.CurrentWeight.ToString();

            maxWeightTextBox.Clear();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double noItem = Convert.ToDouble(noOfItemsTextBox.Text);
            double itemWeight = Convert.ToDouble(weightEachTextBox.Text);

            aWeight.CurrentWeight = noItem*itemWeight;
            aWeight.RemainWeight = aWeight.MaximumWeightCapasity - aWeight.CurrentWeight;

            currentWeightTextBox.Text = aWeight.CurrentWeight.ToString();
            remainWeightTextBox.Text = aWeight.RemainWeight.ToString();
        }
    }
}
