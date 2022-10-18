using System;

namespace SFU11
{
    internal class Program
    {
        static Calculator calc;
        static ILogger log;

        static void Main(string[] args)
        {
            log = new Logger();

            calc = new Calculator(log);
            calc.CalcEvent += CalcHandler;           //инициализация обработчика событий

            try
            {
                calc.ReadNumbers();
            }
            catch (ArgumentException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка! Не был введен оператор матиматического действия!");
                Console.ResetColor();
            }
        }
        /// <summary>
        /// Обработчик события - ввода математического оператора
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mathAction"></param>
        static void CalcHandler(double x, double y, string mathAction)
        {
            switch (mathAction)
            {
                case "+": calc.CalcAddition(x, y); break;
                case "-": calc.CalcSubtraction(x, y); break;
                case "*": calc.CalcMultiplication(x, y); break;
                case "/": calc.CalcDivision(x, y); break;
            }
        }

    }
}
