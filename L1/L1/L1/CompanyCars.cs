using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    /// <summary>
    /// Container to save all car data for company
    /// </summary>
    internal class CompanyCars
    {
        const int Cn = 500;
        private Car[] OneCar;
        public int arraySize { get; set; }
        public string companyName;
        /// <summary>
        /// Class constructor with no parameters
        /// </summary>
        public CompanyCars()
        {
            arraySize = 0;
            OneCar = new Car[Cn];
        }
        /// <summary>
        /// Returns the car object of the specified index
        /// </summary>
        /// <param name="i">Specified index</param>
        /// <returns>Returns car object</returns>
        public Car GetCar(int i)
        {
            return OneCar[i];
        }
        /// <summary>
        /// Adds a new car to the end of the array
        /// </summary>
        /// <param name="request">Spcified new car data</param>
        public void PlaceCar(Car request)
        {
            OneCar[arraySize++]=request;
        }
        /// <summary>
        /// Method for setting company name
        /// </summary>
        /// <param name="name">Desired company name</param>
        public void SetCompanyName(string name) { companyName = name; }
        /// <summary>
        /// Returns object's company name
        /// </summary>
        /// <returns>Company name</returns>
        public string GetCompanyName() { return companyName; }
        /// <summary>
        /// Sorts the array
        /// </summary>
        public void Sort()
        {
            for (int write=0; write < arraySize - 1; write++) 
            {
                for (int sort=0; sort < arraySize - 1; sort++) 
                {
                    if (OneCar[sort].GetPassengerAmount() < 
                        OneCar[sort + 1].GetPassengerAmount())
                    {
                        Car temp = OneCar[sort+1];
                        OneCar[sort+1] = OneCar[sort];
                        OneCar[sort] = temp;
                    }
                }
            }
        }
    }
}
