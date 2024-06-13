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
        //------------------------------------------------
        // Graphic user interface methods
        //------------------------------------------------
        public window()
        {
            InitializeComponent();
            if (File.Exists(CFr))
                File.Delete(CFr);
            enter.Enabled = false;
            find.Enabled = false;
            textLabel.Text = "Enter your desired fuel consumption \nand " +
                "press \"Enter\" to confirm your entry";
        }
        /// <summary>
        /// Actions when "Start" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Actions when "Enter" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enter_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Entry submitted successfully";
            double fuelConsumption = Convert.ToDouble(enteredFuel.Text);
            find.Enabled=true;
        }
        /// <summary>
        /// Actions when "Find" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void find_Click(object sender, EventArgs e)
        {
            results.Clear();
            double fuelConsumption = Convert.ToDouble(enteredFuel.Text);
            CarsBelowFuelCons = NewContainer(CompanyOneCars, CompanyTwoCars);
            CarsBelowFuelCons.Sort();
            CustomDataToString(CFr, CarsBelowFuelCons, "Both companies cars " +
                "that has lower fuel consumption than biggest " +
                "car", fuelConsumption);
            string frez = File.ReadAllText(CFr);
            results.Text = frez;
        }
        /// <summary>
        /// Actions when "Close" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Actions when "Restart" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restart_Click_1(object sender, EventArgs e)
        {
            results.Clear();
            find.Enabled = false;
            enter.Enabled = false;
            textLabel.Text = "Enter your desired fuel consumption \nand " +
                "press \"Enter\" to confirm your entry";
            if (File.Exists(CFr))
            {
                File.Delete(CFr);
            }
        }
        /// <summary>
        /// Actions when "Go" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void go_Click(object sender, EventArgs e)
        {
            results.Clear();
            PrintingCalculations(CFr, CompanyOneCars, CompanyTwoCars);
            DataToString(CFr, CompanyOneCars, "First company cars");
            DataToString(CFr, CompanyTwoCars, "Second company cars");
            string frez = File.ReadAllText(CFr);
            results.Text += frez;
        }
        /// <summary>
        /// Read data file and adds data to container
        /// </summary>
        /// <param name="file">File name</param>
        /// <param name="Container">Container name</param>
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
        /// <summary>
        /// Finds most economical car of the container
        /// </summary>
        /// <param name="companyCars">Container name</param>
        /// <returns>position digit that most economical 
        /// car is in the array</returns>
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
        /// <summary>
        /// Finds biggest car of the container
        /// </summary>
        /// <param name="companyCars">Container name</param>
        /// <returns>Position digit that most economical car 
        /// is in the array</returns>
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
        /// <summary>
        /// Forms a new container from elements that fulfill requirements
        /// </summary>
        /// <param name="companyOneCars">First container name</param>
        /// <param name="companyTwoCars">Second container name</param>
        /// <returns>A new container</returns>
        static CompanyCars NewContainer(CompanyCars companyOneCars, 
            CompanyCars companyTwoCars) 
        {
            CompanyCars CarsBelowFuelCons = new CompanyCars();
            int tempIntOne = MostPassengers(companyOneCars);
            int tempIntTwo = MostPassengers(companyTwoCars);
            double fuelConsumtion;
            if (companyOneCars.GetCar(tempIntOne).passengerAmount > 
                companyTwoCars.GetCar(tempIntTwo).passengerAmount)
            {
                fuelConsumtion = 
                    companyOneCars.GetCar(tempIntOne).fuelConsumption;
            }
            else { fuelConsumtion = 
                    companyTwoCars.GetCar(tempIntTwo).fuelConsumption; }
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
        /// <summary>
        /// Prints data to results file
        /// </summary>
        /// <param name="fv">File name</param>
        /// <param name="companyCars">Container name</param>
        /// <param name="heading">Text that should appear on the top</param>
        static void DataToString (string fv, CompanyCars companyCars, 
            string heading)
        {
            const string up =
                 "-------------------------------------------------------" +
                 "-------------------------------------\r\n"
                + "   Model   Passenger amount  Fuel consumption (l/100km) " +
                "\r\n"
                + "-------------------------------------------------------" +
                "-------------------------------------";
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append)))
            {
                fr.WriteLine(heading);
                fr.WriteLine(up);
                for (int i=0; i<companyCars.arraySize; i++) 
                {
                    Car car= companyCars.GetCar(i);
                    fr.WriteLine(car.ToString());
                }
                fr.WriteLine("---------------------------------------------" +
                    "-----------------------------------------------\n");
            }
        }
        /// <summary>
        /// Prints custom data to results file
        /// </summary>
        /// <param name="fv">File name</param>
        /// <param name="companyCars">Container name</param>
        /// <param name="heading">Text that should appear on the top</param>
        /// <param name="fuelConsumption">Digit entered by the keyboard</param>
        static void CustomDataToString(string fv, CompanyCars companyCars, 
            string heading, double fuelConsumption)
        {
            const string up =
                 "---------------------------------------------------------" +
                 "-----------------------------------\r\n"
                + "   Model   Passenger amount  Fuel consumption (l/100km) " +
                "\r\n"
                + "-------------------------------------------------------" +
                "-------------------------------------";
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
                fr.WriteLine("----------------------------------------------" +
                    "----------------------------------------------\n");
            }
        }
        static void PrintingCalculations(string fv, CompanyCars companyOneCars, CompanyCars companyTwoCars)
        {
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append)))
            {
                fr.WriteLine("Least fuel consuming car of ''" +
                    companyOneCars.GetCompanyName() + "'' company: " +
                    companyOneCars.GetCar(MostEconomicalCar(companyOneCars)).
                    ToString() + "\n");
                fr.WriteLine("Least fuel consuming car of ''"
                    + companyTwoCars.GetCompanyName() + "'' company: "
                    + companyTwoCars.GetCar(MostEconomicalCar(companyTwoCars)).
                    ToString() + "\n\n");
                fr.WriteLine("Biggest car of ''" +
                    companyOneCars.GetCompanyName() + "'' company: " +
                    companyOneCars.GetCar(MostPassengers(companyOneCars))
                    .ToString() + "\n");
                fr.WriteLine("Biggest car of ''" +
                    companyTwoCars.GetCompanyName() + "'' company: "
                    + companyTwoCars.GetCar(MostPassengers(companyTwoCars)).
                    ToString() + "\n\n");
            }
        }
    }
}
