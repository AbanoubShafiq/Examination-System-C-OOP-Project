using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class MCQQuestion : Question
    {
        public override string Header => "MCQ Question";
        public MCQQuestion()
        {
            Answers = new Answer[3];

        }

        public override void AddQuestion()
        {
            // header 
            Console.WriteLine(Header);

            // question body
            do
            {
                Console.WriteLine("PLZ, Enter Question Body");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));

            // mark 
            int mark;
            do
            {
                Console.WriteLine("PLZ, Enter Question Mark");
            } while (!(int.TryParse(Console.ReadLine(), out mark) && (mark > 0)));

            Mark = mark;

            // choices
            Console.WriteLine("Choices Of Question");
            for(int i = 0; i < Answers.Length; i++)
            {
                Answers[i] = new Answer() { Id = i + 1 };

                do
                {
                    Console.WriteLine($"PLZ, Enter Choice Number {i + 1}");
                    Answers[i].Text = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(Answers[i].Text));

            }

            // right answer 

            // right answer 
            int rightAnswerId;
            do
            {
                Console.WriteLine("PLZ, Enter Right Answer Id");
            } while (!(int.TryParse(Console.ReadLine(), out rightAnswerId) && (rightAnswerId is 1 or 2 or 3)));

            RightAnswser.Id = rightAnswerId;
            RightAnswser.Text = Answers[rightAnswerId - 1].Text;

            Console.Clear();


        }
    }
}
