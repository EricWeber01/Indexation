using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexation
{
    public class Person
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public override string ToString()
        {
            return $"{Name} | {Age}";
        }
    }
    public class People
    {
        Person[] p = new Person[3];
        public People()
        {
            p[0] = new Person { Name = "Денис", Age = 19 };
            p[1] = new Person { Name = "Артур", Age = 19 };
            p[2] = new Person { Name = "Ренат", Age = 20 };
        }
        public int GetAge(double _age)
        {
            int index = -1;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].Age == _age)
                    index = i;

            }
            return index;

        }
        enum Names { Олег, Илья, Ренат };
        public Person this[double index]
        {
            get
            {
                if (GetAge(index) != -1)
                    return p[GetAge(index)];
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public Person this[string name]
        {
            get
            {
                if (Enum.IsDefined(typeof(Names), name))
                    return p[(int)Enum.Parse(typeof(Names), name)];
                else
                    return new Person();
            }
        }
    }
}
