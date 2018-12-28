using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleTracking
{
    public class Vehicle
    {

        #region Properties
        //The 'make' property
        private string mMake = "";
        public string make
        {
            get
            {
                return mMake;
            }
            set
            {
                mMake = value;
            }
        }
        //The 'model' property
        private string mModel = "";
        public string model
        {
            get
            {
                return mModel;
            }
            set
            {
                mModel = value;
            }
        }
   

        //The 'condition' property
        private eVehicleCondition mCondition;
        public eVehicleCondition condition
        {
            get
            {
                return mCondition;
            }
            set
            {
                mCondition = value;
            }
        }
        //The 'price' property
        private double mPrice = 0;
        public double price
        {
            get
            {
                return mPrice;
            }
            set
            {
                if (value > 0)
                {
                    mPrice = value;
                }
                else
                {
                    mPrice = 0;
                }
            }
        }
        #endregion

        //Empty constructor
        public Vehicle()
        {
        }

        //Constructor
        public Vehicle(string newMake, string newModel, eVehicleCondition newCondition, double newPrice)
        {
            make = newMake;
            model = newModel;
            condition = newCondition;
            price = newPrice;
        }
    }
}
