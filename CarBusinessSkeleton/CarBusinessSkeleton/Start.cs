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
    public class VehicleClass
    {
        protected string type;
        protected string make;
        protected string model;
        protected int year;
        protected double price;
        protected double weight;
        protected string colour;
        protected string reg;

        public VehicleClass(string type, string make, string model, int year, double price, double weight, string colour, string reg)
        //constructor for VehicleClass
        {
            this.type = type;
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.weight = weight;
            this.colour = colour;
            this.reg = reg;
        }
    }
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Business_Click(object sender, EventArgs e)
        {
            Form myForm = new Locations();
            myForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            Form myForm = new Customers();
            myForm.Show();
        }
    }
}
