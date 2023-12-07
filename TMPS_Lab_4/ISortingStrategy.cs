using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_4
{
    // Strategy Pattern
    public interface ISortingStrategy
    {
        void Sort(List<Book> books); // Strategy interface for sorting books.
    }
}
