using System;

namespace ToDoApp
{

    class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Welcome to Jon's To-Do App!");
                Console.WriteLine("This is a simple console application to manage your daily tasks.");
                Console.WriteLine("You can add, view, edit and delete tasks.");
                Console.WriteLine("What would you like to do? TELL MEEE!");

                Console.WriteLine("\n---To-Do App Menu---");
                Console.WriteLine("1. Add a new task");
                Console.WriteLine("2. Edit a Task");
                Console.WriteLine("3. Delete a Task");
                Console.WriteLine("4. View all tasks");
                Console.WriteLine("5. Exit the application");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddTask.AddNewTask();
                }
                else if (choice == "2")
                {
                    // need to finish
                }
                else if (choice == "3")
                {
                    RemoveTask.DeleteTask();
                }
                else if (choice == "4")
                {
                    ShowTasks.DisplayTasks();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Smell ya later!");
                    break;
                }



            }
        }
    }
}