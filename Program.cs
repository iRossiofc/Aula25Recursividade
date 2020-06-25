using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            fibo.GerarSequenciaFibonacci(0,1,15);
            System.Console.WriteLine(" ");
            System.Console.WriteLine(fibo.GerarFatorial(5));
        }
    }
}
