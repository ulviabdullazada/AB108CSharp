using System.Diagnostics;

namespace Asynchronous
{
    internal class Program
    {
        static object Ruslan = new();
        static object Murad = new();
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            #region Concurrency, Paralellism
            //Thread t1 = new Thread(() =>
            //{
            //    for (int i = 5000; i < 10000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //Thread t2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 5000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //t1.IsBackground = false;
            //t2.IsBackground = false;
            //t1.Start();
            //t2.Start();
            //Console.WriteLine(t1.ManagedThreadId);
            //Console.WriteLine(t2.ManagedThreadId);
            //Console.WriteLine("asdakjdhasdakjdhasdakjdhasdakjdhasdakjdhasdakjdhasdakjdhasdakjdhasdakjdhasdakjdhasdakjdhasdakjdhasdakjdh");
            //Parallel.Invoke(() =>
            //{
            //    for (int i = 5000; i < 10000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}, () =>
            //{
            //    for (int i = 0; i < 5000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //List<int> list = [1,2,3,4,5,6,7,8,9];
            //Parallel.ForEach(list, x =>
            //{
            //    Console.WriteLine(x*x);
            //});
            #endregion

            #region Race condition, Deadlock
            //int num = 0;
            //Thread t1 = new(() =>
            //{
            //    for (int i = 0; i < 5000000; i++)
            //    {
            //        lock (Murad)
            //        {
            //            lock (Ruslan)
            //            {
            //                num++;
            //            }
            //        }
            //    }
            //});
            //Thread t2 = new(() =>
            //{
            //    for (int i = 0; i < 5000000; i++)
            //    {
            //        lock (Ruslan)
            //        {
            //            lock (Murad)
            //            {
            //                num--;
            //            }
            //        }
            //    }
            //});
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();
            //Console.WriteLine(num);
            #endregion

            #region Async, await, task
            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //Task.Run(() =>
            //{
            //    for (int i = 10; i < 20; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});

            //TestAsync().Wait();
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //SeherYemeyiAsync().Wait();
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            #endregion
        }

        //static async Task TestAsync()
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });
        //}
        static async Task SeherYemeyiAsync()
        {
            await Task.WhenAll(CayiHazirlaAsync(), YumurtaBisirAsync(), SufreniHazirlaAsync());
            //await CayiHazirlaAsync();
            //await YumurtaBisirAsync();
            //await SufreniHazirlaAsync();
            Console.WriteLine("Nush olsun");
        }
        static async Task CayiHazirlaAsync()
        {
            Console.WriteLine("Qazin alti yandirildi");
            await Task.Delay(5000);
            Console.WriteLine("Cay hazirdi");
        }
        static async Task YumurtaBisirAsync()
        {
            Console.WriteLine("Yumurta qirildi");
            Console.WriteLine("Tavaya atildi");
            await Task.Delay(6000);
            Console.WriteLine("Yumurta bisdi!!!");
        }
        static async Task SufreniHazirlaAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Sufre hazirdir");
        }
        static void SeherYemeyi()
        {
            CayiHazirla();
            YumurtaBisir();
            SufreniHazirla();
            Console.WriteLine("Nush olsun");
        }
        static void CayiHazirla()
        {
            Console.WriteLine("Qazin alti yandirildi");
            Thread.Sleep(5000);
            Console.WriteLine("Cay hazirdi");
        }
        static void YumurtaBisir()
        {
            Console.WriteLine("Yumurta qirildi");
            Console.WriteLine("Tavaya atildi");
            Thread.Sleep(6000);
            Console.WriteLine("Yumurta bisdi!!!");
        }
        static void SufreniHazirla()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Sufre hazirdir");
        }
    }
}
