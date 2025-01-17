using System.ComponentModel.Design;

namespace kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matemaatiline Koer");


            Console.WriteLine("Sisestage esimene arv");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Sisestage tehe *,-,+,/");
            Char tehe = Console.ReadKey().KeyChar;


            Console.WriteLine("Sisestage teine arv");
            double num2 = Convert.ToDouble(Console.ReadLine());


            double result = 0;


            switch (tehe)
            {
                case '*':
                    result = num1 * num2;
                    break;
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Viga, Nulliga ei saa jagada");
                    }
                     break;

                     default:
                Console.WriteLine("Viga, vale tehemark");
                     return;
                                 
            }
            
            Console.WriteLine($"Vastus: {num1} {tehe} {num2} = {result}");

            
        }
    }
}
