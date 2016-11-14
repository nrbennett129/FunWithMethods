using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Methods ****\n");

            //Pass two variables in by value
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0} Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0} Y: {1}", x, y);
            Console.ReadLine();

            //No need to assign initial value to local variables
            //used as output parameters, provided the first time
            //you use them is as output arguments.
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}", ans );
            Console.ReadLine();

            //Remember that you must use the out modifier
            //when you invoke the method.
            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Bool is: {0}", b);
            Console.ReadLine();
        }

        //Arguments are passed by value by default
        static int Add(int x, int y)
        {
            int ans = x + y;
            //Caller will not see these changes
            //as you are modifying a copy of 
            //the original data
            x = 1000;
            y = 8888;
            return ans;
        }

        //Output parameters must be assigned by the called method
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        //Returning multiple output parameters
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        /*
        The output paramater MUST be assigned within the scope of the method
        static void ThisWontCompile(out int a)
        {
            Console.WriteLine("Error! Forgot to assign output arg!");
        }
        */
    }
}
