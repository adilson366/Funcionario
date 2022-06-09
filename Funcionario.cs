using System;
using System.Globalization;


namespace ConsoleApp41
{
    class Funcionario
    {
        public string Name { get; private set; }
        public double SalarioBruto { get; private set; }
        public double Imposto { get; private set; }

        public Funcionario(string name, double salarioBruto, double imposto)
        {
            Name = name;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentaSalario(double porcentagem)
        {
            SalarioBruto *= (1 + porcentagem / 100);
        }

        public override string ToString()
        {
            return "Funcionário: "
                + Name
                + " $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
