using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoAltura
{
    internal class Program
    {
        static double aproveitamento(double pontos , double jogos)
        {
            return pontos /(jogos * 3) *100;
        }
        static void Main(string[] args)
        {
            string time;
            double resultado = 0;

            Console.WriteLine("O programa abaixo irá calcular a porcentagem de aproveitamento do time");

            Console.Write("\nDigite o nome do time: ");
            time = Console.ReadLine();

            Console.Write("\nEntre com o numero de pontos: ");
            int pontos = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com o número de jogos: ");
            int jogos = int.Parse(Console.ReadLine());

            resultado = aproveitamento(pontos, jogos);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n O {time} obteve {pontos} pontos em {jogos} jogos.");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"\nSeu aproveitamento é de {resultado:F1}%");

            Console.ReadLine();

        }
    }
}
