using System;
using System.Linq;

namespace Cleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 声明变量
            int number = 42;
            string message = "The answer to life, the universe, and everything is";

            // 输出变量内容
            Console.WriteLine($"{message} {number}.");

            // 调用方法并输出结果
            Console.WriteLine($"Sum of 1 and 2 is {Add(1, 2)}.");

            // 使用 LINQ 获取偶数并输出
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var evens = numbers.Where(n => n % 2 == 0).ToArray();
            Console.WriteLine("Even numbers: " + string.Join(", ", evens));

            // 异常处理示例：除以零
            try
            {
                int zero = 0;
                int result = number / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 加法方法定义
        static int Add(int a, int b) => a + b;
    }
}
