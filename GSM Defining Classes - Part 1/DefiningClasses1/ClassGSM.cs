/*
 Problem 1. Define class

Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
 * battery characteristics (model, hours idle and hours talk) and 
 * display characteristics (size and number of colors).
Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
    public class ClassGSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;

        // constructors
        public ClassGSM()
        {
            this.model = "[unknown]";
            this.manufacturer = "[no data for country]";
        }

        public ClassGSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public ClassGSM(Battery battery)
        {
            this.Battery = battery;
        }

        // properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }


        // methods
        public override string ToString()
        {
            return String.Format(@"Battery: {0}", this.Battery.TypeBattery.ToString());
        }

    }
}
