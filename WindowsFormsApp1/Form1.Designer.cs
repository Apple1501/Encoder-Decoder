namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSH = new System.Windows.Forms.CheckBox();
            this.checkBoxDES = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.richTextBoxI = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSH = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDES = new System.Windows.Forms.RichTextBox();
            this.buttonsh = new System.Windows.Forms.Button();
            this.buttonKEY = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonSaveSH = new System.Windows.Forms.Button();
            this.buttondes = new System.Windows.Forms.Button();
            this.labelIT = new System.Windows.Forms.Label();
            this.labelSHT = new System.Windows.Forms.Label();
            this.labelDEST = new System.Windows.Forms.Label();
            this.buttonSaveDES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(476, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите режим работы ";
            // 
            // checkBoxSH
            // 
            this.checkBoxSH.AutoSize = true;
            this.checkBoxSH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSH.Location = new System.Drawing.Point(186, 46);
            this.checkBoxSH.Name = "checkBoxSH";
            this.checkBoxSH.Size = new System.Drawing.Size(145, 26);
            this.checkBoxSH.TabIndex = 1;
            this.checkBoxSH.Text = "Шифрование";
            this.checkBoxSH.UseVisualStyleBackColor = true;
            // 
            // checkBoxDES
            // 
            this.checkBoxDES.AutoSize = true;
            this.checkBoxDES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDES.Location = new System.Drawing.Point(850, 46);
            this.checkBoxDES.Name = "checkBoxDES";
            this.checkBoxDES.Size = new System.Drawing.Size(141, 26);
            this.checkBoxDES.TabIndex = 2;
            this.checkBoxDES.Text = "Дешифровка";
            this.checkBoxDES.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(431, 80);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(344, 38);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Начать работу";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // richTextBoxI
            // 
            this.richTextBoxI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxI.Location = new System.Drawing.Point(12, 162);
            this.richTextBoxI.Name = "richTextBoxI";
            this.richTextBoxI.Size = new System.Drawing.Size(344, 392);
            this.richTextBoxI.TabIndex = 4;
            this.richTextBoxI.Text = "";
            this.richTextBoxI.Visible = false;
            // 
            // richTextBoxSH
            // 
            this.richTextBoxSH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSH.Location = new System.Drawing.Point(431, 162);
            this.richTextBoxSH.Name = "richTextBoxSH";
            this.richTextBoxSH.Size = new System.Drawing.Size(344, 392);
            this.richTextBoxSH.TabIndex = 5;
            this.richTextBoxSH.Text = "";
            this.richTextBoxSH.Visible = false;
            // 
            // richTextBoxDES
            // 
            this.richTextBoxDES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDES.Location = new System.Drawing.Point(850, 162);
            this.richTextBoxDES.Name = "richTextBoxDES";
            this.richTextBoxDES.Size = new System.Drawing.Size(344, 392);
            this.richTextBoxDES.TabIndex = 6;
            this.richTextBoxDES.Text = "";
            this.richTextBoxDES.Visible = false;
            // 
            // buttonsh
            // 
            this.buttonsh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsh.Location = new System.Drawing.Point(13, 576);
            this.buttonsh.Name = "buttonsh";
            this.buttonsh.Size = new System.Drawing.Size(343, 40);
            this.buttonsh.TabIndex = 7;
            this.buttonsh.Text = "Зашифровать";
            this.buttonsh.UseVisualStyleBackColor = true;
            this.buttonsh.Visible = false;
            this.buttonsh.Click += new System.EventHandler(this.buttonsh_Click);
            // 
            // buttonKEY
            // 
            this.buttonKEY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKEY.Location = new System.Drawing.Point(431, 576);
            this.buttonKEY.Name = "buttonKEY";
            this.buttonKEY.Size = new System.Drawing.Size(343, 40);
            this.buttonKEY.TabIndex = 8;
            this.buttonKEY.Text = "Выбрать ключ";
            this.buttonKEY.UseVisualStyleBackColor = true;
            this.buttonKEY.Visible = false;
            this.buttonKEY.Click += new System.EventHandler(this.buttonKEY_Click);
            // 
            // buttonText
            // 
            this.buttonText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonText.Location = new System.Drawing.Point(432, 630);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(343, 40);
            this.buttonText.TabIndex = 9;
            this.buttonText.Text = "Считать текст из файла";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Visible = false;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonSaveSH
            // 
            this.buttonSaveSH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveSH.Location = new System.Drawing.Point(13, 630);
            this.buttonSaveSH.Name = "buttonSaveSH";
            this.buttonSaveSH.Size = new System.Drawing.Size(343, 40);
            this.buttonSaveSH.TabIndex = 10;
            this.buttonSaveSH.Text = "Сохранить полученный текст";
            this.buttonSaveSH.UseVisualStyleBackColor = true;
            this.buttonSaveSH.Visible = false;
            this.buttonSaveSH.Click += new System.EventHandler(this.buttonSaveSH_Click);
            // 
            // buttondes
            // 
            this.buttondes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondes.Location = new System.Drawing.Point(853, 576);
            this.buttondes.Name = "buttondes";
            this.buttondes.Size = new System.Drawing.Size(343, 40);
            this.buttondes.TabIndex = 11;
            this.buttondes.Text = "Расшифровать";
            this.buttondes.UseVisualStyleBackColor = true;
            this.buttondes.Visible = false;
            this.buttondes.Click += new System.EventHandler(this.buttondes_Click);
            // 
            // labelIT
            // 
            this.labelIT.AutoSize = true;
            this.labelIT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIT.Location = new System.Drawing.Point(113, 137);
            this.labelIT.Name = "labelIT";
            this.labelIT.Size = new System.Drawing.Size(146, 22);
            this.labelIT.TabIndex = 12;
            this.labelIT.Text = "Исходный текст";
            this.labelIT.Visible = false;
            // 
            // labelSHT
            // 
            this.labelSHT.AutoSize = true;
            this.labelSHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSHT.Location = new System.Drawing.Point(525, 137);
            this.labelSHT.Name = "labelSHT";
            this.labelSHT.Size = new System.Drawing.Size(202, 22);
            this.labelSHT.TabIndex = 13;
            this.labelSHT.Text = "Зашифрованный текст";
            this.labelSHT.Visible = false;
            // 
            // labelDEST
            // 
            this.labelDEST.AutoSize = true;
            this.labelDEST.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDEST.Location = new System.Drawing.Point(934, 137);
            this.labelDEST.Name = "labelDEST";
            this.labelDEST.Size = new System.Drawing.Size(212, 22);
            this.labelDEST.TabIndex = 14;
            this.labelDEST.Text = "Расшифрованный текст";
            this.labelDEST.Visible = false;
            // 
            // buttonSaveDES
            // 
            this.buttonSaveDES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveDES.Location = new System.Drawing.Point(852, 630);
            this.buttonSaveDES.Name = "buttonSaveDES";
            this.buttonSaveDES.Size = new System.Drawing.Size(343, 40);
            this.buttonSaveDES.TabIndex = 16;
            this.buttonSaveDES.Text = "Сохранить полученный текст";
            this.buttonSaveDES.UseVisualStyleBackColor = true;
            this.buttonSaveDES.Visible = false;
            this.buttonSaveDES.Click += new System.EventHandler(this.buttonSaveDES_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 716);
            this.Controls.Add(this.buttonSaveDES);
            this.Controls.Add(this.labelDEST);
            this.Controls.Add(this.labelSHT);
            this.Controls.Add(this.labelIT);
            this.Controls.Add(this.buttondes);
            this.Controls.Add(this.buttonSaveSH);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonKEY);
            this.Controls.Add(this.buttonsh);
            this.Controls.Add(this.richTextBoxDES);
            this.Controls.Add(this.richTextBoxSH);
            this.Controls.Add(this.richTextBoxI);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.checkBoxDES);
            this.Controls.Add(this.checkBoxSH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метод Вернара ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSH;
        private System.Windows.Forms.CheckBox checkBoxDES;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox richTextBoxI;
        private System.Windows.Forms.RichTextBox richTextBoxSH;
        private System.Windows.Forms.RichTextBox richTextBoxDES;
        private System.Windows.Forms.Button buttonsh;
        private System.Windows.Forms.Button buttonKEY;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonSaveSH;
        private System.Windows.Forms.Button buttondes;
        private System.Windows.Forms.Label labelIT;
        private System.Windows.Forms.Label labelSHT;
        private System.Windows.Forms.Label labelDEST;
        private System.Windows.Forms.Button buttonSaveDES;
    }
}

