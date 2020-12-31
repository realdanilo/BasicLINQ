using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "my name is danilo";
            string[] names = { "danilo","dan","sharon","batman","rattatouie","francois","nicole","mike","jake","Yikes"};
            int[] numbers = { 12,4,3,1,11,8,99,0,3,2,2,6,19,23,83};

            var fivePlus = from number in numbers
                           where number < 5
                           select number;

            var
            //Query > IEnumerable
            //Cannot access [#]
            //Console.WriteLine(string.Join(" ",fivePlus));
        }
    }
}
