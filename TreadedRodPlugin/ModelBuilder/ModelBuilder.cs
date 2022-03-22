using Plugin;

namespace Kompas
{
    /// <summary>
	/// Класс для построения резьбовой шпильки в Компас-3D
	/// </summary>
    public class ModelBuilder
    {
        /// <summary>
        /// Смещение детали по умоляанию
        /// </summary>
        private const double DEFAULT_OFFSET_Y = 0.0;

        /// <summary>
        /// Объект KompasWrapper
        /// </summary>
        private KompasWrapper _kompasWrapper;

        /// <summary>
		/// Создание модели резьбовой шпильки
		/// </summary>
        public void BuildModel(ModelParameters parameters)
        {
            double nutDiameter = parameters.GetValue(
                ParameterNameTypes.NutDiameter);
            double mainDiameter = parameters.GetValue(
                ParameterNameTypes.MainDiameter);
            double boltDiameter = parameters.GetValue(
                ParameterNameTypes.BoltDiameter);
            double nutLength = parameters.GetValue(
                ParameterNameTypes.NutLength);
            double mainLength = parameters.GetValue(
                ParameterNameTypes.MainLength) -
                parameters.GetValue(ParameterNameTypes.NutLength);
            double boltLength = parameters.GetValue(
                ParameterNameTypes.BoltLength);

            double nutOffset = DEFAULT_OFFSET_Y;
            double mainOffset = parameters.GetValue(
                ParameterNameTypes.NutLength);
            double boltOffset = parameters.GetValue(
                ParameterNameTypes.MainLength);

            _kompasWrapper.CreateElement(nutDiameter,
                nutLength, nutOffset, true);
            _kompasWrapper.CreateElement(mainDiameter,
                mainLength, mainOffset, false);
            _kompasWrapper.CreateElement(boltDiameter,
                boltLength, boltOffset, true);
        }

        /// <summary>
		/// Конструктор 
		/// </summary>
        public ModelBuilder()
        {
            _kompasWrapper = new KompasWrapper();
        }
    }
}
