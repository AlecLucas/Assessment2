using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp

{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        double[] Conversions = new double[5];

        double unitConvert;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnConvert_Click(object sender, EventArgs e)
        {
            //Clearing listbox before use
            lbDisplay.Items.Clear();

            //Centimetres to Inches outputs
            lbDisplay.Items.Add("Centimetres to Inches:");
            lbDisplay.Items.Add(CmToInches());
            lbDisplay.Items.Add("");

            // Metres to Feet outputs
            lbDisplay.Items.Add("Metres to Feet:");
            lbDisplay.Items.Add(MetresToFeet());
            lbDisplay.Items.Add("");

            //Celsius to Fehrenheit outputs
            lbDisplay.Items.Add("Celsius to Fehrenheit:");
            lbDisplay.Items.Add(CelsiusToFahrenheit() + " °F");
            lbDisplay.Items.Add("");

            //Centermetres to Feet outputs
            lbDisplay.Items.Add("Centermetres to Feet:");
            lbDisplay.Items.Add(CmToFeet());
            lbDisplay.Items.Add("");

            //Kilometres to Miles outputs
            lbDisplay.Items.Add("Kilometres to Miles:");
            lbDisplay.Items.Add(KilometresToMiles());
            lbDisplay.Items.Add("");

        }

        public double CmToInches()
        {
            const double CmToInchConversion = 0.3937;

            if (! double.TryParse(txtCmToInch.Text, out Conversions[0]))
            {
                MessageBox.Show("Invalid unit in Centermetres to Inches textbox.");
                txtCmToInch.Clear();
                txtCmToInch.Focus();            
            }
            else
            {
                unitConvert = Conversions[0] * CmToInchConversion;
            }

            return unitConvert;
        }

        public double MetresToFeet()
        {
            const double MetresToFeetConversion = 3.28084;

            if (!double.TryParse(txtMetreToFeet.Text, out Conversions[1]))
            {
                MessageBox.Show("Invalid unit in Metres to Feet textbox.");
                txtMetreToFeet.Clear();
                txtMetreToFeet.Focus();
            }
            else
            {
                unitConvert = Conversions[1] * MetresToFeetConversion;
            }

            return unitConvert;
        }

        public double CelsiusToFahrenheit()
        {
            const double CelsiusToFahrenheitConversion = 30.48;

            if (!double.TryParse(txtCelsiusToFahrenheit.Text, out Conversions[2]))
            {
                MessageBox.Show("Invalid unit in Celsius to Fahrenheit textbox.");
                txtCelsiusToFahrenheit.Clear();
                txtCelsiusToFahrenheit.Focus();
            }
            else
            {
                unitConvert = Conversions[2] / CelsiusToFahrenheitConversion;
            }

            return unitConvert;
        }

        public double CmToFeet()
        {
            const double CmToFeetConversion = 0.0328084;

            if (!double.TryParse(txtCmToFeet.Text, out Conversions[3]))
            {
                MessageBox.Show("Invalid unit in Centermetres to Feet textbox.");
                txtCmToFeet.Clear();
                txtCmToFeet.Focus();
            }
            else
            {
                unitConvert = Conversions[3] * CmToFeetConversion;
            }

            return unitConvert;
        }

        public double KilometresToMiles()
        {
            const double KilometresToMilesConversion = 0.621371;

            if (!double.TryParse(txtKiloToMiles.Text, out Conversions[4]))
            {
                MessageBox.Show("Invalid unit in Kilometres to Miles textbox.");
                txtKiloToMiles.Clear();
                txtKiloToMiles.Focus();
            }
            else
            {
                unitConvert = Conversions[4] * KilometresToMilesConversion;
            }

            return unitConvert;
        }
    }
}
