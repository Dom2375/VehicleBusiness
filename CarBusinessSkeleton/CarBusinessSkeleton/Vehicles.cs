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
        public Vehicles()
        {
            InitializeComponent();
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
