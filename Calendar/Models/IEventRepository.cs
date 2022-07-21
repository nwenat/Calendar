using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public interface IEventRepository
    {
        Event GetEvent(int Id);
        IEnumerable<Event> GetAllEvent();
        Event Add(Event newEvent);
        Event Update(Event eventChanges);
        Event Delete(int id);
        SortedList<int, IEnumerable<Event>> GetWeekEvents(int dayNumber, int indexWeek);
        SortedList<int, IEnumerable<Event>> GetWeekEventsPerUser(int dayNumber, int indexWeek, string userId);
    }
}
