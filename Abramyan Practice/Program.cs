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
            return Math.Abs(x - x2) == 1 && Math.Abs(y - y2) == 2 || Math.Abs(x - x2) == 2 && Math.Abs(y - y2) == 1;
        }
        private void If2()
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
                number+= 1;
            if (number < 0)
                number -= 2;
        }
        private void If4()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int result = 0;
            if (first > 0)
                result += 1;
            if (second > 0)
                result += 1;
            if(third>0)
                result += 1;
        }
        private void If6()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if(first>second)
                Console.WriteLine(first);
            if(second>first)
                Console.WriteLine(second);
        }
        private void If8()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if (first > second)
                Console.WriteLine(first + "" + second);
            if (second > first)
                Console.WriteLine(second + "" + first);
        }
        private void If10()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A != B)
            {
                int c = A + B;
                A += c;
                B += c;
            }
            else if(A == B)
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine( A+""+B);
        }
        private void If12()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int min =first;
            if (min > second)
                min = second;
            if (min > third)
                min = third;
            Console.WriteLine(min);
        }
        private void If14()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int min = first;
            int max = first;
            if (min > second)
                min = second;

            if (max < second)
                max = second;

            if (min > third)
                min = third;

            if (max < third)
                max = third;
            Console.WriteLine(min +""+max);
        }
        private void If16()
        {
            float first = float.Parse(Console.ReadLine());
            float second = float.Parse(Console.ReadLine());
            float third = float.Parse(Console.ReadLine());
            if(first<second && second<third)
            {
                first *= 2;
                second *= 2;
                third *= 2;
            }
            else
            {
                first *= -1;
                second *= -1;
                third *= -1;
            }
        }
        private void If18()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int result = 1;
            if (first == second)
                result = 3;
            if (first == third)
                result = 2;
            Console.WriteLine(result);
        }
        private void If20()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if(Math.Abs(A-B) > Math.Abs(A-C))
            {
                Console.WriteLine("B" + B);
            }
            else
            {
                Console.WriteLine("C" + C);
            }
        }
        private void If22()
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            if (X > 0 && Y > 0)
                Console.WriteLine("1");
            if (X < 0 && Y > 0)
                Console.WriteLine("2");
            if (X < 0 && Y < 0)
                Console.WriteLine("3");
            if (X > 0 && Y < 0)
                Console.WriteLine("4");
        }
        private void If24()
        {
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            if (x > 0)
                result = 2 * Math.Sin(x);
            if (x <= 0)
                result = 6 - x;
        }
        private void If26()
        {
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            if (x >= 2)
                result = 2;
            if (x <= 0)
                result =-x;
            if (0 < x && x < 2)
                result = x * x;
        }
        private void If28()
        {
            int year = int.Parse(Console.ReadLine());
            int result = 365;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                result = 366;
        }
        private void If30()
        {
            int number = int.Parse(Console.ReadLine());
            string result = "";

            if (number % 2 == 0)
                result += "Четное";
            else
                result += "Нечетное";

            if (number / 100 > 0)
                result += " Трехзначное";
            else
                result += " Двузначное";

            result += " число";
        }
        private void Case2()
        {
            int k = int.Parse(Console.ReadLine());
            string result;
            switch (k)
            {
                case 1:
                    result = "Плохо";
                    break;
                case 2:
                    result = "Неудовлетворительно";
                    break;
                case 3:
                    result = "Удовлетворительно";
                    break;
                case 4:
                    result = "Хорошо";
                    break;
                case 5:
                    result = "Отлично";
                    break;
            }
        }
        private void Case4()
        {
            int number = int.Parse(Console.ReadLine());
            int result;
            switch (number)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    result = 31;
                    break;
                case 6:
                case 9:
                    result = 30;
                    break;
                case 2:
                    result = 28;
                    break;
            }
        }
        private void Case6()
        {
            int unitsOfLength = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            switch (unitsOfLength)
            {
                case 1:
                    length *= 10;
                    break;
                case 2:
                    length /= 10;
                    break;
                case 4:
                    length *= 1000;
                    break;
                case 5:
                    length *= 100;
                    break;
            }
        }
        private void Case8()
        {
          int D = int.Parse(Console.ReadLine());
          int M = int.Parse(Console.ReadLine());
            D -= 1;
            if (D == 0)
            {
                M -= 1;
                if (M == 0)
                    M = 12;
                switch (M)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        D = 31;
                        break;
                    case 6:
                    case 9:
                        D = 30;
                        break;
                    case 2:
                        D = 28;
                        break;
                }
            }
        }
        private void Case10()
        {
            int N = int.Parse(Console.ReadLine());
            char C = char.Parse(Console.ReadLine());
            switch (C)
            {
                case 'N':
                    switch (N)
                    {
                        case 1:
                            C = 'W';
                                break;
                        case -1:
                            C = 'E';
                            break;
                    }
                    break;
                case 'W':
                    switch (N)
                    {
                        case 1:
                            C = 'S';
                            break;
                        case -1:
                            C = 'N';
                            break;
                    }
                    break;
                case 'S':
                    switch (N)
                    {
                        case 1:
                            C = 'E';
                            break;
                        case -1:
                            C = 'W';
                            break;
                    }
                    break;
                case 'E':
                    switch (N)
                    {
                        case 1:
                            C = 'N';
                            break;
                        case -1:
                            C = 'S';
                            break;
                    }
                    break;
            }
        }
        private void Case12()
        {
            float P = 3.14f;
            int k = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            float R =0 , D =0 , L=0 ,S =0 ;

            switch (k)
            {
                case 1:
                    R = value;
                    D = R * 2;
                    L = 2 * P * R;
                    S = P * R * R;
                    break;
                case 2:
                    D = value;
                    R = D / 2;
                    L = D * P;
                    S = R * R * P;
                    break;
                case 3:
                    L = value;
                    D = L / P;
                    R = D / 2;
                    S = S = R * R * P;
                    break;
                case 4:
                    S = value;
                    R = (float)Math.Sqrt(S / P);
                    D = 2 * R;
                    L = L = 2 * P * R;
                    break;
            }
            Console.WriteLine(R+""+D+""+L+""+'S');
        }
        private void Case14()
        {
            float threeUnderRoot = (float)Math.Pow(3, 1 / 2);
            int k = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            float a =0 , R1 =0 , R2= 0, S=0 ;
            switch (k)
            {
                case 1:
                    a = value;
                    R1 = a * threeUnderRoot/6;
                    R2 = R1 * 2;
                    S = a * a * threeUnderRoot / 4;
                    break;
                case 2:
                    R1 = value;
                    a = R1 * 6 / threeUnderRoot;
                    R2 = R1 * 2;
                    S = a * a * threeUnderRoot / 4;
                    break;
                case 3:
                    R2 = value;
                    R1 = R2 / 2;
                    a = R1 *6 / threeUnderRoot;
                    S = a * a * threeUnderRoot / 4;
                    break;
                case 4:
                    S = value;
                    a = (float)Math.Sqrt(S * 4 / threeUnderRoot);
                    R1 = a * threeUnderRoot / 6;
                    R2 = R1 * 2;
                    break;
            }
            Console.WriteLine(a + "" + R1 + "" + R2 + "" + S);
        }
        private void Case16()
        {
            int age = int.Parse(Console.ReadLine());
            string ageString ="";
            ageString += GetDozensInString(age / 10,0);
            ageString += GetUnitsInString(age % 10);
            switch(age % 10)
            {
                case 1:
                    ageString += " год";
                    break;
                case 2:
                case 3:
                case 4:
                    ageString += " года";
                    break;
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    ageString += " лет";
                    break;
            }
        }
        private void Case18()
        {
            int number = int.Parse(Console.ReadLine());
            int hundreds = number / 100;
            int dozens = number % 100 / 10;
            int units = number % 10;
            string result = "";

            result += GetHundredsInString(hundreds);

            result += GetDozensInString(dozens, units);

            if(dozens >= 2 || dozens == 0)
            {
                result += GetUnitsInString(units);
            }
            Console.WriteLine(result);
        }
        private void Case20()
        {
            int D = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            string zodiacSign = "";
            switch (M)
            {
                case 1:
                    if (D < 20)
                        zodiacSign = "козерог";
                    else
                        zodiacSign = "водолей";
                    break;
                case 2:
                    if (D < 19)
                        zodiacSign = "водолей";
                    else
                        zodiacSign = "рыбы";
                    break;
                case 3:
                    if (D < 21)
                        zodiacSign = "рыбы";
                    else
                        zodiacSign = "овен";
                    break;
                case 4:
                    if (D < 20)
                        zodiacSign = "овен";
                    else
                        zodiacSign = "телец";
                    break;
                case 5:
                    if (D < 21)
                        zodiacSign = "телец";
                    else
                        zodiacSign = "близнецы";
                    break;
                case 6:
                    if (D < 22)
                        zodiacSign = "близнецы";
                    else
                        zodiacSign = "рак";
                    break;
                case 7:
                    if (D < 23)
                        zodiacSign = "рак";
                    else
                        zodiacSign = "лев";
                    break;
                case 8:
                    if (D < 23)
                        zodiacSign = "лев";
                    else
                        zodiacSign = "дева";
                    break;
                case 9:
                    if (D < 23)
                        zodiacSign = "дева";
                    else
                        zodiacSign = "весы";
                    break;
                case 10:
                    if (D < 23)
                        zodiacSign = "весы";
                    else
                        zodiacSign = "скорпион";
                    break;
                case 11:
                    if (D < 23)
                        zodiacSign = "скорпион";
                    else
                        zodiacSign = "стрелец";
                    break;
                case 12:
                    if (D < 22)
                        zodiacSign = "стрелец";
                    else
                        zodiacSign = "козерог";
                    break;
            }
            Console.WriteLine(zodiacSign);

        }
        private string GetHundredsInString(int hundreds)
        {
            string result = "";
            switch (hundreds)
            {
                case 1:
                    result = "Сто";
                    break;
                case 2:
                    result = "Двести";
                    break;
                case 3:
                    result = "Триста";
                    break;
                case 4:
                    result = "Четыреста";
                    break;
                case 5:
                    result = "Пятьсот";
                    break;
                case 6:
                    result = "Шестьсот";
                    break;
                case 7:
                    result = "Семьсот";
                    break;
                case 8:
                    result = "Восемьсот";
                    break;
                case 9:
                    result = "Девятьсот";
                    break;
            }
            return result;
        }
        private string GetDozensInString(int dozens,int units)
        {
            string result = "";
            switch (dozens)
            {
                case 1:
                    switch (units)
                    {
                        case 1:
                            result = " одиннадцать";
                            break;
                        case 2:
                            result = " двенадцать";
                            break;
                        case 3:
                            result = " тринадцать";
                            break;
                        case 4:
                            result = " четырнадцать";
                            break;
                        case 5:
                            result = " пятнадцать";
                            break;
                        case 6:
                            result = " шестнадцать";
                            break;
                        case 7:
                            result = " семнадцать";
                            break;
                        case 8:
                            result = " восемнадцать";
                            break;
                        case 9:
                            result = " девятнадцать";
                            break;
                    }
                    break;
                case 2:
                    result = " двадцать";
                    break;
                case 3:
                    result = " тридцать";
                    break;
                case 4:
                    result = " сорок";
                    break;
                case 5:
                    result = " пятьдесят";
                    break;
                case 6:
                    result = " шестьдесят";
                    break;
            }
            return result;

        }
        private string GetUnitsInString(int units)
        {
            string result = "";
            switch (units)
            {
                case 1:
                    result = " один";
                    break;
                case 2:
                    result = " два";
                    break;
                case 3:
                    result = " три";
                    break;
                case 4:
                    result = " четыре";
                    break;
                case 5:
                    result = " пять";
                    break;
                case 6:
                    result = " шесть";
                    break;
                case 7:
                    result = " семь";
                    break;
                case 8:
                    result = " восемь";
                    break;
                case 9:
                    result = " девять";
                    break;
            }
            return result;
        }
    }
}
