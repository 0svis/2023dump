using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    /// <summary>
    /// Class for test questions, child class for Question class
    /// </summary>
    internal class TestQuestion : Question, IEquatable<Question>,
        IComparable<Question>
    {
        public int possibleOptionsCount { get; private set; }
        /// <summary>
        /// Class constructor with parameters
        /// as well with parameters from father class
        /// </summary>
        /// <param name="possibleOptionsCount">Question possible options
        /// amount</param>
        /// <param name="theme">Question theme</param>
        /// <param name="dificulty">Question dificulty</param>
        /// <param name="author">Question author</param>
        /// <param name="text">Question text</param>
        /// <param name="correctAnswer">Question correct answer</param>
        /// <param name="grade">Question grade</param>
        public TestQuestion (int possibleOptionsCount, string theme, 
            int dificulty, string author, string text, int correctAnswer, 
            int grade) : base(theme, dificulty, author, text, 
                correctAnswer, grade)
        {
            this.possibleOptionsCount = possibleOptionsCount;
        }
        /// <summary>
        /// Class constructor for parameter with data
        /// </summary>
        /// <param name="data">data string</param>
        public TestQuestion (string data) : base(data)
        {
            DataEntry(data);
        }
        /// <summary>
        /// Method for overriding DataEntry method
        /// with additional parameters
        /// </summary>
        /// <param name="line">data string</param>
        public override void DataEntry(string line)
        {
            base.DataEntry(line);
            string[] parts = line.Split(';');
            possibleOptionsCount = int.Parse(parts[7]);
        }
        /// <summary>
        /// Method for overriding CheckingWhichCorrect method
        /// </summary>
        /// <param name="checkedQ">checked question</param>
        /// <param name="criteria">criteria that question must meet</param>
        /// <returns>result</returns>
        public override bool CheckingWhichCorrect(Question checkedQ,
            int criteria)
        {
            TestQuestion question = checkedQ as TestQuestion;
            if (criteria == question.correctAnswer)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Overriding ToString method with additional data
        /// </summary>
        /// <returns>Formated string</returns>
        public override string ToString()
        {
            return String.Format("|{0,-24}{1}{2,-22}|{3,-25}|" +
                "{4,-18}|{5,-11}|", GetType().Name,base.ToString(),"",
                possibleOptionsCount, "", "");
        }
    }
}
