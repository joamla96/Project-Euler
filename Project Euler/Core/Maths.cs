using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {

	public class Maths {
		public static double Sum(IEnumerable<double> List) {
			double Sum = 0;
			foreach (double N in List) {
				Sum = Sum + N;
			}

			return Sum;
		}

		// Is "a" a multiple of "b"
		public static bool isMultiple(double a, double b) {
			return (a % b) == 0;
		}

		// Is Even
		public static bool isEven(double n) {
			return (n % 2) == 0;
		}
	}
}
