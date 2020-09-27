using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProc
{
    static class FileWork
    {
        public static void ReadF(ref int N, ref int[] inputArr, ref int K)
        {
            try
            {
                using (var sr = new StreamReader("input.txt"))
                {
                    N = int.Parse(sr.ReadLine());
                    inputArr = new int[N];
                    var str = sr.ReadLine().Split(new char[] { ' ' });
                    for (int i = 0; i < N; i++)
                    {
                        inputArr[i] = int.Parse(str[i]);//если во второй строке файла больше чем N символов,отсавшиеся не буду прочитаны
                    }
                    K = int.Parse(sr.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void WriteF(int[] outputArr)
        {
            try
            {
                using (var sw = new StreamWriter("output.txt"))
                {
                    foreach (var item in outputArr)
                    {
                        sw.Write(item.ToString() + " ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
