using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleTracking
{
    class Car : Vehicle
    {
        private int mPassengerCapacity = 0;
        public int PassengerCapacity
        {
            get
            {
                return mPassengerCapacity;
            }
            set
            {
                mPassengerCapacity = value;
            }
        }

        //Empty constructor - used to store instances of the class in an array
        public Car() :base()
        {
        }
        //Constructor
        public Car(string make, string model, eVehicleCondition condition, double price, int passengerCapacity) : base(make, model, condition, price)
        {
            PassengerCapacity = passengerCapacity;
        }

        //ToString method
        public override string ToString()
        {
            return base.ToString() + ", Passenger capacity : " + PassengerCapacity;
        }
    }
}
