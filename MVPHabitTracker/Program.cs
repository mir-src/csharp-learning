using System;
using MVPHabitTracker.Models;
using MVPHabitTracker.Services;

namespace MVPHabitTracker;

class Program
{
    public static void Main(string[] args)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);  
        YesNoHabit habitOne = new YesNoHabit("Coding",today); 
        YesNoHabit habitTwo = new YesNoHabit("Japanese",today); 

        HabitService habits = new HabitService();
        habits.AddHabit(habitOne);
        habits.AddHabit(habitTwo);
        List<Habit> habitList = habits.GetHabits();
        foreach (Habit habit in habitList)
        {
            Console.WriteLine($"{habit.Name} | {habit.CreatedAt}");
        }
    }
}