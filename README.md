# ExpressionEvaluator
Simple mathematical expression calculations using abstract syntax trees and reverse polish notation.

## Overview

This is forming part of my Computer Science A-Level project and I've created this more as a learning process. This project covers graph traversal (specifically of abstract syntax trees),
reverse polish notation and a bit of OOP technique (mostly just inheritance).

## Limitations / Goals

Tokeniser still needs to be implemented as currently the program only reads char by char, meaning it can only take single digit numbers. I also do not intend to implement floats
at any point for this project to keep scoped in on the technique and not scale.

## Example Usage

Input (spaces are allowed):

`8*2+(8/4)`

Output:

```
To postfix:
8 2 * 8 4 / +
To infix:
8 * 2 + 8 / 4
To prefix:
+ * 8 2 / 8 4
Answer: 18
```

Input:
`8*(9+2)`
Output:
```
To postfix:
8 9 2 + *
To infix:
8 * 9 + 2
To prefix:
* 8 + 9 2
Answer: 88
```

## Links / References

- https://www.youtube.com/watch?v=7ha78yWRDlE "Reverse Polish Notation and The Stack - Computerphile"
- https://www.youtube.com/watch?v=TrfcJCulsF4 "Reverse Polish Grows on Trees - Computerphile"
- https://en.wikipedia.org/wiki/Shunting-yard_algorithm "Dijkstra's Shunting-Yard Algorithm"
