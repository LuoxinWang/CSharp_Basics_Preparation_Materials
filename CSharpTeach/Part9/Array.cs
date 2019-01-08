using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part9
{
    class Array
    {
        static void Main(string[] args)
        {
            /*
             * 数组是同一类型的一组数据，这些值存储在连续的内存单元中，便于访问操作
             */
            //数组的定义
            /*
             * 声明一个数组可以使用如下写法，但无法使用，因为并没有在内存中初始化数组，如果
             * 需要使用，则需要使用new关键字创建数组的实例对象
             */
            double[] balance;
            balance = new double[10];

            string[] arr2 = new string[10];//声明创建一个数组，这个数组可以存储10个字符串数据

            //数组的赋值和取值
            //1.定义时赋初值
            decimal[] arr3 = { 1, 3, 5, 7, 9 };
            //2.定义以后的赋值和取值
            //利用for循环作为案例
            int count;
            Console.WriteLine("How many numbers do you want to enter?Please write down the number");
            count = Convert.ToInt32(Console.ReadLine());
            string[] numArr = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("No.{0}", i + 1);
                numArr[i] = Console.ReadLine();
            }
            Console.WriteLine("All numbers here:");
            foreach (string key in numArr)
            {
                Console.Write(key + " ");
            }

            Console.ReadLine();
        }
    }
}
