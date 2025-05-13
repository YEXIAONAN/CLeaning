# C#基础教程

 

> C#，称为C sharp。基于C++进行优化，在语法上与Java大差不多，非常适合从Java继续学习到C#！



----

C# 是一个现代的、通用的、面向对象的编程语言，它是由微软（Microsoft）开发的，由 Ecma 和 ISO 核准认可的。

C# 是由 Anders Hejlsberg 和他的团队在 .Net 框架开发期间开发的。

C# 是专为公共语言基础结构（CLI）设计的。CLI 由可执行代码和运行时环境组成，允许在不同的计算机平台和体系结构上使用各种高级语言。

下面列出了 C# 成为一种广泛应用的专业语言的原因：

- 现代的、通用的编程语言。
- 面向对象。
- 面向组件。
- 容易学习。
- 结构化语言。
- 它产生高效率的程序。
- 它可以在多种计算机平台上编译。
- .Net 框架的一部分。

---



### C# 第一个程序

```c#
using System;

namespace Cleaning
{
    /*类名 HelloWorld*/
    internal class HelloWorld
    {
        /*Main方法，与Java相同程序执行入口*/
        private static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld!");
        }
    }
}

```



在C#侧边栏中，你会看到许多项目。让我们来一一认识它们吧！

| 📁 项目结构项            | 🤔 是什么？                         |
| ----------------------- | ---------------------------------- |
| 📦 依赖项 (Dependencies) | 你项目用到的库，全都列在这。       |
| 📦 包 (Packages)         | 从 NuGet 装的插件和工具。          |
| 🧠 分析器 (Analyzers)    | 自动帮你挑错的代码检查器。         |
| 🏗 框架 (Framework)      | 项目用的是哪个 .NET 版本。         |
| 📄 `.cs` 文件            | 你自己写的代码，比如类和方法。     |
| 🧱 类（比如 HelloWorld） | 你写的逻辑模块，组织代码用的单位。 |

> ✅ 总结一句话：只有 `.cs` 是你亲手写的，其它都是项目运行或辅助你开发用的！



----



### C#中易错行为

>  相信在上面说了，C#有着与Java相似的Main方法入口，但是在C#中，main方法的入口只能存在一个文件中，如果需要在其他文件编写main方法，则需要在生成执行文件之后，指定运行方法



**在 C# 中，你可以在多个类中写多个 `Main` 方法，但** 👉 **一个项目只能有一个入口点（Main 方法）被执行。**



 🔍 详细说明：

- C# 和 Java 都支持多个类里写 `Main` 方法。
- **但 Java 是靠类名 + 命令行运行的（`java ClassName`）**，你可以选择运行哪个类。
- **C# 是项目编译成 EXE 后固定一个入口点**，默认会去找 `static void Main(string[] args)` 来执行。

如果你写了多个 `Main`，C# 会报错：“项目有多个入口点，必须指定一个”。



 ✅切换使用 Main？

你可以这样操作：

1. **保留多个类中的 Main 方法，但只能启用一个。**
2. 在项目属性中指定哪一个是启动对象：

 在 Visual Studio 中设置启动项：

- 右键项目 → “属性（Properties）” → “应用程序（Application）”页签
- 找到 “启动对象（Startup object）”，下拉选一个你希望执行的类的全名（如 `Cleaning.test` 或 `Cleaning.HelloWorld`）

这样你可以像 Java 那样，在不同类中写测试代码，然后切换启动执行谁。



🧪 示例：

```csharp
// File1.cs
namespace Cleaning
{
    internal class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("我是 HelloWorld 的 Main");
        }
    }
}

// File2.cs
namespace Cleaning
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("我是 Test 的 Main");
        }
    }
}
```

**只需在项目属性中选定 HelloWorld 或 Test 作为“启动对象”，就可以控制执行哪一个。**



 🧠 总结：

> ✅ C# 可以有多个 `Main()`，但每次编译只能指定一个作为“程序入口点”。
>  🚫 和 Java 不一样的是，不能直接运行某个类，而是要通过“启动对象”设置控制。





### *using* 关键字

在任何 C# 程序中的第一条语句都是：

```
using System;
```

**using** 关键字用于在程序中包含命名空间。一个程序可以包含多个 using 语句。

### *class* 关键字

**class** 关键字用于声明一个类。

### C# 中的注释

注释是用于解释代码。编译器会忽略注释的条目。在 C# 程序中，多行注释以 **/\*** 开始，并以字符 ***/** 终止，如下所示：

```
/* 这个程序演示
C# 的注释
使用 */
```

单行注释是用 **//** 符号表示。例如：

```
// 这一行是注释 
```

**成员变量**

变量是类的属性或数据成员，用于存储数据。在上面的程序中，*Rectangle* 类有两个成员变量，名为 *length* 和 *width*。

**成员函数**

函数是一系列执行指定任务的语句。类的成员函数是在类内声明的。我们举例的类 Rectangle 包含了三个成员函数： *AcceptDetails*、*GetArea* 和 *Display*。

**实例化一个类**

在上面的程序中，类 *ExecuteRectangle* 是一个包含 *Main()* 方法和实例化 *Rectangle* 类的类。

**标识符**

标识符是用来识别类、变量、函数或任何其它用户定义的项目。在 C# 中，类的命名必须遵循如下基本规则：

- 标识符必须以字母、下划线或 **@** 开头，后面可以跟一系列的字母、数字（ 0 - 9 ）、下划线（ _ ）、@。
- 标识符中的第一个字符不能是数字。
- 标识符必须不包含任何嵌入的空格或符号，比如 ? - +! # % ^ & * ( ) [ ] { } . ; : " ' / \。
- 标识符不能是 C# 关键字。除非它们有一个 @ 前缀。 例如，@if 是有效的标识符，但 if 不是，因为 if 是关键字。
- 标识符必须区分大小写。大写字母和小写字母被认为是不同的字母。
- 不能与C#的类库名称相同。

**C# 关键字**

关键字是 C# 编译器预定义的保留字。这些关键字不能用作标识符，但是，如果您想使用这些关键字作为标识符，可以在关键字前面加上 @ 字符作为前缀。

在 C# 中，有些关键字在代码的上下文中有特殊的意义，如 get 和 set，这些被称为上下文关键字（contextual keywords）。

下表列出了 C# 中的保留关键字（Reserved Keywords）和上下文关键字（Contextual Keywords）：

| **保留关键字**   |           |           |            |                        |                       |                |
| ---------------- | --------- | --------- | ---------- | ---------------------- | --------------------- | -------------- |
| abstract         | as        | base      | bool       | break                  | byte                  | case           |
| catch            | char      | checked   | class      | const                  | continue              | decimal        |
| default          | delegate  | do        | double     | else                   | enum                  | event          |
| explicit         | extern    | false     | finally    | fixed                  | float                 | for            |
| foreach          | goto      | if        | implicit   | in                     | in (generic modifier) | int            |
| interface        | internal  | is        | lock       | long                   | namespace             | new            |
| null             | object    | operator  | out        | out (generic modifier) | override              | params         |
| private          | protected | public    | readonly   | ref                    | return                | sbyte          |
| sealed           | short     | sizeof    | stackalloc | static                 | string                | struct         |
| switch           | this      | throw     | true       | try                    | typeof                | uint           |
| ulong            | unchecked | unsafe    | ushort     | using                  | virtual               | void           |
| volatile         | while     |           |            |                        |                       |                |
| **上下文关键字** |           |           |            |                        |                       |                |
| add              | alias     | ascending | descending | dynamic                | from                  | get            |
| global           | group     | into      | join       | let                    | orderby               | partial (type) |
| partial (method) | remove    | select    | set        |                        |                       |                |

**顶级语句（Top-Level Statements）**

在 C# 9.0 版本中，引入了顶级语句（Top-Level Statements）的概念，这是一种新的编程范式，允许开发者在文件的顶层直接编写语句，而不需要将它们封装在方法或类中。

**特点：**

- **无需类或方法**：顶级语句允许你直接在文件的顶层编写代码，无需定义类或方法。
- **文件作为入口点**：包含顶级语句的文件被视为程序的入口点，类似于 C# 之前的 `Main` 方法。
- **自动 `Main` 方法**：编译器会自动生成一个 `Main` 方法，并将顶级语句作为 `Main` 方法的主体。
- **支持局部函数**：尽管不需要定义类，但顶级语句的文件中仍然可以定义局部函数。
- **更好的可读性**：对于简单的脚本或工具，顶级语句提供了更好的可读性和简洁性。
- **适用于小型项目**：顶级语句非常适合小型项目或脚本，可以快速编写和运行代码。
- **与现有代码兼容**：顶级语句可以与现有的 C# 代码库一起使用，不会影响现有代码。

**传统 C# 代码** - 在使用顶级语句之前，你必须像这样编写一个 C# 程序：

**实例**

```c#
using System;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
    }
  }
}
```

**使用顶级语句的 C# 代码** - 使用顶级语句，可以简化为：

**实例**

```c#
using System;

Console.WriteLine("Hello, World!");
```

顶级语句支持所有常见的 C# 语法，包括声明变量、定义方法、处理异常等。

**实例**

```c#
**using System;
using System.Linq;

*// 顶级语句中的变量声明*
int number = 42;
string message = "The answer to life, the universe, and everything is";

*// 输出变量*
Console.WriteLine($"{message} {number}.");

*// 定义和调用方法*
int Add(int a, int b) => a + b;
Console.WriteLine($"Sum of 1 and 2 is {Add(1, 2)}.");

*// 使用 LINQ*
var numbers = new[] { 1, 2, 3, 4, 5 };
var evens = numbers.Where(n => n % 2 == 0).ToArray();
Console.WriteLine("Even numbers: " + string.Join(", ", evens));

*// 异常处理*
try
{
  int zero = 0;
  int result = number / zero;
}
catch (DivideByZeroException ex)
{
  Console.WriteLine("Error: " + ex.Message);
}
```



**注意事项**

- 文件限制：顶级语句只能在一个源文件中使用。如果在一个项目中有多个使用顶级语句的文件，会导致编译错误。
- 程序入口：如果使用顶级语句，则该文件会隐式地包含 Main 方法，并且该文件将成为程序的入口点。
- 作用域限制：顶级语句中的代码共享一个全局作用域，这意味着可以在顶级语句中定义的变量和方法可以在整个文件中访问。

顶级语句在简化代码结构、降低学习难度和加快开发速度方面具有显著优势，特别适合于编写简单程序和脚本。



### C#数据类型

在 C# 中，变量分为以下几种类型：

- 值类型（Value types）
- 引用类型（Reference types）
- 指针类型（Pointer types）

#### 值类型（Value types）

值类型变量可以直接分配给一个值。它们是从类 **System.ValueType** 中派生的。

值类型直接包含数据。比如 **int、char、float**，它们分别存储数字、字符、浮点数。当您声明一个 **int** 类型时，系统分配内存来存储值。

下表列出了 C# 2010 中可用的值类型：
