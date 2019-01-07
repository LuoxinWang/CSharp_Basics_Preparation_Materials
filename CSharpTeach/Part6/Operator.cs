using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6
{
    class Operator
    {
        static void Main(string[] args)
        {
            /*
             * 运算符是一种告诉编译器执行特定的数学或逻辑操作的符号。C# 有丰富的内置运算符，分类如下：
             * 算术运算符
             * 关系运算符
             * 逻辑运算符
             * 位运算符
             * 赋值运算符
             * 其他运算符
             */
            //算术运算符+ - * / % ++ --
            int num1 = 15;
            int num2 = 5;
            Console.WriteLine("num1+num2=" + num1 + num2);
            Console.ReadKey();
            Console.WriteLine("num1-num2=" + num1 - num2);
            Console.ReadKey();
            Console.WriteLine("num1*num2=" + num1 * num2);
            Console.ReadKey();
            Console.WriteLine("num1/num2=" + num1 / num2);
            Console.ReadKey();
            Console.WriteLine("num1%num2=" + num1 % num2);
            Console.ReadKey();
            Console.WriteLine("num1++ =" + num1++);
            Console.ReadKey();
            Console.WriteLine("num1-- =" + num2--);
            Console.ReadKey();
            Console.WriteLine("++num1 =" + ++num1);
            Console.ReadKey();
            Console.WriteLine("--num2 =" + --num2);
            Console.ReadKey();
            /*
             *关于a++和++a 
             *c = a++: 先将 a 赋值给 c，再对 a 进行自增运算。
             *c = ++a: 先将 a 进行自增运算，再将 a 赋值给 c 。
             *c = a--: 先将 a 赋值给 c，再对 a 进行自减运算。
             *c = --a: 先将 a 进行自减运算，再将 a 赋值给 c 。
             */

            //关系运算符：== != >= <= > < 
            int c = 15;
            int d = 20;
            bool flag = c < d;
            Console.WriteLine("c<d：" + flag);
            Console.ReadKey();

            //逻辑运算符 && || !
            bool flag2 = (10 > 2) && (5 < 3);
            Console.WriteLine("(10 > 2) && (5 < 3): {0}",flag2);
            Console.ReadKey();

            //位运算符 & | ^


            //赋值运算符 = += -= *= /= %= <<= >>= &= ^= |=


            //其他运算符 sizeof() typeof() &（返回变量地址） *（指针）?:(条件表达式) is as



        }
    }
}
