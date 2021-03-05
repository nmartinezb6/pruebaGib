using System;

namespace adivinar_la_fecha_de_cumpleaños
{
    class Program
    {
        static void Main(string[] args)
        {
            int calculo, dato;
            string dia, mes, resultado;

            Console.WriteLine("Piensa en el dia que naciste");
            Console.ReadKey();
            Console.WriteLine("Ahora multiplicalo por 20");
            Console.ReadKey();
            Console.WriteLine("Al resultado sumale 73");
            Console.ReadKey();
            Console.WriteLine("Ahora multiplicalo por 5");
            Console.ReadKey();
            Console.WriteLine("Ahora sumale la fecha en que nacisiste, es decir el numero del mes");
            Console.ReadKey();
            Console.WriteLine("Ppr favor insgresa el resultado de tu operacion");
            dato = int.Parse(Console.ReadLine());
            calculo = dato - 365;

            resultado = Convert.ToString(calculo);

            dia = resultado.Substring(0, 2);
            mes = resultado.Substring(2, 2);




            Console.WriteLine("El dia en que naciste es:" + dia);
            Console.WriteLine("El mes en que naciste es:" + mes);
            Console.ReadKey();

        }
    }
}
