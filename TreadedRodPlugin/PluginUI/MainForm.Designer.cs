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
            this.label1 = new System.Windows.Forms.Label();
            this.BuildButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxD1 = new System.Windows.Forms.TextBox();
            this.textBoxL1 = new System.Windows.Forms.TextBox();
            this.textBoxD0 = new System.Windows.Forms.TextBox();
            this.textBoxL0 = new System.Windows.Forms.TextBox();
            this.textBoxD1Label = new System.Windows.Forms.Label();
            this.textBoxLLabel = new System.Windows.Forms.Label();
            this.textBoxDLabel = new System.Windows.Forms.Label();
            this.textBoxL0Label = new System.Windows.Forms.Label();
            this.textBoxD0Label = new System.Windows.Forms.Label();
            this.textBoxL1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диаметр шпильки (4 < D < 16)";
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(266, 412);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(75, 23);
            this.BuildButton.TabIndex = 1;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длина шпильки (12 < L < 100)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Диаметр гаечной резьбы (4 < D1 < 16)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Диаметр ввинчиваемой резьбы (4 < D0 < 16)\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Длина  гаечной резьбы (12 < L1 < 100)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Длина  ввинчиваемой резьбы (12 < L0 < 48)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "мм";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "мм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "мм";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "мм";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "мм";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "мм";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PluginUI.Properties.Resources.scheme;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(247, 176);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(65, 20);
            this.textBoxD.TabIndex = 20;
            this.textBoxD.TextChanged += new System.EventHandler(this.TextBox_ValueChanged);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(247, 218);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(65, 20);
            this.textBoxL.TabIndex = 21;
            this.textBoxL.TextChanged += new System.EventHandler(this.TextBox_ValueChanged);
            // 
            // textBoxD1
            // 
            this.textBoxD1.Location = new System.Drawing.Point(247, 260);
            this.textBoxD1.Name = "textBoxD1";
            this.textBoxD1.Size = new System.Drawing.Size(65, 20);
            this.textBoxD1.TabIndex = 22;
            this.textBoxD1.TextChanged += new System.EventHandler(this.TextBox_ValueChanged);
            // 
            // textBoxL1
            // 
            this.textBoxL1.Location = new System.Drawing.Point(247, 302);
            this.textBoxL1.Name = "textBoxL1";
            this.textBoxL1.Size = new System.Drawing.Size(65, 20);
            this.textBoxL1.TabIndex = 23;
            this.textBoxL1.TextChanged += new System.EventHandler(this.TextBox_ValueChanged);
            // 
            // textBoxD0
            // 
            this.textBoxD0.Location = new System.Drawing.Point(247, 344);
            this.textBoxD0.Name = "textBoxD0";
            this.textBoxD0.Size = new System.Drawing.Size(65, 20);
            this.textBoxD0.TabIndex = 24;
            this.textBoxD0.TextChanged += new System.EventHandler(this.TextBox_ValueChanged);
            // 
            // textBoxL0
            // 
            this.textBoxL0.Location = new System.Drawing.Point(247, 386);
            this.textBoxL0.Name = "textBoxL0";
            this.textBoxL0.Size = new System.Drawing.Size(65, 20);
            this.textBoxL0.TabIndex = 25;
            this.textBoxL0.TextChanged += new System.EventHandler(this.TextBox_ValueChanged);
            // 
            // textBoxD1Label
            // 
            this.textBoxD1Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxD1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxD1Label.ForeColor = System.Drawing.Color.Red;
            this.textBoxD1Label.Location = new System.Drawing.Point(41, 241);
            this.textBoxD1Label.Name = "textBoxD1Label";
            this.textBoxD1Label.Size = new System.Drawing.Size(300, 16);
            this.textBoxD1Label.TabIndex = 30;
            this.textBoxD1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLLabel
            // 
            this.textBoxLLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLLabel.ForeColor = System.Drawing.Color.Red;
            this.textBoxLLabel.Location = new System.Drawing.Point(41, 199);
            this.textBoxLLabel.Name = "textBoxLLabel";
            this.textBoxLLabel.Size = new System.Drawing.Size(300, 16);
            this.textBoxLLabel.TabIndex = 31;
            this.textBoxLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDLabel
            // 
            this.textBoxDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDLabel.ForeColor = System.Drawing.Color.Red;
            this.textBoxDLabel.Location = new System.Drawing.Point(41, 157);
            this.textBoxDLabel.Name = "textBoxDLabel";
            this.textBoxDLabel.Size = new System.Drawing.Size(300, 16);
            this.textBoxDLabel.TabIndex = 32;
            this.textBoxDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxL0Label
            // 
            this.textBoxL0Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxL0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxL0Label.ForeColor = System.Drawing.Color.Red;
            this.textBoxL0Label.Location = new System.Drawing.Point(41, 367);
            this.textBoxL0Label.Name = "textBoxL0Label";
            this.textBoxL0Label.Size = new System.Drawing.Size(300, 16);
            this.textBoxL0Label.TabIndex = 33;
            this.textBoxL0Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxD0Label
            // 
            this.textBoxD0Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxD0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxD0Label.ForeColor = System.Drawing.Color.Red;
            this.textBoxD0Label.Location = new System.Drawing.Point(41, 325);
            this.textBoxD0Label.Name = "textBoxD0Label";
            this.textBoxD0Label.Size = new System.Drawing.Size(300, 16);
            this.textBoxD0Label.TabIndex = 34;
            this.textBoxD0Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxL1Label
            // 
            this.textBoxL1Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxL1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxL1Label.ForeColor = System.Drawing.Color.Red;
            this.textBoxL1Label.Location = new System.Drawing.Point(41, 283);
            this.textBoxL1Label.Name = "textBoxL1Label";
            this.textBoxL1Label.Size = new System.Drawing.Size(300, 16);
            this.textBoxL1Label.TabIndex = 35;
            this.textBoxL1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(347, 439);
            this.Controls.Add(this.textBoxL1Label);
            this.Controls.Add(this.textBoxD0Label);
            this.Controls.Add(this.textBoxL0Label);
            this.Controls.Add(this.textBoxDLabel);
            this.Controls.Add(this.textBoxLLabel);
            this.Controls.Add(this.textBoxD1Label);
            this.Controls.Add(this.textBoxL0);
            this.Controls.Add(this.textBoxD0);
            this.Controls.Add(this.textBoxL1);
            this.Controls.Add(this.textBoxD1);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Резьбовая шпилька";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxD1;
        private System.Windows.Forms.TextBox textBoxL1;
        private System.Windows.Forms.TextBox textBoxD0;
        private System.Windows.Forms.TextBox textBoxL0;
        private System.Windows.Forms.Label textBoxD1Label;
        private System.Windows.Forms.Label textBoxLLabel;
        private System.Windows.Forms.Label textBoxDLabel;
        private System.Windows.Forms.Label textBoxL0Label;
        private System.Windows.Forms.Label textBoxD0Label;
        private System.Windows.Forms.Label textBoxL1Label;
    }
}

