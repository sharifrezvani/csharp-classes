using System;

namespace FourteenthSession
{

    public class Question
    {
        public int ID { get; set; }
        public int SectionID { get; set; }
        public string Title { get; set; }

        public Question(int id, int sectionID, string question)
        {
            this.ID = id;
            this.SectionID = sectionID;
            this.Title = question;
        }

    }

    public class Exam
    {
        public int ID { get; set; }
        public List<Question> Question { get; set; }

        public Exam(int id, List<Question> question)
        {
            this.ID = id;
            this.Question = question;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise One -----------------------------------------------------

            List<Question> questionsList = new List<Question>();

            questionsList.Add(new Question(1, 25, "What's your name?"));
            questionsList.Add(new Question(2, 28, "How old are you?"));
            questionsList.Add(new Question(3, 16, "Where were you born?"));

            List<Exam> examList = new List<Exam>();

            List<Question> secondQuestionsList = new List<Question>();

            secondQuestionsList.Add(new Question(1, 25, "What's your name?"));

            examList.Add(new Exam(14, secondQuestionsList));

            bool hasQuestion = questionsList.Exists(question => question.ID == examList[0].Question[0].ID);

            Console.WriteLine(hasQuestion);
            

            

        }
    }
}