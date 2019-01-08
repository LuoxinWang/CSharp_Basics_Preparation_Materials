using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part10
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            //类型转换：隐式类型转换和显示类型转换
            /* 隐式类型转换 - 这些转换是 C# 默认的以安全方式进行的转换, 
             * 不会导致数据丢失。例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。
             * 显式类型转换 -显式类型转换，即强制类型转换。显式转换需要强制转换运算符，
             * 而且强制转换会造成数据丢失。
             */
            //1.显示类型转换
            double a = 5474.123654;
            int b = (int)a;

            //2.隐式类型转换
            int c = 15;
            double d = c;

            //3.Convert类：Convert类提供了一系列转换方法,可以转换string类型的数据,但要保证原始数据可以转换
            string str = "1";
            int num1 = Convert.ToInt32(str);
            Console.WriteLine(num1);
            Console.ReadKey();
            char c1 = Convert.ToChar(str);
            Console.WriteLine(c1);
            Console.ReadKey();
            string str1 = Convert.ToString(num1);
            Console.WriteLine(str1);
            Console.ReadKey();
            double num4 = Convert.ToDouble(str);
            float num5 = Convert.ToSingle(str);
            /*
             * 还有诸如ToDateTime();ToBoolean();等等
             */

            //4.Parse方法：同样的转换，只针对于字符串形式，相对而言，Convert针对所有数据类型
            //注意：同样要保证数据可以进行转换，如字符串123.456转换为int类型是不可以的，会报异常
            string str2 = "12";
            int p1 = int.Parse(str2);
            Console.WriteLine(p1);
            Console.ReadKey();
            float p2 = float.Parse(str2);
            Console.WriteLine(p2);
            Console.ReadKey();

            //5.TryParse方法：int.TryParse(string s,out int i)
            // 该方式也是将数字内容的字符串转换为int类型，但是该方式比int.Parse(string s) 
            // 好一些，它不会出现异常，最后一个参数result是输出值，如果转换成功则输出相应的
            // 值，转换失败则输出0。 
            string str3 = "135";
            string str4 = "135.217";
            bool bol = int.TryParse(str3, out int tp1);
            Console.WriteLine("转换成功与否：{0}，转换的值：{1}",bol,tp1);
            Console.ReadLine();
            bool bol2 = int.TryParse(str4, out int tp2);
            Console.WriteLine("转换成功与否：{0}，转换的值：{1}", bol2, tp2);
            Console.ReadLine();


        }
    }
}
