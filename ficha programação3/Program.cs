using System;

namespace ficha_programação3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Digite um número positivo ou negativo:");
            numero = Double.Parse(Console.ReadLine());
            if (numero >= 0)
            {
                numero = Math.Sqrt(numero);
                Console.WriteLine("A raiz quadrada do número informado é: {0}", numero);
            }
            else
            {
                numero = Math.Pow(numero, 2);
                    Console.WriteLine("O valor do número informado elevado a 2 é:{0}", numero);
            }
            Console.ReadLine();
        }
    }
}
