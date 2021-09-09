using System;

namespace Abramyan_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private int Int2()
        {
            int M = int.Parse(Console.ReadLine());
            return M/1000;
        }
        private int Int4()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            return a/b;
        }
        private void Int6()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number/10+""+number%10);
        }
        private void Int8()
        {
            int k = int.Parse(Console.ReadLine());
            int dozens = k / 10;
            int units = k % 10;
            Console.WriteLine(units + "" + dozens);
        }
        private void Int10()
        {
            int number = int.Parse(Console.ReadLine());
            int dozens = number%100/ 10;
            int units = number % 10;
            Console.WriteLine(units + "" + dozens);
        }
        private  void Int12()
        {
            int number = int.Parse(Console.ReadLine());
            int hundreds = number / 100;
            int dozens = number % 100 / 10;
            int units = number % 10;
            Console.WriteLine(units + "" + dozens+""+hundreds);
        }
        private void Int14()
        {
            int number = int.Parse(Console.ReadLine());
            int dozens = number / 10;
            int units = number % 10;
            Console.WriteLine(units + "" + dozens);
        }
        private  void Int16()
        {
            int number = int.Parse(Console.ReadLine());
            int hundreds = number / 100;
            int dozens = number % 100 / 10;
            int units = number % 10;
            Console.WriteLine(hundreds+""+units + "" + dozens);
        }
        private void Int18()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 10000 / 1000); 
        }
        private void Int20()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(N/3600);
        }
        private void Int22()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(N & 3600);
        }
        private void Int24()
        {
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(k % 7);
        }
        private void Int26()
        {
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(k % 7 +1);
        }
        private  void Int28()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((k+n-2)%7+1);
        }
        private void Int30()
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine((year-1)/100 +1);
        }
        private bool Bool2()
        {
            int a = int.Parse(Console.ReadLine());
            return a % 2 == 1;
        }
        private bool Bool4()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            return b <= 3 && a > 2;
        }
        private bool Bool6()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return a < b&& b < c;
        }
        private bool Bool8()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            return a % 2 == 1 && b % 2 == 1;
        }
        private bool Bool10()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            return a % 2 == 1 && b % 2 == 0 || a % 2 == 0 && b % 2 == 1;
        }
        private bool Bool12()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return a >0 && b > 0 && c > 0;
        }
        private bool Bool14()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return a > 0 && b < 0 && c < 0 ||
                   a < 0 && b > 0 && c < 0 ||
                   a < 0 && b < 0 && c > 0;
        }
        private bool Bool16()
        {
            int a = int.Parse(Console.ReadLine());
            return a>9 && a<100 && a%2 ==0;
        }
        private bool Bool18()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return a == b || b == c || c == a;
        }
        private bool Bool20()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return a != b && b != c && c != a;
        }
        private bool Bool22()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return a < b && b < c || a > b && b > c;
        }
        private bool Bool24()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return b * b - 4 * a * c >= 0;
        }
        private bool Bool26()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return x > 0 && y < 0;
        }
        private bool Bool28()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return x > 0 && y > 0 || x < 0 && y < 0;
        }
        private bool Bool30()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return a==b&&b==c;
        }
        private bool Bool32()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            return a * a == b * b + c * c ||
                   b * b == a * a + c * c || 
                   c * c == a * a + b * b; 
        }
        private bool Bool34()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return (x+y)%2 == 0;
        }
        private bool Bool36()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            return x==x2&& y!= y2||x!=x2 && y==y2 ; 
        }
        private bool Bool38()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            return Math.Abs(x-x2)==Math.Abs(y-y2) || x==x2||y==y2;
        }
        private bool Bool40()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            return Math.Abs(x - x2) ==1 && Math.Abs(y - y2) ==2  || Math.Abs(x - x2) == 2 && Math.Abs(y - y2) == 1;
        }
    }
}
