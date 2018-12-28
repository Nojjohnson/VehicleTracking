using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleTracking
{
    public class Bike : Vehicle
    {
        private int mEngineCapacity = 0;
        public int EngineCapacity
        {
            get
            {
                return mEngineCapacity;
            }
            set
            {
                mEngineCapacity = value;
            }
        }

        //Empty constructor
        public Bike() : base()
        {
        }
        //Constructor
        public Bike(string make, string model, eVehicleCondition condition, double price, int engineCapacity) : base(make, model, condition, price)
        {
            EngineCapacity = engineCapacity;
        }

        //ToString method
        public override string ToString()
        {
            return base.ToString() + ", Engine capacity : " + EngineCapacity;
        }

    }

}
