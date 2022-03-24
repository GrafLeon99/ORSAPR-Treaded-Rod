using Plugin;

namespace Kompas
{
    /// <summary>
	/// Класс для построения резьбовой шпильки в Компас-3D
	/// </summary>
    public class ModelBuilder
    {
        /// <summary>
        /// Смещение детали по умолчанию
        /// </summary>
        private const double DefaultOffset = 0.0;

        /// <summary>
        /// Объект KompasWrapper
        /// </summary>
        private KompasWrapper _kompasWrapper;

        /// <summary>
		/// Создаёт модель резьбовой шпильки
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

            double boltStep = parameters.GetValue(
                ParameterNameTypes.BoltStep);
            double nutStep = parameters.GetValue(
                ParameterNameTypes.NutStep);

            bool isShamfer = parameters.IsChamfer;

            double nutOffset = DefaultOffset;
            double mainOffset = parameters.GetValue(
                ParameterNameTypes.NutLength);
            double boltOffset = parameters.GetValue(
                ParameterNameTypes.MainLength);

            _kompasWrapper.CreateElement(nutDiameter,
                nutLength, nutOffset, true, isShamfer, false, nutStep);
            _kompasWrapper.CreateElement(mainDiameter,
                mainLength, mainOffset);
            _kompasWrapper.CreateElement(boltDiameter,
                boltLength, boltOffset, true, isShamfer, true, boltStep);
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
