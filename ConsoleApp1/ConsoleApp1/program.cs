using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class program
    {
        public static Semaphore s = new Semaphore(1, 1, "mySemaphor");
        public static Semaphore sv = new Semaphore(1, 1, "mySem");
        public static Semaphore sp = new Semaphore(1, 1, "myS");

        public static Queue<stay> Stays = new Queue<stay>();
        public static Queue<svarka> Svarka = new Queue<svarka>();
        public static Queue<proiz> Proiz = new Queue<proiz>();
        public static Queue<relax> Relax = new Queue<relax>();
        public static int length { get; set; }
       // public static int cntModel { get; set; }
        public static int cntstay{ get; set; }

        public static int svar { get; set; }
        public static  int proz { get; set; }
        public  static int  relax { get; set;  }
        public static bool overflow { get; set; }
        public static Random r = new Random();
        public static Random r1 = new Random();
        public static Random r2= new Random();
        public static Random r3 = new Random();

        static void Main(string[] args)
        {


             //int[]svar = { 5, 6, 7, 8 };
          //  int[] svar = new int[4] { 5, 6, 7, 8 };

            int[] proz = new int[3] {  2, 3, 4};

            int[] relax = new int[3] { 9,10,11};

          
            cntstay = 13;

            length = 30;

            overflow = false;

            Addstate add = new Addstate();

           
            Console.ReadLine();
        }
    }
}
