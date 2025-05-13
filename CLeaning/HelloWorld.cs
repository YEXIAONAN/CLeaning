using System;

namespace Cleaning
{
    /*类名 HelloWorld*/
    internal class HelloWorld
    {
        // const 关键字用于声明一个常量，即一个在编译时就确定且运行时不可更改的值
        public const string name = "Mugun";

        static void Main(string[] args)
        {
            // 布尔类型变量
            const bool boolean = true;
            
            // byte类型
            const byte b1 = 1;
            
            // char类型
            const char c = 'c';
            
            // int类型
            const int i = 1;
            
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.name);

        }

        class MyClass
        {
            public string name = "91";
            
            
        }


    }
}
