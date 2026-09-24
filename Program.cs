using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lavoro_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("MENU");


            do
            {
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("1) Inserimento di un nuovo record");

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("2) Visualizzazione dei file");

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3) modifica di un record");

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4) cancellazione di un recod");

                            break;
                        }
                }




            }
            while (i != 0);




        }
    }
}
