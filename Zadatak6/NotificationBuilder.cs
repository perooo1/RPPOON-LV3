﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    class NotificationBuilder : IBuilder
    {
        private string author = "N/A";
        private string title = "N/A";
        private string text = "N/A";
        private DateTime time = DateTime.Now;
        private Category level = Category.INFO;
        private ConsoleColor color = ConsoleColor.DarkMagenta;


        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color);
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.time = time;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }
    }
}
