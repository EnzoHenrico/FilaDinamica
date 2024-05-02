
namespace FilaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonQueue queue = new();
            Person person1 = new("Enzo");
            Person person2 = new("Odair");
            Person person3 = new("Luigi");

            queue.Push(person1);
            queue.Push(person2);
            queue.Push(person3);
            Console.WriteLine("Fila: " + queue);
            
            Console.WriteLine();
            
            queue.Pop();
            Console.WriteLine("Fila c/ remoção: " + queue);

        }
    }
}
