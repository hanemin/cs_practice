using System;
namespace _2 {
    class Program {
        static int n;
        static int[] a;
        static int Solve() {
            Array.Sort(a);
            Array.Reverse(a);
            for(int i=0;i<a.Length-2;i++)
                for(int j=i+1;j<a.Length-1;j++)
                    for(int k = j + 1; k < a.Length; k++)
                        if (a[i] < (a[j] + a[k]))
                            return a[i] + a[j] + a[k];
            return 0;
        }
        static void Main(string[] args) {
            n = int.Parse(Console.ReadLine());
            a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(Solve());
        }
    }
}
