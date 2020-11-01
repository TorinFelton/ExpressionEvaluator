﻿using Sandbox.TreeTraversal;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace Sandbox.Algorithms
{
    class Postfix
    {
        public static TreeNode InfixToPostfix(string infix)
        {
            Stack<BinOp> operatorStack = new Stack<BinOp>();
            Stack<TreeNode> numStack = new Stack<TreeNode>();

            foreach (char character in infix.Replace(" ", ""))
            {
                if (character == '(')
                {
                    operatorStack.Push(new BinOp(character.ToString()));
                }

                else if (Char.IsDigit(character)) // If it is a number, add to numStack
                {
                    numStack.Push(new Num((int)Char.GetNumericValue(character)));
                    // Simply create a new Num (inheritant from TreeNode) node with the number in the character.
                }

                else if (BinOp.precedences.ContainsKey(character.ToString()) && character != ')')
                {
                    while (operatorStack.Count > 0 && BinOp.precedences[operatorStack.Peek().value] >= BinOp.precedences[character.ToString()])
                    { // While the precedence of the top of the operatorStack is bigger than or equal to the precedence of the char
                        BinOp binOperator = operatorStack.Pop();
                        // Reversed as the second op was pushed at the end
                        binOperator.right = numStack.Pop();
                        binOperator.left = numStack.Pop();

                        numStack.Push(binOperator);
                    }
                    // Now push operator at the end 
                    operatorStack.Push(new BinOp(character.ToString()));
                }

                else if (character == ')')
                {
                    while (operatorStack.Count > 0 && operatorStack.Peek().value != "(")
                    {
                        BinOp binOperator = operatorStack.Pop();
                        // Reversed as the second op was pushed at the end
                        binOperator.right = numStack.Pop();
                        binOperator.left = numStack.Pop();

                        numStack.Push(binOperator);
                    }
                    operatorStack.Pop();
                }

                else
                {
                    throw new SyntaxErrorException();
                }
            }

            while (operatorStack.Count > 0)
            {
                BinOp binOperator = operatorStack.Pop();
                // Reversed as the second op was pushed at the end
                binOperator.right = numStack.Pop();
                binOperator.left = numStack.Pop();

                numStack.Push(binOperator);
            }

            return numStack.Pop();
        }
    }
}