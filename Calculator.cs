using System; 

namespace Calculator
{
    class Program
    {

        public static void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
    
        public static void Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}"); 
        }

        public static void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}"); 
        }

        public static void Divide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public static void Operate(int x, int y, char op)
        {
            switch(op)
            {
                case '+':
                    Add(x, y);
                    break;
                case '-':
                    Subtract(x, y);
                    break;
                case '*':
                    Multiply (x, y);
                    break;
                case '/':
                    Divide(x, y);
                    break; 
            }
        }
       

        public static char GetOp()
        {
            // ask user for operator
            Console.Write("Enter an operator: ");
            char op = char.Parse(Console.ReadLine()); 
            // loop until valid input enterd
            while (op != '+' && op != '-' && op != '*' && op != '/')
            {
                Console.Write("Try again: ");
                op = char.Parse(Console.ReadLine()); 
            }

            return op; 
        }

        public static int GetNum()
        {
            // ask user for number and return it 
            Console.Write("Enter a number: ");
            return int.Parse(Console.ReadLine()); 
        }

        public static void Main()
        {
            int x = GetNum();

            char op = GetOp(); 

            int y = GetNum();

            Operate(x, y, op); 
        }
    }
}
