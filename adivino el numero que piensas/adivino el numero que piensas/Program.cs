using System;

namespace adivino_el_numero_que_piensas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, divicion, resta;

            Console.WriteLine("piense en un numero, no lo olvide");
            Console.ReadKey();


            Console.WriteLine(" ahora multiplique su numero por 2 ");
            Console.ReadKey();

            Console.WriteLine(" al numero resultante sumele 8 ");
            Console.ReadKey();

            Console.WriteLine(" al resultado multipliquelo por 5 ");
            Console.ReadKey();

            Console.WriteLine("ingrese el resultado");
            valor = Convert.ToInt32(Console.ReadLine());

            divicion = valor / 10;
            resta = divicion - 4;



            Console.WriteLine("el numero resultante es: {0}", resta);
            Console.ReadKey();

        }
    }
}
