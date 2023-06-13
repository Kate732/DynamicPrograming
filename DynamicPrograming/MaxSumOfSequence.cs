namespace Kate.DynamicPrograming
{
	public static class MaxSumOfSequence
	{
		public static Answer CalculateMaxSumOfSequence(List<double> list)
		{
			double sumOfAnswer = 0;
			double maxSumConnectedToCurrentItem = 0;
			int beginIndexOfCurrMaxSum = -1; int endIndexOfCurrMaxSum = -1;
			int beginIndexOfCurrSumOfAnswer = -1; int endIndexOfCurrSumOfAnswer = -1;
			for (int i = 0; i < list.Count; i++)
			{
				double previousMaxSum = maxSumConnectedToCurrentItem;
				double previousSumOfAnswer = sumOfAnswer;
				double item = list[i];
				maxSumConnectedToCurrentItem = Math.Max(maxSumConnectedToCurrentItem + item, 0);
				sumOfAnswer = Math.Max(sumOfAnswer, maxSumConnectedToCurrentItem);
				if (maxSumConnectedToCurrentItem == 0)
				{
					beginIndexOfCurrMaxSum = -1;
				}
				beginIndexOfCurrMaxSum = maxSumConnectedToCurrentItem > 0 && previousMaxSum == 0
					? i : beginIndexOfCurrMaxSum;
				endIndexOfCurrMaxSum = maxSumConnectedToCurrentItem > 0
					? i : -1;
				beginIndexOfCurrSumOfAnswer = sumOfAnswer > previousSumOfAnswer
					? beginIndexOfCurrMaxSum : beginIndexOfCurrSumOfAnswer;
				endIndexOfCurrSumOfAnswer = sumOfAnswer > previousSumOfAnswer
					? endIndexOfCurrMaxSum : endIndexOfCurrSumOfAnswer;
			}
			Answer answer = new Answer()
			{
				SumOfAnswer = sumOfAnswer,
				BeginIndexOfCurrSumOfAnswer = beginIndexOfCurrSumOfAnswer,
				EndIndexOfCurrSumOfAnswer = endIndexOfCurrSumOfAnswer
			};
			return answer;
		}
	}
}
