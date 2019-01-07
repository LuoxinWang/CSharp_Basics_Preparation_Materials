using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7
{
    class Jujde
    {
        static void Main(string[] args)
        {
            //C#判断 if if-else 嵌套if switch 嵌套switch
            //判断结构要求程序员指定一个或多个要评估或测试的条件，以及条件为真时要执行的语句（必需的）
            //和条件为假时要执行的语句（可选的）。
            /*
             * if语句：进行条件表达式判断，若为真，则执行之后的代码语句
             * if(表达式){
             *  执行代码
             * }
             */
            if (2 + 3 > 4)
            {
                Console.WriteLine("条件为真");
                Console.ReadKey();
            }

            /*
             * if-else语句：进行条件判断，若为真，则执行之后的代码块代码，否则执行else后的代码
             * if(表达式){
             *  执行代码1
             * }else{
             *  执行代码2
             * }
             */
            Console.WriteLine("Write the first number");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);
            Console.WriteLine("Write the second number");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);

            if (num1 > num2)
            {
                Console.WriteLine("{0}>{1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0}<={1}", num1, num2);
            }
            Console.ReadKey();
            /*
             * if-else if-else语句：存在多个条件下的不同输出时使用
             * if(){
             * 
             * }else if(){
             * 
             * }
             * 
             * .
             * .
             * .
             * 
             * else{
             * }
             */
            Console.WriteLine("Please Input Your Age:(Age>0)");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt16(ageInput);
            if (age < 18)
            {
                Console.WriteLine("未成年");
            }
            else if (age >= 18 && age < 30)
            {
                Console.WriteLine("青年");
            }
            else if (age >= 30 && age < 60)
            {
                Console.WriteLine("中年");
            }
            else if (age >= 60)
            {
                Console.WriteLine("老年");
            }
            Console.ReadKey();
            /*
             * 嵌套if结构：在一个条件进行判断过后在进行另一个条件判断
             * if(){
             *  if(){
             *      ... ...
             *  }else{
             *      ... ...
             *  }
             * }else{
             *  ... ...
             * }
             * 
             */

            Console.WriteLine("Please input your name:(Administrator:admin)");
            string name = Console.ReadLine();
            Console.WriteLine("Please input your password:(Administrator:123456)");
            string password = Console.ReadLine();
            if (name.Equals("admin"))
            {
                if (password.Equals("123456"))
                {
                    Console.WriteLine("Login Success!");
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                }
            }
            else
            {
                Console.WriteLine("Wrong Login Name");
            }
            Console.ReadKey();

            /*
             * switch结构：switch结构实质上和if-else if相差不大，同样是在多个条件判断时所使用，
             * 区别在于if后的条件是表达式，而switch后只可以传参数
             * switch(参数){
             * case 值1:
             *  值1满足执行代码
             * case 值2:
             *  值2满足执行代码
             *   .
             *   .
             *   .
             * default:
             *  所有值都不满足时执行代码
             *   
             * }
             */
            Console.WriteLine("请选择你要进行的操作：1.登录；2.注册；3.退出；");
            string chInput = Console.ReadLine();
            int choice = Convert.ToInt32(chInput);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Login Page");
                    break;
                case 2:
                    Console.WriteLine("Register Page");
                    break;
                case 3:
                    Console.WriteLine("Exit Page");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            Console.ReadKey();
            /*
             * 嵌套switch语句：可以把一个 switch 作为一个外部 switch 的语句序列的一部分，
             * 即可以在一个 switch 语句内使用另一个 switch 语句。即使内部和外部 switch 
             * 的 case 常量包含共同的值，也没有矛盾。
             */
            int a = 100;
            int b = 200;

            switch (a)
            {
                case 100:
                    Console.WriteLine("这是外部 switch 的一部分");
                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("这是内部 switch 的一部分");
                            break;
                    }
                    break;
            }
            Console.WriteLine("a 的准确值是 {0}", a);
            Console.WriteLine("b 的准确值是 {0}", b);
            Console.ReadLine();
        }
    }
}
