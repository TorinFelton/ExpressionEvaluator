using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.Algorithms
{
    class ExpressionToken
    {
        public string value = null;
        public bool isNumber = false;

        public ExpressionToken(string inputValue, bool isNumber)
        {
            this.isNumber = isNumber;
            this.value = inputValue;
        }

    }
}
