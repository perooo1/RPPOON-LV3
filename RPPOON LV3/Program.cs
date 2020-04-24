using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/korisnik/source/repos/RPPOON LV3/CSVfile.txt";
            Dataset dataset = new Dataset();

            dataset.LoadDataFromCSV(filePath);

            dataset.clone();
        }
    }
}
