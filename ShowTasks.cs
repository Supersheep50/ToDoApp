using System;

namespace ToDoApp
{
    class ShowTasks
    {
        public static void DisplayTasks()
        {
            if (TaskStore.Tasks.Count == 0)
            {
                Console.WriteLine("You have no tasks to show!");
            }
            else
            {
                Console.WriteLine("Here are your tasks:");
                for (int i = 0; i < TaskStore.Tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {TaskStore.Tasks[i]}");
                }
            }
        }
    }
}