using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDanielTorres
{
    public class ValidParentheses
    {    
        public bool IsValid(string input)
        {
            //Stack to save brackets to validate if were closed in the stack order
            Stack<char> stack = new Stack<char>();
            if (input.Length == 0) return true;
            if (input.Length == 1) return false;

            //Loop for characters in input
            foreach (char character in input)
            {
                switch (character)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    default:
                        if (!stack.Any()) return false;
                        var lastBracket = stack.Pop();
                        if (lastBracket != character)
                            return false;
                        break;
                }
            }

            if (stack.Any()) return false;

            return true;
        }
    }
}
