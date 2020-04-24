using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationDirector director = new NotificationDirector();
            ConsoleNotification notification = director.CreateERRORotification("Petar");
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
        }
    }
}
