using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class FinalExam : Exam
    {
        public FinalExam(int _time, int _noOfquestion) : base(_time, _noOfquestion)
        {
        }

        public override void CreateListOfQuestions()
        {
            Questions = new Question[NoOfQuestion];
            for(int i = 0; i < Questions?.Length; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("PLZ, Enter Question Type (1 For MCQ 2 for True Or False)");
                } while (!(int.TryParse(Console.ReadLine(), out choice) && (choice is 1 or 2 or 3)));

                Console.Clear();

                if (choice == 1)
                {
                    Questions[i] = new MCQQuestion();
                    Questions[i].AddQuestion();
                }else
                {
                    Questions[i] = new TFQuestion();
                    Questions[i].AddQuestion();
                }





            }
        }

        public override void ShowExam()
        {
            foreach(var question in Questions)
            {
                Console.WriteLine(question);

                for(int i=0; i<question?.Answers?.Length; i++)
                    Console.WriteLine(question.Answers[i]);

                int userAnswerId;

                if (question?.GetType() == typeof(MCQQuestion))
                {
                    do
                    {
                        Console.WriteLine("PLZ, Enter the Answer Id ");
                    } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));
                }
                else
                {
                    do
                    {
                        Console.WriteLine("PLZ, Enter the Answer Id (1 For True 2 For False) ");
                    } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2)));

                }

                question.UserAnswer.Id = userAnswerId;
                question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;

            }

            Console.Clear();

            int grade = 0, totalMark = 0;
            for(int i=0; i<Questions.Length;i++)
            {
                totalMark += Questions[i].Mark;
                if (Questions[i].UserAnswer.Id == Questions[i].RightAnswser.Id)
                {
                    grade += Questions[i].Mark;
                }

                Console.WriteLine($"Question {i+1} : {Questions[i].Body}");
                Console.WriteLine($"Your Answer => : {Questions[i].UserAnswer.Text}");
                Console.WriteLine($"Right Answer => : {Questions[i].RightAnswser.Text}");

            }
            Console.WriteLine($"Your Grade is {grade} from {totalMark}");

        }
    }
}
