using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_proxy_pattern_example
{
    public class BookProxy : IBook
    {
        private Book _book;

        public BookProxy()
        {
            _book = new Book();
        }

        public void ChangeTitle(string title)
        {
            _book.ChangeTitle(title);
        }

        public void ChangeAuthor(string author)
        {
            _book.ChangeAuthor(author);
        }

        public void ChangeCoverColor(string color)
        {
            _book.ChangeCoverColor(color);
        }

        public void AddPages(int count)
        {
            _book.AddPages(count);
        }

        public override string ToString()
        {
            return _book.ToString();
        }
    }
}
