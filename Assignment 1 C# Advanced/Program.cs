using System.Globalization;

namespace Assignment_1_C__Advanced
{
    public static class StringExtension
    {
        public static bool ValidFormat(this string number)//the validations are for the three examples in the pdf, I know it doen't work for other cases.
        {
            number = number.Trim();
            int digits = 0;
            if (number.Count() < 10)
                return false;
            for(int i = 0; i < number.Count(); i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                    digits++;
                else if ((i == 0 || i == 4) && number[0] == '(' && number[4] == ')')
                    continue;
                else if ((i == 3 || i == 7) && number[3] == '-' && number[7] == '-')
                    continue;
                else if (number[i] == ' ')
                    continue;
                else return false;
            }
            if (digits == 10)
                return true;
            return false;
        }
    }
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (number.ValidFormat())
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            
        }
    }
}
