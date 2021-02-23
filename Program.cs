using System;

namespace lab1
{
    class Program
    {

        public static double amount_of_information(double color, double summ)
        {
            double inf = Math.Log2(summ / color);

            
            
            if ((inf - Math.Truncate(inf))  != 0) ++inf;

            return Math.Floor(inf);
        }

        public static double average_amount_of_information(double color1, double color2, double color3, double summ)
        {
            double inf = color1 / summ * Math.Log2(summ / color1) + color2 / summ * Math.Log2(summ / color2) + color3 / summ * Math.Log2(summ / color3);
            if ((inf - Math.Truncate(inf)) != 0) ++inf;
            return Math.Floor(inf);
        }

        static void Main(string[] args)
        {
            double red = 108.0;
            double yellow = 4.0;
            double green = 16.0;

            double summ_of_sygnals = red + yellow + green;

            
            Console.WriteLine();
            Console.Write("Count of information in red color: ");
            Console.Write(amount_of_information(red, summ_of_sygnals));
            
            Console.WriteLine();
            Console.Write("Count of information in yellow color: ");
            Console.Write(amount_of_information(yellow, summ_of_sygnals));
            
            Console.WriteLine();
            Console.Write("Count of information in green color: ");
            Console.Write(amount_of_information(green, summ_of_sygnals));
            
            Console.WriteLine();
            Console.Write("Average amount of information: ");
            Console.Write(average_amount_of_information(red, yellow, green, summ_of_sygnals));
            
        }
    }
}