using Core;
using System;

namespace UI.CLI.Projects {
	public class Two {
		public static void Run() {
			Console.Clear();
			Console.WriteLine("Project 2 - Even Fib Numbers");

			Fibonacci Fib = new Fibonacci();
			Fib.MaxValue = 4000000;

			Fib.Get();

			foreach(double T in Fib.Terms) {
				Console.Write(T + ", ");
			}

			Console.ReadKey();
		}
	}
}
