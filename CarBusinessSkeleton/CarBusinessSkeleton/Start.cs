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

    public class Car : VehicleClass
    {
        int DoorTotal;// stores the number of doors
        float engineSize;// stores the engine size
        bool electricWindows;//stores whether a car has electric windows
        public Car(string type, string make, string model, int year, double price, double weight, string colour, string registration,
            int DoorTotal, float engineSize, bool electricWindows) : base(type, make, model, year, price, weight, colour, registration)
        //constructor for car class
        {
            this.DoorTotal = DoorTotal;
            this.engineSize = engineSize;
            this.electricWindows = electricWindows;
        }

    }

    public class Truck : VehicleClass
    {
        protected int weightLimit;
        protected int wheelNum;
        protected int truckLength;

        public Truck(string type, string make, string model, int year, double price, double weight, string colour, string reg, int weightLimit, int wheelNum, int truckLength) 
            : base(type, make, model, year, price, weight, colour, reg)
        {
            this.weightLimit = weightLimit;
            this.wheelNum = wheelNum;
            this.truckLength = truckLength;
        }
    }

    public class Helicopter : VehicleClass
    {
        protected bool airworthy;
        protected int hoursUsed;
        protected double altLimit;

        public Helicopter(string type, string make, string model, int year, double price, double weight, string colour, string reg, bool airworthy, int hoursUsed, double altLimit)
            : base(type, make, model, year, price, weight, colour, reg)
        {
            this.airworthy = airworthy;
            this.hoursUsed = hoursUsed;
            this.altLimit = altLimit;
        }
    }

    public class Plane : VehicleClass
    {
        protected bool airworthy;
        protected int hoursUsed;
        protected double altLimit;
        protected int seats;
        protected string engines;

        public Plane(string type, string make, string model, int year, double price, double weight, string colour, string reg, bool airworthy, int hoursUsed, double altLimit, int seats, string engines)
            : base(type, make, model, year, price, weight, colour, reg)
        {
            this.airworthy = airworthy;
            this.hoursUsed = hoursUsed;
            this.altLimit = altLimit;
            this.seats = seats;
            this.engines = engines;
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
