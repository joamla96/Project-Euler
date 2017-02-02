using System;
using Core;

namespace UI.CLU {
	class Program {
		static void Main(string[] args) {
			bool running = true;

			while(running) {
				Console.Clear();

				Console.WriteLine("Project Eular Solver\n");

				Console.WriteLine("0. Exit");
				Console.WriteLine("1. Multiples of 3 and 5");

				int MenuSelection;
				Console.WriteLine("\n\nWrite Problem Nr, and hit enter");
				while (!int.TryParse(Console.ReadLine(), out MenuSelection)) {
					Console.WriteLine("Invalid numer. Please type a valid number only!");
				}

				switch(MenuSelection) {
					default: Console.WriteLine("Could not find selection."); break;
					case 0:	running = false; break;
				}
			}
		}
	}
}
