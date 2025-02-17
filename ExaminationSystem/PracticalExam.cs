using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int _time, int _noOfquestion) : base(_time, _noOfquestion)
        {
        }

        public override void CreateListOfQuestions()
        {
            Questions = new MCQQuestion[NoOfQuestion];
            for(int i = 0; i < Questions?.Length; i++)
            {
                Questions[i] = new MCQQuestion();
                Questions[i].AddQuestion();
            }
            Console.Clear();
        }

        public override void ShowExam()
        {
            foreach(var question in Questions)
            {
                Console.WriteLine(question);
                for(int i =0; i<NoOfQuestion; i++)
                {
                    Console.WriteLine(question.Answers[i]);
                }
                int userAnswerId;

                do
                {
                    Console.WriteLine("PLZ, Enter the Answer Id ");
                } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));


                question.UserAnswer.Id = userAnswerId;
                question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;

            }

            Console.Clear();

            Console.WriteLine("Right Answer");
            for(int i=0; i<Questions?.Length; i++)
            {
                Console.WriteLine($"Question Number {i+1} : {Questions[i].Body}");

                Console.WriteLine($"Right Answer => {Questions[i].RightAnswser.Text}");
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
