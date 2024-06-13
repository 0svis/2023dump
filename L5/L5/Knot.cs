using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    public sealed class Knot<C>
    {
        public C Data { get; set; }
        public Knot<C> Next { get; set; }
        /// <summary>
        /// Knot constructor without parameters
        /// </summary>
        public Knot()
        {
        }
        /// <summary>
        /// Knot constructor with parameters
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Next"></param>
        public Knot (C Data, Knot<C> Next)
        {
            this.Data = Data;
            this.Next = Next;
        }
    }
}
