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
    public partial class Vehicles : Form
    {
        public Vehicles(List<VehicleClass> locationlist)
        //creates Vehicles form with a list of type VehicleClass as a parameter 
        {
            InitializeComponent();
            vehiclesListBox.DataSource = locationlist;//loads the list pased to the method in the listbox
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show();
        }
    }
}
