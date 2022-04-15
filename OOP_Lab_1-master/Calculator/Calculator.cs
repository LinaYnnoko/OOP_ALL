using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static Func Add = (a, b) => a + b;
        public static Func Subtract = (a, b) => a - b;
        public static Func Multiply = (a, b) => a * b;
        public static Func Divide = (a, b) => a / b;

    }
}
