using System;

namespace escola
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Olá, por favor insira seu nome:");
            string nome = Console.ReadLine();
        //-------------------------------------------------------
             Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Bem vindo! {nome}, por favor insira sua primeira nota:");
            float nota1 = float.Parse(Console.ReadLine());
        //--------------------------------------------------------
         
             Console.WriteLine("ótimo! agora insira sua segunda nota:");
             float nota2 = float.Parse(Console.ReadLine());
        //--------------------------------------------------------
             Console.WriteLine("ótimo! agora insira sua terceira nota:");
             float nota3 = float.Parse(Console.ReadLine());

        //=----------------------------------------------------------
            float media = nota1 + nota2 + nota3 / 3;

        if (media >= 7)
        {    Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ótimo {nome}, voce está aprovado");
            
        }else{
                Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine($"Que pena {nome}, voce foi reprovado, procure estudar mais!");
        }
                       
        }
    }
}
