//一个C#程序主要包括以下部分
//namespace 命名空间声明
//一个 class
//Class 方法
//Class 属性
//一个 Main 方法
//语句（Statements）& 表达式（Expressions）
//注释

//以下代码的所有结构注释
//using：引用命名空间，使用其他命名空间的方法，类似java中的import
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace：命名空间，一个 namespace 里包含了一系列的类，类似JAVA中的包package
namespace Part1
{
    //class：声明一个类，类一般包含多个方法。方法定义了类的行为。
    class ProgramStructure
    {
        //Main 方法，是所有 C# 程序的 入口点。Main 方法说明当执行时 类将做什么动作。
        static void Main(string[] args)
        {
            //调用System命名空间下的Console类中的WriteLine方法，输出一句话
            Console.WriteLine("这是我的第一个C#程序");
            //针对 VS.NET 用户的。这使得程序会等待一个按键的动作，防止程序从 Visual Studio .NET 启动时屏幕会快速运行并关闭。
            Console.ReadKey();
        }
    }
}
