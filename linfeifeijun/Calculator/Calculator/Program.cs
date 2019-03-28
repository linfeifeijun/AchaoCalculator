using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
namespace Calculator
{
    public class Program
    {
        static public int allcount(int i, int j, int q)
        {
            List<char> sign = new List<char>
            {
                '+','-','*','/'
            };
            DataTable dt = new DataTable();
            double result = Convert.ToDouble(dt.Compute((i.ToString() + sign[q] + j.ToString()), "false"));
            if (result > 0 && Convert.ToInt32(result) == result)
            {
                Console.WriteLine(i.ToString() + sign[q] + j.ToString() + "=" + result.ToString() + '\r' + '\n');
                string fname = @"E:\subject.txt";
                if (File.Exists(fname))
                {
                    File.AppendAllText(fname, i.ToString() + sign[q] + j.ToString() + "=" + result.ToString());
                }

            }
            return 0;
        }
        static void Main(string[] args)
        {
            int w = 0;
            Random a = new Random();
            DataTable dt = new DataTable();
            int n = Convert.ToInt32(Console.ReadLine());
            while (w != n)
            {
                int i = a.Next(0, 101);
                int j = a.Next(0, 101);
                int q = a.Next(0, 4);
                allcount(i, j, q);
                w++;
            }
        }
    }
}
