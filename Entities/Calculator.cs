using System;

namespace MethodOverload.Entities {
    public class Calculator {
        public static int Sum(int a, int b) => a + b;
        public static double Sum(double a, double b) => a + b;
        public static double Sum(double a) => a;
        public static float Sum(float a, float b) => a + b;
    }
}