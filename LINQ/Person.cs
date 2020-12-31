using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Person
    {
        public string name;
        public int height;
        public int weight;

        public Gender gender;

        public Person(string name, int height, int weight, Gender gender)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.gender = gender;

        }
    }

    enum Gender
    {
        male,
        female,
        other
    }
}
