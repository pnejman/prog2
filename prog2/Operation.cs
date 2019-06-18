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

        public Operation(OperationType type, string label) //the friendly name for label is a good idea, but it can be improved... and, after that improvement, it might turn out that the Operation class is not needed 
        {
            this.Type = type;
            this.Label = label;
        }

        public override string ToString()
        {
            return Label;
        }
    }
}
