using System;

namespace Hello_World_by_Kaylany
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            Console.Clear();
            Console.WriteLine("Por favor me diga seu nome: "); Nome = Console.ReadLine(); 
            Console.Clear();

            Console.WriteLine($"OOII {Nome} meu nome é Kaylany"); 
            Console.ReadKey();
            Console.WriteLine("Prazer em te conhecer!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Até a próxima {Nome}.");
            Console.ReadKey();
            Console.Clear();
               }
    }
}
