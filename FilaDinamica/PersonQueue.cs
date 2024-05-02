using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class PersonQueue
    {
        Person? head;
        Person? tail;
        int size;

        public PersonQueue()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public override string ToString()
        {
            string result = string.Empty;
            Person? aux = this.head;

            while (aux != null)
            {
                result += aux.ToString();
                aux = aux.GetNext();

                if (aux != null)
                {
                    result += ", ";
                }
            }

            return result;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public int GetSize()
        {
            return this.size;
        }

        public void Push(Person newPerson)
        {
            if (IsEmpty())
            {
                this.head = this.tail = newPerson;
            }
            else
            {
                this.tail?.SetNext(newPerson);
                this.tail = newPerson;
            }
            size++;
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                this.head = this.head?.GetNext();
                size--;
            }
        }

        public void PrintQueue() 
        {
            Console.WriteLine(this.ToString());
        }
    }
}
