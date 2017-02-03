using System.Collections.Generic;

namespace Core {
	public class Fibonacci {
		public double MaxValue { get; set; }
		public double MaxTerm { get; set; }
		public List<double> Terms = new List<double>();

		private double CurrentTerm = 1;
		private double CurrentValue = 1;
		private double LastValue = -1; // Offset, so we can get 1,1

		public void Get() {
			while((CurrentTerm < MaxTerm) || (CurrentValue < MaxValue)) {
				Terms.Add(CurrentValue);
				CurrentTerm++;

				LastValue = CurrentValue;
				CurrentValue = CurrentValue + LastValue;
			}
		}
	}
}
