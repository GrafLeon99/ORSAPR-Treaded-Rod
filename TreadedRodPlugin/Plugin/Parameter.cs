namespace Plugin
{
    public class Parameter
    {
		/// <summary>
		/// Возвращает и устанавливает значение параметра
		/// </summary>
		public double Value { get; set; }

		/// <summary>
		/// Возвращает и устанавливает минимальное значение
		/// </summary>
		public double MinValue { get; set; }

		/// <summary>
		/// Возвращает и устанавливает максимальное значение
		/// </summary>
		public double MaxValue { get; set; }

		/// <summary>
		/// Конструктор параметра
		/// </summary>
		public Parameter(double defaultValue,
			double minValue, double maxValue)
		{
			MinValue = minValue;
			MaxValue = maxValue;
			Value = defaultValue;
		}
	}
}
