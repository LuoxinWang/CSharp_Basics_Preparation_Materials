using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class VariablesAndConstants
    {
        static void Main(string[] args)
        {
            //变量的定义和赋值
            int a = 15;
            int b;
            b = 20;
            //var的隐型局部变量
            var number = 123;
            var str = "String";
            var i = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("var:"+number);
            Console.ReadKey();

            //常量的定义与赋值
            const int num = 15;

        }
    }
}
