using System;

namespace AreadoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do triângulo...");
            string altura = Console.ReadLine();
            Console.WriteLine("Digite a base do triângulo...");
            string base1 = Console.ReadLine();
            
            Double altura1 = Convert.ToDouble(altura);
            Double base2 = Convert.ToDouble(base1);

            Double x = base2 * altura1;
            Double y = x / 2;

            Console.WriteLine("A área é =" + " " + y);


        }
    }
}
