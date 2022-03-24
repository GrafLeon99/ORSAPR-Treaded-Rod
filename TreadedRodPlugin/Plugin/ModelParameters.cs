using System;
using System.Collections.Generic;

namespace Plugin
{
    /// <summary>
    /// Класс, хранящий параметры модели
    /// </summary>
    public class ModelParameters
    {
        /// <summary>
		/// Словарь числовых параметров модели
		/// </summary>
        private readonly Dictionary<ParameterNameTypes, Parameter> _modelParameters;

        /// <summary>
		/// параметр модели, отвечающий за нанесение фаски.
		/// </summary>
        private bool _isChamfer;

        /// <summary>
		/// устанавливает и возвращает значение параметра, отвечающего за нанесение фаски.
		/// </summary>
        public bool IsChamfer 
        { 
            get { return _isChamfer; }
            set { _isChamfer = value; }
        }

        /// <summary>
		/// Устанавливает значечие параметра, проверяя значения зависимых параметров
		/// </summary>
        /// <param name="parameterName"> Имя параметра </param>
        /// <param name="value"> Значение параметра </param>
        public void SetValue(ParameterNameTypes parameterName, double value)
        {
            switch (parameterName)
            {
                case ParameterNameTypes.MainDiameter:
                    {
                        if (value <
                            _modelParameters[ParameterNameTypes.NutDiameter].Value)
                        {
                            throw new ArgumentException
                                (
                                "Не должно быть меньше диаметра гаечной резьбы"
                                );
                        }
                        if (value >
                            _modelParameters[ParameterNameTypes.MainLength].Value)
                        {
                            throw new ArgumentException
                                (
                                "Не должно превышать длину шпильки"
                                );
                        }
                        break;
                    }
                case ParameterNameTypes.NutDiameter:
                    {
                        if (value >
                            _modelParameters[ParameterNameTypes.MainDiameter].Value)
                        {
                            throw new ArgumentException
                                (
                                "Не должно быть больше диаметра шпильки"
                                );
                        }
                        if (value >
                            _modelParameters[ParameterNameTypes.NutLength].Value)
                        {
                            throw new ArgumentException
                                (
                                "Не должно превышать длину гаечной резьбы"
                                );
                        }
                        break;
                    }
                case ParameterNameTypes.BoltDiameter:
                    {
                        if (value >
                            _modelParameters[ParameterNameTypes.BoltLength].Value)
                        {
                            throw new ArgumentException
                                (
                                "Не должно превышать длину ввинчиваемой резьбы"
                                );
                        }
                        break;
                    }
                case ParameterNameTypes.MainLength:
                    {
                        if (value <
                            _modelParameters[ParameterNameTypes.NutLength].Value)
                        {
                            throw new ArgumentException
                                (
                                "Не должно быть меньше длины гаечной резьбы"
                                );
                        }
                        if (value <
                           _modelParameters[ParameterNameTypes.MainDiameter].Value)
                        {
                            throw new ArgumentException
                                (
                                "Должно быть не меньше диаметра шпильки"
                                );
                        }
                        break;
                    }
                case ParameterNameTypes.NutLength:
                    {
                        if (value >
                            _modelParameters[ParameterNameTypes.MainLength].Value)
                        {
                            throw new ArgumentException
                                (
                                "Не должно быть больше длины шпильки"
                                );
                        }
                        if (value <
                           _modelParameters[ParameterNameTypes.NutDiameter].Value)
                        {
                            throw new ArgumentException
                                (
                                "Должно быть не меньше диаметра гаечной резьбы"
                                );
                        }
                        break;

                    }
                case ParameterNameTypes.BoltLength:
                    {
                        if (value <
                           _modelParameters[ParameterNameTypes.BoltDiameter].Value)
                        {
                            throw new ArgumentException
                                (
                                "Должно быть не меньше диаметра резьбы"
                                );
                        }
                        break;
                    }
                case ParameterNameTypes.BoltStep:
                    {
                        break;
                    }
                case ParameterNameTypes.NutStep:
                    {
                        break;
                    }
            }

            _modelParameters[parameterName].Value = value;

        }

        /// <summary>
		/// Возвращает значение параметра.
		/// </summary>
        /// <param name="parameterName"> Имя параметра </param>
		/// <returns cref="double">Значение параметра</returns>
        public double GetValue(ParameterNameTypes parameterName)
        {
            return _modelParameters[parameterName].Value;
        }


        /// <summary>
		/// Возвращает значение параметра по умолчанию.
		/// </summary>
        /// <param name="parameterName"> Имя параметра </param>
		/// <returns cref="double">Значение параметра по умолчанию</returns>
        public double GetDefaultValue(ParameterNameTypes parameterName)
        {
            return _modelParameters[parameterName].DefaultValue;
        }

        /// <summary>
		/// Конструктор параметров
		/// </summary>
        public ModelParameters()
        { 
            _modelParameters = new Dictionary<ParameterNameTypes, Parameter> 
            {
                { ParameterNameTypes.MainDiameter,
                new Parameter(14,4,16)},
                { ParameterNameTypes.MainLength,
                new Parameter(60,8,100)},
                { ParameterNameTypes.NutDiameter,
                new Parameter(8,4,16)},
                { ParameterNameTypes.NutLength,
                new Parameter(40,8,100)},
                { ParameterNameTypes.BoltDiameter,
                new Parameter(12,4,16)},
                { ParameterNameTypes.BoltLength,
                new Parameter(24,12,48)},
                { ParameterNameTypes.BoltStep,
                new Parameter(1,0.5,2)},
                { ParameterNameTypes.NutStep,
                new Parameter(1,0.5,2)},
            };
            IsChamfer = false;
        }
    }
}
