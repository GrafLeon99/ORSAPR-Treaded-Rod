using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Plugin;
using Kompas;

namespace PluginUI
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Параметры модели
		/// </summary>
		private ModelParameters _modelParameters;

		/// <summary>
		/// Словарь сообщений об ошибках
		/// </summary>
		private readonly Dictionary<ParameterNameTypes, Label> _errorLabels;

		/// <summary>
		/// Список полей ввода
		/// </summary>
		private readonly List<TextBox> _textBoxes;

		/// <summary>
		/// Список полей сообщений об ошибках
		/// </summary>
		private readonly List<Label> _labels;

		/// <summary>
		/// Конструктор формы
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			_modelParameters = new ModelParameters();

			_errorLabels = new Dictionary<ParameterNameTypes, Label>
			{
				{ParameterNameTypes.MainDiameter,textBoxDLabel},
				{ParameterNameTypes.BoltDiameter,textBoxD0Label},
				{ParameterNameTypes.NutDiameter,textBoxD1Label},
				{ParameterNameTypes.MainLength,textBoxLLabel},
				{ParameterNameTypes.BoltLength,textBoxL0Label},
				{ParameterNameTypes.NutLength,textBoxL1Label},
			};

			_textBoxes = new List<TextBox>
			{
				textBoxD,
				textBoxD0,
				textBoxD1,
				textBoxL,
				textBoxL0,
				textBoxL1,
			};

			_labels = new List<Label>
			{
				textBoxDLabel,
				textBoxD0Label,
				textBoxD1Label,
				textBoxLLabel,
				textBoxL0Label,
				textBoxL1Label,
			};

			SetDefaultParameters();
		}

		/// <summary>
		/// Словарь сообщений об ошибках
		/// </summary>
		/// <param name="textBoxName"> Имя поля ввода </param>
		/// <returns cref="ParameterNameTypes">Возвращает имя параметра</returns>
		private ParameterNameTypes GetParameterName(string textBoxName)
		{
			switch (textBoxName)
			{
				case "textBoxD": 
					return ParameterNameTypes.MainDiameter;
				case "textBoxD1":
					return ParameterNameTypes.NutDiameter;
				case "textBoxD0":
					return ParameterNameTypes.BoltDiameter;
				case "textBoxL":
					return ParameterNameTypes.MainLength;
				case "textBoxL1":
					return ParameterNameTypes.NutLength;
				case "textBoxL0":
					return ParameterNameTypes.BoltLength;
				default:
					throw new ArgumentException
						(
						"Данный параметр не обрабатывается."
						);
			}
		}

		/// <summary>
		/// Обрабатывает событие ввода значения параметра
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TextBox_ValueChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ParameterNameTypes parameterName = 
				GetParameterName(textBox.Name);
            string text = textBox.Text;

			try
			{
				if (string.IsNullOrEmpty(text))
				{
					throw new ArgumentException
						(
						"Строка не должна быть пуста."
						);
				}
				if (!double.TryParse(text, out var value))
				{
					throw new ArgumentException
						(
						"Введено некорректное значение."
						);
				}
				_modelParameters.SetValue(parameterName,value);

			}
			catch (ArgumentException exception)
			{

				string message = "* " + exception.Message;
				SetErrorMessage(textBox, message);
				return;
			}

			ClearErrorMessage(textBox);
		}

		/// <summary>
		/// Обрабатывает событие нажатия на кнопку "построить"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BuildButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (isErrorPresented())
				{
					throw new ArgumentException
						(
						"Не все параметры введены верно."
						);
				}
				
				ModelBuilder modelBuilder = new ModelBuilder();
				modelBuilder.BuildModel(_modelParameters);
			}
			catch (ArgumentException exception)
			{
				displayErrorPopUp(exception.Message);
			}
		}

		/// <summary>
		/// Выводит сообщения об ошибке в виде диалогового окна
		/// </summary>
		/// <param name="message">Текст ошибки</param>
		private void displayErrorPopUp(string message)
		{
			string caption = "Ошибка при построении модели";
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			DialogResult result;
			result = MessageBox.Show(message, caption, buttons);
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				//
			}
		}

		/// <summary>
		/// Возвращает true, если присутствуют ошибки в параметрах.
		/// </summary>
		/// <returns cref="bool"></returns>
		private bool isErrorPresented()
		{
			foreach (Label label in _labels)
			{ 
				if (!string.IsNullOrEmpty(label.Text))
                {
					return true;
                }
			}
			return false;
		}
	
		/// <summary>
		/// Выводит сообщение об ошибке над полем ввода параметра
		/// </summary>
		/// <param name="textBox">Поле ввода параметра</param>
		/// <param name="errorMessage">Текст ошибки</param>
		private void SetErrorMessage(TextBox textBox, String errorMessage)
		{
			ParameterNameTypes parameterName =
				GetParameterName(textBox.Name);
			_errorLabels[parameterName].Text = errorMessage;
		}

		/// <summary>
		/// Убирает сообщение об ошибке над полем ввода параметра
		/// </summary>
		/// <param name="textBox">Поле ввода параметра</param>
		private void ClearErrorMessage(TextBox textBox)
		{
			ParameterNameTypes parameterName =
				GetParameterName(textBox.Name);
			_errorLabels[parameterName].Text = "";
		}

		/// <summary>
		/// Устанавливает значения параметров по умолчанию
		/// </summary>
		private void SetDefaultParameters()
		{
			foreach (TextBox textBox in _textBoxes)
			{
				ParameterNameTypes parameterName = 
					GetParameterName(textBox.Name);
				textBox.Text =
					_modelParameters.GetValue(parameterName).ToString();
			}
		}

}
}
