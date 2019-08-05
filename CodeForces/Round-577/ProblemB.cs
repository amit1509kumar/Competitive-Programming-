//problem link -https://codeforces.com/contest/1201/problem/B

using System;
using System.Collections.Generic;
using System.Text;

namespace Competitive_Programming.CodeForces.Round_577
{
    public class ProblemB
    {
        public void Solve()
        {
            int n = Reader.ReadInt();
            int[] A = Reader.ReadArray();

            long sum = 0;
            int max = 0;

            foreach (var a in A)
            {
                sum += a;
                max = Math.Max(a, max);
            }



            Console.WriteLine(sum % 2 == 0 && sum - max >= max ? "YES" : "NO");
        }
    }
}
