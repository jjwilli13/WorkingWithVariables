using System;

namespace WorkingWithVariables  
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Copper";
            int dogAge = 4;
            char nickName = 'C';
            bool hatesBaths = true;
            double dogBones = 10;
            decimal weight = 12.2m;

            Console.WriteLine($"My dogs name is {dogName} but we call him {nickName}, and " +
                $"he is {dogAge} years old. He weighs {weight} pounds." +
                $"It is also {hatesBaths} that he hates baths.");

        

            
        }
    }
}

