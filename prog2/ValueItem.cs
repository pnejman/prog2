using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    class ValueItem
    {
        public double A { get; set; }
        public double B { get; set; }

        public ValueItem(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public void Multiply()
        {
            B = A * B;
        }

        public void Divide()
        {
            B = A / B;
        }

        public void Power()
        {
            B = Math.Pow(A, B);
        }

        public void Substract()
        {
            B = A - B;
        }

        public override string ToString()
        {
            return $"a = {A}, b = {B}";
        }
    }
}
