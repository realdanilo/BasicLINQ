using System;
using System.Collections.Generic;
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

            //Console.WriteLine(string.Join(" ",fivePlusOrder));

            List<Person> people = new List<Person>()
            {
                new Person("john",123,33,Gender.male),
                new Person("dan",401,11,Gender.male),
                new Person("olive",23,99,Gender.female),
                new Person("paul",82,3,Gender.male),
                new Person("jud",66,100,Gender.female),
                new Person("cate",144,563,Gender.male),
                new Person("mu",893,93,Gender.other),
                new Person("jake",199,99,Gender.male),
                new Person("xion",12,10,Gender.other),

            };

            var threeCharPeople = from p in people
                                 where p.name.Length <= 5
                                 orderby p.name , p.height descending
                                 select p;
            //selects only strins, not people
            var onlyNames = from p in people
                            where p.name.Length <= 3
                            orderby p.weight
                            select p.name;

            foreach (var i in threeCharPeople)
            {
                Console.WriteLine($"{i.name}  {i.height}");
            }

            /*foreach (var item in onlyNames)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
