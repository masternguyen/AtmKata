using AtmKata.ConsoleUI;
using AtmKata.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmKata
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplication application = Factory.CreateApplication();
            application.Run();
        }
    }
}
