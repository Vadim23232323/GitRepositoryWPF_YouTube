using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_13
{
    public struct book
    {
        private int pages;
        private string avtor, name;
        private short date;

        public book(int pages, string avtor, string name, short date)
        {
            this.pages = pages;
            this.avtor = avtor;
            this.name = name;
            this.date = date;
        }

        public void printBook()
        {
            Console.WriteLine($"Bookname: {name}, Author: {avtor}, Publication date {date}, Number of pages: {pages}");
        }
    }
}
