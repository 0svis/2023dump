using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    internal class Car
    {
        public string model;
        public int passengerAmount;
        public double fuelConsumption;
        public Car (string model, int passengerAmount, double fuelConsumption)
        {
            this.model = model;
            this.passengerAmount = passengerAmount;
            this.fuelConsumption = fuelConsumption;
        }
        public override string ToString()
        {
            string line;
            line = string.Format("{0, 20}, {1}, {2}l/100km", model, passengerAmount, fuelConsumption);
            return line;
        }
        public string GetModel() { return model; }
        public int GetPassengerAmount() { return passengerAmount; }
        public double GetFuelConsumption() { return fuelConsumption; }
    }
}
