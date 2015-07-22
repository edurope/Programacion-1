using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta
{
    class Program
    {
        static void Main(string[] args)
        {

            char continuar = 's';
            byte contador = 0;
           

            
            while(continuar == 's'){
                
                try{
                    Console.WriteLine("Bienvenido, ésta es una encuesta para conocer su opinión acerca del proceso de paz en Colombia");    
                    Console.WriteLine("Digita tu nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Digita tu edad");
                    byte edad = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Digita tu genero masculino: m  femenino: f");
                    char genero = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Digita tu estrato socio-económico");
                    byte estrato = Convert.ToByte(Console.ReadLine());
                    
                    Console.WriteLine("En el proceso de paz que atraviesa Colombia, cree Usted que el cese bilateral del fuego se logrará en el 2015 (s/n) ? ");
                    
                    

                    contador += 1;
                    
                    Console.WriteLine("Desea continuar?");
                   

                    Console.ReadKey();
                }
                
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                
            }
        }
    }
}
