using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_semana_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el nuero de jugadores totales");
            int n = int.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            int carta1 = 0;
            int carta2 = 0;
            int cartaN = 0;
            int total = carta1 + carta2;
            int[] puntaje = new int[n];
            string[] jugador = new string[n];
            int ganador = 0;
            int o = 0;
            string nganador = "";
            string continuar = "s";

            for (int i = 0; i < n; i++) {
                o++;
                Console.WriteLine("Bienvenido jugador "+o +" escriba su nombre");
                jugador[i] = Console.ReadLine();
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                total = carta1 + carta2;
                Console.WriteLine("su primera carta es =" + carta1);
                Console.WriteLine("su segunda carta es =" + carta2);
                Console.WriteLine("Sus puntos son =" + total);
                Console.WriteLine("Desea continuar (s/n)");
                continuar = Console.ReadLine();
                if (continuar == "s")
                {
                    while (continuar == "s" && total < 21)
                    {
                        cartaN = aleatorio.Next(1, 11);
                        total += cartaN;

                        if (total > 21)
                        {
                            Console.WriteLine("Perdio");
                            Console.WriteLine("Su nueva carta fue =" + cartaN);
                        }
                        else if (total == 21)
                        {
                            Console.WriteLine("gano");
                            Console.WriteLine("Su nueva carta fue =" + cartaN);
                        }
                        else
                        {
                            Console.WriteLine("Su nueva carta es =" + cartaN);

                            Console.WriteLine("Sus puntos son =" + total);
                            Console.WriteLine("Desea continuar (s/n)");
                            continuar = Console.ReadLine();
                        }
                    }
                    Console.WriteLine("Su total fue =" + total);
                    Console.WriteLine("Gracias por participár");
                }
                else
                {
                    Console.WriteLine("Su total fue =" + total);
                    Console.WriteLine("Gracias por participár");
                }
                puntaje[i] = total;
                total = 0;
            }
            for(int i = 0; i < n; i++)
            {
                if (puntaje[i] == 21)
                {
                    ganador = puntaje[i];
                    nganador = jugador[i];
                    break;
                }
                if (puntaje[i] > ganador && puntaje[i] <= 21)
                {
                    ganador = puntaje[i];
                    nganador = jugador[i];

                }
            }
            Console.WriteLine("El ganador es "+nganador);
            Console.WriteLine( nganador +" obtubo un total de "+ganador+" putos");

        }
    }
}
