using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_4
{
    public class TitleSortStrategy : ISortingStrategy
    {
        public void Sort(List<Book> books)
        {
            books.Sort((x, y) => x.Title.CompareTo(y.Title)); // Sorting by title.
        }
    }
}
