using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSpeedApp
{
    class Vehicle
    {
        private string vehicleName;
        private string vehicleRegNo;
        private double vehicleSpeedSum = 0;

        private double minSpeed;
        private double maxSpeed;
        private double aversgeSpeed;

        public string VehicleName
        {
            //get { return vehicleName; }
            set { vehicleName = value; }
        }

        public string VehicleRegNo
        {
            //get { return vehicleRegNo; }
            set { vehicleRegNo = value; }
        }

        public double counter;
        public double VehicleSpeedSum
        {
            //get { return vehicleSpeedSum; }
            set
            {
                counter++;
                vehicleSpeedSum += value;

            }
        }

        public double MinSpeed
        {
            get { return minSpeed; }
            set
            {
                if (minSpeed == 0)
                {
                    minSpeed = value;
                }
                else if (value < minSpeed)
                {
                    minSpeed = value;
                }


            }
        }

        public double MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (maxSpeed == 0)
                {
                    maxSpeed = value;
                }
                else if (value > maxSpeed)
                {
                    maxSpeed = value;
                }

            }
        }

        public double AversgeSpeed
        {
            get
            {
                aversgeSpeed = vehicleSpeedSum / counter;
                return aversgeSpeed;
            }
        }


    }
}
