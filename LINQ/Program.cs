using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "my name is danilo";
            string[] names = { "danilo","dan","sharon","batman","rattatouie","francois","nicole","mike","jake","Yikes", "yinyin","omg","Hello"};
            int[] numbers = { 12,4,3,1,11,8,99,0,3,2,2,6,19,23,83};

            var fivePlus = from number in numbers
                           where number < 5 || number >80
                           select number;

            var fivePlusOrder = from number in numbers
                                where number < 5 || number > 80
                                orderby number descending
                                select number;

            //Query > IEnumerable
            //Cannot access [#]
            //Runs only when is called

            var namesWithA = from name in names
                             where name.Contains("a") && name.Length <6
                             select name;
            
            Console.WriteLine(string.Join(" ",fivePlusOrder));
        }
    }
}
