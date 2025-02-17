using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NoOfQuestion { get; set; }
        public Question[] Questions { get; set; }
        public Exam(int _time, int _noOfquestion)
        {
            Time = _time;
            NoOfQuestion = _noOfquestion;
        }
        public abstract void CreateListOfQuestions();
        public abstract void ShowExam();
    }
}
