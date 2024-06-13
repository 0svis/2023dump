using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1
{
    public partial class window : Form
    {
        const string CFd1 = "..\\..\\Company1.txt";
        const string CFd2 = "..\\..\\Company2.txt";
        const string CFr = "..\\..\\Results.txt";
        CompanyCars CompanyOneCars = new CompanyCars();
        CompanyCars CompanyTwoCars = new CompanyCars();
        CompanyCars CarsBelowFuelCons = new CompanyCars();
        public window()
        {
            InitializeComponent();
            if (File.Exists(CFr))
                File.Delete(CFr);
            enter.Enabled = false;
            find.Enabled = false;
            textLabel.Text = "Enter your desired fuel consumption \nand press \"Enter\" to confirm your entry";
        }

        private void start_Click(object sender, EventArgs e)
        {
            string data1 = File.ReadAllText(CFd1);
            string data2 = File.ReadAllText(CFd2);
            results.Clear();
            results.Text = data1 + "\n\n" + data2 + "\n\n";
            ReadDataFile(CFd1, CompanyOneCars);
            ReadDataFile(CFd2, CompanyTwoCars);
            enter.Enabled=true;
            
        }
        private void enter_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Entry submitted successfully";
            double fuelConsumption = Convert.ToDouble(enteredFuel.Text);
            find.Enabled=true;
        }
        private void find_Click(object sender, EventArgs e)
        {
            results.Clear();
            double fuelConsumption = Convert.ToDouble(enteredFuel.Text);
            CarsBelowFuelCons = NewContainer(CompanyOneCars, CompanyTwoCars);
            CarsBelowFuelCons.Sort();
            CustomDataToString(CFr, CarsBelowFuelCons, "Both companies cars that has lower fuel consumption than biggest car", fuelConsumption);
            string frez = File.ReadAllText(CFr);
            results.Text = frez;
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void restart_Click(object sender, EventArgs e)
        {
            results.Clear();
            find.Enabled=false;
            enter.Enabled = false;
            textLabel.Text = "Enter your desired fuel consumption \nand press \"Enter\" to confirm your entry";

        }
        private void go_Click(object sender, EventArgs e)
        {
            results.Clear();
            results.Text = "Least fuel consuming car of ''" + CompanyOneCars.GetCompanyName() + "'' company: " + CompanyOneCars.GetCar(MostEconomicalCar(CompanyOneCars)).ToString() + "\n";
            results.Text += "Least fuel consuming car of ''" + CompanyTwoCars.GetCompanyName() + "'' company: " + CompanyTwoCars.GetCar(MostEconomicalCar(CompanyTwoCars)).ToString() + "\n\n";
            results.Text += "Biggest car of ''" + CompanyOneCars.GetCompanyName() + "'' company: " + CompanyOneCars.GetCar(MostPassengers(CompanyOneCars)).ToString() + "\n";
            results.Text += "Biggest car of ''" + CompanyTwoCars.GetCompanyName() + "'' company: " + CompanyTwoCars.GetCar(MostPassengers(CompanyTwoCars)).ToString() + "\n\n";
            DataToString(CFr, CompanyOneCars, "First company cars");
            DataToString(CFr, CompanyTwoCars, "Second company cars");
            string frez = File.ReadAllText(CFr);
            results.Text += frez;
        }
        static void ReadDataFile(string file, CompanyCars Container)
        { 
            using (StreamReader reader = new StreamReader(file)) 
            {
                Container.SetCompanyName(reader.ReadLine());
                string line;
                while ((line=reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Car IndividualCar = new Car(parts[0], 
                        Convert.ToInt32(parts[1]), 
                        Convert.ToDouble(parts[2]));
                    Container.PlaceCar(IndividualCar);
                }
            }
        }
        static int MostEconomicalCar(CompanyCars companyCars) 
        {
            double lowestCons = double.MaxValue;
            int saveNumber = -1;
            for (int i=0; i<companyCars.arraySize; i++) 
            {
                if (companyCars.GetCar(i).fuelConsumption < lowestCons) 
                {
                    lowestCons = companyCars.GetCar(i).fuelConsumption;
                    saveNumber = i;
                }
            }
            return saveNumber;
        }
        static int MostPassengers(CompanyCars companyCars) 
        {
            int mostPass = int.MinValue;
            int saveNumber = -1;
            for (int i = 0; i < companyCars.arraySize; i++)
            {
                if (companyCars.GetCar(i).passengerAmount > mostPass)
                {
                    mostPass = companyCars.GetCar(i).passengerAmount;
                    saveNumber = i;
                }
            }
            return saveNumber;
        }
        static CompanyCars NewContainer(CompanyCars companyOneCars, CompanyCars companyTwoCars) 
        {
            CompanyCars CarsBelowFuelCons = new CompanyCars();
            int tempIntOne = MostPassengers(companyOneCars);
            int tempIntTwo = MostPassengers(companyTwoCars);
            double fuelConsumtion;
            if (companyOneCars.GetCar(tempIntOne).passengerAmount > companyTwoCars.GetCar(tempIntTwo).passengerAmount)
            {
                fuelConsumtion = companyOneCars.GetCar(tempIntOne).fuelConsumption;
            }
            else { fuelConsumtion = companyTwoCars.GetCar(tempIntTwo).fuelConsumption; }
            for (int i=0; i<companyOneCars.arraySize; i++)
            {
                if (companyOneCars.GetCar(i).fuelConsumption < fuelConsumtion)
                {
                    CarsBelowFuelCons.PlaceCar(companyOneCars.GetCar(i));
                }
            }
            for (int i = 0; i < companyTwoCars.arraySize; i++)
            {
                if (companyTwoCars.GetCar(i).fuelConsumption < fuelConsumtion)
                {
                    CarsBelowFuelCons.PlaceCar(companyTwoCars.GetCar(i));
                }
            }
            return CarsBelowFuelCons;
        }
        static void DataToString (string fv, CompanyCars companyCars, string heading)
        {
            const string up =
                 "--------------------------------------------------------------------------------------------\r\n"
                + "   Model   Passenger amount  Fuel consumption (l/100km) \r\n"
                + "--------------------------------------------------------------------------------------------";
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append)))
            {
                fr.WriteLine(heading);
                fr.WriteLine(up);
                for (int i=0; i<companyCars.arraySize; i++) 
                {
                    Car car= companyCars.GetCar(i);
                    fr.WriteLine(car.ToString());
                }
                fr.WriteLine("--------------------------------------------------------------------------------------------\n");
            }
        }
        static void CustomDataToString(string fv, CompanyCars companyCars, string heading, double fuelConsumption)
        {
            companyCars.Remove
            const string up =
                 "--------------------------------------------------------------------------------------------\r\n"
                + "   Model   Passenger amount  Fuel consumption (l/100km) \r\n"
                + "--------------------------------------------------------------------------------------------";
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append)))
            {
                fr.WriteLine(heading);
                fr.WriteLine(up);
                for (int i = 0; i < companyCars.arraySize; i++)
                {
                    Car car = companyCars.GetCar(i);
                    if (car.fuelConsumption <= fuelConsumption)
                    {
                        fr.WriteLine(car.ToString());
                    }
                }
                fr.WriteLine("--------------------------------------------------------------------------------------------\n");
            }
        }
    }
}
