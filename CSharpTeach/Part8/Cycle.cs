using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part8
{
    class Cycle
    {
        static void Main(string[] args)
        {
            //循环：while for/foreach do-while 嵌套循环
            /*
             * while循环：只要给定的条件为真，C# 中的 while 循环语句会重复执行一个目标语句。
             * while(condition)
             * {
             * statement(s);
             * }
             * statement(s) 可以是一个单独的语句，也可以是几个语句组成的代码块。
             * condition 可以是任意的表达式，当为任意非零值时都为真。当条件为真时执行循环
             */
            /* 局部变量定义 */
            int a = 10;

            /* while 循环执行 */
            while (a < 20)
            {
                Console.WriteLine("a 的值： {0}", a);
                a++;
            }
            Console.ReadLine();

            /*
             *  for 循环：是一个允许编写一个执行特定次数的循环的重复控制结构。
             *  for(初始化变量;循环条件;控制语句){
             *      循环体
             *  }
             */
            for (int k = 10; k < 20; k ++)
            {
                Console.WriteLine("k 的值： {0}", k);
            }
            Console.ReadLine();

            /*
             * foreach:增强型for循环
             */
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibarray)
            {
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine();


            // 类似 foreach 循环
            for (int i = 0; i < fibarray.Length; i++)
            {
                System.Console.WriteLine(fibarray[i]);
            }
            System.Console.WriteLine();

            /*
             * do-while循环：do...while 循环是在循环的尾部检查它的条件。
             * do...while 循环与 while 循环类似，但是 do...while 循环会确保至少执行一次循环。
             * do
             * {
             *    statement(s);
             * }while( condition );
             * 条件表达式出现在循环的尾部，所以循环中的 statement(s) 会在条件被测试之前至少执行一次。
             * 如果条件为真，控制流会跳转回上面的 do，然后重新执行循环中的 statement(s)。
             * 这个过程会不断重复，直到给定条件变为假为止。
             */
            /* 局部变量定义 */
            int num = 10;

            /* do 循环 */
            do
            {
                Console.WriteLine("num 的值： {0}", num);
                num = num + 1;
            } while (num == 100); /* 返回false，不继续循环*/
            //} while (num< 20);

            Console.ReadLine();

        }
    }
}
