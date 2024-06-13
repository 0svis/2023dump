using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    /// <summary>
    /// Question class
    /// </summary>
    public abstract class Question : IComparable<Question>,
        IEquatable<Question>
    {
        public string theme { get; set; }
        public int dificulty { get; set; }
        public string author { get; set; }
        public string text { get; set; }
        public int correctAnswer { get; set; }
        public int grade { get; set; }
        /// <summary>
        /// Class constructor with parameters
        /// </summary>
        /// <param name="theme">Question theme</param>
        /// <param name="dificulty">Question difficulty</param>
        /// <param name="author">Question author</param>
        /// <param name="text">Question text</param>
        /// <param name="correctAnswer">Question correct answer index</param>
        /// <param name="grade">Question grade</param>
        public Question(string theme, int dificulty, string author, 
            string text, int correctAnswer, int grade)
        {
            this.theme = theme;
            this.dificulty = dificulty;
            this.author = author;
            this.text = text;
            this.correctAnswer = correctAnswer;
            this.grade = grade;
        }
        /// <summary>
        /// Class constructor for parameter with data
        /// </summary>
        /// <param name="dataInfo">data string</param>
        public Question(string dataInfo)
        {
            DataEntry(dataInfo);
        }
        /// <summary>
        /// Reading data method
        /// </summary>
        /// <param name="line">data string</param>
        public virtual void DataEntry(string line)
        {
            string[] parts;
            parts=line.Split(';');
            string type = parts[0].Trim();
            theme = parts[1].Trim();
            dificulty = int.Parse(parts[2].Trim());
            author = parts[3].Trim();
            text = parts[4].Trim();
            correctAnswer = int.Parse(parts[5].Trim());
            grade = int.Parse(parts[6].Trim());

        }
        /// <summary>
        /// Method for formating string
        /// </summary>
        /// <returns>Formated string</returns>
        public override string ToString()
        {
            string line;
            line = string.Format("|{0,-20}|{1,-5}|{2,-18}|{3,-65}|" +
                "{4,-7}|{5,-12}|", theme, dificulty, author, text, 
                correctAnswer, grade);
            return line;
        }
        /// <summary>
        /// Method for comparing theme and grade
        /// </summary>
        /// <param name="other">Compared with question</param>
        /// <returns>Result for comparing</returns>
        public virtual int CompareTo(Question other)
        {
            if ((object)other == null) return 1;
            int result = this.theme.CompareTo(other.theme);
            if (result == 0)
            { return this.grade.CompareTo(other.grade); }
            return result;
        }
        /// <summary>
        /// Method for overwriting Equals method
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool result</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var question = obj as Question;
            return Equals(question);
        }
        /// <summary>
        /// method for checking if it is equal
        /// </summary>
        /// <param name="questionOne">Question one</param>
        /// <returns>bool method Equals result</returns>
        public bool Equals(Question questionOne)
        {
            return questionOne != null 
                && theme == questionOne.theme 
                && dificulty == questionOne.dificulty 
                && text == questionOne.text 
                && correctAnswer == questionOne.correctAnswer
                && grade == questionOne.grade;
        }
        /// <summary>
        /// Method for comparing two objects
        /// </summary>
        /// <param name="one">object one</param>
        /// <param name="two">object two</param>
        /// <returns>compare result</returns>
        public static bool operator ==(Question one, Question two)
        {
            if (((object)one) == null || ((object)two) == null)
                return Object.Equals(one, two);
            return one.Equals(two);
        }
        public static bool operator !=(Question one, Question two)
        {
            if (((object)one) == null || ((object)two) == null)
                return !Object.Equals(one, two);
            return !(one.Equals(two));
        }
        /// <summary>
        /// Method for comparing two objects
        /// </summary>
        /// <param name="one">object one</param>
        /// <param name="two">object two</param>
        /// <returns>compare result</returns>
        public static bool operator <=(Question one, Question two)
        {
            int a = one.grade;
            int b = two.grade;
            int r = String.Compare(one.theme, two.theme, 
                StringComparison.CurrentCulture);
            return (r < 0 || (r == 0 && b > a));
        }
        /// <summary>
        /// Method for comparing two objects
        /// </summary>
        /// <param name="one">object one</param>
        /// <param name="two">object two</param>
        /// <returns>compare result</returns>
        public static bool operator >=(Question one, Question two)
        {
            int a = one.grade;
            int b = two.grade;
            int r = String.Compare(one.theme, two.theme, 
                StringComparison.CurrentCulture);
            return (r > 0 || (r == 0 && b < a));
        }
        public abstract bool CheckingWhichCorrect(Question checkedQ, 
            int criteria);
        /// <summary>
        /// Method for getting object's hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
