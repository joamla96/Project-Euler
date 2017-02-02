using System.Collections.Generic;

namespace Core {
	public class Maths {
		public int Number { get; set; }
		public int MaxLimit { get; set; }
		public object Result { get; set; }

		public Maths() {

		}

		public Maths(int N, int L) {
			this.Number = N;
			this.MaxLimit = L;
		}

		public void MultiplesOff() {
			List<double> multiples = new List<double>();

			for(double i = 0; i < this.MaxLimit; i++) {
				if (isMultiple(i, this.Number))
					multiples.Add(i);
			}

			this.Result = multiples;
		}

		public void Sum() {
			double Sum = 0;
			foreach(double N in (IEnumerable<double>)this.Result) {
				Sum = Sum + N;
			}

			this.Result = Sum;
		}

		// Is "a" a multiple of "b"
		private bool isMultiple(double a, double b) {
			return (a % b) == 0;
		}
	}
}
