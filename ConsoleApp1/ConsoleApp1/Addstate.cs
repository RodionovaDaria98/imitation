using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;


namespace ConsoleApp1
{
    class Addstate
    {
        public Thread Thr { get; set; }

        public Addstate()
        {
            ThreadStart threadRun = new ThreadStart(Run);
            Thr = new Thread(threadRun);
            Thr.Start();
        }
        
        private void Run()
        {
            //timer1 a = new timer1();

            Random r1 = new Random(); 
            Random r2 = new Random();
            Random r3 = new Random();
            int[] svar = new int[4] { 5, 6, 7, 8 };
            int[] proz = new int[3] { 2, 3, 4 };
            int[] relax = new int[3] { 9, 10, 11 };

            //Random r4 = new Random();

            int working = 13;
            Console.WriteLine(" Обьект включен "  /*+ " время   "+ a*/ );
            Console.WriteLine();
            while (!program.overflow)
            {
                try
                {
                    Random _random = new Random();
                    program.s.WaitOne();
                   // Thread.Sleep(_random.Next(100, 100000));
                    int ns = program.r.Next(1, program.cntstay);

                    //var  nsv = svar.Select(x=> Random.Next(0, program.svar));
                    //int nsv = program.svar[new Random().Next(0,)];
                    int nsv = svar[new Random().Next(0, svar.Length)];
                    //int nsv = program.r1.Next(5,8);
                    //int prs = r2.Next(0, program.proz);
                    int prs = proz[new Random().Next(0, proz.Length)];
                    int rels = relax[new Random().Next(0, relax.Length)];
                   // int rels = r3.Next(0, program.relax);

                    //  int np = r2.Next(1, program.cntDetails);
                    stay s = new stay(ns);
                    svarka sv = new svarka(nsv);
                    proiz sp = new proiz(prs);
                    relax sr = new relax(rels);

                    if ( program.Svarka.Count < program.length)
                    {
                        program.Svarka.Enqueue(sv);
                        Thread.Sleep(_random.Next(100, 1000));
                        Console.WriteLine(" Объект  находится в состоянии №  " + nsv /*+ " время   "+ a*/ );
                        Console.WriteLine();
                       
                    }
                    else if ( program.Proiz.Count < program.length )
                    {
                        program.Proiz.Enqueue(sp);
                        Thread.Sleep(_random.Next(100, 500));
                        Console.WriteLine(" объект находится в состоянии    " + prs );
                        Console.WriteLine();

                    }
                    else if (program.Relax.Count < program.length)
                    {
                        program.Relax.Enqueue(sr);
                        Thread.Sleep(_random.Next(100, 500));
                        Console.WriteLine(" объект находится в состоянии    " + rels);
                        Console.WriteLine();

                    }

                    else
                    {
                        Console.WriteLine("Объект выключен");
                        program.overflow = true;
                    }
                    working = working + 10;
                    program.s.Release();
                }
                catch (ObjectDisposedException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Текущий экземпляр семафора уже был удален");
                }
                catch (AbandonedMutexException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ожидание завершено, поскольку поток завершил работу, не освободив семафор.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Текущий экземпляр является прозрачный прокси для WaitHandle в другом домене приложения.");
                }
            }

        }
    }
}
