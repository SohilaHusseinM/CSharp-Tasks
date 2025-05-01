using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    // Answer Class
    public class Answer
    {
        public Question Question { get; set; }
        public string StudentAnswer { get; set; }

        public Answer(Question question, string studentAnswer)
        {
            Question = question;
            StudentAnswer = studentAnswer;
        }
    }

    public class AnswerList : List<Answer>
    {
    }
}
