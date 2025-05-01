using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{

    // Base Exam Class
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public enum ExamMode { Starting, Queued, Finished }

        public string Name { get; set; }
        public int Time { get; set; } // Time in minutes
        public Dictionary<Question, string> QuestionAnswerDictionary { get; set; } = new Dictionary<Question, string>();
        public ExamMode Mode { get; set; }

        public Subject Subject { get; set; }

        protected Exam(string name, int time, Subject subject)
        {
            Name = name;
            Time = time;
            Subject = subject;
            Mode = ExamMode.Queued;
        }

        public abstract void ShowExam();

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            return Time.CompareTo(other.Time);
        }

        public override string ToString()
        {
            return $"Exam: {Name}, Time: {Time} mins, Subject: {Subject.Name}";
        }

        public override bool Equals(object obj)
        {
            return obj is Exam exam && Name == exam.Name && Time == exam.Time;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Time);
        }
    }

    public class PracticeExam : Exam
    {
        public PracticeExam(string name, int time, Subject subject) : base(name, time, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Practice Exam: {Name}");
            foreach (var question in QuestionAnswerDictionary.Keys)
            {
                question.Display();
                Console.WriteLine($"Correct Answer: {QuestionAnswerDictionary[question]}");
            }
        }
    }

    public class FinalExam : Exam
    {
        public FinalExam(string name, int time, Subject subject) : base(name, time, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam: {Name}");
            foreach (var question in QuestionAnswerDictionary.Keys)
            {
                question.Display();
            }
        }
    }

}
