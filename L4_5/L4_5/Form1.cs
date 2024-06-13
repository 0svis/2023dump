using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms.VisualStyles;
using System.Deployment.Application;

namespace L4_5
{
    public partial class Form1 : Form
    {
        public static System.Text.Encoding UTF8 { get; }
        CompanyCars oneCompany, twoCompany, newList;
        string oneCompanyName, twoCompanyName, CFr;
        public Form1()
        {
            InitializeComponent();
            outputFile.Enabled = false;
            mostEconomicalCars.Enabled = false;
            biggestCar.Enabled = false;
            formANewList.Enabled = false;
            sort.Enabled = false;
            button1.Enabled = false;
        }
        /// <summary>
        /// Button for choosing input files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter
                = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Choose data file";
            string data = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data = openFileDialog1.FileName;
                oneCompany = ReadCompanyContainerA(data, out oneCompanyName);
                MessageBox.Show("First data file read succesfully");
                results.Text += "\n" + File.ReadAllText(data) + "\n";
            }
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter
                = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog2.Title = "Choose data file";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                data = openFileDialog2.FileName;
                twoCompany = ReadCompanyConteinerT(data, out twoCompanyName);
                MessageBox.Show("First data file read succesfully");
                results.Text += "\n" + File.ReadAllText(data) + "\n";
            }
            inputFiles.Enabled = false;
            outputFile.Enabled = true;
        }
        /// <summary>
        /// Button for choosing results file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter 
                = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Choose results file";
            DialogResult resultFile = saveFileDialog1.ShowDialog();
            if (resultFile == DialogResult.OK)
            {
                CFr = saveFileDialog1.FileName;
                if(File.Exists(CFr))
                {
                    File.Delete(CFr);
                }
            }
            Print(CFr, oneCompany, 
                "Cars of leasing companies", oneCompanyName);
            Print(CFr, twoCompany, "", twoCompanyName);
            outputFile.Enabled = false;
            mostEconomicalCars.Enabled = true;
            biggestCar.Enabled = true;
            formANewList.Enabled = true;
            sort.Enabled = true;
            button1.Enabled = true;
        }
        /// <summary>
        /// Button for closing the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Button to find most economical cars of each company
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostEconomicalCars_Click(object sender, EventArgs e)
        {
            PrintEconomical(CFr, oneCompany, oneCompanyName);
            PrintEconomical(CFr, twoCompany, twoCompanyName);
            results.Clear();
            string temp = File.ReadAllText(CFr);
            results.Text = temp;
            mostEconomicalCars.Enabled = false;
        }
        /// <summary>
        /// Button to find biggest car of two companies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void biggestCar_Click(object sender, EventArgs e)
        {
            using (var write =
                new StreamWriter(File.Open(CFr, FileMode.Append)))
            {
                write.WriteLine();
                write.WriteLine("Biggest car is: " + 
                    BiggestCarOfTwo(oneCompany, twoCompany).model 
                    + " and it has space for " + 
                    BiggestCarOfTwo(oneCompany, twoCompany).passengers 
                    + " passengers");
                write.WriteLine();
            }
            string temp = File.ReadAllText(CFr);
            results.Clear();
            results.Text = temp;
            biggestCar.Enabled = false;
        }
        /// <summary>
        /// Button to form a new list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formANewList_Click(object sender, EventArgs e)
        {
            newList = new CompanyCars();
            double biggestCarFuel = 
                BiggestCarOfTwo(oneCompany, twoCompany).fuelCons;
            NewListCreation(ref newList, oneCompany, biggestCarFuel);
            NewListCreation(ref newList, twoCompany, biggestCarFuel);
            Print(CFr, newList, "Cars list that uses less " +
                "fuel than largest car", "");
            string temp = File.ReadAllText(CFr);
            results.Clear();
            results.Text = temp;
            formANewList.Enabled = false;
        }
        /// <summary>
        /// Button to sort the newly formed list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sort_Click(object sender, EventArgs e)
        {
            if (newList != null)
            {
                newList.Bubble();
                Print(CFr, newList, "Sorted list of " +
                    "cars in decreasing order", "");
                string temp = File.ReadAllText(CFr);
                results.Clear();
                results.Text = temp;
                sort.Enabled = false;
            }
            else results.Text += "\nCritical error, there " +
                    "is no list to sort\n";
        }
        /// <summary>
        /// Button to see the task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void task_Click(object sender, EventArgs e)
        {
            string task = "..\\..\\task.txt";
            string msg = File.ReadAllText(task);
            MessageBox.Show(msg, "Instructions for user: ");
        }
        /// <summary>
        /// Button to see instructions for user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instructionsForUser_Click(object sender, EventArgs e)
        {
            string ins = "..\\..\\instructions.txt";
            string msg = File.ReadAllText(ins);
            MessageBox.Show(msg, "Given task: ");
        }
        /// <summary>
        /// Button to remove cars that exceeds entered fuel consumption
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double enteredFuelCons = Convert.ToDouble(textBox1.Text);
            if(EconomicalCar(newList).fuelCons> enteredFuelCons) 
            {
                using (var wr 
                    = new StreamWriter(File.Open(CFr, FileMode.Append)))
                {
                    wr.WriteLine("All cars has larger " +
                        "fuel consumtion than entered");
                }
            }
            else 
            {
                Removal(newList, enteredFuelCons);
                Print(CFr, newList, 
                    "Car list with removed cars that fuel " +
                    "consumption exceeds entered fuel consumption", "");
            }
            string temp = File.ReadAllText(CFr);
            results.Clear();
            results.Text = temp;
            button1.Enabled = false;
        }
        /// <summary>
        /// Method to read data file and add data in regular order
        /// </summary>
        /// <param name="fv">Data file name</param>
        /// <param name="name">Company's name</param>
        /// <returns>List of data readed from file</returns>
        static CompanyCars ReadCompanyConteinerT(string fv, out string name)
        {
            CompanyCars cars = new CompanyCars();
            using (StreamReader reader = new StreamReader(fv)) 
            {
                string line = reader.ReadLine();
                name = line;
                while ((line = reader.ReadLine()) != null) 
                {
                    string[] parts = line.Split(';');
                    string model = parts[0];
                    int passengers = int.Parse(parts[1]);
                    double fuel = double.Parse(parts[2]);
                    Car car = new Car(model, passengers, fuel);
                    cars.PutDataT(car);
                }
            }
            return cars;
        }
        /// <summary>
        /// Method to read data file and add data in reverse order
        /// </summary>
        /// <param name="fv">Data file name</param>
        /// <param name="name">Company's name</param>
        /// <returns>List of data readed from file</returns>
        static CompanyCars ReadCompanyContainerA(string fv, out string name)
        {
            CompanyCars cars = new CompanyCars();
            using (StreamReader reader = new StreamReader(fv))
            {
                string line = reader.ReadLine();
                name = line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string model = parts[0];
                    int passengers = int.Parse(parts[1]);
                    double fuel = double.Parse(parts[2]);
                    Car car = new Car(model, passengers, fuel);
                    cars.PutDataA(car);
                }
            }
            return cars;
        }
        /// <summary>
        /// Method to print the data
        /// </summary>
        /// <param name="fv">Results file name</param>
        /// <param name="cars">List of company's cars</param>
        /// <param name="head">Heading</param>
        /// <param name="name">Company's name</param>
        static void Print(string fv, CompanyCars cars, string head, 
            string name)
        {
            const string top =
            "----------------------------------------------\r\n"
            + "      Car model name      Passengers L/100km \r\n"
            + "----------------------------------------------";
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append)))
            {
                fr.WriteLine(head);
                fr.WriteLine(name);
                fr.WriteLine(top);
                for(cars.Beginning(); cars.Exists(); cars.Move())
                {
                    if (cars.GetData() != null)
                        fr.WriteLine(cars.GetData());
                }
                fr.WriteLine("---------------------------" +
                    "-------------------\n");
            }
        }
        /// <summary>
        /// Method to print most econimal car
        /// </summary>
        /// <param name="fv">Results file name</param>
        /// <param name="cars">Company's cars list</param>
        /// <param name="which">Name of the car that is the most eco</param>
        static void PrintEconomical(string fv, CompanyCars cars, string which)
        {
            const string top =
            "----------------------------------------------\r\n"
            + "      Car model name      Passengers L/100km \r\n"
            + "----------------------------------------------";
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append)))
            {
                fr.WriteLine();
                fr.WriteLine(which + " company's most economical car");
                fr.WriteLine(top);
                fr.WriteLine(EconomicalCar(cars));
                fr.WriteLine("---------------------------------------" +
                    "-------\n");
            }
        }
        /// <summary>
        /// Method to find the most economical car of company
        /// </summary>
        /// <param name="cars">Company's car list</param>
        /// <returns>Most economical car of company</returns>
        static Car EconomicalCar(CompanyCars cars)
        {
            cars.Beginning();
            Car temp = cars.GetData();
            for(cars.Beginning(); cars.Exists(); cars.Move())
            {
                if(cars.GetData().fuelCons < temp.fuelCons) 
                {
                    temp = cars.GetData();
                }
            }
            return temp;
        }
        /// <summary>
        /// Method to find the largest car of company
        /// </summary>
        /// <param name="cars">Company's car list</param>
        /// <returns>Largest car of company</returns>
        static Car BiggestCar(CompanyCars cars)
        {
            cars.Beginning();
            Car temp = cars.GetData();
            for (cars.Beginning(); cars.Exists(); cars.Move())
            {
                if(cars.GetData().passengers > temp.passengers) 
                {
                    temp = cars.GetData();
                }
            }
            return temp;
        }
        /// <summary>
        /// Find largest car of two companies
        /// </summary>
        /// <param name="cars1">1 Company's car list</param>
        /// <param name="cars2">2 Company's car list</param>
        /// <returns>Largest car of two companies</returns>
        static Car BiggestCarOfTwo(CompanyCars cars1, CompanyCars cars2)
        {
            if(BiggestCar(cars1).passengers > BiggestCar(cars2).passengers)
            {
                return BiggestCar(cars1);
            }
            else return BiggestCar(cars2);
        }
        /// <summary>
        /// New list creation method according to criteria
        /// </summary>
        /// <param name="newList">Newly formed list</param>
        /// <param name="cars">Company's car list</param>
        /// <param name="enteredFuel">Criteria</param>
        public void NewListCreation(ref CompanyCars newList, 
            CompanyCars cars, double enteredFuel)
        {
            for (cars.Beginning(); cars.Exists(); cars.Move())
            {
                if (cars.GetData().fuelCons < enteredFuel)
                {
                    newList.PutDataT(cars.GetData());
                }
            }
        }
        /// <summary>
        /// Method to remove car that doesn't meet the criteria
        /// </summary>
        /// <param name="cars">Company's car list</param>
        /// <param name="enteredFuel">criteria</param>
        public void Removal(CompanyCars cars, double enteredFuel)
        {
            for (cars.Beginning(); cars.Exists(); cars.Move())
            {
                if (enteredFuel < cars.GetData().fuelCons)
                {
                    cars.Remove(cars.GetData());
                }
            }
        }
    }
}