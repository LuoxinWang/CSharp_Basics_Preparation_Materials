using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C# 是一种面向对象的编程语言。在面向对象的程序设计方法中，程序由各种相互交互的对象组成。
//相同种类的对象通常具有相同的类型，或者说，是在相同的 class 中。
namespace Part2
{
    //例如：Cuboid类作为一个长方体对象，拥有长(length)、宽(weight)、高(height)三个属性
    //它可能需要接受这些属性值、计算表面积、体积和显示细节。
    //让我们来看看一个这个类的实现，讨论 C# 的基本语法：
    class Cuboid
    {
        //定义三个属性
        double length;
        double weight;
        double height;
        //创建方法，给三者赋值
        public void Acceptdetails()
        {
            length = 2.5;
            weight = 3.25;
            height = 4.5;
        }
        //创建方法计算表面积
        public double GetArea()
        {
            return 2 * (length * weight + length * height + weight * height);
        }
        //创建方法计算体积
        public double GetVolume()
        {
            return length * weight * height;
        }
        //创建方法，输出所有信息
        public void Display()
        {
            Console.WriteLine("长方体的长为：{0}", length);//{0}代表占位符将后续的数据附到对应位置
            Console.WriteLine("长方体的宽为：{0}", weight);
            Console.WriteLine("长方体的高为：{0}", height);
            Console.WriteLine("长方体的表面积为：{0}", GetArea());
            Console.WriteLine("长方体的体积为：{0}", GetVolume());
        }
    }

    //声明一个类，实现Cuboid类中的方法
    class BasicGrammar
    {
        static void Main()
        {
            //实例化Cubiod类，创建一个长方体的对象
            Cuboid b = new Cuboid();
            //调用Acceptdetails方法，给这个对象赋值
            b.Acceptdetails();
            //调用Display方法，输出信息
            b.Display();
            Console.ReadKey();
        }
    }
}
