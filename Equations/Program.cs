// See https://aka.ms/new-console-template for more information
using System;
using Solver;

namespace Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Console.WriteLine($"Ответ: {result[0]}");
            Console.WriteLine($"ОТвет: {result[1]}");
        }
    }
}