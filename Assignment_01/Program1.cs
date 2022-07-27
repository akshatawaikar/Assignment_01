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
            Console.WriteLine();

            //Prog2 - Swapping 2 numbers
            Console.WriteLine("---------Program 2---------- ");
            Program2 p2 = new Program2();
            Console.WriteLine("Numbers chosen are a : 20 and b: 10 ");
            int a = 20;
            int b = 10;
            p2.swap(ref a, ref b);
            Console.WriteLine("Swapped a : " + a + "Swapped b : " + b);
            Console.WriteLine();

            //Prog3 - Mathematical operations
            Console.WriteLine("---------Program 3----------- ");
            Program3 p3 = new Program3();
            Console.WriteLine("Enter number 1 for all Mathematical Operations : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 for all Mathematical Operations : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition is {0} \n Substraction is {1} \n Multiplication is {2} \n Division is {3}",p3.add(num1,num2),p3.sub(num1,num2),p3.mul(num1,num2),p3.div(num1,num2));
            Console.WriteLine();

            //Prog4 - Multiplication Table
            Console.WriteLine("---------Program 4----------- ");
            Program4 p4 = new Program4();
            Console.WriteLine("Enter the number to print the table");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = p4.table(n);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, arr1[i]);
            }
            Console.WriteLine();

            //Prog5 - return the number 4 times
            Console.WriteLine("---------Program 5----------- ");
            int n1;
            Console.WriteLine("Enter a number to be repeated");
            n1 = Convert.ToInt32(Console.ReadLine());
            Program5 p5 = new Program5();
            Console.WriteLine("{0} {1} {2} {3}", p5.printOutput(n1), p5.printOutput(n1), p5.printOutput(n1), p5.printOutput(n1));
            Console.WriteLine();

            //Prog6 : Swap front and back characters of a string
            Console.WriteLine("---------Program 6----------- ");
            Program6 p6 = new Program6();
            Console.WriteLine(p6.changeFirstAndLast("Waikar")); 
            Console.WriteLine();

            //Prog7
            Console.WriteLine("---------Program 7----------- ");
            Program7 p7 = new Program7();
            Console.WriteLine("Enter first positive or negative number : ");
            int n_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second positive or negative number : ");
            int n_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p7.PositiveNegative(n_1,n_2));
            Console.WriteLine();

            //Prog8
            Console.WriteLine("---------Program 8----------- ");
            Program8 p8 = new Program8();
            Console.WriteLine("Enter the string to check the longest string");
            string str = Console.ReadLine();
            Console.WriteLine("Longest String in the given string is "+p8.LongestWord(str));

            //Prog9
            Console.WriteLine("---------Program 9-----------");
            Console.WriteLine("Enter the number for addition of the digits");
            int num = Convert.ToInt32(Console.ReadLine());
            Program9 p9 = new Program9();
            Console.WriteLine("The sum of digits of the entered integer is : {0}", p9.sumOfDigitsOfInteger(num));

            //Prog10
            Program10 p10 = new Program10();
            Console.WriteLine("---------Program 10----------- ");
            Console.WriteLine("Enter the array to be rotated");
            int[] arr = new int[3];
            for(int i =0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            p10.ArrayRotation(arr);

            //Prog11
            Console.WriteLine("---------Program 11----------- ");
            Program11 p11 = new Program11();
            int[] ar1 = new int[3];
            Console.WriteLine("Enter the 3 elements of the firstArray");
            for (int i = 0; i < 3; i++)
            {
                ar1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr2 = new int[3];
            Console.WriteLine("Enter the 3 elements of the Second Array");
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr3 = new int[3];
            Console.WriteLine("Enter the 3 elements of the third Array");
            for (int i = 0; i < 3; i++)
            {
                arr3[i] = Convert.ToInt32(Console.ReadLine());
            }

            p11.formingArrayFromMiddleElement(ar1, arr2, arr3);
            Console.WriteLine();

            //Prog12



































































        }
    }
}
