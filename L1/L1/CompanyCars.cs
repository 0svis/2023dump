using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    internal class CompanyCars
    {
        const int Cn = 500;
        private Car[] OneCar;
        public int arraySize { get; set; }
        public string companyName;
        public CompanyCars()
        {
            arraySize = 0;
            OneCar = new Car[Cn];
        }
        public Car GetCar(int i)
        {
            return OneCar[i];
        }
        public void PlaceCar(Car request)
        {
            OneCar[arraySize++]=request;
        }
        public void SetCompanyName(string name) { companyName = name; }
        public string GetCompanyName() { return companyName; }
        public void Sort()
        {
            for (int write=0; write < arraySize - 1; write++) 
            {
                for (int sort=0; sort < arraySize - 1; sort++) 
                {
                    if (OneCar[sort].GetPassengerAmount() < OneCar[sort + 1].GetPassengerAmount())
                    {
                        Car temp = OneCar[sort+1];
                        OneCar[sort+1] = OneCar[sort];
                        OneCar[sort] = temp;
                    }
                }
            }
        }
        public void Remove(double enteredFuel)
        {
            for (int i=0; i<arraySize; i++)
            {
                if (OneCar[i].GetFuelConsumption() > enteredFuel)
                {
                    for (int j=i; j<arraySize-1; j++)
                    {
                        OneCar[j] = OneCar[j + 1];
                        arraySize = arraySize - 1;
                        i = i - 1;
                    }
                }
            }
        }
    }
}
