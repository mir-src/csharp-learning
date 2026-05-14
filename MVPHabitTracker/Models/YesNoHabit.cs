using System;
using System.Collections.Generic;
using System.Text;

namespace MVPHabitTracker.Models
{
    internal class YesNoHabit : Habit
    {
        public HashSet<DateOnly> CompletedDates { get; private set; }
        public YesNoHabit(string name, DateOnly createdAt) : base(name, createdAt)
        {
            CompletedDates = new HashSet<DateOnly>();
        }
    }
}
