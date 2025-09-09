using System;

namespace Postulante
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de preguntas que se realizaron");
            string linea = Console.ReadLine();
            double preg = double.Parse(linea);

            Console.WriteLine("Ingrese la cantidad que contestó correctamente");
            linea = Console.ReadLine();
            double correc = double.Parse(linea);

            double porc = correc / 100 * preg;
            double noventa = 90.0 / 100 * preg;
            double sete = 75.0 / 100 * preg;
            double cinc = 50.0 / 100 * preg;
            
            if (porc >= noventa)
            {
                Console.WriteLine("Nivel Máximo");
            }
            else
            {
                if (porc >= sete && porc < noventa)
                {
                    Console.WriteLine("Nivel Medio");
                }
                else
                {
                    if (porc >= cinc && porc < sete)
                    {
                        Console.WriteLine("Nivel Regular");
                    }
                    else
                    {
                        Console.WriteLine("Fuera de nivel");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
