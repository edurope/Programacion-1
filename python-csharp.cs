using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hola Mundo 
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Digita tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " Bienvenido a C#");
            Console.ReadKey();


            // Ganadores de un partido
            Console.WriteLine("Ganadores de un partido");
            Console.WriteLine("Digita el nombre del primer equipo");
            string equipo1 = Console.ReadLine();
            Console.WriteLine("Cuántos goles hizo?");
            byte goles1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digita el nombre del segundo equipo ");
            string equipo2 = Console.ReadLine();
            Console.WriteLine("Cuántos goles hizo");
            byte goles2 = Convert.ToByte(Console.ReadLine());


            if (goles1 > goles2) 
            {
               Console.WriteLine("Ganó el " + equipo1);
            }
            else if(goles2 > goles1)
            {
               Console.WriteLine("Ganó el " + equipo2);
            }

            else
            {
               Console.WriteLine("Empate entre " + equipo1 + " y " + equipo2);
            }

            Console.ReadKey();


            // Notas
            float nota1 = -1;
            while (nota1 < 0 || nota1 > 5)
            {
               Console.WriteLine("Ingrese la nota que desea sacar en el parcial (0.0 - 5.0) ");
               nota1 = Convert.ToSingle(Console.ReadLine());

            }
            Console.WriteLine("Su nota es: " + nota1);
            
            Console.WriteLine("pulse una tecla para continuar con el bucle For");
            Console.ReadKey();

            // Bucle For
            byte num = 50;
            for (byte i = 0; i <= num; i+=5)
            {
               Console.WriteLine(i);
            }
            Console.WriteLine("pulse una tecla para continuar con validación de tipo ");
            Console.ReadKey();

            // While Validar tipo
            bool continuar = false;
            byte number;
            while(continuar != true){
                Console.WriteLine("Ingresa un valor numero entero ");
                try 
                {
                    number = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Dado que el valor digitado fue entero, continuamos");
                    continuar = true;
                    Console.WriteLine("pulse una tecla para terminar ");
                    Console.ReadKey();
                }
                catch(Exception e){
                    Console.WriteLine(e.Message);
                    Console.Write("El valor digitado no fue un entero ");
                    Console.Write("nos salimos de try y ahora estamos en catch \n");
                }
            }
            
  
        }
    }
}
