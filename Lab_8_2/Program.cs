using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "num10";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string pathNum = "num10/num.txt";
            if (!File.Exists(pathNum))
            {
                File.Create(pathNum);
            }
            int Sum = 0;
            using (StreamWriter sw = new StreamWriter(pathNum))
            {
                int[] n = new int[10];
                Random random = new Random();
                for (int i=1; i<10; i++)
                {
                    n[i] = random.Next(0, 10);
                    sw.WriteLine(n[i]);
                    Sum += n[i];
                }
            }
            using (StreamReader sr = new StreamReader(pathNum))
            {
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine(Sum);
            }
            Console.ReadKey();
        }
    }
}
