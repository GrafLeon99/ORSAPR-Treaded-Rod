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
        /// Сообщение об отсутствии ошибки
        /// </summary>
        public const string noError = "";
        /// <summary>
        /// Сообщение об ошибке, при вводе пустой строки 
        /// </summary>
        public const string nullError = "Строка не должна быть пуста.";
        /// <summary>
        /// Сообщение об ошибке, при вводе неккоректных данных 
        /// </summary>
        public const string nonDoubleError = "Значение должно быть числом.";

        private const string MainLengthInfo = "Длина шпильки (8 < L < 100)";
        private const string MainDiameterInfo = "Диаметр шпильки (4 < D < 16)";
        private const string NutLengthInfo = "Длина  гаечной резьбы (8 < L1 < 100)";
        private const string NutDiameterInfo = "Диаметр гаечной резьбы (4 < D1 < 16)";
        private const string BoltLengthInfo = "Длина  ввинчиваемой резьбы (12 < L0 < 48)";
        private const string BoltDiameterInfo = "Диаметр ввинчиваемой резьбы (4 < D0 < 16)";

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
                switch (value)
                {
                    case ParameterNameTypes.MainDiameter:
                        {
                            infoLabel.Text = MainDiameterInfo;
                            break;
                        }
                    case ParameterNameTypes.BoltDiameter:
                        {
                            infoLabel.Text = BoltDiameterInfo;
                            break;
                        }
                    case ParameterNameTypes.NutDiameter:
                        {
                            infoLabel.Text = NutDiameterInfo;
                            break;
                        }
                    case ParameterNameTypes.MainLength:
                        {
                            infoLabel.Text = MainLengthInfo;
                            break;
                        }
                    case ParameterNameTypes.BoltLength:
                        {
                            infoLabel.Text = BoltLengthInfo;
                            break;
                        }
                    case ParameterNameTypes.NutLength:
                        {
                            infoLabel.Text = NutLengthInfo;
                            break;
                        }
                    default:
                        {
                            break;
                        }
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
        public double Parameter 
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
                if (oldMessage != nullError && oldMessage != nonDoubleError)
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
            ErrorMessage = noError;
        }

        /// <summary>
		/// Обрабатывает событие изменения текста в textBox
		/// </summary>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            try
            {
                if (string.IsNullOrEmpty(text))
                {
                    throw new ArgumentException
                        (
                        nullError
                        );
                }
                if (!double.TryParse(text, out var value))
                {
                    throw new ArgumentException
                        (
                        nonDoubleError
                        );
                }
                Parameter = value;
            }
            catch (ArgumentException exception)
            {
                errorLabel.Text = exception.Message;
                return;
            }
            errorLabel.Text = noError;
            
            if (ParameterChanged != null)
            {
                ParameterChanged(this, new EventArgs());
            }
        }

}
}
