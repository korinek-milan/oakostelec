using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vozidla
{
    internal class Vehicle
    {
        int VehicleId;
        public string Brand { get; private set; }
        public string Model { get; private set; }
        int Year;
        public double PricePerDay { get; private set; }

        public Vehicle(int _VehicleId, string _Brand, string _Model, int _Year, double _PricePerDay)
        {
            VehicleId = _VehicleId;
            Brand = _Brand;
            Model = _Model;
            Year = _Year;
            PricePerDay = _PricePerDay;
        }

        //lepší než nic, horší než getter
        public int vratVehicleID()
        {
            return VehicleId;
        }
    }
}
