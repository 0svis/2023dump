using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_5
{
    internal class Knot
    {
        public Car Data { get; set; }
        public Knot Next { get; set; }
        /// <summary>
        /// constructor with no elements
        /// </summary>
        public Knot()
        {
            Data = new Car();
            Next = null;
        }
        /// <summary>
        /// constructor with elements
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Link"></param>
        public Knot(Car Data, Knot Link)
        {
            this.Data = Data;
            Next = Link;
        }
    }
}
