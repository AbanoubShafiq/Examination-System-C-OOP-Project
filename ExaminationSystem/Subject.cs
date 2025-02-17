using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam exam { get; set; }

        public Subject(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }


        public void CreateExam ()
        {
            int examType, time, noOfQuestion;
            do
            {
                Console.WriteLine("PLZ, Enter Type Of Exam (1 For Practical 2 for Final)");
            } while (!(int.TryParse(Console.ReadLine(), out examType) && (examType is 1 or 2)));


            do
            {
                Console.WriteLine("PLZ, Enter The time to Exam from (30 min to 180)");
            } while (!(int.TryParse(Console.ReadLine(), out time) && (time >= 30 && time <= 180)));


            do
            {
                Console.WriteLine("PLZ, Enter No Of Quesiton");
            } while (!(int.TryParse(Console.ReadLine(), out noOfQuestion) && (noOfQuestion > 0)));

            if (examType == 1)
                exam = new PracticalExam(time, noOfQuestion);
            else
                exam = new FinalExam(time, noOfQuestion);

            Console.Clear();
            exam.CreateListOfQuestions();

        }

    }
}
