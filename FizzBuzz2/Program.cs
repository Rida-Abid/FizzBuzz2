using System;

namespace FizzBuzz2
{
    public class Program
    {


        static void Main(string[] args)
        {

            if (args.Length != 3)
            {
                Console.WriteLine("Please enter 3 numbers: fizzId, buzzId, maxCount ");
            }
            else
            {

                var logic = new Logic();
                int fizzId = Convert.ToInt16(args[0]);
                int buzzId = Convert.ToInt16(args[1]);
                int maxCount = Convert.ToInt16(args[2]);
                var results = logic.Process(fizzId, buzzId, maxCount);
                foreach(var result in results )
                {
                    Console.WriteLine(result);
                }
               

            }



        }

    }
}