using Kate.DynamicPrograming;

namespace TestCalculateMaxSumOfSequence
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestEmptyList()
		{
			List<double> origin = new List<double> {  };
			double expected = 0;
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestAllNegativeNumbers()
		{
			List<double> origin = new List<double> { -1, -25, -12 };
			double expected = 0;
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestAllPositiveNumbers()
		{
			List<double> origin = new List<double> { 1, 2, 3, 4, 5 };
			double expected = 15;
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestNegativeAndPositiveNumbersAnswerIsInTheEnd()
		{
			List<double> origin = new List<double> { 5, -1, -3, 6, -25, 8 };
			double expected = 8;
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestNegativeAndPositiveNumbersAnswerIsInTheMiddle()
		{
			List<double> origin = new List<double> { 5, -1, -3, 6, -25, 2 };
			double expected = 7;
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestNegativeAndPositiveNumbersAnswerIsInTheMiddle2()
		{
			List<double> origin = new List<double> { 5, -1, -3, 6, -25, 2, 30, -1, 4 };
			double expected = 35;
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
	}
}