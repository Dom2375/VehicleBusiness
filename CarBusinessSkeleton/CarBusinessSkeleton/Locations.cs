using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Locations : Form
    {
        List<VehicleClass> LisbonItems = new List<VehicleClass>(); //a list containing instances of vehicles read from location2.csv
        List<VehicleClass> LondonItems = new List<VehicleClass>(); //a list containing instances of vehicles read from location1.csv
        List<VehicleClass> ParisItems = new List<VehicleClass>();  //a list containing instances of vehicles read from location4.csv
        List<VehicleClass> TokyoItems = new List<VehicleClass>();  //a list containing instances of vehicles read from location3.csv 

        int lisbonCount = 0; //counts the amount of vehicles in Lisbon
        int londonCount = 0; //counts the amount of vehicles in London
        int parisCount = 0; //counts the amount of vehicles in Paris
        int tokyoCount = 0; //counts the amount of vehicles in Tokyo
        public Locations()
        {
            InitializeComponent();
            string[] londonData = File.ReadAllLines(@"C:\Users\domin\Documents\Projects\CarBusinessSkeleton\CarBusinessSkeleton\CarBusinessSkeleton\bin\Debug\Vehicles\Location1.csv");
            //stores each line in location1.csv in an array
            string[] lisbonData = File.ReadAllLines(@"C:\Users\domin\Documents\Projects\CarBusinessSkeleton\CarBusinessSkeleton\CarBusinessSkeleton\bin\Debug\Vehicles\Location2.csv");
            //stores each line in location2.csv in an array
            string[] tokyoData = File.ReadAllLines(@"C:\Users\domin\Documents\Projects\CarBusinessSkeleton\CarBusinessSkeleton\CarBusinessSkeleton\bin\Debug\Vehicles\Location3.csv");
            //stores each line in location3.csv in an array
            string[] parisData = File.ReadAllLines(@"C:\Users\domin\Documents\Projects\CarBusinessSkeleton\CarBusinessSkeleton\CarBusinessSkeleton\bin\Debug\Vehicles\Location4.csv");
            //stores each line in location4.csv in an array

            locationsList.Items.Add(lisbonData[0]);//displays 'Lisbon' in Location's list box
            locationsList.Items.Add(londonData[0]);//displays 'London' in Location's list box
            locationsList.Items.Add(parisData[0]);//displays 'Paris' in Location's list box
            locationsList.Items.Add(tokyoData[0]);//displays 'Tokyo' in Location's list box

            for (int i = 0; i < lisbonData.Length; i++)
            //cycles through each item in the array
            {
                string[] bits;//used to store indivdual parts of each vehicle entry

                do
                {
                    bits = lisbonData[i].Split(',');//splits each vehicle into parts at each comma

                    if (bits[0] == "Car")
                    {
                        Car c = new Car(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                        bits[6], bits[7], int.Parse(bits[8]), float.Parse(bits[9]), bool.Parse(bits[10]));//uses each part of the vehicle to create an instance of the car class
                        LisbonItems.Add(c);//adds the car instance to the list of vehicles in lisbon
                        i++;
                        lisbonCount++;//increments by one to count the amount of vehicles in lisbon
                    }
                    if (bits[0] == "Truck")
                    {
                        Truck t = new Truck(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                            bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));//uses each part of the vehicle to create an instance of the truck class
                        LisbonItems.Add(t);//adds the truck instance to the list of vehicles in lisbon
                        i++;
                        lisbonCount++;
                    }
                    if (bits[0] == "Helicopter")
                    {
                        Helicopter h = new Helicopter(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                           bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));//uses each part of the vehicle 
                        //to create an instance of the helicoper class
                        LisbonItems.Add(h);//adds the helicopter instance to the list of vehicles in lisbon
                        i++;
                        lisbonCount++;
                    }

                    if (bits[0] == "Plane")
                    {
                        Plane p = new Plane(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                            bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                        //uses each part of the vehicle to create an instance of the plane class
                        LisbonItems.Add(p);//adds the plane  instance to the list of vehicles in lisbon
                        i++;
                        lisbonCount++;
                    }


                    if (i == lisbonData.Length)
                    {
                        break;
                    }
                }
                while (lisbonData[i].Split(',').Length > 1);
            }

            for (int i = 0; i < londonData.Length; i++)
            {
                string[] bits;

                do
                {
                    bits = londonData[i].Split(',');

                    if (bits[0] == "Car")
                    {
                        Car c = new Car(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                        bits[6], bits[7], int.Parse(bits[8]), float.Parse(bits[9]), bool.Parse(bits[10]));//uses each part of the vehicle to create an instance of the car class
                        LondonItems.Add(c);//adds the car instance to the list of vehicles in london
                        i++;
                        londonCount++;//increments by one to count the amount of vehicles in London
                    }
                    if (bits[0] == "Truck")
                    {
                        Truck t = new Truck(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                            bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));//uses each part of the vehicle to create an instance of the truck class
                        LondonItems.Add(t);//adds the truck instance to the list of vehicles in london
                        i++;
                        londonCount++;
                    }
                    if (bits[0] == "Helicopter")
                    {
                        Helicopter h = new Helicopter(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                           bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));//uses each part of the vehicle to 
                        //create an instance of the helicopter class
                        LondonItems.Add(h);//adds the helicopter instance to the list of vehicles in london
                        i++;
                        londonCount++;
                    }

                    if (bits[0] == "Plane")
                    {
                        Plane p = new Plane(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                            bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                        //uses each part of the vehicle to create an instance of the plane class
                        LondonItems.Add(p);//adds the plane instance to the list of vehicles in london
                        i++;
                        londonCount++;
                    }


                    if (i == londonData.Length)
                    {
                        break;
                    }
                }
                while (londonData[i].Split(',').Length > 1);

            }

            for (int i = 0; i < parisData.Length; i++)
            {
                string[] bits;

                do
                {
                    bits = parisData[i].Split(',');

                    if (bits[0] == "Car")
                    {
                        Car c = new Car(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                        bits[6], bits[7], int.Parse(bits[8]), float.Parse(bits[9]), bool.Parse(bits[10]));//uses each part of the vehicle to create an instance of the car class
                        ParisItems.Add(c);//adds the car instance to the list of vehicles in Paris
                        i++;
                        parisCount++;//increments by one to count the amount of vehicles in Paris
                    }
                    if (bits[0] == "Truck")
                    {
                        Truck t = new Truck(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                            bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));//uses each part of the vehicle to create an instance of the truck class
                        ParisItems.Add(t);//adds the truck instance to the list of vehicles in Paris
                        i++;
                        parisCount++;
                    }
                    if (bits[0] == "Helicopter")
                    {
                        Helicopter h = new Helicopter(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                           bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));//uses each part of the vehicle to create an instance of the helicopter class
                        ParisItems.Add(h);//adds the helicopter instance to the list of vehicles in Paris
                        i++;
                        parisCount++;
                    }

                    if (bits[0] == "Plane")
                    {
                        Plane p = new Plane(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                            bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                        //uses each part of the vehicle to create an instance of the plane class
                        ParisItems.Add(p);//adds the helicopter instance to the list of vehicles in Paris
                        i++;
                        parisCount++;
                    }


                    if (i == parisData.Length)
                    {
                        break;
                    }
                }
                while (parisData[i].Split(',').Length > 1);

            }

            for (int i = 0; i < tokyoData.Length; i++)
            {
                string[] bits;

                do
                {
                    bits = tokyoData[i].Split(',');

                    if (bits[0] == "Car")
                    {
                        Car c = new Car(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                        bits[6], bits[7], int.Parse(bits[8]), float.Parse(bits[9]), bool.Parse(bits[10]));//uses each part of the vehicle to create an instance of the car class
                        TokyoItems.Add(c);//adds the car instance to the list of vehicles in Tokyo
                        i++;
                        tokyoCount++;//increments by one to count the amount of vehicles in Tokto
                    }
                    if (bits[0] == "Truck")
                    {
                        Truck t = new Truck(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                            bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));//uses each part of the vehicle to create an instance of the truck class
                        TokyoItems.Add(t);//adds the truck instance to the list of vehicles in Tokyo
                        i++;
                        tokyoCount++;
                    }
                    if (bits[0] == "Helicopter")
                    {
                        Helicopter h = new Helicopter(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                           bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));//uses each part of the vehicle to create an instance of the helicopter class
                        TokyoItems.Add(h);//adds the helicopter instance to the list of vehicles in Tokyo
                        i++;
                        tokyoCount++;
                    }

                    if (bits[0] == "Plane")
                    {
                        Plane p = new Plane(bits[0], bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]),
                            bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                        TokyoItems.Add(p);//adds the plane instance to the list of vehicles in Tokyo
                        i++;
                        tokyoCount++;
                    }


                    if (i == tokyoData.Length)
                    {
                        break;
                    }
                }
                while (tokyoData[i].Split(',').Length > 1);
            }

        }

        private void selectLocation_Click(object sender, EventArgs e)
        {
            if (locationsList.SelectedIndex == 0)
            //if the user selects lisbon
            {
                Form myForm = new Vehicles(LisbonItems);
                //displays the vehicles available in Lisbon on the vehicles form
                myForm.Show();
            }

            if (locationsList.SelectedIndex == 1)
            //if the user selects london
            {
                Form myForm = new Vehicles(LondonItems);
                //displays the vehicles available in London on the vehicles form
                myForm.Show();
            }
            if (locationsList.SelectedIndex == 2)
            //if the user selects paris
            {
                Form myForm = new Vehicles(ParisItems);
                //displays the vehicles available in Paris on the vehicles form
                myForm.Show();
            }
            if (locationsList.SelectedIndex == 3)
            //if the user selects tokyo
            {
                Form myForm = new Vehicles(TokyoItems);
                //////displays the vehicles available in Tokyo on the vehicles form
                myForm.Show();
            }

        }
    }
}
