using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    sealed class ColoursList<C>
    {
        private Knot<C> head; //List start
        private Knot<C> d; //First list interface
        private Knot<C> d2; //Second list interface
        private Knot<C> d3; //Third list interface
        /// <summary>
        /// Constructor with no parameters
        /// </summary>
        public ColoursList()
        {
            this.head = null;
            this.d = null;
            this.d2 = null;
            this.d3 = null;
        }
        /// <summary>
        /// Method to get beginning of data
        /// </summary>
        public void Start()
        {
            d = head;
        }
        /// <summary>
        /// Method for selecting next element
        /// </summary>
        public void Next()
        {
            d = d.Next;
        }
        /// <summary>
        /// Method to check if element exists
        /// </summary>
        /// <returns>result</returns>
        public bool Exists()
        {
            return d != null;
        }
        /// <summary>
        /// Method to get data
        /// </summary>
        /// <returns>data</returns>
        public C GetData()
        {
            return d.Data;
        }
        /// <summary>
        /// Method to get beginning of data
        /// </summary>
        public void Start2()
        {
            d2 = head;
        }
        /// <summary>
        /// Method for selecting next element
        /// </summary>
        public void Next2()
        {
            d2 = d2.Next;
        }
        /// <summary>
        /// Method to check if element exists
        /// </summary>
        /// <returns>bool result</returns>
        public bool Exists2()
        {
            return d2 != null;
        }
        /// <summary>
        /// Method to get data
        /// </summary>
        /// <returns>data</returns>
        public C GetData2()
        {
            return d2.Data;
        }
        /// <summary>
        /// Method to get beginning of data
        /// </summary>
        public void Start3()
        {
            d3 = head;
        }
        /// <summary>
        /// Method for selecting next element
        /// </summary>
        public void Next3()
        {
            d3 = d3.Next;
        }
        /// <summary>
        /// Method to check if element exists
        /// </summary>
        /// <returns>bool result</returns>
        public bool Exists3()
        {
            return d3 != null;
        }
        /// <summary>
        /// Method to get data
        /// </summary>
        /// <returns>data</returns>
        public C GetData3()
        {
            return d3.Data;
        }
        /// <summary>
        /// Method to add data to array
        /// </summary>
        /// <param name="Data">Data to be added</param>
        public void AddData (C Data)
        {
            var add = new Knot<C>(Data, null);
            add.Next = head;
            head = add;
        }
    }
}