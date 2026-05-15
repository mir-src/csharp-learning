using System;
using System.Collections.Generic;
using System.Text;
using MVPHabitTracker.Models;

namespace MVPHabitTracker.Services
{
    internal class HabitService
    {
        List<Habit> Habits;
        public HabitService()
        {
            Habits = new List<Habit>();
        }
        public void AddHabit(Habit habit)
        {
            Habits.Add(habit);
        }
        public List<Habit> GetHabits()
        {
            return Habits;
        }
    }
}
