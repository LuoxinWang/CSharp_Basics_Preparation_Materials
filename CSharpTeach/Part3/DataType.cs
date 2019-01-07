using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    //数据类型：
    /*
     C#中的数据类型分为三种：
     值类型
     引用类型
     指针类型
    */
    class DataType
    {
        static void Main(string[] args)
        {
            //值类型（Value Types）
            //布尔型bool
            bool flag = true;
            //整型byte，short，int，long
            byte b = 99;//字节型
            short s = 123;//短整型
            int i = 12345;//整型
            long l = 123456789;//长整型
            //128 位精确的十进制值，28-29 有效位数
            decimal di = 12345678901234567890;
            //浮点型
            float f = 1.234f;//单精度
            double d = 1.2345678;//双精度
            //字符型
            char c = 'a';

            //引用类型（Reference Types）
            //字符串型string
            string str = "HELLO C#";


            Console.WriteLine("布尔型"+flag);
            Console.WriteLine("短整型"+s);
            Console.WriteLine("整型"+i);
            Console.WriteLine("长整型"+l);
            Console.WriteLine("decimal"+di);
            Console.WriteLine("float型"+f);
            Console.WriteLine("double型"+d);
            Console.WriteLine("char型"+c);
            Console.WriteLine("字符串 string型"+str);
            Console.ReadKey();

        }
    }
}
