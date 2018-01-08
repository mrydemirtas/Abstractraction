using Abstractraction.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstractraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Audi[] audis = new Audi[2];

            Audi a1 = new Audi();
            a1.ModelYear = 2015;
            a1.Model = "a5";
            a1.DoorCount = 4;

            Audi a2 = new Audi();
            a2.Model = "a3";
            a2.ModelYear = 2012;
            a2.DoorCount = 2;

            audis[0] = a1;
            audis[1] = a2;


            Vehicle[] vehicles = new Vehicle[3]; //Boxing

            AirPlane plane = new AirPlane();
            plane.EngineNumber = "95121212";
            string type1 = plane.StartEngine();
            string f1 = plane.DriveStyle();

            Bus bs = new Bus();
            string type2 = bs.StartEngine();
            string f2 = bs.DriveStyle();

            vehicles[0] = plane;
            vehicles[1] = bs;


            foreach (var item in vehicles)
            {
                if (item is AirPlane)
                {
                    var airPlane = item as AirPlane;
                    MessageBox.Show(airPlane.FuelType);
                }
                else if (item is Bus)
                {
                    var buss = item as Bus;
                    MessageBox.Show(buss.FuelType);
                }
            }


        }
    }
}
