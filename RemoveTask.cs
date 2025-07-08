using System; 

namespace ToDoApp
{
    class RemoveTask
    {
        public static void DeleteTask()
        {
            ShowTasks.DisplayTasks();
            Console.WriteLine("Please enter a task to delete");
            int index = int.Parse(Console.ReadLine()) - 1;
            string taskDelete = TaskStore.Tasks[index];

            if (index >= 0 && index < TaskStore.Tasks.Count)
            {
                TaskStore.Tasks.Remove(taskDelete);

                Console.WriteLine($"Task '{taskDelete}' has been removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }
    }
}