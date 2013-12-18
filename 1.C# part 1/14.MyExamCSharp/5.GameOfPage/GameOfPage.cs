using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.GameOfPage
{
    class GameOfPage
    {
        static void Main(string[] args)
        {
            string[] str = new string[16];
            string currentCommand;
            int bitcounter = 0;
            int bought = 0;


            for (int row = 0; row < 16; row++)
            {
                str[row] = Console.ReadLine();
            }

            char[][] array = new char[16][];

            for (int row = 0; row < 16; row++)
            {
                array[row] = str[row].ToCharArray();
            }


            while (true)
            {
                bool isTop = false;
                bool isBottom = false;
                bool isLeft = false;
                bool isRight = false;

                bitcounter = 0;
                currentCommand = Console.ReadLine();
                if (currentCommand.Equals("paypal"))
                {
                    break;
                }

                int rowIndex = int.Parse(Console.ReadLine());
                int colIndex = int.Parse(Console.ReadLine());


                if (currentCommand.Equals("what is"))
                {
                    if (array[rowIndex][colIndex] == '1')
                    {
                        if (rowIndex > 0)
                        {
                            isTop = true;
                        }
                        if (rowIndex < 15)
                        {
                            isBottom = true;
                        }
                        if (colIndex > 0)
                        {
                            isLeft = true;
                        }
                        if (colIndex < 15)
                        {
                            isRight = true;
                        }
                        if (isTop)
                        {
                            if (array[rowIndex - 1][colIndex] == '1')
                            {
                                bitcounter++;
                            }
                        }
                        if (isBottom)
                        {
                            if (array[rowIndex + 1][colIndex] == '1')
                            {
                                bitcounter++;
                            }
                        }
                        if (isLeft)
                        {
                            if (array[rowIndex][colIndex - 1] == '1')
                            {
                                bitcounter++;
                            }
                            
                        }
                        if (isTop && isLeft)
                        {
                            if (array[rowIndex - 1][colIndex - 1] == '1')
                            {
                                bitcounter++;
                            }
                            
                        }
                        if (isBottom && isLeft)
                        {
                            if (array[rowIndex + 1][colIndex - 1] == '1')
                            {
                                bitcounter++;
                            }
                            
                        }
                        if (isRight)
                        {
                            if (array[rowIndex][colIndex + 1] == '1')
                            {
                                bitcounter++;
                            }
                            
                        }

                        if (isTop && isRight)
                        {
                            if (array[rowIndex - 1][colIndex + 1] == '1')
                            {
                                bitcounter++;
                            }
                            
                        }
                        if (isBottom && isRight)
                        {
                            if (array[rowIndex + 1][colIndex + 1] == '1')
                            {
                                bitcounter++;
                            }
                        }

                        //if (bitcounter == 8 && array[rowIndex][colIndex] == '1')
                        //{
                        //    Console.WriteLine("cookie");
                        //}
                        //else if (bitcounter == 0 && array[rowIndex][colIndex] == '1')
                        //{
                        //    Console.WriteLine("cookie crumb");
                        //}
                        //else if (bitcounter != 0 || array[rowIndex][colIndex] == '1')
                        //{
                        //    Console.WriteLine("broken cookie");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("smile");
                        //}
                        if (bitcounter == 8)
                        {
                            Console.WriteLine("cookie");
                        }
                        else if (bitcounter == 0)
                        {
                            Console.WriteLine("cookie crumb");
                        }
                        else
                        {
                            Console.WriteLine("broken cookie");
                        }
                    }
                    else
                    {
                        Console.WriteLine("smile");
                    }
                }


                //==========================================================
                if (currentCommand.Equals("buy"))
                {

                    //if (array[rowIndex][colIndex] == '1')
                    //{
                    if (rowIndex > 0)
                    {
                        isTop = true;
                    }
                    if (rowIndex < 15)
                    {
                        isBottom = true;
                    }
                    if (colIndex > 0)
                    {
                        isLeft = true;
                    }
                    if (colIndex < 15)
                    {
                        isRight = true;
                    }
                    if (isTop)
                    {
                        if (array[rowIndex - 1][colIndex] == '1')
                        {
                            bitcounter++;
                        }
                    }
                    if (isBottom)
                    {
                        if (array[rowIndex + 1][colIndex] == '1')
                        {
                            bitcounter++;
                        }
                    }
                    if (isLeft)
                    {
                        if (array[rowIndex][colIndex - 1] == '1')
                        {
                            bitcounter++;
                        }
                       
                    }
                    if (isTop && isLeft)
                    {
                        if (array[rowIndex - 1][colIndex - 1] == '1')
                        {
                            bitcounter++;
                        }

                    }
                    if (isBottom && isLeft)
                    {
                        if (array[rowIndex + 1][colIndex - 1] == '1')
                        {
                            bitcounter++;
                        }

                    }

                    if (isRight)
                    {
                        if (array[rowIndex][colIndex + 1] == '1')
                        {
                            bitcounter++;
                        }
                        
                    }
                    if (isTop && isRight)
                    {
                        if (array[rowIndex - 1][colIndex + 1] == '1')
                        {
                            bitcounter++;
                        }

                    }
                    if (isBottom && isRight)
                    {
                        if (array[rowIndex + 1][colIndex + 1] == '1')
                        {
                            bitcounter++;
                        }
                    }

                    if (bitcounter == 8 && array[rowIndex][colIndex] == '1')
                    {
                        bought++;
                        array[rowIndex][colIndex] = '0';
                        array[rowIndex - 1][colIndex] = '0';
                        array[rowIndex - 1][colIndex - 1] = '0';
                        array[rowIndex - 1][colIndex + 1] = '0';
                        array[rowIndex + 1][colIndex] = '0';
                        array[rowIndex + 1][colIndex - 1] = '0';
                        array[rowIndex + 1][colIndex + 1] = '0';
                        array[rowIndex][colIndex - 1] = '0';
                        array[rowIndex][colIndex + 1] = '0';
                    }
                    else if (bitcounter != 0 || array[rowIndex][colIndex] == '1') //bitcounter != 0 || 
                    {
                        Console.WriteLine("page");
                    }
                    else if (array[rowIndex][colIndex] == '0' && bitcounter == 0)// && bitcounter == 0
                    {
                        Console.WriteLine("smile");
                    }
                    
                }

            }

            Console.WriteLine("{0:F2}", bought * 1.79);

        }
    }
}
