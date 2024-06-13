using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_5
{
    public sealed class CompanyCars : IEnumerable
    {
        private Knot b; // List Beginning
        private Knot e; // List Ending
        private Knot eb; // List Ending (Bonus)
        private Knot i; // List Interface
        /// <summary>
        /// Constructor with no elements
        /// </summary>
        public CompanyCars()
        {
            e = new Knot(null, null);
            b = new Knot(null, e);
            eb = b;
            i = null;
        }
        /// <summary>
        /// Method to get the begging of data from node
        /// </summary>
        public void Beginning()
        {
            i = b.Next;
        }
        /// <summary>
        /// Method for selecting the next element in node
        /// </summary>
        public void Move()
        {
            i = i.Next;
        }
        /// <summary>
        /// Method for checking if the next element exists in node
        /// </summary>
        /// <returns></returns>
        public bool Exists()
        {
            return i.Next != null;
        }
        /// <summary>
        /// IEnumerator method
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            for (Knot i = b; i != null; i = i.Next)
            {
                yield return i.Data;
            }
        }
        /// <summary>
        /// Method for taking data of element
        /// </summary>
        /// <returns></returns>

        public Car GetData() { return i.Data; }

        /// <summary>
        /// Puts data in reverse order
        /// </summary>
        /// <param name="Data">data</param>
        public void PutDataA(Car Data)
        {
            var i = new Knot(Data, b.Next);
            b.Next = i;
        }
        /// <summary>
        /// Puts data in regular order
        /// </summary>
        /// <param name="Data">data</param>
        public void PutDataT(Car Data)
        {
            eb.Next = new Knot(Data, e);
            eb = eb.Next;
        }
        /// <summary>
        /// sorting method using the bubble cycle
        /// </summary>
        public void Bubble()
        {
            if (b.Next.Next == null) { return; }
            bool changed = true;
            while (changed)
            {
                changed = false;
                Knot i = b.Next;
                while (i.Next.Next != null)
                {
                    if (i.Next.Data <= i.Data)
                    {
                        Car n = i.Data;
                        i.Data = i.Next.Data;
                        i.Next.Data = n;
                        changed = true;
                    }
                    i = i.Next;
                }
            }
        }
        /// <summary>
        /// Method for removing certain elements
        /// </summary>
        /// <param name="Data">Given collection
        /// </param>
        public void Remove(Car Data)
        {
            Knot x = b;
            while (x != null && x.Next != null && x.Next.Data != Data)
                x = x.Next;
            Knot delete = x.Next;
            x.Next = x.Next.Next;
            delete.Data = null;
            delete = null;
        }

    }
}
