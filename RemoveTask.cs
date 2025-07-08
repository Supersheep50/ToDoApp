using System; 

namespace ToDoApp
{
    class RemoveTask
    {
        public static void DeleteTask()
        {
            ShowTasks.DisplayTasks();
            Console.WriteLine("Please enter a task to delete");
            string taskDelete = Console.ReadLine();

            TaskStore.Tasks.Remove(taskDelete);

            Console.WriteLine($"Task '{taskDelete}' has been removed successfully!");
        }
    }
}