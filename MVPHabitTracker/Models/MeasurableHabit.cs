using System;
using System.Collections.Generic;
using System.Text;

namespace MVPHabitTracker.Models
{
    internal class MeasurableHabit : Habit
    {
        public Dictionary<DateOnly, int> Measurements { get; private set; }
        public MeasurableHabit(string name, DateOnly createdAt) : base(name, createdAt)
        {
            Measurements = new Dictionary<DateOnly, int>(); 
        }
    }
}
