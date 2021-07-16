using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public class MultiThread
    {
        public static void MainFunction()
        {
            var t1 = new Thread(new ThreadStart(FunctionOne));
            var t2 = new Thread(new ThreadStart(FunctionTwo));
            t1.Start();
            t2.Start();
        }

        public static void FunctionOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function 1 says {i} at {DateTime.Now}");
                Thread.Sleep(500);
            }
        }

        public static void FunctionTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function 2 says {i} at {DateTime.Now}");
                Thread.Sleep(1500);
            }
        }
    }

    public class MultiTask
    {
        public static void MainFunction()
        {
            var resOne = FunctionOne();
            var resTwo = FunctionTwo();

            Task.Run(() =>
            {
                Console.WriteLine(resTwo.Result);
            });
            Task.Run(() =>
            {
                Console.WriteLine(resOne.Result);
                Task.Delay(2000);
            });
        }

        public async static Task<string> FunctionOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function 1 says {i} at {DateTime.Now}");
                await Task.Delay(500);
            }
            return "Function One Completed";
        }

        public async static Task<string> FunctionTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function 2 says {i} at {DateTime.Now}");
                await Task.Delay(1500);
            }
            return "Function Two Completed";
        }
    }

    public class CancellationExample
    {
        public static void MainFunction()
        {
            CancellationTokenSource tokensource = new CancellationTokenSource();
            var tokenOne = tokensource.Token;

            CancellationTokenSource tokensourceTwo = new CancellationTokenSource();
            var tokenTwo = tokensourceTwo.Token;

            var t1 = Task.Run(async () =>
              {
                  for (int i = 0; i < 10; i++)
                  {
                      Console.WriteLine($"Function 1 says {i} at {DateTime.Now}");
                      await Task.Delay(500);

                      tokenOne.ThrowIfCancellationRequested();
                  }
              }, tokenOne).ContinueWith((t) =>
              {
                  t.Exception.Handle((e) => true);
                  Console.WriteLine("The Task One is interrupted");
              }, TaskContinuationOptions.OnlyOnCanceled);

            var t2 = Task.Run(async () =>
             {
                 for (int i = 0; i < 10; i++)
                 {
                     Console.WriteLine($"Function 2 says {i} at {DateTime.Now}");
                     await Task.Delay(1500);
                     tokenTwo.ThrowIfCancellationRequested();
                 }
             }, tokenTwo).ContinueWith((t) =>
             {
                 t.Exception.Handle((e) => true);
                 Console.WriteLine("The Task Two is interrupted");
             }, TaskContinuationOptions.OnlyOnCanceled); ;

            Task.Run(async () =>
            {
                await Task.Delay(2000);
                Console.WriteLine("Cancelling Task 1");
                tokensource.Cancel();
            });

            Task.Run(async () =>
            {
                await Task.Delay(5000);
                Console.WriteLine("Cancelling Task 2");
                tokensourceTwo.Cancel();
            });
        }
    }
}