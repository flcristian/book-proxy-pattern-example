using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_proxy_pattern_example
{
    public class Book : IBook
    {
        private string _title;
        private string _author;
        private string _coverColor;
        private int _pages;

        // Constructors

        public Book(string title, string author, string coverColor, int pages)
        {
            _title = title;
            _author = author;
            _coverColor = coverColor;
            _pages = pages;
        }

        public Book()
        {
            _title = "Title";
            _author = "Author";
            _coverColor = "Black";
            _pages = 10;
        }

        public void ChangeTitle(string title)
        {
            _title = title;
        }

        public void ChangeAuthor(string author)
        {
            _author = author;
        }

        public void ChangeCoverColor(string color)
        {
            _coverColor = color;
        }

        public void AddPages(int count)
        {
            _pages += count;
        }

        public override string ToString()
        {
            String desc = "";
            desc += $"Title : {_title}\n";
            desc += $"Author : {_author}\n";
            desc += $"Cover Color : {_coverColor}\n";
            desc += $"Page count : {_pages}\n";
            return desc;
        }
    }
}
