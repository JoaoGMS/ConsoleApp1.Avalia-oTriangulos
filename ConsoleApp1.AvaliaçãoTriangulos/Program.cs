using System;

namespace ConsoleApp1.AvaliaçãoTriangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▲▲Triangulos▲▲");
            
            string opçao;
            while (true)
            {

                int x, y, z;
                Console.Write("Digite o tamanho do primeiro lado:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o tamanho do segundo lado: ");
                y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o tamanho do terceito lado:");
                z = Convert.ToInt32(Console.ReadLine());

                





                if (x + y >= z && z + y >= x && x + z >= y)
                {
                    Console.WriteLine("Os três lados formam um triangulo");

                    if (x == y && x == z)
                    {
                        Console.WriteLine("EQUILATERO");


                    }

                    else
                        if (x == y || x == z || y == z)
                    {

                        Console.WriteLine("ISOCELES");

                    }

                    else Console.WriteLine("ESCALENO");


                }


                else Console.WriteLine("Os três lados não formam um triangulo");











                Console.WriteLine("▲▲▲Digite S para continuar▲▲▲");

                opçao = Console.ReadLine();

            } while (opçao == "s");
        }
    }
}
