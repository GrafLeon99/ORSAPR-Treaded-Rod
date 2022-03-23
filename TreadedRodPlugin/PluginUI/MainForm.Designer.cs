namespace PluginUI
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BuildButton = new System.Windows.Forms.Button();
            this.ButtonDefault = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.parameterBoxBoltLength = new PluginUI.ParameterBox();
            this.parameterBoxBoltDiameter = new PluginUI.ParameterBox();
            this.parameterBoxNutLength = new PluginUI.ParameterBox();
            this.parameterBoxNutDiameter = new PluginUI.ParameterBox();
            this.parameterBoxMainLength = new PluginUI.ParameterBox();
            this.parameterBoxMainDiameter = new PluginUI.ParameterBox();
            this.parameterBoxBoltStep = new PluginUI.ParameterBox();
            this.parameterBoxNutStep = new PluginUI.ParameterBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(253, 678);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(139, 23);
            this.BuildButton.TabIndex = 1;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // ButtonDefault
            // 
            this.ButtonDefault.Location = new System.Drawing.Point(12, 677);
            this.ButtonDefault.Name = "ButtonDefault";
            this.ButtonDefault.Size = new System.Drawing.Size(139, 23);
            this.ButtonDefault.TabIndex = 42;
            this.ButtonDefault.Text = "Значения по умолчанию";
            this.ButtonDefault.UseVisualStyleBackColor = true;
            this.ButtonDefault.Click += new System.EventHandler(this.ButtonDefault_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(12, 654);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "Фаска";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PluginUI.Properties.Resources.scheme;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // parameterBoxBoltLength
            // 
            this.parameterBoxBoltLength.ErrorMessage = "";
            this.parameterBoxBoltLength.Location = new System.Drawing.Point(10, 472);
            this.parameterBoxBoltLength.Name = "parameterBoxBoltLength";
            this.parameterBoxBoltLength.Parameter = 0D;
            this.parameterBoxBoltLength.ParameterName = Plugin.ParameterNameTypes.BoltLength;
            this.parameterBoxBoltLength.Size = new System.Drawing.Size(382, 53);
            this.parameterBoxBoltLength.TabIndex = 41;
            this.parameterBoxBoltLength.ParameterChanged += new System.EventHandler(this.ParameterBox_ParameterChanged);
            // 
            // parameterBoxBoltDiameter
            // 
            this.parameterBoxBoltDiameter.ErrorMessage = "";
            this.parameterBoxBoltDiameter.Location = new System.Drawing.Point(12, 413);
            this.parameterBoxBoltDiameter.Name = "parameterBoxBoltDiameter";
            this.parameterBoxBoltDiameter.Parameter = 0D;
            this.parameterBoxBoltDiameter.ParameterName = Plugin.ParameterNameTypes.BoltDiameter;
            this.parameterBoxBoltDiameter.Size = new System.Drawing.Size(382, 53);
            this.parameterBoxBoltDiameter.TabIndex = 40;
            this.parameterBoxBoltDiameter.ParameterChanged += new System.EventHandler(this.ParameterBox_ParameterChanged);
            // 
            // parameterBoxNutLength
            // 
            this.parameterBoxNutLength.ErrorMessage = "";
            this.parameterBoxNutLength.Location = new System.Drawing.Point(12, 354);
            this.parameterBoxNutLength.Name = "parameterBoxNutLength";
            this.parameterBoxNutLength.Parameter = 0D;
            this.parameterBoxNutLength.ParameterName = Plugin.ParameterNameTypes.NutLength;
            this.parameterBoxNutLength.Size = new System.Drawing.Size(382, 53);
            this.parameterBoxNutLength.TabIndex = 39;
            this.parameterBoxNutLength.ParameterChanged += new System.EventHandler(this.ParameterBox_ParameterChanged);
            // 
            // parameterBoxNutDiameter
            // 
            this.parameterBoxNutDiameter.ErrorMessage = "";
            this.parameterBoxNutDiameter.Location = new System.Drawing.Point(12, 295);
            this.parameterBoxNutDiameter.Name = "parameterBoxNutDiameter";
            this.parameterBoxNutDiameter.Parameter = 0D;
            this.parameterBoxNutDiameter.ParameterName = Plugin.ParameterNameTypes.NutDiameter;
            this.parameterBoxNutDiameter.Size = new System.Drawing.Size(382, 53);
            this.parameterBoxNutDiameter.TabIndex = 38;
            this.parameterBoxNutDiameter.ParameterChanged += new System.EventHandler(this.ParameterBox_ParameterChanged);
            // 
            // parameterBoxMainLength
            // 
            this.parameterBoxMainLength.ErrorMessage = "";
            this.parameterBoxMainLength.Location = new System.Drawing.Point(12, 236);
            this.parameterBoxMainLength.Name = "parameterBoxMainLength";
            this.parameterBoxMainLength.Parameter = 0D;
            this.parameterBoxMainLength.ParameterName = Plugin.ParameterNameTypes.MainLength;
            this.parameterBoxMainLength.Size = new System.Drawing.Size(382, 53);
            this.parameterBoxMainLength.TabIndex = 37;
            this.parameterBoxMainLength.ParameterChanged += new System.EventHandler(this.ParameterBox_ParameterChanged);
            // 
            // parameterBoxMainDiameter
            // 
            this.parameterBoxMainDiameter.ErrorMessage = "";
            this.parameterBoxMainDiameter.Location = new System.Drawing.Point(12, 177);
            this.parameterBoxMainDiameter.Name = "parameterBoxMainDiameter";
            this.parameterBoxMainDiameter.Parameter = 0D;
            this.parameterBoxMainDiameter.ParameterName = Plugin.ParameterNameTypes.MainDiameter;
            this.parameterBoxMainDiameter.Size = new System.Drawing.Size(382, 53);
            this.parameterBoxMainDiameter.TabIndex = 36;
            this.parameterBoxMainDiameter.ParameterChanged += new System.EventHandler(this.ParameterBox_ParameterChanged);
            this.parameterBoxMainDiameter.Load += new System.EventHandler(this.parameterBoxMainDiameter_Load);
            // 
            // parameterBoxBoltStep
            // 
            this.parameterBoxBoltStep.ErrorMessage = "";
            this.parameterBoxBoltStep.Location = new System.Drawing.Point(10, 531);
            this.parameterBoxBoltStep.Name = "parameterBoxBoltStep";
            this.parameterBoxBoltStep.Parameter = 0D;
            this.parameterBoxBoltStep.ParameterName = Plugin.ParameterNameTypes.BoltStep;
            this.parameterBoxBoltStep.Size = new System.Drawing.Size(382, 53);
            this.parameterBoxBoltStep.TabIndex = 50;
            this.parameterBoxBoltStep.ParameterChanged += new System.EventHandler(this.ParameterBox_ParameterChanged);
            // 
            // parameterBoxNutStep
            // 
            this.parameterBoxNutStep.ErrorMessage = "";
            this.parameterBoxNutStep.Location = new System.Drawing.Point(10, 590);
            this.parameterBoxNutStep.Name = "parameterBoxNutStep";
            this.parameterBoxNutStep.Parameter = 0D;
            this.parameterBoxNutStep.ParameterName = Plugin.ParameterNameTypes.NutStep;
            this.parameterBoxNutStep.Size = new System.Drawing.Size(382, 53);
            this.parameterBoxNutStep.TabIndex = 51;
            this.parameterBoxNutStep.ParameterChanged += new System.EventHandler(this.ParameterBox_ParameterChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(404, 713);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.parameterBoxNutStep);
            this.Controls.Add(this.parameterBoxBoltStep);
            this.Controls.Add(this.ButtonDefault);
            this.Controls.Add(this.parameterBoxBoltLength);
            this.Controls.Add(this.parameterBoxBoltDiameter);
            this.Controls.Add(this.parameterBoxNutLength);
            this.Controls.Add(this.parameterBoxNutDiameter);
            this.Controls.Add(this.parameterBoxMainLength);
            this.Controls.Add(this.parameterBoxMainDiameter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuildButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Резьбовая шпилька";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ParameterBox parameterBoxMainDiameter;
        private ParameterBox parameterBoxMainLength;
        private ParameterBox parameterBoxNutDiameter;
        private ParameterBox parameterBoxNutLength;
        private ParameterBox parameterBoxBoltDiameter;
        private ParameterBox parameterBoxBoltLength;
        private System.Windows.Forms.Button ButtonDefault;
        private System.Windows.Forms.CheckBox checkBox1;
        private ParameterBox parameterBoxBoltStep;
        private ParameterBox parameterBoxNutStep;
    }
}

