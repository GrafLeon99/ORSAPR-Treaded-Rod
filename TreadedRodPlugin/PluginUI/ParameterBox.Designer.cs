namespace PluginUI
{
    partial class ParameterBox
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.errorLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.mmLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(4, 2);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(374, 23);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "error";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(3, 31);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "label2";
            // 
            // mmLabel
            // 
            this.mmLabel.AutoSize = true;
            this.mmLabel.Location = new System.Drawing.Point(354, 31);
            this.mmLabel.Name = "mmLabel";
            this.mmLabel.Size = new System.Drawing.Size(23, 13);
            this.mmLabel.TabIndex = 2;
            this.mmLabel.Text = "мм";
            // 
            // textBox
            // 
            this.textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "0,5",
            "1,0",
            "1,5",
            "2,0"});
            this.textBox.FormattingEnabled = true;
            this.textBox.Items.AddRange(new object[] {
            "0,5",
            "1,0",
            "1,5",
            "2,0"});
            this.textBox.Location = new System.Drawing.Point(267, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(81, 21);
            this.textBox.TabIndex = 4;
            this.textBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_TextChanged);
            this.textBox.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // ParameterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.mmLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.errorLabel);
            this.Name = "ParameterBox";
            this.Size = new System.Drawing.Size(382, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label mmLabel;
        private System.Windows.Forms.ComboBox textBox;
    }
}
