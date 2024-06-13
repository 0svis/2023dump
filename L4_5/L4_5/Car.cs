using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_5
{
    public class Car
    {
        public string model { get; set; }
        public int passengers { get; set; } 
        public double fuelCons { get; set; }
        /// <summary>
        /// Class constructor: gives meanings to the
        /// </summary>
        /// <param model="model"> model/brand of a car </param>
        /// <param model="ppl"> How many passengers can the car fit </param>
        /// <param model="fuel"> Gas mileage </param>
        public Car(string model = "", int passengers = 0, double fuelCons = 0)
        {
            this.model = model;
            this.passengers = passengers;
            this.fuelCons = fuelCons;
        }
        /// <summary>
        /// constructor with elements
        /// </summary>
        /// <param model="a">model</param>
        /// <param model="b"></param>
        /// <param model="c"></param>
        void PutIn(string a, int b, double c)
        {
            model = a;
            passengers = b;
            fuelCons = c;
        }
        /// <summary>
        /// Covered method ToString()
        /// </summary>
        /// <returns> nicely formed line </returns>
        public override string ToString()
        {
            string line;
            line = string.Format("{0, -20} {1, 6} {2, 15}", model, passengers, fuelCons);
            return line;
        }
        /// <summary>
        /// overlapped GetHashCode method
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Bool operator thar compares first and second elements
        /// </summary>
        /// <param name="first">first element</param>
        /// <param name="second">second element</param>
        /// <returns>result of comparision</returns>
        public static bool operator >=(Car first, Car second)
        {
            return first.passengers > second.passengers 
                || first.passengers == second.passengers &&
                first.fuelCons > second.fuelCons;
        }
        /// <summary>
        /// Bool operator that compares first and second elements
        /// </summary>
        /// <param name="first">first element</param>
        /// <param name="second">second element</param>
        /// <returns>result of comparision</returns>
        public static bool operator <=(Car first, Car second)
        {
            return first.passengers > second.passengers 
                || first.passengers == second.passengers &&
                first.fuelCons > second.fuelCons;
        }
    }
}