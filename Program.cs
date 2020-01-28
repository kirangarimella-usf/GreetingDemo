using System;

namespace GreetingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Are you ok?";
            string nextGreeting = "";

            if (greeting == "Hello World!")
            {
                nextGreeting = "It's great to be born!";
            }
            else if (greeting == "Hey there!")
            {
                nextGreeting = "I'm about to be born!";
            }
            else if (greeting == "Are you ok?")
            {
                nextGreeting = "Yup! All good.";
            }

            Console.WriteLine(nextGreeting);
           
        }
    }
}
