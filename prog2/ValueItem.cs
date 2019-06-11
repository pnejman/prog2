using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    class ValueItem
    {
        public double a { get; set; }
        public double b { get; set; }

        public ValueItem(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Multiply()
        {
            b = a * b;
        }

        public void Divide()
        {
            b = a / b;
        }

        public void Power()
        {
            b = Math.Pow(a, b);
        }

        public void Substract()
        {
            b = a - b;
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}";
        }
    }
}
