using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmC__
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.HanoiTowers(1, 2, 4);
            Console.ReadLine();
        }
        //Алгоритм Евклида
        public int Gcd(int a, int b)
        {
            
            return (b == 0) ? a : Gcd(b, a % b);
            
        }
        public void EuclidsAlgorithm()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Program program = new Program();
            Console.WriteLine(program.Gcd(a, b));
        }
        
        //Ханойские башни.
        public void HanoiTowers(int i, int k, int n)
        {
            if(n == 1)
            {
                Console.WriteLine($"Move disk 1 from pin {i} to pin {k}");
            }
            else
            {
                int tmp = 6 - i - k;  //third pin(temporary).
                HanoiTowers(i, tmp, n - 1);
                Console.WriteLine($"Move disk {n} from pin {i} to pin {k}");
                HanoiTowers(tmp, k, n - 1);
            }
        }
    }
}
