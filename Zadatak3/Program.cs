using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.GetInstance().SetFileName("TestFileLogger.txt");
            logger.GetInstance().LogToFile("test123");
        }
    }
}
