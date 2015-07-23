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
            int ceseSI = 0;
            int ceseNO = 0;
            int hombreSI = 0;
            int hombreNO = 0;
            int mujerSI = 0;
            int mujerNO = 0;
            int estrato1 = 0;
            int estrato2 = 0;
            int estrato3 = 0;
            int estrato4 = 0;
            int estrato5 = 0;
            int estrato6 = 0;

            char continuar = 's';
            
            float encuestados = 0;

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

                    char rta = Convert.ToChar(Console.ReadLine());


                    switch (rta) 
                    {
                        case 's': ceseSI++;
                            break;
                        case 'n': ceseNO++;
                            break;
                    }

                    if(rta == 's')
                    {
                        if (genero == 'm') hombreSI++;
                        else mujerSI++;
                    }

                    if (rta == 'n')
                    {
                        if (genero == 'm') hombreNO++;
                        else mujerNO++;
                    }

                    switch (estrato)
                    {
                        case 1: estrato1++;
                            break;
                        case 2: estrato2++;
                            break;
                        case 3: estrato3++;
                            break;
                        case 4: estrato4++;
                            break;
                        case 5: estrato5++;
                            break;
                        case 6: estrato6++;
                            break;
                    }

                    encuestados += 1;
                    
                    Console.WriteLine("Desea continuar?");
                    continuar = Convert.ToChar(Console.ReadLine());
                }
                
                catch(Exception excep)
                {
                    Console.WriteLine(excep.Message);
                }
                

                    
            }

            Console.WriteLine("El numero de encuestados es {0}", encuestados);

            float porceSI = (ceseSI / encuestados) * 100;
            float porceNO = (ceseNO / encuestados) * 100;


            Console.WriteLine("Hombres SI {0}", hombreSI);
            Console.WriteLine("Mujeres SI {0}", mujerSI);
            Console.WriteLine("Hombres NO {0}", hombreNO);
            Console.WriteLine("Mujeres NO {0}", mujerNO);

            Console.WriteLine("Los de estrato 1 son {0}", estrato1);
            Console.WriteLine("Los de estrato 2 son {0}", estrato2);
            Console.WriteLine("Los de estrato 3 son {0}", estrato2);
            Console.WriteLine("Los de estrato 4 son {0}", estrato3);
            Console.WriteLine("Los de estrato 4 son {0}", estrato4);
            Console.WriteLine("Los de estrato 5 son {0}", estrato5);
            Console.WriteLine("Los de estrato 6 son {0}", estrato6);


            Console.WriteLine("porcentaje ceseSI es {0} % ", porceSI);
            Console.WriteLine("porcentaje ceseNO es {0} % ", porceNO);
            

            Console.ReadKey();
        }
    }
}
