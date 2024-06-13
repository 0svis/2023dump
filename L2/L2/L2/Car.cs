using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    /// <summary>
    /// Class for storing data per car
    /// </summary>
    internal class Car
    {
        public string model { get; set; }
        public int passengerAmount { get; set; }
        public double fuelConsumption { get; set; }
        /// <summary>
        /// Class constructor, assigns values to properties
        /// </summary>
        /// <param name="model">Car model</param>
        /// <param name="passengerAmount">Amount of passengers that
        /// can sit in the car</param>
        /// <param name="fuelConsumption">Fuel consumption, 
        /// per l/100km</param>
        public Car(string model, int passengerAmount, double fuelConsumption)
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
        public string ToStringCSV()
        {
            string line;
            line = string.Format("{0},{1},{2}", model, passengerAmount, fuelConsumption);
            return line;
        }
        public bool Compare (Car Two)
        {
            return this.passengerAmount > Two.passengerAmount || (this.passengerAmount == Two.passengerAmount && this.fuelConsumption > Two.fuelConsumption);
        }
    }
}