using System;
namespace _4 {
    //1<=n<=20
    //-1e8<=a_i<=1e8
    //-1e8<=k<=1e8
    class Program {
        static int n, k;
        static int[] a;
        static void Solve() {
            if (dfs(0, 0))
                Console.WriteLine("はい");
            else
                Console.WriteLine("エラーだゾ");
        }
        static bool dfs(int i,int sum) {
            if (i == a.Length) return (sum == k);
            //not add
            if(dfs(i + 1, sum)) return true;
            //add
            if(dfs(i + 1, sum + a[i])) return true;
            //muri
            return false;
        }
        static void Main(string[] args) {
            n = int.Parse(Console.ReadLine());
            a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            k = int.Parse(Console.ReadLine());
            Solve();
        }
    }
}
