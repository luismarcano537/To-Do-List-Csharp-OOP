using System;
using System.Globalization;
using System.Collections.Generic;
using ToDoList.Models.Entities;
using ToDoList.Services;
using ToDoList.Exceptions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ItemManagement Management = new ItemManagement();
                Console.WriteLine("\nTo-Do Management App: ");

                Console.Write("Enter your first taks: ");
                string worktitem = Console.ReadLine();

                Management.AddWorkItem(worktitem);
                Console.Clear();

                bool active = true;

                while (active)
                {
                    Console.WriteLine("\n==============================");
                    Console.WriteLine("To-Do List App");
                    Console.WriteLine("==============================");
                    Console.WriteLine("1. Add new task");
                    Console.WriteLine("2. List pending tasks");
                    Console.WriteLine("3. Mark Task as Completed");
                    Console.WriteLine("4. Remove Task by ID");
                    Console.WriteLine("5. EXIT");
                    Console.WriteLine("==============================");
                    Console.Write("\nChoose an option (Only the number): ");

                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.Write("\nDescription of the new task: ");
                            string description = Console.ReadLine();
                            Management.AddWorkItem(description);
                            Console.WriteLine("\nTask added successfully.");
                            break;

                        case "2":
                            Console.WriteLine("\n===== Pending tasks =====");

                            List<WorkItem> PendingItems = Management.PendingItems();

                            if (PendingItems.Any())
                            {
                                foreach (WorkItem item in PendingItems)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nPending tasks are empty");
                            }

                            break;

                        case "3":
                            Console.WriteLine("\nCurrent task list: ");

                            List<WorkItem> AllItemsList = Management.PendingItems();

                            if (AllItemsList.Count == 0)
                            {
                                Console.WriteLine("\nThe task list is empty");
                            }
                            else
                            {
                                foreach (WorkItem item in AllItemsList)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                            }

                            Console.Write("\nEnter the task ID to complete: ");
                            int id = int.Parse(Console.ReadLine());

                            Management.MarkCompletedItem(id);
                            break;

                        case "4":
                            Console.WriteLine("\nCurrent task list: ");

                            AllItemsList = Management.AllItems();

                            if (AllItemsList.Count == 0)
                            {
                                Console.WriteLine("\nThe task list is empty");
                            }
                            else
                            {
                                foreach (WorkItem item in AllItemsList)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                            }

                            Console.Write("\nEnter the task ID to Remove: ");
                            if (int.TryParse(Console.ReadLine(), out int idRemove))
                            {
                                if (Management.RemoveWorkItem(idRemove))
                                {
                                    Console.WriteLine($"\nTask {idRemove} has been removed");
                                }
                                else
                                {
                                    Console.WriteLine("\nID not found");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Try");
                            }
                            break;

                        case "5":

                            active = false;
                            Console.WriteLine("\nClosing the App");
                            break;

                        default:

                            Console.WriteLine("\nOption invalid, please try again.");

                            break;
                    }
                    if (active)
                    {
                        Console.WriteLine("\nPlease, press ENTER to continue.");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Error Processing: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }

        }
    }
}