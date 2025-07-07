using System; 

namespace ToDoApp
{
    class AddTask
    {
        public static void AddNewTask()
        {
            Console.WriteLine("Please enter a task");
            string taskDescription = Console.ReadLine();

            TaskStore.Tasks.Add(taskDescription);

            Console.WriteLine($"Task '{taskDescription}' has been added successfully!");
        }
    }
}