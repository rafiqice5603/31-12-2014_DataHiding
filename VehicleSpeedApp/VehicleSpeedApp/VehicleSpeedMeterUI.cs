using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeedApp
{
    public partial class VehicleSpeedMeterUI : Form
    {
        public VehicleSpeedMeterUI()
        {
            InitializeComponent();
        }
        Vehicle aVehicle = new Vehicle();
        private void createButton_Click(object sender, EventArgs e)
        {

            aVehicle.VehicleName = vehicleNameTextBox.Text;
            aVehicle.VehicleRegNo = vehicleRegNoTextBox.Text;

            vehicleNameTextBox.Clear();
            vehicleRegNoTextBox.Clear();

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicle.MinSpeed = Convert.ToDouble(vehicleSpeedTextBox.Text);
            aVehicle.MaxSpeed = Convert.ToDouble(vehicleSpeedTextBox.Text);
            aVehicle.VehicleSpeedSum = Convert.ToDouble(vehicleSpeedTextBox.Text);
            vehicleSpeedTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            vehicleMinSpeedtextBox.Text = aVehicle.MinSpeed.ToString();
            vehicleMaxSpeedtextBox.Text = aVehicle.MaxSpeed.ToString();
            vehicleAvgSpeedtextBox.Text = aVehicle.AversgeSpeed.ToString();
        }
    }
}
