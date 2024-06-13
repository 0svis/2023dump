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

namespace L5
{
    public partial class Form1 : Form
    {
        ColoursList<Triangle> Triangles = new ColoursList<Triangle>();
        ColoursList<ColoursCoordinates> Coordinates;
        ColoursList<ColoursOrders> Orders;
        const string CFd1 = "..\\..\\U5a.txt"; //1st Data file
        const string CFd2 = "..\\..\\U5b.txt"; //2nd Data file
        string CFr = "..\\..\\results.txt"; //Results file
        public Form1()
        {
            InitializeComponent();
            actions.Enabled = false;
            if (File.Exists(CFr))
                File.Delete(CFr);
        }
        /// <summary>
        /// Button for reading and printing original data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addInput_Click(object sender, EventArgs e)
        {
            Coordinates = ReadCCoords(CFd1);
            Orders = ReadCOrders(CFd2);
            PrintCoordinates(Coordinates, "Point coordinates", CFr);
            PrintOrders(Orders, "Colours Orders", CFr);
            string temp = File.ReadAllText(CFr);
            results.Text = temp;
            actions.Enabled = true;
        }
        /// <summary>
        /// Not used method for adding results file button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter
                = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Choose results file";
            DialogResult resultFile = saveFileDialog1.ShowDialog();
            if (resultFile == DialogResult.OK)
            {
                CFr = saveFileDialog1.FileName;
                if (File.Exists(CFr))
                {
                    File.Delete(CFr);
                }
            }
            actions.Enabled = true;
        }
        /// <summary>
        /// Button to close program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Button to find largest possible triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void largest_Click(object sender, EventArgs e)
        {
            CalcTriangles(Coordinates, Orders, Triangles);
            PrintArea(Triangles, "Possible triangles information", CFr);
            largest.Enabled = false;
            string temp = File.ReadAllText(CFr);
            results.Text = temp;
        }
        /// <summary>
        /// Button to see task information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void task_Click(object sender, EventArgs e)
        {
            string task = "..\\..\\task.txt";
            string msg = File.ReadAllText(task);
            MessageBox.Show(msg, "Given task:");
        }
        /// <summary>
        /// Button to see user instructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userInstructions_Click(object sender, EventArgs e)
        {
            string ins = "..\\..\\instructions.txt";
            string msg = File.ReadAllText(ins);
            MessageBox.Show(msg, "Instructions for user:");

        }
        /// <summary>
        /// Method to read first data file
        /// </summary>
        /// <param name="data">data file</param>
        /// <returns>data</returns>
        static ColoursList<ColoursOrders> ReadCOrders(string data)
        {
            ColoursList<ColoursOrders> orders = 
                new ColoursList<ColoursOrders>();
            using (StreamReader reader = new StreamReader(data))
            {
                string line;
                while((line=reader.ReadLine())!=null)
                {
                    string[] parts = line.Split(';');
                    string colour = parts[0];
                    string order = parts[1];
                    ColoursOrders add = 
                        new ColoursOrders(colour, order);
                    orders.AddData(add);
                }
            }
            return orders;
        }
        /// <summary>
        /// Method to read second data file
        /// </summary>
        /// <param name="data">data file</param>
        /// <returns>data</returns>
        static ColoursList<ColoursCoordinates> ReadCCoords(string data)
        {
            ColoursList<ColoursCoordinates> coords = 
                new ColoursList<ColoursCoordinates>();
            using (StreamReader reader = new StreamReader(data))
            {
                string line;
                line = reader.ReadLine();
                int n = int.Parse(line);
                for (int i=0; i<n; i++)
                {
                    line = reader.ReadLine();
                    string[] parts = line.Split(';');
                    string colour = parts[0];
                    int x = int.Parse(parts[1]);
                    int y = int.Parse(parts[2]);
                    ColoursCoordinates cCoords = 
                        new ColoursCoordinates(colour, x, y);
                    coords.AddData(cCoords);
                }
            }
            return coords;
        }
        /// <summary>
        /// Method to print coordinates
        /// </summary>
        /// <param name="coords">Given list</param>
        /// <param name="header">Header</param>
        /// <param name="CFr">Results file</param>
        static void PrintCoordinates(ColoursList<ColoursCoordinates> coords, 
            string header, string CFr)
        {
            const string top =
                "---------------------\r\n"
              + "| Colour |  X  |  Y |\r\n"
              + "---------------------\r\n";
            string line = new string('-', 21);
            using (var fr = new StreamWriter(File.Open(CFr, 
                FileMode.Append), Encoding.GetEncoding(12000)))
            {
                fr.WriteLine(header);
                fr.WriteLine(top);
                for(coords.Start(); coords.Exists(); coords.Next())
                {
                    fr.WriteLine(coords.GetData());
                    fr.WriteLine(line);
                }
                fr.WriteLine();
            }
        }
        /// <summary>
        /// Method to print orders
        /// </summary>
        /// <param name="orders">Given list</param>
        /// <param name="header">Header</param>
        /// <param name="CFr">Results file</param>
        static void PrintOrders(ColoursList<ColoursOrders> orders, 
            string header, string CFr)
        {
            const string top =
                "---------------------\r\n"
               + "| Colour |   Can?   |\r\n"
               + "---------------------\r\n";
            string line = new string('-', 21);
            using (var fr = new StreamWriter(File.Open(CFr, 
                FileMode.Append), Encoding.GetEncoding(12000)))
            {
                fr.WriteLine(header);
                fr.WriteLine(top);
                for(orders.Start(); orders.Exists(); orders.Next())
                {
                    fr.WriteLine(orders.GetData());
                    fr.WriteLine(line);
                }
                fr.WriteLine();
            }
        }
        /// <summary>
        /// Method to find and calculate largest possible triangle
        /// </summary>
        /// <param name="coords">Coordinates list</param>
        /// <param name="orders">Orders list</param>
        /// <param name="triangles">Triangles list</param>
        static void CalcTriangles(ColoursList<ColoursCoordinates> coords, 
            ColoursList<ColoursOrders> orders, 
            ColoursList<Triangle> triangles)
        {
            for (orders.Start(); orders.Exists(); orders.Next())
            {
                string colourName = orders.GetData().Color;
                string order = orders.GetData().Order;
                double maxPerimeter = 0;
                if (order == "Taip" || order == "Yes")
                {
                    for (coords.Start(); coords.Exists(); coords.Next())
                    {
                        int x1 = coords.GetData().X;
                        int y1 = coords.GetData().Y;
                        for (coords.Start2(); coords.Exists2(); 
                            coords.Next2())
                        {
                            if (coords.GetData().Colour == colourName)
                            {
                                int x2 = coords.GetData2().X;
                                int y2 = coords.GetData2().Y;
                                for (coords.Start3(); coords.Exists3(); 
                                    coords.Next3())
                                {
                                    int x3 = coords.GetData3().X;
                                    int y3 = coords.GetData3().Y;
                                    double perimeter = 
                                        PerimeterOfTriangle(x1, y1, x2, 
                                        y2, x3, y3);
                                    if (perimeter > maxPerimeter)
                                    {
                                        maxPerimeter = perimeter;
                                    }
                                }
                            }
                        }
                    }
                    if (maxPerimeter == 0)
                    {
                        order = "None";
                    }
                }
                else 
                {
                    order = "Not possible";
                }
                Triangle triangle = new Triangle(colourName, 
                    order, maxPerimeter);
                triangles.AddData(triangle);
            }
        }
        /// <summary>
        /// Method to find perimeter of triangle
        /// </summary>
        /// <param name="x1">x1 coordinate</param>
        /// <param name="y1">y1 coordinate</param>
        /// <param name="x2">x2 coordinate</param>
        /// <param name="y2">y2 coordinate</param>
        /// <param name="x3">x3 coordinate</param>
        /// <param name="y3">y3 coordinate</param>
        /// <returns>Perimeter</returns>
        static double PerimeterOfTriangle(int x1, int y1, int x2, 
            int y2, int x3, int y3)
        {
            double distance1_2 = DistanceBetweenTwoDots(x1, y1, x2, y2);
            double distance1_3 = DistanceBetweenTwoDots(x1, y1, x3, y3);
            double distance2_3 = DistanceBetweenTwoDots(x2, y2, x3, y3);
            if (distance1_2 == distance1_3)
            {
                return distance1_2 + distance1_3 + distance2_3;
            }
            else if (distance1_2 == distance2_3)
            {
                return distance1_2 + distance1_3 + distance2_3;
            }
            else if (distance1_3 == distance2_3)
            {
                return distance1_2 + distance1_3 + distance2_3;
            }
            else return 0.0;
        }
        /// <summary>
        /// Method to find distance between two coordinates
        /// </summary>
        /// <param name="x1">x1 coordinate</param>
        /// <param name="y1">y1 coordinate</param>
        /// <param name="x2">x2 coordinate</param>
        /// <param name="y2">y2 coordinate</param>
        /// <returns>distance between two coordinates</returns>
        static double DistanceBetweenTwoDots(int x1, int y1, int x2, int y2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) 
                + Math.Pow(y2 - y1, 2)), 4);
        }
        /// <summary>
        /// Prints results
        /// </summary>
        /// <param name="triangles">Given list</param>
        /// <param name="header">Header</param>
        /// <param name="CFr">Results file</param>
        static void PrintArea(ColoursList<Triangle> triangles, 
            string header, string CFr)
        {
            const string top =
                "----------------------------------\r\n"
              + " Colour | Possible | Perimeter \r\n"
              + "----------------------------------\r\n";
            string line = new string('-', 34);
            using (var fr = new StreamWriter(File.Open(CFr, 
                FileMode.Append), Encoding.GetEncoding(12000)))
            {
                fr.WriteLine(header);
                fr.WriteLine(top);
                for (triangles.Start(); triangles.Exists(); triangles.Next())
                {
                    fr.WriteLine(triangles.GetData());
                    fr.WriteLine(line);
                }
            }
        }
    }
}
