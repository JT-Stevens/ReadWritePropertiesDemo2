using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    public class Car
    {
        private int? speed;
        private Nullable<decimal> price;
        private int numberOfDoors;
        private string carType;

        public int? Year { get; set; }

        public int? Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Nullable<decimal> Price
        {
            get { return price; }
            set { price = value; }
        }

        public int NumberOfDoors
        {
            get
            {
                return numberOfDoors;
            }
            set
            {
                //Ensure the value < 10
                if (value < 10)
                {
                    numberOfDoors = value;
                }
            }
        }

        public string CarType { get; set; }
    }
}
