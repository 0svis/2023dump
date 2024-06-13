using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    /// <summary>
    /// Data class for orders
    /// </summary>
    public class ColoursOrders
    {
        public string Color { get; private set; }
        public string Order { get; private set; }
        /// <summary>
        /// Class constructor
        /// </summary>
        public ColoursOrders()
        {
            Color = "";
            Order = "";
        }
        /// <summary>
        /// Class constructor with parameters
        /// </summary>
        /// <param name="Color">Colour</param>
        /// <param name="Order">Order</param>
        public ColoursOrders (string Color, string Order)
        {
            this.Color = Color;
            this.Order = Order;
        }
        /// <summary>
        /// Overlaped GetHashCode Method
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Overlaped ToString method
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string line = string.Format("| {0, -7} | {1,-5} |", Color, Order);
            return line;
        }
    }
}