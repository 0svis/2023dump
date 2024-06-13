using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2
{
    public partial class Form1 : Form
    {
        private string CFr = string.Empty;
        private List<Car> oneCompany = new List<Car>();
        private List<Car> twoCompany = new List<Car>();
        private List<Car> carsBelowFuelCons = new List<Car>();
        private List<Car> additionalCompany = new List<Car>();
        string oneCompanyName;
        string twoCompanyName;
        string threeCompanyName = string.Empty;
        public Form1()
        {
            InitializeComponent();
            print.Enabled = false;
            csv.Enabled = false;
            find.Enabled = false;
            sort.Enabled = false;
            filterFuelConsumptionToolStripMenuItem.Enabled = false;
            findButton.Enabled = false;
        }

        private void input_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Choose your data file";
            DialogResult result1 = openFileDialog1.ShowDialog();
            if (result1 == DialogResult.OK)
            { 
                string CFd = openFileDialog1.FileName;
                oneCompany = ReadDataFile(CFd, out oneCompanyName);
                resultPrint.LoadFile(CFd, RichTextBoxStreamType.PlainText);
                resultPrint.Text += "\nData read successfully.";
            }
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog2.Title = "Choose data file";
            DialogResult result2 = openFileDialog2.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                string CFd = openFileDialog2.FileName;
                twoCompany = ReadDataFile(CFd, out twoCompanyName);
                resultPrint.LoadFile(CFd, RichTextBoxStreamType.PlainText);
                resultPrint.Text += "\nData read successfully.";
            }
            input.Enabled = false;
            print.Enabled = true;
        }

        private void print_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Choose result file";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                CFr = saveFileDialog1.FileName;
                if (File.Exists(CFr))
                    File.Delete(CFr);
                using (var fr = File.Open(CFr, FileMode.Append))
                {
                    using (var fr2 = new StreamWriter(fr, Encoding.GetEncoding(1257)))
                    {
                        fr2.Write("Company name: {0}", oneCompanyName);
                    }
                    DataToString(CFr, oneCompany, "\nFirst company cars:");
                }
                using (var fr = File.Open(CFr, FileMode.Append))
                {
                    using (var fr2 = new StreamWriter(fr, Encoding.GetEncoding(1257)))
                    {
                        fr2.Write("Company name: {0}", twoCompanyName);
                    }
                    DataToString(CFr, twoCompany, "\nSecond company cars:");
                }
                resultPrint.LoadFile(CFr, RichTextBoxStreamType.PlainText);
                print.Enabled = false;
                filterFuelConsumptionToolStripMenuItem.Enabled = true;
                csv.Enabled = true;
                find.Enabled = true;
                sort.Enabled = true;
                findButton.Enabled = true;
                clearTextToolStripMenuItem.Enabled = true;
            }
        }

        private void csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog1.Title = "Choose CSV data file";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                CFr = saveFileDialog1.FileName;
                if (File.Exists(CFr))
                    File.Delete(CFr);
                using (var fr = File.Open(CFr, FileMode.Append))
                {
                    using (var fr2 = new StreamWriter(fr, Encoding.GetEncoding(1257)))
                    {
                        fr2.Write("Companies names: {0},{1},{2}", oneCompanyName, twoCompanyName, threeCompanyName);
                    }
                }
                DataToStringCSV(CFr, carsBelowFuelCons, "List");
                csv.Enabled = false;
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            int oneCompanyLeastFuel = MostEconomicalCar(oneCompany);
            int twoCompanyLeastFuel = MostEconomicalCar(twoCompany);
            int oneCompanyMostPass = MostPassengers(oneCompany);
            int twoCompanyMostPass = MostPassengers(twoCompany);
                using (var fr = File.Open(CFr, FileMode.Append))
                {
                    using (var fr2 = new StreamWriter(fr, Encoding.GetEncoding(1257)))
                    {
                        fr2.WriteLine("Least fuel consuming car of ''" +
                            oneCompanyName + "'' company: " +
                            oneCompany[oneCompanyLeastFuel].ToString() + "\n");
                        fr2.WriteLine("Least fuel consuming car of ''"
                            + twoCompanyName + "'' company: "
                            + twoCompany[twoCompanyLeastFuel].ToString() + "\n\n");
                        fr2.WriteLine("Biggest car of ''" +
                            oneCompanyName + "'' company: " +
                            oneCompany[oneCompanyMostPass].ToString()
                            .ToString() + "\n");
                        fr2.WriteLine("Biggest car of ''" +
                            twoCompanyName + "'' company: "
                            + twoCompany[twoCompanyMostPass].
                            ToString() + "\n\n");
                    }
                }
                resultPrint.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }

        private void sort_Click(object sender, EventArgs e)
        {
            Sort_List(carsBelowFuelCons);
            DataToString(CFr, carsBelowFuelCons, "Sorted List");
            resultPrint.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }

        private void filterFuelConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Car> temp = NewArray(oneCompany, twoCompany);
            carsBelowFuelCons = Removal(temp);
            DataToString(CFr, carsBelowFuelCons, "\nCars whose fuel consumption is lower than biggest car overall");
            resultPrint.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            double fuelConsumption = Convert.ToDouble(enteredFuel.Text);
            RemoveSpecific(carsBelowFuelCons, fuelConsumption);
            DataToString(CFr, carsBelowFuelCons, "Cars that doesn't exceed entered fuel consumption");
            resultPrint.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }
        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultPrint.Clear();
        }
        private void additionalData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog3.Title = "Choose your data file";
            DialogResult result3 = openFileDialog3.ShowDialog();
            if (result3 == DialogResult.OK)
            {
                string CFd = openFileDialog3.FileName;
                additionalCompany = ReadDataFile(CFd, out threeCompanyName);
            }
            AdditionalCompany(additionalCompany, carsBelowFuelCons);
            DataToString(CFr, carsBelowFuelCons, "Sorted results list + third company added to sorted list");
            resultPrint.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }
        static List<Car> ReadDataFile(string file, out string companyName)
        {
            List<Car> companyData = new List<Car>();
            using (StreamReader reader = new StreamReader(file))
            {
                companyName = reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Car IndividualCar = new Car(parts[0],
                        Convert.ToInt32(parts[1]),
                        Convert.ToDouble(parts[2]));
                    companyData.Add(IndividualCar);
                }
            }
            return companyData;
        }
        static void DataToString(string fv, List<Car> companyCars,
    string heading)
        {
            const string up =
                 "-------------------------------------------------------" +
                 "-------------------------------------\r\n"
                + "   Model   Passenger amount  Fuel consumption (l/100km) " +
                "\r\n"
                + "-------------------------------------------------------" +
                "-------------------------------------";
            using (var fr = File.AppendText(fv))
            {
                fr.WriteLine(heading);
                fr.WriteLine(up);
                for (int i = 0; i < companyCars.Count; i++)
                {
                    Car car = companyCars[i];
                    fr.WriteLine(car.ToString());
                }
                fr.WriteLine("---------------------------------------------" +
                    "-----------------------------------------------\n");
            }
        }
        static int MostEconomicalCar(List<Car> companyCars)
        {
            double lowestCons = double.MaxValue;
            int saveNumber = -1;
            for (int i = 0; i < companyCars.Count; i++)
            {
                if (companyCars[i].fuelConsumption < lowestCons)
                {
                    lowestCons = companyCars[i].fuelConsumption;
                    saveNumber = i;
                }
            }
            return saveNumber;
        }
        static int MostPassengers(List<Car> companyCars)
        {
            int mostPass = int.MinValue;
            int saveNumber = -1;
            for (int i = 0; i < companyCars.Count; i++)
            {
                if (companyCars[i].passengerAmount > mostPass)
                {
                    mostPass = companyCars[i].passengerAmount;
                    saveNumber = i;
                }
            }
            return saveNumber;
        }
        static List<Car> NewArray(List<Car> oneCompany, List<Car> twoCompany)
        {
            List<Car> cars = oneCompany;
            for (int i = 0; i < twoCompany.Count; i++)
            {
                cars.Add(twoCompany[i]);
            }
            return cars;
        }
        static List<Car> Removal(List<Car> newArray)
        {
            List<Car> cars = new List<Car>();
            int temp = MostPassengers(newArray);
            for (int i=0; i< newArray.Count; i++)
            {
                if (newArray[i].fuelConsumption < newArray[temp].fuelConsumption)
                {
                    cars.Add(newArray[i]);
                }
            }
            return cars;
        }
        static void Sort_List(List<Car> carsBelowFuelConsumption) 
        {
            for (int write = 0; write < carsBelowFuelConsumption.Count; write++)
            {
                for (int sort = 0; sort < carsBelowFuelConsumption.Count; sort++)
                {
                    if (carsBelowFuelConsumption[write].Compare(carsBelowFuelConsumption[sort]))
                    {
                        Car temp = carsBelowFuelConsumption[write];
                        carsBelowFuelConsumption[write] = carsBelowFuelConsumption[sort];
                        carsBelowFuelConsumption[sort] = temp;
                    }
                }
            }
        }
        static void RemoveSpecific(List<Car> carsBelowFuelConsumption, double enteredFuel)
        {
            for (int i=0; i<carsBelowFuelConsumption.Count; i++) 
            {
                if (carsBelowFuelConsumption[i].fuelConsumption >= enteredFuel)
                {
                    carsBelowFuelConsumption.RemoveAt(i);
                    i = -1;
                }
            }

        }
        static void AdditionalCompany(List<Car> additionalCompany, List<Car>alreadyExisting)
        {
            for (int i = 0; i < additionalCompany.Count; i++)
            {
                 alreadyExisting.Add(additionalCompany[i]);
            }
            Sort_List(alreadyExisting);
        }
        static void DataToStringCSV(string fv, List<Car> companyCars,
        string heading)
        {
            const string up =
            "Nr.,Model,Passenger amount,Fuel consumption (l/100km),";
            using (var fr = File.AppendText(fv))
            {
                fr.WriteLine(heading);
                fr.WriteLine(up);
                for (int i = 0; i < companyCars.Count; i++)
                {
                    Car car = companyCars[i];
                    fr.WriteLine("{0},{1}", i + 1, car.ToStringCSV());
                }
            }
        }
    }
}
