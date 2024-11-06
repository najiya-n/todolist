using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to TO DO program.");
            List<string> tasklist = new List<string>();
            string option = "";
            while(option != "e")
            {
                Console.Write("what would you like to do?.\n");
                Console.Write("enter 1 to add a task to the list.\n");
                Console.Write("enter 2 to remove a task from the list.\n");
                Console.Write("enter 3 to view the list.\n");
                Console.Write("enter e to exit from the list\n");

                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("please enter the name of the task to add to the list");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine("task added to the list.");
                }
                else if(option == "2") {
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + ":" + tasklist[i]);

                    }
                    Console.WriteLine("please enter the number of the task to remove from the list.");
                    int tasknum = int.Parse(Console.ReadLine());
                    tasklist.RemoveAt(tasknum);
                }
                else if(option == "3") {
                    Console.WriteLine("current taskmin the list :");
                    for(int i = 0;i < tasklist.Count;i++)
                    {
                        Console.WriteLine(tasklist[i]);
                    }
                
                }
                else if (option == "e")
                {
                    Console.WriteLine("exiting program");
                }
                else { 
                    Console.WriteLine("invalid option,please try again.");
                }
                    

                


                     

       

            }

            
                
        }
    }
}
