using Kate.DynamicPrograming;

namespace TestCalculateMaxSumOfSequence
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestEmptyList()
		{
			List<double> origin = new List<double> { };
			Answer expected = new Answer { SumOfAnswer = 0, BeginIndexOfCurrSumOfAnswer = -1, EndIndexOfCurrSumOfAnswer = -1 };
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestAllNegativeNumbers()
		{
			List<double> origin = new List<double> { -1, -25, -12 };
			Answer expected = new Answer { SumOfAnswer = 0, BeginIndexOfCurrSumOfAnswer = -1, EndIndexOfCurrSumOfAnswer = -1 };
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestAllPositiveNumbers()
		{
			List<double> origin = new List<double> { 1, 2, 3, 4, 5 };
			Answer expected = new Answer { SumOfAnswer = 15, BeginIndexOfCurrSumOfAnswer = 0, EndIndexOfCurrSumOfAnswer = 4 };
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestNegativeAndPositiveNumbersAnswerIsInTheEnd()
		{
			List<double> origin = new List<double> { 5, -1, -3, 6, -25, 8 };
			Answer expected = new Answer { SumOfAnswer = 8, BeginIndexOfCurrSumOfAnswer = 5, EndIndexOfCurrSumOfAnswer = 5 };
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestNegativeAndPositiveNumbersAnswerIsInTheMiddle()
		{
			List<double> origin = new List<double> { 5, -1, -3, 6, -25, 2 };
			Answer expected = new Answer { SumOfAnswer = 7, BeginIndexOfCurrSumOfAnswer = 0, EndIndexOfCurrSumOfAnswer = 3 };
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
		[TestMethod]
		public void TestNegativeAndPositiveNumbersAnswerIsInTheMiddle2()
		{
			List<double> origin = new List<double> { 5, -1, -3, 6, -25, 2, 30, -1, 4 };
			Answer expected = new Answer { SumOfAnswer = 35, BeginIndexOfCurrSumOfAnswer = 5, EndIndexOfCurrSumOfAnswer = 8 };
			Assert.AreEqual(expected, MaxSumOfSequence.CalculateMaxSumOfSequence(origin));
		}
	}
}