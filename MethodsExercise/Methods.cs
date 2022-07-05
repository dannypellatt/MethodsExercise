using System;
namespace MethodsExercise
{
    public class Methods
    {
        public static void MethodsExercise()
        {
            Console.WriteLine("What is your name?");
            var returnedName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var returnedColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var returnedAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var returnedBand = Console.ReadLine();

            Console.WriteLine($"Your name is {returnedName}, your favorite color is {returnedColor}, " +
                $"your favorite animal is {returnedAnimal} and your favorite band is {returnedBand}!");
        }
    }
}

