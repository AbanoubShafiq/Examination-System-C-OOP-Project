using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(1, "C#");
            sub.CreateExam();
            Console.Clear();

            char flag;

            do
            {
                Console.WriteLine("do you want to start the exame (y for yes, n for no)");
            } while(!(char.TryParse(Console.ReadLine(), out flag) && (flag == 'y' || flag == 'n')));

            if (flag == 'y')
            {
                Console.Clear() ;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub.exam.ShowExam();    
                sw.Stop();

                Console.WriteLine($"time = {sw.Elapsed}");
            }
            Console.WriteLine("Thanks");
        }
    }
}