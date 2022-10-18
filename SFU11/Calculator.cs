using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFU11
{
    /// <summary>
    /// класс Калькулятор с математическими действиями сложения, вычитания, умножения и деления
    /// </summary>
    internal class Calculator : ICalculator
    {
        public delegate void CalculatorFunction(double x, double y, string math);
        public event CalculatorFunction CalcEvent;

        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// получение данных от пользователя: число Х, число У и математического оператора.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void ReadNumbers()
        {
            int x;
            Console.WriteLine("Введите число Х");
            while (!int.TryParse(Console.ReadLine(), out x))                             //Проверка на корректность введенных данных
            {
                Logger.Error("Ошибка! Введены некорректные данные! Введите число.");     //Логирование ошибки методом класса Logger
                Console.ResetColor();
            }

            int y;
            Console.WriteLine("Введите число Y");
            while (!int.TryParse(Console.ReadLine(), out y))                             //Проверка на корректность введенных данных
            {
                Logger.Error("Ошибка! Введены некорректные данные! Введите число.");    //Логирование ошибки методом класса Logger
                Console.ResetColor();
            }

            Console.WriteLine("Введите желаемое математическое действие: + , - , *  или / ");
            string mathAction = Console.ReadLine();

            if (mathAction != "+" && mathAction != "-" && mathAction != "*" && mathAction != "/")  //Проверка на корректность введенных данных
                throw new ArgumentException();

            CalcEvent?.Invoke(x, y, mathAction);
        }
        public void CalcAddition(double x, double y)
        {
            Logger.Event("Калькулятор запущен. Метод сложения");
            Console.WriteLine($"Результат вычисления - {x + y}");
            Logger.Event("Калькулятор завершил работу.");
            Console.ResetColor();
        }
        public void CalcSubtraction(double x, double y)
        {
            Logger.Event("Калькулятор запущен. Метод деления");
            Console.WriteLine($"Результат вычисления - {x - y}");
            Logger.Event("Калькулятор завершил работу.");
            Console.ResetColor();
        }

        public void CalcDivision(double x, double y)
        {
            Logger.Event("Калькулятор запущен. Метод вычитания");
            Console.WriteLine($"Результат вычисления - {x / y}");
            Logger.Event("Калькулятор завершил работу.");
            Console.ResetColor();
        }

        public void CalcMultiplication(double x, double y)
        {
            Logger.Event("Калькулятор запущен. Метод умножения");
            Console.WriteLine($"Результат вычисления - {x * y}");
            Logger.Event("Калькулятор завершил работу.");
            Console.ResetColor();
        }
    }
}
