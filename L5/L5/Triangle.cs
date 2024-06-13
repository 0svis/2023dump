using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    internal class Triangle
    {
        public string Color { get; private set; }
        public string Order { get; private set; }
        public double Perimetre { get; private set; }
        /// <summary>
        /// class constructor without parameters
        /// </summary>
        public Triangle()
        {
            Color = "";
            Order = "";
            Perimetre = 0.0;
        }
        /// <summary>
        /// class constructor with parameters
        /// </summary>
        /// <param name="Color">Color</param>
        /// <param name="Order">Order</param>
        /// <param name="Perimetre">Perimetre</param>
        public Triangle(string Color, string Order, double Perimetre)
        {
            this.Color = Color;
            this.Order = Order;
            this.Perimetre = Perimetre;
        }
        /// <summary>
        /// overrided GetHashCode method
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Overrided ToString method
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            string line = string.Format("| {0, -8} | {1, -8} | {2, -8}", Color, Order, Perimetre);
            return line;
        }
    }
}
