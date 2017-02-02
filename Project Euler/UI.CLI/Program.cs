using Core;
using System;
using UI.CLI.Projects;

namespace UI.CLI {
	class Program {
		static void Main(string[] args) {
			Program p = new Program();
			p.Run();
		}

		private void Run() {
			bool running = true;

			while (running) {
				Console.Clear();

				Console.WriteLine("Project Eular Solver\n");

				Console.WriteLine("0. Exit");
				Console.WriteLine("1. Multiples of 3 and 5");

				int MenuSelection;
				Console.WriteLine("\n\nWrite Problem Nr, and hit enter");
				while (!int.TryParse(Console.ReadLine(), out MenuSelection)) {
					Console.WriteLine("Invalid numer. Please type a valid number only!");
				}

				switch (MenuSelection) {
					default: Console.WriteLine("Could not find selection."); break;
					case 0: running = false; break;
					case 1: P1(); break;
				}
			}
		}

		private void P1() {
			One.Run();
		}
	}
}
