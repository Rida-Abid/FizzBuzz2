using System;

namespace FizzBuzz2
{
    public class Logic
    {
        const string fizz = "fizz";
        const string buzz = "buzz";

        public Logic()
        {
        }


        public List<string> Process(int fizzId, int buzzId, int maxCount)
        {
            var result = new List<string>();
            if (maxCount < 1)
            {
                result.Add("Please enter a maxCount of more than 0");
                return result;
            }

            if (fizzId < 1)
            {
                result.Add("Please enter a fizzId of more than 0");
                return result;
            }

            if (buzzId < 1)
            {
                result.Add("Please enter a buzzId of more than 0");
                return result;
            }



            for (int i = 1; i <= maxCount; i++)
            {
                result.Add(calculation(i, fizzId, buzzId));
            }
             return result;

        }



        private static string calculation(int value, int fizzId, int buzzId)
        {
            if (fizzId == 0 || buzzId == 0)
            {
                return "0";
            }
            if (value % fizzId == 0 && value % buzzId == 0)
            {
                return fizz + buzz;
            }
            else if (value % fizzId == 0)
            {
                return fizz;
            }
            else if (value % buzzId == 0)
            {
                return buzz;
            }
            else
            {
                return value.ToString();
            }
        }

        
    }
}