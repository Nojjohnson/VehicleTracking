using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleTracking
{
    public class Truck : Vehicle
    {
        //Properties
        private int mCargoCapacity = 0;
        public int CargoCapacity
        {
            get
            {
                return mCargoCapacity;
            }
            set
            {
                mCargoCapacity = value;
            }
        }

        //Empty constructor
        public Truck() : base()
        {
        }
        //Constructor
        public Truck(string make, string model, eVehicleCondition condition, double price, int cargoCapacity) : base (make, model, condition, price)
        {
            CargoCapacity = cargoCapacity;
        }

        //ToString method
        public override string ToString()
        {
            return base.ToString() + ", Cargo capacity : " + CargoCapacity;
        }



    }
}


