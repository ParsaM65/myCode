using System; 

namespace Calculator
{
    class Program
    {

        public static void add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
    
        public static void subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}"); 
        }

        public static void multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}"); 
        }

        public static void divide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public static void operate(int x, int y, char op)
        {
            switch(op)
            {
                case '+':
                    add(x, y);
                    break;
                case '-':
                    subtract(x, y);
                    break;
                case '*':
                    multiply(x, y);
                    break;
                case '/':
                    divide(x, y);
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

            operate(x, y, op); 
        }
    }
}
