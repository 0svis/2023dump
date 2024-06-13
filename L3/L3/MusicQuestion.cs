using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    /// <summary>
    /// Class for music questions, child class for Question class
    /// </summary>
    internal class MusicQuestion : Question, IEquatable<Question>,
        IComparable<Question>
    {
        string fileName;
        int fileSize;
        /// <summary>
        /// Class constructor with parameters
        /// as well with parameters from father class
        /// </summary>
        /// <param name="fileName">Question file name</param>
        /// <param name="fileSize">Question file size</param>
        /// <param name="theme">Question theme</param>
        /// <param name="dificulty">Question dificulty</param>
        /// <param name="author">Question author</param>
        /// <param name="text">Question text</param>
        /// <param name="correctAnswer">Question correct answer</param>
        /// <param name="grade">Question grade</param>
        public MusicQuestion(string fileName, int fileSize, string theme, int dificulty, string author, string text, int correctAnswer, int grade) : base(theme, dificulty, author, text, correctAnswer, grade)
        {
            this.fileName = fileName;
            this.fileSize = fileSize;
        }
        /// <summary>
        /// Class constructor for parameter with data
        /// </summary>
        /// <param name="data">data string</param>
        public MusicQuestion(string data) : base(data) 
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
            fileName = parts[7];
            fileSize = int.Parse(parts[8]);
        }
        /// <summary>
        /// Method for overriding CheckingWhichCorrect method
        /// </summary>
        /// <param name="checkedQ">checked question</param>
        /// <param name="criteria">criteria that question must meet</param>
        /// <returns>result</returns>
        public override bool CheckingWhichCorrect(Question checkedQ, int criteria)
        {
            MusicQuestion question = checkedQ as MusicQuestion;
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
            return String.Format("|{0,-24}{1}{2,-22}|{3,-25}|{4,-18}|{5,-11}|", GetType().Name,base.ToString(), "", "", fileName, fileSize);
        }
    }
}
