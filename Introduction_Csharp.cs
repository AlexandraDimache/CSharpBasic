using System;
using System.Diagnostics;

namespace CsharpBasic // Colectie de clase
{
    class Program // reprezinta un prototip al obiectelor
    {
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            Console.WriteLine("Hello World!");
            messages.PrintMessages();

        }

    }
    public class Messages
    {
        public void PrintMessages()
        {
            int age;
            age = 25;
            bool student;
            //Console.WriteLine("New Messages: ");
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            /*
            if(student == true)
            {
                student = true;
                Console.WriteLine(name + " is a student");
            }
            else if (!(student == true)){

                Console.WriteLine(name + " is not a student");   
            }

            else
            {
                Console.WriteLine("Failed");
            }
            
            // While loops
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            while (age < 18)
            {
                Console.WriteLine("Age: " + age + " - " + name + " is not a student");
                break;
            }
            while (age >= 18)
            {
                Console.WriteLine("Age: " + age + " - " + name + " can be a student");
                break;
            }
            
            // For Loop
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("For Loop condition number: " + i);
            }
            */
            for (int i = 10; i >= 5; i--)
            {
                Console.WriteLine("For Loop condition number: " + i);
            }

        }
    }
}

