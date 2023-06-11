namespace Kate.DynamicPrograming
{
	public static class MaxSumOfSequence
	{
		public static double CalculateMaxSumOfSequence(List<double> list)
		{
			double sumOfAnswer = 0;
			double maxSumConnectedToCurrentItem = 0;
			bool isConnectedToSum = true;
			foreach (double item in list)
			{
				if (item > 0)
				{
					if (isConnectedToSum) { sumOfAnswer += item; }
					else
					{
						if (maxSumConnectedToCurrentItem + item >= sumOfAnswer)
						{
							sumOfAnswer = item + maxSumConnectedToCurrentItem;
							isConnectedToSum = true;
						}
					}
				}
				else
				{
					isConnectedToSum = false;
					if (maxSumConnectedToCurrentItem + item < 0)
					{
						maxSumConnectedToCurrentItem = 0;
						continue;
					}
				}
				maxSumConnectedToCurrentItem += item;
			}
			return sumOfAnswer;
		}
	}
}
