using System;
using System.Globalization;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func;
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine());

            func = new Funcionario(name, salarioBruto, imposto);

            Console.WriteLine();
            Console.WriteLine(func);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentaSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

        }
    }
}
