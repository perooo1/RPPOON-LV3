using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Logger
    {
        private string filename = "LogFile.txt";
        private Logger instance;

        public Logger GetInstance()
        {
            if (instance == null) instance = new Logger();
            return instance;
        }

        public void SetFileName(string name) { this.filename = name; }

        public void LogToFile(string dataToWrite)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename))
            {
                writer.WriteLine(dataToWrite);
            }
        }

        /*Ako datoteka nije ponovno postavljena, odnosno ako se ne mijejna putanja, onda će pisati u istu datoteku*/

    }
}
