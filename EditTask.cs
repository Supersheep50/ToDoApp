using System;

namespace ToDoApp
{

    class EditTask
    {
        public static void UpdateTask()
        {
            ShowTasks.DisplayTasks();
            Console.WriteLine("Please enter the task number you want to edit:");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < TaskStore.Tasks.Count)
            {

                Console.WriteLine("Please enter a new task description:");
                string newTaskDescription = Console.ReadLine();
                TaskStore.Tasks[index] = newTaskDescription;
                Console.WriteLine($"Task {index + 1} has been updated to '{newTaskDescription}' successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }
    }
}