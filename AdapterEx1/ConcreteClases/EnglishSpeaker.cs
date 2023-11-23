using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx1.ConcreteClases
{
    internal class EnglishSpeaker : ICommunication
    {
        public string Ask(string question)
        {
            return "Question in english: " + question;
        }

        public string Reply(string answer)
        {
            return "Answer in english: " + answer;
        }
    }
}
