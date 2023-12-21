using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean running = true;
            Message message = new Message(9, 13, 18);
            while (running)
            {
                Console.WriteLine("type '' to get message or exit then ENTER");
                string input = Console.ReadLine();
                if ( input == "")
                {
                    message.SetMessage();
                    Console.WriteLine(message._HelloMessage);
                } 
                else if (input.ToLower().Equals("exit"))
                {
                    running = false;
                }
            }
        }
    }
}

