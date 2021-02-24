using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquaitance_with_Csh_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name, happy user?");
            string username;
            username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}! Today is {DateTime.Now}");
           
        }
    }
}
