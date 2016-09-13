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
            Console.WriteLine(getNum());
        }

        public static int AddNum(int v)
        {
            return num += v;
        }

        public static int getNum()
        {
            return num;
        }
    }
}
