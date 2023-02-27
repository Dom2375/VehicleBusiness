using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();

            typeComboBox.Items.Add("Car");
            typeComboBox.Items.Add("Truck");
            typeComboBox.Items.Add("Plane");
            typeComboBox.Items.Add("Helicopter");
        }
    }
}
