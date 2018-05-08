/*
 * Created by: Allison Cook
 * Created on: 25 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Volume of a Cylinder
 * This program calculates the volume of a cylinder with height and radius given by user
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CylinderAllisonC
{
    public partial class frmVolumeCylinder : Form
    {
        public frmVolumeCylinder()
        {
            InitializeComponent();
        }

        private double CalculateVolume (double tmpheight, double tmpradius)
        {
            //declare variable
            double tmpvolume;
            const double PI = 3.14;

            //calculate the area
            tmpvolume = 2 * PI * Math.Pow(tmpradius, 2) * tmpheight;

            //return the area value
            return tmpvolume;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //delare variables
            double radius, height, volume;

            //getting the input
            radius = float.Parse(txtRadius.Text);
            height = float.Parse(txtHeight.Text);

            //calling the calculate function to set ot area
            volume = CalculateVolume(height, radius);

            //display the area
            MessageBox.Show("The volume is " + volume, "Volume of a Cylinder");
        }
    }
}
