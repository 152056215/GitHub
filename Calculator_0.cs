using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator_0 c = new Calculator_0();
            Console.WriteLine("请输入两个整数：");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            c.math(x, y);
            Console.WriteLine("请输入两个字符串：");
            string m = Console.ReadLine();
            string n = Console.ReadLine();
            c.math(m, n);
        }
    }

    public class Calculator_0
    {
        public void math(int a,int b)
        {
            Console.WriteLine("请选择运算符{1.+，2.-，3.*，4.÷}：");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1: Console.WriteLine(a + b);
                    break;
                case 2: Console.WriteLine(a - b);
                    break;
                case 3: Console.WriteLine(a * b);
                    break;
                case 4:
                    {
                        try { int s = a / b; Console.WriteLine(s); }
                        catch (Exception e) { Console.WriteLine("分母不能为0！"); }
                    }; break;
            }
        }
        public void math(string c, string d)
        {
            Console.WriteLine("请选择运算符{1.+，2.-}：");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1: Console.WriteLine(c+d);
                    break;
                case 2:
                    {
                        if (c.Contains(d))  //c中是否包含d,若是则用Replace(string old,string new)方法替换成新字符串
                        {
                            Console.WriteLine(c.Replace(d,""));
                        }
                    }
                    break;
            }
        }
    }
}
