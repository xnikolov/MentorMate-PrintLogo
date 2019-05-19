using System;
using System.Collections.Generic;
using System.Text;

namespace Sunglasses
{
    public class Printer
    {
        //initialize vars
        private const char asterics = '*';
        private const char space = '-';

        public static int count = 0;

        //method prints the MM pattern
        public static void printMM()
        {
            Console.Write("n: ");
            try
            {
                int count = int.Parse(Console.ReadLine());
                if (count < 2 || count > 10000)
                {
                    Console.WriteLine("Unsupported count :( ");
                }

                else
                {

                    int i, j, k;
                    for (i = 1; i <= count + 1; i++)
                    {
                        for (j = 1; j <= count - i + 1; j++)
                        {
                            Console.Write(space);
                        }
                        for (k = 1; k <= j + i; k++)
                        {
                            Console.Write(asterics);
                        }

                        for (j = 1; j <= count + i + 1; j++)
                        {
                            Console.Write(space);
                        }
                        for (k = 1; k <= j - i; k++)
                        {
                            Console.Write(asterics);
                        }

                        for (j = 1; j <= count + i + 1; j++)
                        {
                            Console.Write(space);
                        }
                        for (k = 1; k <= j - i; k++)
                        {
                            Console.Write(asterics);
                        }


                        Console.WriteLine("");

                    }
                }
                }
            catch (FormatException)
            {

                Console.WriteLine("Error: Wrong Input! \n You can use only integers!");
            }
            


            //check if count is in correct format
            
                Console.ReadLine();
            }
        }
    
}
