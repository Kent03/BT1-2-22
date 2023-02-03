using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        // bài giải check nghiệm có phải số nguyên tố không- Khôi-20it438-20MC
        static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Moi nhap so de check: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
                Console.Write("Ban co muon tiep tuc check.");
        }
    }
}
