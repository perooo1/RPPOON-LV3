using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor("petar");
            builder.SetTitle("Test zadatak6");
            NotificationManager manager = new NotificationManager();
            manager.Display(builder.Build());
        }
    }
}
