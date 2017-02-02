using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
	class Math {
		public int Number { get; set; }
		public int MaxLimit { get; set; }

		public List<int> MultiplesOff() {
			List<int> multiples = new List<int>();

			for(int i = 0; i < this.MaxLimit; i++) {
				if (isMultiple(i, this.Number))
					multiples.Add(i);
			}

			return multiples;
		}

		public double Sum(List<double> List) {
			double Sum = 0;
			foreach(double N in List) {
				Sum = Sum + N;
			}

			return Sum;
		}

		// Is "a" a multiple of "b"
		private bool isMultiple(int a, int b) {
			return (a % b) == 0;
		}
	}
}
