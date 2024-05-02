using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class Person
    {
        string name;
        Person? next;

        public override string ToString()
        {
            return this.name;
        }

        public Person(string name) 
        {
            this.name = name;
            this.next = null;
        }
        public void SetNext(Person? nextPerson)
        {
            this.next = nextPerson;
        }

        public Person? GetNext()
        {
            return this.next;
        }
    }
}
