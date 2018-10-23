using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    class Person
    {
        protected double age;
        protected string name;

        public Person(string name, double age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(Person p)
        {
            this.name = p.name;
            this.age = p.age;
        }

        public double GASAge
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string GASName
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return "Name = " + this.name + " Age = " + this.age;
        }
    }   
}