using CoreXUnitTestExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreXUnitTestExample
{
    public class Calculator
    {
        private CalculatorState _state = CalculatorState.Cleared;

        public decimal Value { get; private set; } = 0;

        public decimal Add(decimal value)
        {
            _state = CalculatorState.Active;
            return Value += value;
        }

        public decimal Subtract(decimal value)
        {
            _state = CalculatorState.Active;
            return value -= value;
        }
        public decimal Multiply(decimal value)
        {
            if(Value is 0 && _state.Equals(CalculatorState.Cleared))
            {
                _state = CalculatorState.Active;
                return Value = value;
            }
            return value *= value;
        }
        public decimal Divide(decimal value)
        {
            if (Value is 0 && _state.Equals(CalculatorState.Cleared))
            {
                _state = CalculatorState.Active;
                return Value = value;
            }
            return value /= value;
        }
    }
}
