using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TFQuestion : Question
    {
        public override string Header => "True Or False Question";

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

            // right answer 
            int rightAnswerId;
            do
            {
                Console.WriteLine("PLZ, Enter Right Answer Id (1 For True, 2 For False)");
            } while (!(int.TryParse(Console.ReadLine(), out rightAnswerId) && (rightAnswerId is 1 or 2)));
            
            RightAnswser.Id = rightAnswerId;
            RightAnswser.Text = Answers[rightAnswerId - 1].Text;

            Console.Clear();

        }
        public TFQuestion()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");

        }
    }
}
