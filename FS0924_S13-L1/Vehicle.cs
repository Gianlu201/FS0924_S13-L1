using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS0924_S13_L1
{
    internal class Vehicle
    {
        private string _vehicleType;
        private string _producer;
        private string _plate;
        private int _nbWheels;

        public Vehicle(string vehicleType, string producer, string plate, int nbWheels)
        {
            this._vehicleType = vehicleType;
            this._producer = producer;
            this._plate = plate;
            this._nbWheels = nbWheels;
        }

        public string VeichleInfo()
        {
            return "It's a " + this._vehicleType + " and its plate is: " + this._plate;
        }
    }
}
