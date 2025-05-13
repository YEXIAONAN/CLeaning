using System;

namespace Cleaning
{
    /*类名 HelloWorld*/
    internal class HelloWorld
    { 
        const string name = "Mugun";
        const int password = 123456;

        static void Main(string[] args)
        {
            Console.WriteLine("------------小楠登录系统------------");
            Console.WriteLine("欢迎使用LoginSystem！\n请输入用户名：");
            string input_name = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            int input_password = int.Parse(Console.ReadLine());

            /*
             * 判断用户输入是否与程序设置的相同，缺一不可
             */

            // 使用 && 连接符。一次性判断两个输入判断正确
            if (input_name == name && input_password == password)
            {
                Console.WriteLine("登录成功！");
            }
            else
            {
                Console.WriteLine("登录失败！");
            }

        }


    }
}
