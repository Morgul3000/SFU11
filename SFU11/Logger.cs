using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFU11
{
    public class Logger : ILogger
    {
        public void Event(string mes)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mes);
        }
        public void Error(string mes)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mes);
        }
    }
}
