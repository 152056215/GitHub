using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.math();
        }
    }
    public class Calculator
    {
        Boolean w = true;
        public void math()
        {
            while (w)
            {
                Console.WriteLine("请输入两个运算数：");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("是否继续运算？\n 1.yes    2.no  ");
                string d = Console.ReadLine();
                if (d.Equals("1"))
                {
                    w = true;
                }
                else if (d.Equals("2"))
                {
                    w = false;
                }
            }
        }
        
    }
}
