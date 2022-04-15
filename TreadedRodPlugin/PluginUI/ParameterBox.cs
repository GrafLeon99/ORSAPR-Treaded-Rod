using System;
using System.Windows.Forms;
using Plugin;

namespace PluginUI
{
    /// <summary>
    /// Элемент управления для ввода параметра модели.
    /// </summary>
    public partial class ParameterBox : UserControl
    {
        /// <summary>
        /// Сообщение об отсутствии ошибки.
        /// </summary>
        public const string NoError = "";
        /// <summary>
        /// Сообщение об ошибке, при вводе пустой строки.
        /// </summary>
        public const string NullError = "Строка не должна быть пуста.";
        /// <summary>
        /// Сообщение об ошибке, при вводе неккоректных данных .
        /// </summary>
        public const string NonDoubleError = "Значение должно быть числом.";

        /// <summary>
		/// Имя параметра
		/// </summary>
        private ParameterNameTypes _parameterName = ParameterNameTypes.MainDiameter;

        /// <summary>
		/// Возвращает и устанавливает имя параметра.
		/// </summary>
        public ParameterNameTypes ParameterName
        {
            get
            {
                return _parameterName;
            }
            set
            {
                if (value == ParameterNameTypes.BoltStep || value == ParameterNameTypes.NutStep)
                {
                    textBox.DropDownStyle = ComboBoxStyle.DropDown;
                }
                else
                {
                    textBox.DropDownStyle = ComboBoxStyle.Simple;
                }
                _parameterName = value;
            }
        }

        /// <summary>
		/// Числовое значение поля ввода
		/// </summary>
        private double _parameter;

        /// <summary>
		/// Возвращает и устанавливает числовое значение поля ввода.
		/// </summary>
        public virtual double Parameter 
        { 
            get 
            { 
                return _parameter; 
            }
            set 
            { 
                _parameter = value; 
                textBox.Text = Parameter.ToString();
            }
        }
        /// <summary>
		/// Возвращает и устанавливает тескт сообщения об ошибке.
		/// </summary>
        public string ErrorMessage
        {
            get 
            { 
                return errorLabel.Text;
            }
            set 
            {
                string oldMessage = errorLabel.Text;
                if (oldMessage != NullError && oldMessage != NonDoubleError)
                {
                    errorLabel.Text = value;
                }
            }
        }
        /// <summary>
		/// Событие изменения параметра.
		/// </summary>
        public event EventHandler ParameterChanged;

        /// <summary>
		/// Конструктор поля ввода параметра
		/// </summary>
        public ParameterBox()
        {
            InitializeComponent();
            ErrorMessage = NoError;
        }

        /// <summary>
        /// Возвращает название параметра поля ввода в виде строки.
        /// </summary>
        /// <returns cref="string">Название параметра поля ввода</returns>
        private string GetSelfName()
        {
            switch (_parameterName)
            {
                case ParameterNameTypes.MainLength:
                    {
                        return "Длина шпильки";
                    }
                case ParameterNameTypes.NutLength:
                    {
                        return "Длина  гаечной резьбы";
                    }
                case ParameterNameTypes.BoltLength:
                    {
                        return "Длина ввинчиваемой резьбы";
                    }
                case ParameterNameTypes.MainDiameter:
                    {
                        return "Диаметр шпильки";
                    }
                case ParameterNameTypes.NutDiameter:
                    {
                        return "Диаметр гаечной резьбы";
                    }
                case ParameterNameTypes.BoltDiameter:
                    {
                        return "Диаметр ввинчиваемой резьбы";
                    }
                case ParameterNameTypes.BoltStep:
                    {
                        return "Шаг ввинчиваемой резьбы";
                    }
                case ParameterNameTypes.NutStep:
                    {
                        return "Шаг гаечной резьбы";
                    }
            }
            return " ";
        }
        
        /// <summary>
		/// Изменяет подпись к полю ввода в зависимости от значений параметров  
		/// </summary>
        /// <param name="modelParameters">Объект параметров модели</param>
        public void SetInfoLabelText(ModelParameters modelParameters)
        {
            infoLabel.Text = GetSelfName() + ": " + 
                modelParameters.GetMinValue(_parameterName) + " - " + 
                modelParameters.GetMaxValue(_parameterName) + " мм";
        }
        
        /// <summary>
		/// Обрабатывает событие изменения текста в textBox
		/// </summary>
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox textBox = (ComboBox)sender;
            string text = textBox.Text;
            try
            {
                if (string.IsNullOrEmpty(text))
                {
                    throw new ArgumentException
                        (
                        NullError
                        );
                }
                if (!double.TryParse(text, out var value))
                {
                    throw new ArgumentException
                        (
                        NonDoubleError
                        );
                }
                Parameter = value;
            }
            catch (ArgumentException exception)
            {
                errorLabel.Text = exception.Message;
                return;
            }
            errorLabel.Text = NoError;
            
            if (ParameterChanged != null)
            {
                ParameterChanged(this, EventArgs.Empty);
            }
        }
    }
}
