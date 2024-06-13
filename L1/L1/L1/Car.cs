using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    /// <summary>
    /// Class for storing data per car
    /// </summary>
    internal class Car
    {
        public string model;
        public int passengerAmount;
        public double fuelConsumption;
        /// <summary>
        /// Class constructor, assigns values to properties
        /// </summary>
        /// <param name="model">Car model</param>
        /// <param name="passengerAmount">Amount of passengers that
        /// can sit in the car</param>
        /// <param name="fuelConsumption">Fuel consumption, 
        /// per l/100km</param>
        public Car (string model, int passengerAmount, double fuelConsumption)
        {
            this.model = model;
            this.passengerAmount = passengerAmount;
            this.fuelConsumption = fuelConsumption;
        }
        /// <summary>
        /// Override method
        /// </summary>
        /// <returns>Returns formatted string</returns>
        public override string ToString()
        {
            string line;
            line = string.Format("{0, 20}, {1}, {2}l/100km", 
                model, passengerAmount, fuelConsumption);
            return line;
        }
        /// <summary>
        /// Returns model name
        /// </summary>
        /// <returns>Model name</returns>
        public string GetModel() { return model; }
        /// <summary>
        /// Returns amount of passenger that can handle the car
        /// </summary>
        /// <returns>Amount of passenger</returns>
        public int GetPassengerAmount() { return passengerAmount; }
        /// <summary>
        /// Returns car's fuel consumption
        /// </summary>
        /// <returns>Car's fuel consumption</returns>
        public double GetFuelConsumption() { return fuelConsumption; }
    }
}
