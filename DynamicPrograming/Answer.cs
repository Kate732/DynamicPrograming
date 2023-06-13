namespace Kate.DynamicPrograming
{
	public struct Answer
	{
		public double SumOfAnswer { get; set; }
		public int BeginIndexOfCurrSumOfAnswer { get; set; }
		private int _endIndexOfCurrSumOfAnswer;
		public int EndIndexOfCurrSumOfAnswer { 
			get { return _endIndexOfCurrSumOfAnswer; } 
			set { 
				if (value < -1)
				{
					throw new Exception($"End Index Value is not valid: {value}");
				}
				_endIndexOfCurrSumOfAnswer = value; 
			}
		}
		public override string ToString()
		{
			return $"{SumOfAnswer}, {BeginIndexOfCurrSumOfAnswer}, {EndIndexOfCurrSumOfAnswer}";
		}
	}
}
