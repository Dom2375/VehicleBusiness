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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
        }

        private void selectLocation_Click(object sender, EventArgs e)
        {
            Form myForm = new Vehicles();
            myForm.Show();
        }
    }
}
