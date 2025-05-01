using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    // Base Question Class
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }

        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }

        public abstract void Display();
    }

    // Derived Question Types
    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string header, string body, int marks, bool correctAnswer)
            : base(header, body, marks)
        {
            CorrectAnswer = correctAnswer;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}\n{Body}\nTrue/False");
        }
    }

    public class ChooseOneQuestion : Question
    {
        public List<string> Choices { get; set; }
        public int CorrectChoiceIndex { get; set; }

        public ChooseOneQuestion(string header, string body, int marks, List<string> choices, int correctChoiceIndex)
            : base(header, body, marks)
        {
            Choices = choices;
            CorrectChoiceIndex = correctChoiceIndex;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}\n{Body}");
            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            }
        }
    }

    public class ChooseAllQuestion : Question
    {
        public List<string> Choices { get; set; }
        public List<int> CorrectChoicesIndices { get; set; }

        public ChooseAllQuestion(string header, string body, int marks, List<string> choices, List<int> correctChoicesIndices)
            : base(header, body, marks)
        {
            Choices = choices;
            CorrectChoicesIndices = correctChoicesIndices;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}\n{Body}");
            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            }
        }
    }

    // Question List Class
    public class QuestionList : List<Question>
    {
        private string FilePath;

        public QuestionList(string filePath)
        {
            FilePath = filePath;
        }

        public new void Add(Question question)
        {
            base.Add(question);
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine(question.ToString());
            }
        }
    }

}
