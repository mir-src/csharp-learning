using System;
using System.Collections.Generic;
using System.Text;

namespace MVPHabitTracker.Models
{
    internal class MeasurableHabit : Habit
    {
        public Dictionary<DateOnly, int> Measurements { get; private set; }
    }
}
