using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Stacks
{
    public class MyStack
    {
        private readonly List<char> openLst = new List<char> { '(', '<', '[', '{' };
        private readonly List<char> closeLst = new List<char> { ')', '>', ']', '}' };

        public string StringReverser(string input)
        {

            Stack<char> charStack = new Stack<char>();
            foreach (char c in input)
            {
                charStack.Push(c);
            }
            var len = charStack.Count;
            StringBuilder revStr = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                revStr.Append(charStack.Pop());
            }
            return revStr.ToString();
        }
        public bool IsBalancedExpression(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new InvalidOperationException($"Not a valid input");

            Stack<char> charStack = new Stack<char>();
            bool IsValid = true;

            foreach (char c in input)
            {
                if (openLst.Contains(c))
                    charStack.Push(c);

                else if (closeLst.Contains(c))
                {
                    if (charStack.Count == 0)
                        return false;

                    if (openLst.IndexOf(charStack.Pop()) != closeLst.IndexOf(c))
                    {
                        IsValid = false;
                        break;
                    }
                }
            }
            return IsValid && charStack.Count == 0;
        }
    }
}
