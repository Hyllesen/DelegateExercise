using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        delegate int NumberChanger(int n);
        static int num = 10;

        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(AddNum2);
            nc1 += nc2;
            nc1(5);
            Console.WriteLine(getNum());
        }

        public static int AddNum(int v)
        {
            return num += v;
        }
        
        public static int AddNum2(int v)
        {
            return num += v;
        }

        public static int getNum()
        {
            return num;
        }
    }
}
