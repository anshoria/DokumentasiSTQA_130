using System;

namespace Algoritma
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class program dapat membuat operasi penjumlahan deret bilangan segitiga jika angka yang dimasukkan adalah angka 1-9</remarks>
    class Program
    {
        /// <summary>
        /// operasi penjumlahan deret bilangan segitiga
        /// </summary>
        /// <param name="n">jumlah deret bilangan</param>
        static void Segitiga(int n)
        {
            string deret = "";
            for (int i = 1; i <= n; i++)
            { 
                Console.WriteLine(i + " " + deret);
                deret = i + " " + deret;
            }
        }

        static void Main(string[] args)
        {
            {
                Console.Write("Masukkan angka: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n >= 1 && n <= 9)
                {
                    Segitiga(n);
                }
                else
                {
                    Console.WriteLine("harap masukkan angka 1-9");
                }

                Console.ReadKey();

            }
        }
    }
}


