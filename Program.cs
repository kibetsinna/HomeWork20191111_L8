using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191111_Lesson8
{
    class Program
    {
        static bool module(int a, int b)
        {
           
                if (b!=0)
                {
                    if (a % b == 0)
                    {
                        Console.WriteLine("No module!!!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Same module!!!");
                        return false;
                    }

                }
                else
                {
                    Console.WriteLine("Divide by zero!!!");
                    return false;
                }
    
        }
        static void refInt(ref int a, ref int b)
        {
            a++;
            b=b*2;
        }
        static void outInt(out int a, out int b)
        {
            do
            {
                Console.WriteLine("Please, enter number a");

            } while (int.TryParse(Console.ReadLine(), out a) == false);
            do
            {
                Console.WriteLine("Please, enter number b");

            } while (int.TryParse(Console.ReadLine(), out b) == false);
        }
        static int defValue(int a, int b = 1, int c = -1)
        {
            return a * b * c;
        }
        static int calcParams(params int[] val)
        {
            int sum = 0;
            if (val.Length==0)
            {
                Console.WriteLine("Error: (val.Length==0) ");
                return 0;
            }
            for (int i = 0; i < val.Length; i++)
            {
                sum += (int)Math.Pow(val[i], i+1);
            }
            return sum;
        }
        static void Array3(int[] arr1,out int[] arr2,out int[] arr3)
        {
            int x=0;
            int y=0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] >= 0)
        
                    x++;
                else
 
                    y++;
 
            }
            arr2 = new int[x];
            arr3 = new int[y];
            int j = 0;
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] >= 0)
                {
                   arr2[j]=arr1[i];
                   j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
                    

            }
         
            if (x > 0)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("pozitive number {0} ={1}", i, arr2[i]);
                }
            }
            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    Console.WriteLine("negative number {0} ={1}", i, arr3[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("**********");
            Console.WriteLine("Exercise 1");
            Console.WriteLine("**********");
            Console.WriteLine(module(4, 2));
            Console.WriteLine(module(4, 3));
            //Exercise 2
            Console.WriteLine("**********");
            Console.WriteLine("Exercise 2");
            Console.WriteLine("**********");
            int a=2;
            int b=7;
            Console.WriteLine("before a={0} b={1}", a, b);
            refInt(ref a, ref b);
            Console.WriteLine("after a={0} b={1}",a,b);
            //Exercise 3
            Console.WriteLine("**********");
            Console.WriteLine("Exercise 3");
            Console.WriteLine("**********");
            int x, y;
            outInt(out x, out y);
            Console.WriteLine("after out x={0} y={1}", x, y);

            //Exercise 4
            Console.WriteLine("**********");
            Console.WriteLine("Exercise 4");
            Console.WriteLine("**********");
            int [] par = { 1, 2, 3 };
            Console.WriteLine("a={0} b={1} c={2} a^a+b^b+c^c={3}", 1, 2, 3, calcParams(par));
            int[] par1 = { 1, 2 };         
            Console.WriteLine("a={0} b={1} a^a+b^b={2}", 1, 2, calcParams(par1));
            //Exercise 5
            Console.WriteLine("**********");
            Console.WriteLine("Exercise 5");
            Console.WriteLine("**********");
            Console.WriteLine("a={0} b={1} c={2} a*b*c ={3}", 4, 3, 2, defValue(4, 3, 2));
            Console.WriteLine("a={0} b={1} a*b*c ={2}", 4, 3, defValue(4, 3));
            Console.WriteLine("a={0}  a*b*c ={1}", 4,  defValue(4));
            //Exercise 6
            Console.WriteLine("**********");
            Console.WriteLine("Exercise 6");
            Console.WriteLine("**********");
            Console.WriteLine("a={0} c={1} a*b*c ={2}", 1, 10, defValue(a:1,c:10));
        
            //Exercise 7
            Console.WriteLine("**********");
            Console.WriteLine("Exercise 7");
            Console.WriteLine("**********");
            int[] arr1 = { 1, 18, -5, 15, -7 };
            int[] arr2;
            int[] arr3;
            Array3(arr1, out arr2, out arr3);
            Console.ReadLine();

        }
    }
}
