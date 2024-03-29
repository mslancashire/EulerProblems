﻿namespace Problems.Problem002;

/// <summary>
/// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
/// 
/// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
/// 
/// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
/// </summary>
public class Solution002
{
    public List<Int64> FibonacciNumbers(Int64 lessThan)
    {
        var fibonacciNumbers = new List<Int64>();
        var previousNumber = 0;
        var currentNumber = 1;

        while (1 == 1)
        {
            var fibonacciNumber = currentNumber + previousNumber;
            if (fibonacciNumber > lessThan)
            {
                break;
            }

            fibonacciNumbers.Add(fibonacciNumber);
            previousNumber = currentNumber;
            currentNumber = fibonacciNumber;
        };

        return fibonacciNumbers;
    }

    public List<Int64> EvenFibonacciNumbers(Int64 lessThan)
    {
        var fibonacciNumbers = FibonacciNumbers(lessThan);

        var evenFibonacciNumbers = fibonacciNumbers.Where(fn => fn % 2 == 0).ToList();

        return evenFibonacciNumbers;
    }

    public Int64 SumOfEvenFibonacciNumbers(Int64 lessThan)
    {
        return EvenFibonacciNumbers(lessThan).Sum();
    }
}