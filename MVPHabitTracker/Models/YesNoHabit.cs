using System;
using System.Collections.Generic;
using System.Text;

namespace MVPHabitTracker.Models
{
    internal class YesNoHabit : Habit
    {
        public HashSet<DateOnly> CompletedDates { get; private set; }
    }
}
