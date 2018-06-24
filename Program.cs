using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab1
{
    class Program
    {
        static void Main(string[] args) // going beyond the application
        {

            Console.WriteLine("Type first number:"); // user input first number

            string num1 = Console.ReadLine(); // Read string from console

            int[] firstNumber = new int[num1.Length]; 

            int value;

            while (!Int32.TryParse(num1, out value)) // while num1 is not a valid input than repeat 

            {

                Console.WriteLine("Not a valid first number, try again.");

                num1 = Console.ReadLine();

            }

            firstNumber = GetDigits(num1);

            /*******************************/

            Console.WriteLine("Type second number:"); // user input second number

            string num2 = Console.ReadLine(); // Read string from console

            int[] secondNumber = new int[num2.Length];

            int value2;

            while (!Int32.TryParse(num2, out value2)) // while num2 is not a valid input than repeat

            {

                Console.WriteLine("Not a valid second number, try again.");

                num2 = Console.ReadLine();

            }

            secondNumber = GetDigits(num2);

            int test = firstNumber[1];

            int sum = firstNumber[0] + secondNumber[0];



            bool match = true;

            for (int i = 0; i < num1.Length; i++)

            {

                if (firstNumber[i] + secondNumber[i] != sum) // loop through firstNumber + secondNumber and match the sum 

                {

                    match = false;  // false if theres no match

                }

            }

            if (match) // returns true if theres a match

            {

                Console.WriteLine("True - You're Done!");

                Console.WriteLine("Theres a match for the sum of {0} and {1} in the Ones,Tens,Hunredths.", num1, num2);

                Console.ReadLine();

            }

            else

            {
                Console.WriteLine("Theres no match for the sum of {0} and {1} in the Ones,Tens,Hunredths.", num1, num2);

                Console.WriteLine("False");

                Main(null);

            }

        }



        public static int[] GetDigits(string number)

        {

            int numValue;

            string temp = number;

            int[] rtn = new int[temp.Length];

            for (int i = 0; i < rtn.Length; i++)

            {

                bool res = int.TryParse(temp[i].ToString(), out numValue);

                rtn[i] = numValue;

            }

            return rtn;


        }
    }
}
