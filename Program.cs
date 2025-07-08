using System;

namespace ToDoApp
{

    class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Welcome to Steph's To-Do App!");
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
                    while (true)
                    {

                        Console.WriteLine("Would you like to add another task? (yes/no)");

                        string addAnother = Console.ReadLine().ToLower();

                        if (addAnother == "yes")
                        {
                            AddTask.AddNewTask();

                        }
                        else if (addAnother == "no")
                        {
                            Console.WriteLine("Returning to the main menu...");
                            break;
                        }
                    }
                }
                else if (choice == "2")
                {
                    EditTask.UpdateTask();
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