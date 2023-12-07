using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_4
{
    public class Book
    {
        public string Title { get; set; }
        public string Status { get; private set; } // Status is private set to control changes through method.

        private List<IBookObserver> _observers = new List<IBookObserver>(); // List of observers to notify.

        public Book(string title)
        {
            Title = title;
            Status = "Available"; // Default status.
        }

        public void ChangeStatus(string newStatus)
        {
            Status = newStatus; // Changing the status.
            NotifyObservers(); // Notifying observers about the status change.
        }

        public void AttachObserver(IBookObserver observer)
        {
            _observers.Add(observer); // Attach a new observer.
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this); // Notify each observer about the change.
            }
        }
    }
}
