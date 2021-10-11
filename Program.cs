using System;
using MethodOverload.Entities;

namespace MethodOverload {
    class Program {
        static void Main(string[] args) {
            var result = Calculator.Sum(5,8);
            Console.WriteLine(result);
        }
    }
}
