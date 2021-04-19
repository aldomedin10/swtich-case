using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtich_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //opciones 
            Console.WriteLine("Elige una opcion\n" +
                "\n1. - suma" +
                "\n2. - resta" +
                "\n3. - multiplicacion" +
                "\n4. - division" +
                "\n5. - salir"
                );

            string s1 = null;
            int i1 = 0;
            //s1 = console.readline();
            i1 = Convert.ToInt32(Console.ReadLine());

            switch (s1)
            {
                case 1:
                    Console.WriteLine("seleccionaste la suma");
                    break;
                case 2:
                    Console.WriteLine("seleccionaste la resta");
                    break;
                case 3:
                    Console.WriteLine("seleccionaste la multiplicacion");
                    break;
                case 4:
                    Console.WriteLine("seleccionaste la division");
                    break;
                case 5:
                    Console.WriteLine("seleccionaste salir");
                    break;
                default:
                    Console.WriteLine("la opcion es incorrecta, try again :(");
                    break;

            }
            Console.ReadKey();

        }
    }
}
