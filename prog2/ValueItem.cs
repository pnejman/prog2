using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    class ValueItem
    {
        public int a { get; set; }
        public int b { get; set; }

        public ValueItem(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Multiply()
        {
            a = 999;
        }

        public void Divide()
        {

        }

        public void Power()
        {

        }

        public void Substract()
        {

        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}";
        }
    }
}
