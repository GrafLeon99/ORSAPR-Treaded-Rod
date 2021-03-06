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
		/// Параметры модели.
		/// </summary>
		private ModelParameters _modelParameters;

		/// <summary>
		/// Список полей ввода параметров.
		/// </summary>
		private readonly List<ParameterBox> _parameterBoxes;

		/// <summary>
		/// Конструктор формы.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			_modelParameters = new ModelParameters();

			_parameterBoxes = new List<ParameterBox>
			{
				parameterBoxMainDiameter,
				parameterBoxMainLength,
				parameterBoxNutDiameter,
				parameterBoxNutLength,
				parameterBoxBoltDiameter,
				parameterBoxBoltLength,
				parameterBoxBoltStep,
				parameterBoxNutStep,
			};

			SetDefaultParameters();
			SetRanges();
		}

		/// <summary>
		/// Обрабатывает событие нажатия на кнопку "построить".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BuildButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsErrorPresented())
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
				DisplayErrorPopUp(exception.Message);
			}
		}

		/// <summary>
		/// Выводит сообщения об ошибке в виде диалогового окна.
		/// </summary>
		/// <param name="message">Текст ошибки</param>
		private void DisplayErrorPopUp(string message)
		{
			string caption = "Ошибка при построении модели";
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			MessageBox.Show(message, caption, buttons);
		}
		
		/// <summary>
		/// Возвращает true, если присутствуют ошибки в параметрах.
		/// </summary>
		/// <returns cref="bool"></returns>
		private bool IsErrorPresented()
		{
			foreach (ParameterBox parameterBox in _parameterBoxes)
			{
				if (parameterBox.ErrorMessage != ParameterBox.NoError)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Устанавливает значения параметров по умолчанию для всех полей ввода.
		/// </summary>
		private void SetDefaultParameters()
		{
			foreach (ParameterBox parameterBox in _parameterBoxes)
			{
				ParameterNameTypes parameterName = parameterBox.ParameterName;
				parameterBox.Parameter = _modelParameters.GetDefaultValue(parameterName);
			}
			ValidateAllParameters();
			checkBox1.Checked = false;
		}

		/// <summary>
		/// Устанавливает значения диапазонов параметров для всех полей ввода.
		/// </summary>
		private void SetRanges()
		{
			foreach (ParameterBox parameterBox in _parameterBoxes)
			{
				parameterBox.SetInfoLabelText(_modelParameters);
			}
		}

		/// <summary>
		/// Обрабатывает событие изменения значения в поле ввода параметра.
		/// </summary>
		private void ParameterBox_ParameterChanged(object sender, EventArgs e)
		{
			ParameterBox parameterBox = (ParameterBox)sender;
			SetParameter(parameterBox);
			ValidateAllParameters();
		}

		/// <summary>
		/// Проверяет правильность значений всех полей ввода.
		/// </summary>
		private void ValidateAllParameters()
		{
			foreach (ParameterBox parameterBox in _parameterBoxes)
			{
				SetParameter(parameterBox);
			}
		}

		/// <summary>
		/// Устанавливает значение из поля ввода в словарь параметров.
		/// Выводит сообщение об ошибке, при вводе некорректных данных.
		/// </summary>
		private void SetParameter(ParameterBox parameterBox)
		{
			ParameterNameTypes parameterName = parameterBox.ParameterName;
			double value = parameterBox.Parameter;
			string errorMessage = ParameterBox.NoError;
			try
			{
				_modelParameters.SetValue(parameterName, value);
			}
			catch (ArgumentException exception)
			{
				errorMessage = exception.Message;
			}
			parameterBox.ErrorMessage = errorMessage;
		}

		/// <summary>
		/// Обрабатывает событие нажатия на кнопку "значения по умолчанию".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonDefault_Click(object sender, EventArgs e)
        {
			SetDefaultParameters();
        }

		/// <summary>
		/// Обрабатывает событие переключения чекбокса "фаска".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
			CheckBox checkBox = (CheckBox)sender;
			_modelParameters.IsChamfer = checkBox.Checked;
		}
    }
}
