using System;
namespace Plugin
{
	/// <summary>
	/// Класс числового параметра модели.
	/// </summary>
	public class Parameter
    {
		/// <summary>
		/// Минимальное значение параметра.
		/// </summary>
		private double _minValue;

		/// <summary>
		/// Максимальное значение параметра.
		/// </summary>
		private double _maxValue;

		/// <summary>
		/// Значение параметра.
		/// </summary>
		private double _value;

		/// <summary>
		/// Возвращает и устанавливает значение параметра.
		/// </summary>
		public double Value 
		{ 
			get { return _value; }
			set 
			{
				if (!Validator.IsInRange(value, MinValue, MaxValue))
				{
					throw new ArgumentException
						(
						"Значение должно быть в диапазоне " +
						MinValue.ToString() + " - " + MaxValue.ToString()
						);
				}
				_value = value;
			} 
		}

		/// <summary>
		/// Возвращает и устанавливает минимальное значение.
		/// </summary>
		public double MinValue 
		{ 
			get { return _minValue; }
			set { _minValue = value; }
		}

		/// <summary>
		/// Возвращает и устанавливает максимальное значение.
		/// </summary>
		public double MaxValue 
		{
			get { return _maxValue; }
			set 
			{
				if (value <= MinValue)
				{
					throw new ArgumentException
						(
						"Максимальное значение должно быть больше минимального"
						);
				}
				_maxValue = value;
			}
		}

		/// <summary>
		/// Конструктор параметра.
		/// </summary>
		/// <param name="value">Значение</param>
		/// <param name="minValue">Минимальное значение</param>
		/// <param name="maxValue">Максимальное значение</param>
		public Parameter(double value,
			double minValue, double maxValue)
		{
			MinValue = minValue;
			MaxValue = maxValue;
			Value = value;
		}
	}

	
}
