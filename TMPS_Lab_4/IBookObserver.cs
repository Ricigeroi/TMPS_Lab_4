using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_4
{
    // Observer Pattern
    public interface IBookObserver
    {
        void Update(Book book); // Observer interface for notification of state changes in Book objects.
    }
}
