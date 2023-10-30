using System;
using System.Collections.Generic;
namespace Library
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public List<Person> Children { get; private set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Children = new List<Person>();
        }

        public void AddChildren(Person child)
        {
            this.Children.Add(child);
        }
    }
}