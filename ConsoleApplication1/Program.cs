using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{

    class Country
    {

        private string capital;
        private int biggestTown;
        private int population;

        public Country(string _capital, int _population, int _biggestTown)
        {
            capital = _capital;
            biggestTown = _biggestTown;
            population = _population;
            
        }

        public void compare()
        {
            if (population == biggestTown)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(capital + " is the biggest town");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(capital + " is not the biggest town");
                Console.ResetColor();
            }
        }



    }



    class Program
    {
        static void Main(string[] args)
        {
            //შეგვაქვს დედაქალაქის სახელი და ვამოწმებთ 
            string capital = null;
            Console.Write("Enter the capital: ");
            string inp0 = Console.ReadLine();
            if (string.IsNullOrEmpty(inp0)) {
                capital = "Tbilisi";
            } else {
                capital = inp0;
            }


            //შეგვყავს რაოდენობები და ვამოწმებთ
            int number1 = 0;
            int number2 = 0;
            Console.Write("Population of the capital: ");
            string inp1 = Console.ReadLine();
            try {
                number1 = Convert.ToInt32(inp1);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please input number!!!");
                return;
            }

            Console.Write("Population of the biggest town: ");
            string inp2 = Console.ReadLine();
            try {
                number2 = Convert.ToInt32(inp2);
            } catch (Exception e){
                Console.WriteLine("Please input number!!!");
                Console.WriteLine(e.Message);
                return;
            }

            //კლასის ობიექტის შექმნა და ინიციალიზაცია
            //github 
            Country C1 = new Country(capital, number1, number2 );
            C1.compare();




        }
    }
}
