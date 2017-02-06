using Core;
using System;
using System.Collections.Generic;
using System.Threading;

namespace UI.CLI.Projects {
	public class Two {
		public static void Run() {
			Console.Clear();
			Console.WriteLine("Project 2 - Even Fib Numbers");

			Fibonacci Fib = new Fibonacci();
			Fib.MaxValue = 4000000;

			Thread T1 = new Thread(Fib.Get);
			Thread T2 = new Thread(Fib.GetEven);

			T1.Start();
			T1.Join();

			T2.Start();
			T2.Join();

			foreach(double T in Fib.Terms) {
				Console.Write(T + ", ");
			}

			Console.ReadKey();
		}
	}
}
