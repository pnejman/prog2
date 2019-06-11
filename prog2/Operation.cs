using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    class Operation
    {
        public OperationType Type { get; private set; }
        public string Label { get; private set; }

        public Operation(OperationType type, string label)
        {
            Type = type;
            Label = label;
        }

        public override string ToString()
        {
            return Label;
        }
    }

    enum OperationType
    {
        Multiply,
        Divide,
        Power,
        Substract
    }
}
