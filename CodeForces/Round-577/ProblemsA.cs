//problem link https://codeforces.com/contest/1201/problem/A
using System;
using System.Collections.Generic;
using System.Text;

namespace Competitive_Programming.CodeForces.Round_577
{
    public class ProblemsA
    {
        public void Solve()
        {
            int[] A = Reader.ReadArray();

            int n = A[0], m = A[1];

            int[,] B = new int[m, 5];
            int[] ans = new int[m];


            while (n-- > 0)
            {
                var s = Reader.ReadStr();

                for (int i = 0; i < s.Length; i++)
                {
                    B[i, s[i] - 'A']++;
                    ans[i] = Math.Max(ans[i], B[i, s[i] - 'A']);
                }
            }

            int[] mul = Reader.ReadArray();

            long res = 0;

            for (int i = 0; i < m; i++)
                res += mul[i] * ans[i];

            Console.WriteLine(res);
        }
    }
}
