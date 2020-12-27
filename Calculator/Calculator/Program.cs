using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculate();
            RepeatOrNot();




           void RepeatOrNot()
            {
                Console.WriteLine("WOULD YOU LIKE TO GO AGAIN?");
                Console.WriteLine("YES OR NO?");
                string yn = Console.ReadLine();

                if (yn == "yes" || yn == "YES")
                {
                    Calculate();
                    RepeatOrNot();

                }

                if (yn == "no" || yn == "NO")
                {
                    Console.WriteLine("THANK YOU FOR USING CALCULATOR!!");
                }



            }





            void Calculate()
            {
                double fNumber;
                double sNumber;
                string op;
                double answer;


                Console.WriteLine("Welcome!");
                Console.WriteLine("");

                Console.WriteLine("PLEASE ENTER YOUR FIRST NUMBER");
                fNumber = double.Parse(Console.ReadLine());


                Console.WriteLine("PLEASE ADD YOUR OPERATOR");
                op = Console.ReadLine();

                Console.WriteLine("PLEASE ENTER YOUR SECOND NUMBER");
                sNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("YOUR ANSWER IS..");

                if (op == "+")
                {
                    answer = fNumber + sNumber;
                    Console.WriteLine(answer);
                }
                if (op == "-")
                {
                    answer = fNumber - sNumber;
                    Console.WriteLine(answer);
                }
                if (op == "/")
                {
                    answer = fNumber / sNumber;
                    Console.WriteLine(answer);
                }
                if (op == "*")
                {

                    answer = fNumber * sNumber;
                    Console.WriteLine(answer);

                }


            }




        }
    }
}
