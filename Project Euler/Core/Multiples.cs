using System.Collections.Generic;

namespace Core {
	public class Multiples {
		public int Number { get; set; }
		public int MaxLimit { get; set; }
		public object Result { get; set; }

		public Multiples() {

		}

		public Multiples(int N, int L) {
			this.Number = N;
			this.MaxLimit = L;
		}

		public void MultiplesOff() {
			List<double> multiples = new List<double>();

			for(double i = 0; i < this.MaxLimit; i++) {
				if (Maths.isMultiple(i, this.Number))
					multiples.Add(i);
			}

			this.Result = multiples;
		}
	}
}
