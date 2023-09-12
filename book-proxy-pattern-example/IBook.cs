using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_proxy_pattern_example
{
    public interface IBook
    {
        void ChangeTitle(string title);
        
        void ChangeAuthor(string author);

        void ChangeCoverColor(string color);

        void AddPages(int count);
    }
}
