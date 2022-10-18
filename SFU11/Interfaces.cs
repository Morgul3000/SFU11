using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFU11
{
    interface ICalculator
    {
        void CalcAddition(double x, double y);
        void CalcSubtraction(double x, double y);
        void CalcMultiplication(double x, double y);
        void CalcDivision(double x, double y);
    }
    interface ILogger
    {
        void Event(string mes);
        void Error(string mes);
    }
}
