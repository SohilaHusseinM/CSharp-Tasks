using System.Diagnostics;
using System.Security.Cryptography;

namespace DAY1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int st = 1, ed = (int)1e8 - 1;
            int cnt = 0;
            Stopwatch stopwatch = new Stopwatch();

            #region Case1
            stopwatch.Start();
            for (int i = st; i <= ed; i++)
            {
                string s = i.ToString();
                string[] strList = s.Split(new char[] { '0', '2', '3', '4', '5', '6', '7', '8', '9' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < strList.Length; j++)
                {
                    cnt += strList[j].Length;
                }
            }
            stopwatch.Stop();
            double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine($"Case1\nTime taken: {elapsedSeconds.ToString("F10")} seconds The result:{cnt}");
            #endregion


            #region Case2
            cnt = 0;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = st; i <= ed; i++)
               {
                   int x = i;
                   while (x != 0)
                   {
                       if (x % 10 == 1) cnt++;
                       x /= 10;
                   }
               }
            stopwatch.Stop();
            elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine($"Case2\nTime taken: {elapsedSeconds.ToString("F10")} seconds The result:{cnt}");
            #endregion


            #region Case3

            cnt = 0;
            int fstRange = 0;
            for (int i = 1; i < 100; i++)
            {
                int x = i;
                while (x != 0)
                {
                    if (x % 10 == 1) fstRange++;
                    x /= 10;
                }
            }

            cnt += fstRange;
            int sndRange = fstRange + 100;

            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i < 8; i++)
            {
                cnt += fstRange * 8;
                cnt += sndRange;
                fstRange *= 10; fstRange += (int)Math.Pow(10, i);
                sndRange = fstRange + (int)Math.Pow(10, i + 1);
            }
            stopwatch.Stop();
            elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine($"Case3\nTime taken: {elapsedSeconds.ToString("F10")} seconds The result:{cnt}");
            #endregion
        }
    }
}
