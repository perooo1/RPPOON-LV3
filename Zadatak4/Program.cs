using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleNotification notification = new ConsoleNotification("Petar", "Test obavijest", "Ovo je test notification", DateTime.Now, Category.INFO, ConsoleColor.DarkMagenta);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
        }
    }
}
