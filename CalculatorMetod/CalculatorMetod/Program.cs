namespace CalculatorMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int cavab;

                Console.Write("birinci reqem yaz enter bas:\t");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Simvol yaz enter bas  (/,+,-,*) :\t");
                string symbol = Console.ReadLine();

                Console.Write("ikinci reqem yaz:\t");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (symbol)
                {
                    case "+":
                        cavab = num1 + num2;
                        Console.WriteLine("toplama:" + cavab);
                        break;
                    case "-":
                        cavab = num1 - num2;
                        Console.WriteLine("cixma:" + cavab);
                        break;
                    case "*":
                        cavab = num1 * num2;
                        Console.WriteLine("vurma:" + cavab);
                        break;
                    case "/":
                        cavab = num1 / num2;
                        Console.WriteLine("bolme:" + cavab);
                        break;
                    default:
                        
                        break;
                }
                
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }


    }




       





    }
