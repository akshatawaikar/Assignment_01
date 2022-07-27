using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Prog1
            Console.WriteLine("---------Program 1----------- ");
            Console.WriteLine("Hello!");
            Console.WriteLine("Akshata Waikar");

            //Prog2 - Swapping 2 numbers
            Console.WriteLine("---------Program 2---------- ");
            Program2 p2 = new Program2();
            Console.WriteLine("Numbers chosen are a : 20 and b: 10 ");
            int a = 20;
            int b = 10;
            p2.swap(ref a, ref b);
            Console.WriteLine("Swapped a : " + a + "Swapped b : " + b);

            //Prog3 - Mathematical operations
            Console.WriteLine("---------Program 3----------- ");
            Program3 p3 = new Program3();
            Console.WriteLine("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition is {0} \n Substraction is {1} \n Multiplication is {2} \n Division is {3}",p3.add(num1,num2),p3.sub(num1,num2),p3.mul(num1,num2),p3.div(num1,num2));

            //Prog4 - Multiplication Table
            Program4 p4 = new Program4();
            Console.WriteLine("Enter the number to print the table");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[10];
            arr1 = p4.table(n);

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, arr1[i]);
            }

            //Prog5 - 

            


        }
    }
}
