using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    enum OperationType
    {
        [Description("Mnożenie")]
        Multiply,

        [Description("Dzielenie")]
        Divide,

        [Description("Potęgowanie")]
        Power,

        [Description("Odejmowanie")]
        Substract
    }
}
