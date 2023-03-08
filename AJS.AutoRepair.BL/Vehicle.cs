using AJS.AutoRepair.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.AutoRepair.BL
{
    public class Vehicle : iStartable
    {
        // fields
        private int year;

        // properties
        public bool IsRunning { get; set; } = false;

        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1900) year = value;
                else throw new InvalidYearException(value);
            }
        }



        public Vehicle() { }
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }


        public override string ToString()
        {
            return Make + " " + Model + " (" + Year + ")";
        }

        public void Start()
        {
            //do stuff
            IsRunning = true;
        }
    }
}
