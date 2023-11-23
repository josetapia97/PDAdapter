using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx1
{
    public class CommunicationSystem
    {
        public void StartConversation(ICommunication communicator, string question, string answer)
        {
            Console.WriteLine(communicator.Ask(question));
            Console.WriteLine(communicator.Reply(answer));
        }
    }
}
