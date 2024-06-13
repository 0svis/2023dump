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

namespace L3
{
    public partial class Lab3 : Form
    {
        //list for keeping data of questions
        private List<Question> saQ1;
        private List<Question> saQ2;
        //lists created by criterias
        private List<Question> DesiredThemeAndAmountOfAnsListSA1;
        private List<Question> DesiredThemeAndAmountOfAnsListSA2;
        private List<Question> DifficultyList;
        //names of the lists
        string sa1Name;
        string sa2Name;
        //Chosen results file name
        string CFr = string.Empty;
        //names of the most productive authors
        string sa1Author;
        string sa2Author;
        //amount of questions made by most productive authors
        int sa1HowMuch;
        int sa2HowMuch;
        public Lab3()
        {
            InitializeComponent();
            DesiredThemeAndAmountOfAnsListSA1 = new List<Question>();
            DesiredThemeAndAmountOfAnsListSA2 = new List<Question>();
            DifficultyList= new List<Question>();
            formButton.Enabled = false;
            diffButton.Enabled = false;
            findAuthorWithMostQuestionsToolStripMenuItem.Enabled = false;
            sortButton.Enabled = false;
            printToolStripMenuItem.Enabled = false;
        }
        /// <summary>
        /// Input button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (saQ2 == null)
            {


                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.Title = "Choose data file";
                string data = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    data = openFileDialog1.FileName;
                    if (saQ1 == null)
                    {
                        saQ1 = DataRead(data, ref sa1Name);
                        MessageBox.Show("First data file read succesfully");
                        results.Text += "\n" + File.ReadAllText(data) + "\n";
                    }
                    else if (saQ1 != null && data != null)
                    {
                        saQ2 = DataRead(data, ref sa2Name);
                        MessageBox.Show("Second data file read succesfully");
                        results.Text += "\n" + File.ReadAllText(data) + "\n";
                    }
                }
                inputToolStripMenuItem.Enabled = false;
                printToolStripMenuItem.Enabled = true;
            }
        }
        /// <summary>
        /// Output button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = 
                "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Choose results file";
            DialogResult resultFile = saveFileDialog1.ShowDialog();
            if (resultFile == DialogResult.OK)
            {
                CFr = saveFileDialog1.FileName;
                if (File.Exists(CFr))
                {
                    File.Delete(CFr);
                }
                if (saQ1 != null)
                    DataPrint(CFr, saQ1, sa1Name + " Questions");
                if (saQ2 != null)
                    DataPrint(CFr, saQ2, sa2Name + " Questions");
                results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            }
            printToolStripMenuItem.Enabled = false;
            formButton.Enabled = true;
            diffButton.Enabled = true;
            findAuthorWithMostQuestionsToolStripMenuItem.Enabled = true;
            sortButton.Enabled = true;
            printToolStripMenuItem.Enabled = true;
        }
        /// <summary>
        /// End button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Find Author with most questions button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findAuthorWithMostQuestionsToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            MostQuestionsAuthor(saQ1, ref sa1Author, ref sa1HowMuch);
            if (sa1HowMuch > 0)
            {
                results.Text += 
                    string.Format("Author who created the most musical" +
                    " questions from {0} SA is {1} with {2} questions\n",
                    sa1Name, sa1Author, sa1HowMuch);
            }
            else
                results.Text += "There is no musical questions\n";
            MostQuestionsAuthor(saQ2, ref sa2Author, ref sa2HowMuch);
            if (sa2HowMuch > 0)
            {
                results.Text += string.Format("Author who created the " +
                    "most musical questions from {0} SA is {1} with {2}" +
                    " questions\n", sa2Name, sa2Author, sa2HowMuch);
            }
            else
                results.Text += "There is no musical questions\n";
        }
        /// <summary>
        /// Sort button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortButton_Click(object sender, EventArgs e)
        {
            DifficultyList.Sort();
            DataPrint(CFr, DifficultyList, "Sorted common specified " +
                "difficulty and specified answer index list");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }
        /// <summary>
        /// Instruction button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instructions_Click(object sender, EventArgs e)
        {
            string ins = "..\\..\\instructions.txt";
            string msg = File.ReadAllText(ins);
            MessageBox.Show(msg, "Instructions for user: ");
        }
        /// <summary>
        /// Task button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void task_Click(object sender, EventArgs e)
        {
            string task = "..\\..\\task.txt";
            string msg = File.ReadAllText(task);
            MessageBox.Show(msg, "Given task: ");
        }
        /// <summary>
        /// Form a list from specific theme and specific
        /// amount of answer options button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formButton_Click(object sender, EventArgs e)
        {
            string theme = letterBox.Text;
            int amount = Convert.ToInt32(digitBox.Text);
            DesiredThemeAndAmountOfAnsListSA1 = 
                ThemeAndAmountOfAnswers(saQ1, theme, amount);
            DesiredThemeAndAmountOfAnsListSA2 = 
                ThemeAndAmountOfAnswers(saQ2, theme, amount);
            DataPrint(CFr, DesiredThemeAndAmountOfAnsListSA1, 
                "Each SA specified theme and specified possible " +
                "answer options questions list");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            DataPrint(CFr, DesiredThemeAndAmountOfAnsListSA2, 
                "Each SA specified theme and specified possible" +
                " answer options questions list");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }
        /// <summary>
        /// Form a list with desired question difficulty
        /// and answer index button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void diffButton_Click(object sender, EventArgs e)
        {
            int difficulty = Convert.ToInt32(diffBox.Text);
            int correctAnswer = Convert.ToInt32(answerBox1.Text);
            DifficultyList = FormsSpecificList(saQ1, saQ2, 
                typeof(MusicQuestion), typeof(TestQuestion), 
                difficulty, correctAnswer);
            DataPrint(CFr, DifficultyList, "Common specified " +
                "difficulty and specified answer index list");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }
        /// <summary>
        /// Method for reading data file
        /// </summary>
        /// <param name="data">data file string</param>
        /// <param name="name">SA name of the file</param>
        /// <returns>List with question from SA</returns>

        static List<Question> DataRead(string data, ref string name)
        {
            List<Question> questions = new List<Question>();
            using (StreamReader reader = new StreamReader(data))
            {
                string line;
                line = reader.ReadLine();
                name = line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts;
                    parts = line.Split(';');
                    char type = char.Parse(parts[0]);
                    if (type == 'O')
                    {
                        OpenQuestion newQ = new OpenQuestion(line);
                        if (!questions.Contains(newQ))
                        {
                            questions.Add(newQ);
                        }
                    }
                    else if (type == 'M')
                    {
                        MusicQuestion newQ = new MusicQuestion(line);
                        if (!questions.Contains(newQ))
                        {
                            questions.Add(newQ);
                        }
                    }
                    else if (type == 'T')
                    {
                        TestQuestion newQ = new TestQuestion(line);
                        if (!questions.Contains(newQ))
                        {
                            questions.Add(newQ);
                        }
                    }
                }
            }
            return questions;
        }
        /// <summary>
        /// Method for printing data
        /// </summary>
        /// <param name="resultFile">Result file string</param>
        /// <param name="questions">Questions list</param>
        /// <param name="name">header</param>
        static void DataPrint(string resultFile, 
            List<Question> questions, string name)
        {
            using (var fr = new StreamWriter
                (File.Open(resultFile, FileMode.Append),
                Encoding.GetEncoding(1257)))
            {
                if (questions.Count > 0)
                {
                    string header = 
                        String.Format("|{0,-24}|{1,-20}|{2,-5}|{3,-18}|" +
                        "{4,-65}|{5,-7}|{6,-12}|{7,-22}|{8,-25}|{9,-18}|" +
                        "{10,-11}|",
                                      "Type", "Theme", "Diff", "Author",
                                      "Question", "Answer", "Grades", 
                                      "A. of words",
                                      "Amount of answers", "File name",
                                      "File size");
                    fr.WriteLine("\n" + name);
                    fr.WriteLine(new String('-', header.Length));
                    fr.WriteLine(header);
                    fr.WriteLine(new String('-', header.Length));
                    for (int i = 0; i < questions.Count; i++)
                    {
                        fr.WriteLine(questions[i].ToString());
                    }
                    fr.WriteLine(new String('-', header.Length));
                    fr.WriteLine();
                }
                else if (questions.Count == 0)
                {
                    fr.WriteLine("\n " + name);
                    fr.WriteLine("In this list, there is no questions.");
                }
            }
        }
        /// <summary>
        /// Method for finding which author created the most questions
        /// </summary>
        /// <param name="questions">Questions list</param>
        /// <param name="author">Author name</param>
        /// <param name="howMuch">Amount of questions created 
        /// by author</param>
        static void MostQuestionsAuthor(List<Question> questions,
            ref string author, ref int howMuch)
        {
            List<Question> authors = new List<Question>();
            int count=0;
            howMuch=-1;
            string tempAuthor="";
            for (int i=0; i<questions.Count; i++)
            {
                for (int j=i; j<questions.Count; j++)
                {
                    if (questions[i].author == questions[j].author
                        && questions[j].GetType() == typeof(MusicQuestion))
                    {
                        count++;
                        tempAuthor=questions[i].author;
                    }
                }
                if (howMuch < count)
                {
                    howMuch = count;
                    author = tempAuthor;
                }
            }
        }
        /// <summary>
        /// Method for finding questions that apply with
        /// theme and amount of answers criterias
        /// </summary>
        /// <param name="questions">Questions list</param>
        /// <param name="theme">Theme criteria</param>
        /// <param name="amount">Amount of answer criteria</param>
        /// <returns>List with questions that meet criterias</returns>
        static List<Question>ThemeAndAmountOfAnswers(List<Question> questions,
            string theme, int amount)
        {
            List<Question> answer = new List<Question>();
            for (int i=0; i<questions.Count; i++)
            {
                if (questions[i].GetType() == typeof(TestQuestion) && 
                    questions[i].theme == theme 
                    && ((TestQuestion)questions[i]).possibleOptionsCount
                    == amount)
                {
                    answer.Add((TestQuestion)questions[i]);
                }
            }
            return answer;
        }
        /// <summary>
        /// Forms specific list, that applies with
        /// specific question difficulty and specific
        /// answer index
        /// </summary>
        /// <param name="questions1">SA1 Questions list</param>
        /// <param name="questions2">SA2 Questions list</param>
        /// <param name="A">Specific question type</param>
        /// <param name="B">Specific question type</param>
        /// <param name="difficulty">Specific difficulty</param>
        /// <param name="correctAnswer">Specific amount of questions</param>
        /// <returns>A list that meets criteria</returns>
        static List<Question>FormsSpecificList(List<Question> questions1, 
            List<Question> questions2, Type A, Type B, int difficulty, 
            int correctAnswer) 
        {
            List<Question> answer = new List<Question>();
            List<Question> combined = questions1.Concat(questions2).ToList();
            for (int i=0; i< combined.Count; i++) 
            {
                if ((combined[i].GetType() == A || combined[i].GetType() == B) 
                    && combined[i].dificulty == difficulty 
                    && combined[i].correctAnswer == correctAnswer)
                {
                    answer.Add(combined[i]);
                }
            }
            return answer;
        }
    }
}