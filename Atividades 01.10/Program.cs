using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_01._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercicio1();
            exercicio2();
            exercicio3();
        }

        private static void exercicio1()
        {
            // Declarando uma variável do tipo inteiro
            int numeroInteiro = 10;

            // Declarando uma variável do tipo real (double)
            double numeroReal = 20.5;

            // Declarando uma variável do tipo caractere
            char caractere = 'A';

            // Exibindo os valores das variáveis
            Console.WriteLine("Número Inteiro: " + numeroInteiro);
            Console.WriteLine("Número Real: " + numeroReal);
            Console.WriteLine("Caractere: " + caractere);

            Console.ReadKey();
        }
        private static void exercicio2()
        {
            const double PI = 3.14159;
            Console.WriteLine("Digite o raio do cálculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double area = PI * raio * raio;

            Console.WriteLine("A área do circulo é: " + area);
        }
        private static void exercicio3()
        {
            
        }
    }
}
