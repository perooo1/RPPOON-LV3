using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class NotificationDirector
    {
        public ConsoleNotification CreateINFONotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("N/A");
            builder.SetText("N/A");
            builder.SetLevel(Category.INFO);
            builder.SetColor(ConsoleColor.DarkMagenta);

            return builder.Build();
        }

        public ConsoleNotification CreateERRORotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("N/A");
            builder.SetText("N/A");
            builder.SetLevel(Category.ERROR);
            builder.SetColor(ConsoleColor.Red);

            return builder.Build();
        }

        public ConsoleNotification CreateALERTotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("N/A");
            builder.SetText("N/A");
            builder.SetLevel(Category.ALERT);
            builder.SetColor(ConsoleColor.DarkRed);

            return builder.Build();
        }
    }
}
