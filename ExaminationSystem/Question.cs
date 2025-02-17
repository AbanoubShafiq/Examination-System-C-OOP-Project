using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswser { get; set; }
        public Answer UserAnswer { get; set; }


        public Question()
        {
            RightAnswser = new Answer();
            UserAnswer = new Answer();
        }

        public abstract void AddQuestion();
        public override string ToString()
        {
            return $"{Header} \t Mark {Mark} \n" +
                   $"\n {Body} \n";
        }

    }
}
