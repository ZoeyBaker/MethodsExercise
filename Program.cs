using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Exercise 1----------------
            //Name: Zoey
            //Favorite color: Purple
            //Favorite Anmal: Lion
            //Favorite Band: Project 86

            Console.WriteLine("Hello - What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("---------------------------------");



            Console.WriteLine($"name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");

        }

    }


}








        


     





  

