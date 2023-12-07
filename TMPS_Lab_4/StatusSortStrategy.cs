using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_4
{
    public class StatusSortStrategy : ISortingStrategy
    {
        public void Sort(List<Book> books)
        {
            books.Sort((x, y) => x.Status.CompareTo(y.Status)); // Sorting by status.
        }
    }
}
