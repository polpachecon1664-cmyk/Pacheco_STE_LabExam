using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        Queue<string> students = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        int finished = 0;
        int choice = 0;

        do
        {
            Console.WriteLine("\nSTUDENT SERVICE QUEUE SYSTEM");
            Console.WriteLine("[1] - ADD STUDENT");
            Console.WriteLine("[2] - SHOW WAITING STUDENT");
            Console.WriteLine("[3] - SERVE NEXT STUDENT");
            Console.WriteLine("[4] - SHOW LAST SERVED STUDENT");
            Console.WriteLine("[5] - EXIT");
            Console.Write("ENTER A CHOICE: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Write("add student: ");
                    string student = Console.ReadLine();

                    students.Enqueue(student);
                    Console.WriteLine("new student has been added!");
                    break;
                case 2:
                    if (students.Count > 0)
                    {
                        Console.WriteLine("STUDENT WAITING: ");
                        foreach (string s in students)
                            Console.WriteLine(s);
                    }
                    else
                    {
                        Console.WriteLine(" no students waiting");
                    }
                            break;
                            case 3:
                                if (students.Count == 0)
                                {
                                    students.Dequeue();
                                    Console.WriteLine("serving student: ");
                                    Console.WriteLine(" STUDENT SUCCESFULLY SERVED: ");
                                }
                                break;
                case 4:
                                if (students.Count > 0)
                                    Console.WriteLine(" LAST SERVES STUDENT: " + students.Peek());
                                else
                                    Console.WriteLine("No studnet have beed served.");
                                {
                                    break;
                                }
                            case 5:
                                Console.WriteLine("Program ended.");
                                break;

                            default:
                                Console.WriteLine("Invalid choice!");
                                break;
                            }

                        } while (choice != 5) ;
                        Console.ReadKey();
                    }
            }
        
