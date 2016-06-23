	
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OilTestController
{
	class Program 
    {

		
		public static void Main(string[] args)
		{
            string Name = "";
			Name = name(Name);
            string newName = "";
            Console.WriteLine("{0}",Name);

            Console.WriteLine("Do you want to edit anything 1: Yes, 2: No ");
            int ans = Convert.ToInt32(Console.ReadLine());
            if (ans != 1)
            {
                Console.WriteLine("What would you like to edit? ");
                int ans2 = Convert.ToInt32(Console.ReadLine());
                if (ans2 == 1)
                {
                   newName = name(newName);
                   Name = newName;
                   Console.WriteLine("{0}", newName);
                }
            }
            Console.WriteLine("New Name: ", newName);

           // string Card = card();


		}
		
		public static string name(string Name)
		{
			
			bool nameValid = false;
            string inputName = "";
           
			 do
                {
                    int n = 25;
                    Console.WriteLine("Name: ");
                    inputName = Console.ReadLine();
                    nameValid = check_name(inputName, n);
                } while (!nameValid);
             if (nameValid)
             {
                 Name = inputName;
             }
                Console.WriteLine("Success! ");
                return inputName;
		}
		  public static bool check_name(string input, int n)
        {
            bool validLength = check_ParamLength(input, n);
            bool validString = check_ParamLet(input, n);
            bool validSymb = check_ParamSymb(input, n);

            if ((!validLength) || (!validString) || (!validSymb))
            {
                Console.WriteLine("This Test Doesnt work!!!");
               // isFunky(validLength, validString, validSymb); // Error Analysis
                return false;
            }
            return true;
        }

        //Card
          public static string card()
          {

              return card();
          }

	 // Checking String Length
        public static bool check_ParamLength(string input, int n)
        {
            //checking length of user input
            char[] array = input.ToCharArray(); //parsing string into an array to check each ind character
            if (input.Length > n)
            {
                return false;
            }
            return true;
        }

        public static bool check_ParamLet(string input, int n)
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
        public static bool check_ParamNum(string input, int n)
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
        public static bool check_ParamSymb(string input, int n)
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
       

	}	
}
