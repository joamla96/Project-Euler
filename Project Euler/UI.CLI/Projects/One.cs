using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace UI.CLI.Projects {
	class One {
		public static void Run() {
			Maths Three = new Maths(3, 1000);
			Maths Five = new Maths(5, 1000);


			// Gather their multiples
			Thread T0 = new Thread(Three.MultiplesOff);
			Thread T1 = new Thread(Five.MultiplesOff);

			T0.Start();
			T1.Start();

			T0.Join();
			T1.Join();

			Console.WriteLine("Multiples of 3, less than 1000:");
			foreach(double N in (List<double>)Three.Result) {
				Console.Write(N + ", ");
			}

			Console.WriteLine("\n\nMultiples of 5, less than 1000:");
			foreach (double N in (List<double>)Five.Result) {
				Console.Write(N + ", ");
			}

			// Gather results, and merge, and remove duplicates
			List<double> ResultThree = (List<double>)Three.Result;
			List<double> ResultFive = (List<double>)Five.Result;

			IEnumerable<double> Result = ResultThree.Union(ResultFive);

			Maths Final = new Maths();
			Final.Result = Result;

			// Spin off one last thread for the summing
			Thread T3 = new Thread(Final.Sum);

			T3.Start();
			Console.Write("\n\nTotal Sum: ");

			T3.Join();

			
			Console.WriteLine(Final.Result);

			Console.WriteLine("\n\nHit a key to close.");
			Console.ReadKey();
		}
	}
}
