using System.Security.Cryptography.X509Certificates;

namespace ex3
{
    internal class Program
    {
        public delegate void Ponteiro(double result);
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do retangulo:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a base do retangulo:");
            double baseRet = double.Parse(Console.ReadLine());

            Func <double, double, double> calcArea = (altura, baseRet) => (altura * baseRet);

            double areaRet = calcArea(altura, baseRet);

            Ponteiro ponteiro = result => Console.WriteLine($"A area do retangulo é {result}");
            ponteiro(areaRet);
        }

    }
}
