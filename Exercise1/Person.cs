using System;

namespace Exercise1
{
    public class Person
    {
        private string name = "Amar";
        private int age = 40;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }
    }
    
}