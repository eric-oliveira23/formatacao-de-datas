
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatacaocs
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, valord, valorm;
            DateTime data = DateTime.Now;

            Console.WriteLine("Data de Hoje: " + data.ToString());
            Console.WriteLine("Dia Atual: " + data.ToString("dd"));
            Console.WriteLine("Dia da Semana: " + data.ToString("dddd"));

            Console.WriteLine("Mês Atual: " + data.ToString("dd"));
            Console.WriteLine("Dia da Semana: " + data.ToString("dddd"));


            Console.WriteLine("Digite o valor para ser formatado.");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor formatado é " + valor.ToString("F"));
            Console.WriteLine("O valor formatado é " + valor.ToString("N"));

            Console.WriteLine("O valor formatado é " + valor.ToString("F1"));
            Console.WriteLine("O valor formatado é " + valor.ToString("N1"));

            Console.WriteLine("O valor formatado é " + valor.ToString("F3"));
            Console.WriteLine("O valor formatado é " + valor.ToString("N3"));

            Console.WriteLine("Digite qualquer tecla para continuar.");
            Console.ReadKey();

            Console.WriteLine("Digite o valor decimal para ser formatado.");
            valord = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor formatado é " + valord.ToString("P"));
            Console.WriteLine("O valor formatado é " + valord.ToString("P1"));

            Console.WriteLine("O valor formatado é " + valord.ToString("P3"));
            Console.WriteLine("O valor formatado é " + valord.ToString("P8"));
             
            Console.WriteLine("Digite qualquer tecla para continuar.");
            Console.ReadKey();

            Console.WriteLine("Digite o valor monetário para ser formatado.");
            valorm = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor formatado é " + valorm.ToString("C"));
            Console.WriteLine("O valor formatado é " + valorm.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ja-JP")));

            Console.WriteLine("O valor formatado é " + valorm.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US")));
            Console.WriteLine("O valor formatado é " + valorm.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-AG")));

            Console.WriteLine("Digite qualquer tecla para continuar.");
            Console.ReadKey();














        }
    }
}
