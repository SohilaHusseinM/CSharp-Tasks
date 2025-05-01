using System;
using System.Collections.Generic;
using System.IO;
using Day7_8;

class Program
{
    static void Main(string[] args)
    {
        Subject math = new Subject("Mathematics");
        PracticeExam practiceExam = new PracticeExam("Math Practice Exam", 60, math);
        FinalExam finalExam = new FinalExam("Math Final Exam", 120, math);

        // Example questions
        var tfQuestion = new TrueFalseQuestion("Q1", "Is 2+2=4?", 5, true);
        var choiceQuestion = new ChooseOneQuestion("Q2", "What is 2+3?", 5, new List<string> { "4", "5", "6" }, 1);

        practiceExam.QuestionAnswerDictionary.Add(tfQuestion, "True");
        practiceExam.QuestionAnswerDictionary.Add(choiceQuestion, "5");

        finalExam.QuestionAnswerDictionary.Add(tfQuestion, "True");
        finalExam.QuestionAnswerDictionary.Add(choiceQuestion, "5");

        Console.WriteLine("Select Exam Type: 1. Practice Exam  2. Final Exam");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            practiceExam.ShowExam();
        }
        else if (choice == 2)
        {
            finalExam.ShowExam();
        }
    }
}
