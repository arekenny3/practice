using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OilTestController
{

    //static
    class Program
    {
        public static void Main(string[] args)
        {
            
            /********************Name*******************/
            bool nameValid = false;
            do
            {
                int n = 25;
                Console.WriteLine("Name: ");
                string inputName = Console.ReadLine();
                nameValid = check_name(n, inputName);
            } while (!nameValid);
            Console.WriteLine("Success! ");
        /*************************Clock Card**********/
        bool cardValid = false;
        do
	{
        int n = 5; // length of string
                Console.WriteLine("Clock Card: ");
                string inputCard = Console.ReadLine();
                cardValid = check_card(n, inputCard);
            } while (!cardValid);
            Console.WriteLine("Success! ");
        }
	        

        public static bool check_ParamLength(int n, string input)
        {
            //checking length of user input
            char[] array = input.ToCharArray(); //parsing string into an array to check each ind character
            if (input.Length > n)
            {
                return false;
            }
            return true;
        }
        // Check if input is all letters
        public static bool check_ParamLet(int n, string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (Char.IsNumber(array[i]))
                {
                    Console.WriteLine("Sorry");
                    return false;
                }
                //checking to see all input characters are letters.
            }
            return true;
        }
        // check if input is all numbers
        public static bool check_ParamNum(int n, string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (Char.IsLetter(array[i]))
                {
                    Console.WriteLine("Sorry");
                    return false;
                }
                //checking to see all input characters are letters.
            }
            return true;
        }
        // check if input doesn't contain any special characters...(/,!,~,etc...)
        public static bool check_ParamSymb(int n, string input)
        {
            bool validSymb;
            Regex RgxUrl = new Regex("[^a-zA-Z0-9]");
            validSymb = RgxUrl.IsMatch(input);
            if (validSymb)
            {
                return false;
            }

            return true;
        }
      
        // Error Analysis!!!
        public static void isFunky(bool validLength, bool validString, bool validSymb)
        {
            Console.WriteLine("Problems with input: ");
            if (!validLength)
            {
                Console.WriteLine("Length! ");
            }
            if (!validString)
            {
                Console.WriteLine("Cannot have Numbers! ");
            }
            if (!validSymb)
            {
                Console.WriteLine("Cannot contain any special Characters!!! ('*!@,./ ')");
            }
        }
        // check name
        public static bool check_name(int n, string inputName)
        {
            bool validLength = check_ParamLength(n, inputName);
            bool validString = check_ParamLet(n, inputName);
            bool validSymb = check_ParamSymb(n, inputName);

            if ((!validLength) || (!validString) || (!validSymb))
            {
                Console.WriteLine("This Test Doesnt work!!!");
                isFunky(validLength, validString, validSymb);
                return false;
            }
            return true;
        }
        //check Clockcard

        public static bool check_card(int n, string inputCard)
        {
            bool validLength = check_ParamLength(n, inputCard);
            bool validString = check_ParamNum(n, inputCard); //different than name
            bool validSymb = check_ParamSymb(n, inputCard);

            if ((!validLength) || (!validString) || (!validSymb))
            {
                Console.WriteLine("This Test Doesnt work!!!");
                isFunky(validLength, validString, validSymb);
                return false;
            }
            return true;
        }

    }


}
