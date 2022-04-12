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
		/// Значение параметра по умолчанию.
		/// </summary>
		private double _defaultValue;

		//TODO:
		/// <summary>
		/// Проверяет, принадлежит ли значение диапазону.
		/// </summary>
		/// <param name="value"> Значение </param>
		/// <param name="minValue"> Минимальное значение </param>
		/// <param name="maxValue"> Максимальное значение </param>
		/// <returns cref="bool">True, если значение принадлежит диапазону, иначе False</returns>
		private bool IsInRange(double value, double minValue, double maxValue)
		{
			if (value < minValue || value > maxValue)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Возвращает и устанавливает значение параметра по умолчанию.
		/// </summary>
		public double DefaultValue
		{
			get { return _defaultValue; }
			set
			{
				if (!IsInRange(value, MinValue, MaxValue))
				{
					throw new ArgumentException
						(
						"Значение должно быть в диапазоне " +
						MinValue.ToString() + " - " + MaxValue.ToString()
						);
				}
				_defaultValue = value;
			}
		}
		/// <summary>
		/// Возвращает и устанавливает значение параметра.
		/// </summary>
		public double Value 
		{ 
			get { return _value; }
			set 
			{
				if (!IsInRange(value, MinValue, MaxValue))
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
			DefaultValue = value;
		}

		/// <summary>
		/// Конструктор параметра.
		/// </summary>
		/// <param name="value">Значение</param>
		/// <param name="minValue">Минимальное значение</param>
		/// <param name="maxValue">Максимальное значение</param>
		/// <param name="defaultValue">Значение, по умолчанию</param>
		public Parameter(double value,
			double minValue, double maxValue, double defaultValue)
		{
			MinValue = minValue;
			MaxValue = maxValue;
			DefaultValue = defaultValue;
			Value = value;
		}
	}

	
}
