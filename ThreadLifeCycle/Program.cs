//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;


//namespace ThreadLifeCycle
//{
//    internal class Program
//    {
//        static void Method1()
//        {
//            Console.WriteLine("Thread 1 is running");
//        }
//        static void Method2()
//        {
//            Console.WriteLine("Thread 2 is running");
//        }
//        static void Main(string[] args)
//        {
//            //First Thread
//            Thread t1 = new Thread(Method1);
//            //second thread
//            Thread t2 = new Thread(Method2);
//            //start the Threads
//            t1.Start();
//            t2.Start();
//            //join the threads or wait for both threads to finish
//            t1.Join();
//            t2.Join();
//            Console.WriteLine("both threads finished");
//        }
//    }
//    }
//program for arithmatic operations by using  Multiple Threads
//using System;
//using System;
//using System.Threading;

//namespace ThreadMathOperations
//{
//    class Program
//    {
//        static int a = 20;
//        static int b = 10;

//        static void Add()
//        {
//            Console.WriteLine("Addition = " + (a + b));
//        }

//        static void Sub()
//        {
//            Console.WriteLine("Subtraction = " + (a - b));
//        }

//        static void Mul()
//        {
//            Console.WriteLine("Multiplication = " + (a * b));
//        }

//        static void Div()
//        {
//            Console.WriteLine("Division = " + (a / b));
//        }

//        static void Main(string[] args)
//        {
//            Thread t1 = new Thread(Add);
//            Thread t2 = new Thread(Sub);
//            Thread t3 = new Thread(Mul);
//            Thread t4 = new Thread(Div);

//            t1.Start();
//            t2.Start();
//            t3.Start();
//            t4.Start();

//            // Main thread waits here
//            t1.Join();
//            t2.Join();
//            t3.Join();
//            t4.Join();

//            Console.WriteLine("All Threads Completed");

//            Console.ReadLine();
//        }
//    }
//}
//using System.ComponentModel;

//prg to make a thread as BackgroundWorker thread
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Method()
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine("Background Thread: " + i);
//                Thread.Sleep(1000);
//            }
//        }
//        static void Main(string[] args)
//        {
//            //Creating a thread
//            Thread t = new Thread(Method);

//            //Make "t" as a background thread
//            t.IsBackground = true;

//            //Start the thread
//            t.Start();

//            Console.WriteLine("Main Thread started");

//            //wait for some time : 2 seconds
//            Thread.Sleep(2000);


//            Console.WriteLine("Main Thread Ended");
//        }
//    }
//}
//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static int count = 0;
//        static object obj = new object();
//        static void Add()
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                lock (obj)
//                {
//                    count++;
//                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "count:" + count);
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            Thread t1 = new Thread(Add);
//            Thread t2 = new Thread(Add);
//            Thread t3 = new Thread(Add);
//            Thread t4 = new Thread(Add);
//            t1.Start();
//            t2.Start();
//            t3.Start();
//            t4.Start();
//            t1.Join();
//            t2.Join();
//            t3.Join();
//            t4.Join();
//        }
//    }
//}
//TO INVOKE ONE METHOD USING MULTIPLE THREADS
namespace MulThereads
{
    //    class MyClass
    //    {
    //        internal void Method()
    //        {
    //            for (int i = 1; i < 10; i++)
    //            {
    //                Console.WriteLine("Method is " + i);
    //            }
    //        }
    //    }
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            MyClass obj = new MyClass();

    //            ThreadStart tstart = new ThreadStart(obj.Method);
    //            Thread thr1 = new Thread(tstart);
    //            thr1.Start();
    //            Thread thr2 = new Thread(tstart);
    //            thr2.Start();
    //        }
    //    }
    //}
    //invoke more methods
    class MyClass
    {
        internal void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 1 is " + i);
            }
        }
        internal void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                MyClass obj = new MyClass();
                ThreadStart tstart = new ThreadStart(obj.Method1);
                Thread thr1 = new Thread(tstart);
                thr1.Start();
                Thread thr2 = new Thread(tstart);
                thr2.Start();
            }
        }
    }
}

