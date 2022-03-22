namespace Plugin
{
    public static class Validator
    {
        /// <summary>
		/// Проверяет, принадлежит ли значение диапазону.
		/// </summary>
        /// <param name="value"> Значение </param>
        /// <param name="minValue"> Минимальное значение </param>
        /// <param name="maxValue"> Максимальное значение </param>
        /// <returns cref="bool">True, если значение принадлежит диапазону, иначе False</returns>
        public static bool IsInRange(double value,double minValue,double maxValue)
        {
            if (value < minValue || value > maxValue)
            {
                return false;
            }
            return true;
        }
    }
}
