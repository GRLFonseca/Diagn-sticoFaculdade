using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


namespace AvaliacaoDiagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade Diagnóstica \nGabriel Rodrigues Lima Fonseca - ADS - Manhã");
            Console.WriteLine("Questão 1: ");
            int a = 10;
            int b = 20;
            a = b;
            b = a - 10;
            Console.WriteLine(a + " " + b);
            Console.WriteLine("Aperte enter para ir para a próxima questão!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Questão 2: ");
            Console.WriteLine("Item a: Será impresso 10 e 5\nItem B: será impresso 30,  10 e 40\nItem C: 10, 10, 10\nItem D: 14, 13\nItem E: 10, 20, 20\nItem F: 5, 6, 1.");
            Console.WriteLine("Questão 3: ");
            Console.WriteLine("Digite um número: ");
            int numLer = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");
            Console.WriteLine(numLer);
            Console.WriteLine("Aperte enter para ir para a próxima questão!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--------- Eleições 2020 ----------");
            Console.WriteLine("Qte de eleitores: ");
            int qtEleitores = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos nulos: ");
            int votoNulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos brancos: ");
            int votoBranco = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos válidos: ");
            int votoValido = int.Parse(Console.ReadLine());
            Console.WriteLine("Percentual votos em brancos: " + votoBranco / qtEleitores * 100 + "%");
            Console.WriteLine("Percentual votos nulos: " + qtEleitores / votoNulo * 100 + "%");
            Console.WriteLine("Percentual votos válidos: " + qtEleitores / votoValido * 100 + "%");
            Console.WriteLine("Aperte enter para ir para a próxima questão!");
            Console.ReadKey();
            Console.Clear();
            try
            {
                Console.WriteLine("Escreva sua idade nesse seguinte formato: (DD/MM/YYYY)");
                DateTime dataNive = DateTime.Parse(Console.ReadLine());
                DateTime d1 = DateTime.Now;
                TimeSpan Data = d1.Subtract(dataNive);
                Console.WriteLine("Da data do seu aniversário até hoje tem: " + Data + " dias");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Um erro ocorreu, verifique!" + e.Message);
            }
        }
    }
}
