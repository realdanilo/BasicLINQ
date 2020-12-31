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

            //people.ForEach(p => Console.WriteLine(p.gender));

            var threeCharPeople = from p in people
                                 where p.name.Length <= 5
                                 orderby p.name , p.height descending
                                 select p;
            //selects only strins, not people
            var onlyNames = from p in people
                            where p.name.Length <= 3
                            orderby p.weight
                            select p.name;

            /*foreach (var i in threeCharPeople)
            {
                Console.WriteLine($"{i.name}  {i.height}");
            }*/

            /*foreach (var item in onlyNames)
            {
                Console.WriteLine(item);
            }*/


            //Lambda
            var oddNums = from n in numbers
                          where n % 2 == 1
                          select n;

            var oddNumsLam = numbers.Where(n => n % 2==1);

            //
            var peopleLam = people.Where(p => p.name.Contains("e")).Select(p => p.height);
            //Console.WriteLine(string.Join(" ",peopleLam));


            var stringNums = "1,33,99,0,12,11,0,-9,4,11";

            List<int> numsInt = stringNums.Split(",")
                          .Select(e => int.Parse(e))
                          .ToList();


            // numsInt.ForEach(i => Console.WriteLine(i));

            var genderGroup = from p in people
                              group p by p.gender;

            /*foreach (var item in genderGroup)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine("\t"+p.name);
                }
            }*/

            var alphaPeople = from p in people
                              orderby p.name
                              group p by p.name[0];

            /*foreach (var item in alphaPeople)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine("\t" + p.name);
                }
            }*/

            var alphaPeopleLam = people.Where(p=> p.name.Contains("u")).OrderBy(p => p.name).GroupBy(p => p.name[0]);

            foreach (var item in alphaPeopleLam)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine("\t" + p.name);
                }
            }
        }
    }
}
