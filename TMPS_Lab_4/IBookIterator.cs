using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_4
{
    // Iterator Pattern
    public interface IBookIterator
    {
        bool HasNext();
        Book Next(); // Interface for iterating over book collections.
    }
}
