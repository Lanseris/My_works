namespace LSevenHW
{
    partial class MainMenu
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
            this.Doubler_Button = new System.Windows.Forms.Button();
            this.GuessNumber_Button = new System.Windows.Forms.Button();
            this.documentTemplate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Doubler_Button
            // 
            this.Doubler_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Doubler_Button.Location = new System.Drawing.Point(128, 49);
            this.Doubler_Button.MaximumSize = new System.Drawing.Size(75, 40);
            this.Doubler_Button.MinimumSize = new System.Drawing.Size(75, 40);
            this.Doubler_Button.Name = "Doubler_Button";
            this.Doubler_Button.Size = new System.Drawing.Size(75, 40);
            this.Doubler_Button.TabIndex = 0;
            this.Doubler_Button.Text = "Удвоитель";
            this.Doubler_Button.UseVisualStyleBackColor = true;
            this.Doubler_Button.Click += new System.EventHandler(this.Doubler_Button_Click);
            // 
            // GuessNumber_Button
            // 
            this.GuessNumber_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuessNumber_Button.Location = new System.Drawing.Point(115, 95);
            this.GuessNumber_Button.MaximumSize = new System.Drawing.Size(100, 40);
            this.GuessNumber_Button.MinimumSize = new System.Drawing.Size(75, 40);
            this.GuessNumber_Button.Name = "GuessNumber_Button";
            this.GuessNumber_Button.Size = new System.Drawing.Size(100, 40);
            this.GuessNumber_Button.TabIndex = 1;
            this.GuessNumber_Button.Text = "Угадай число";
            this.GuessNumber_Button.UseVisualStyleBackColor = true;
            this.GuessNumber_Button.Click += new System.EventHandler(this.GuessNumber_Button_Click);
            // 
            // documentTemplate_button
            // 
            this.documentTemplate_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentTemplate_button.Location = new System.Drawing.Point(115, 141);
            this.documentTemplate_button.MaximumSize = new System.Drawing.Size(100, 40);
            this.documentTemplate_button.MinimumSize = new System.Drawing.Size(75, 40);
            this.documentTemplate_button.Name = "documentTemplate_button";
            this.documentTemplate_button.Size = new System.Drawing.Size(100, 40);
            this.documentTemplate_button.TabIndex = 2;
            this.documentTemplate_button.Text = "Шаблон анкеты";
            this.documentTemplate_button.UseVisualStyleBackColor = true;
            this.documentTemplate_button.Click += new System.EventHandler(this.documentTemplate_button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 264);
            this.Controls.Add(this.documentTemplate_button);
            this.Controls.Add(this.GuessNumber_Button);
            this.Controls.Add(this.Doubler_Button);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Doubler_Button;
        private System.Windows.Forms.Button GuessNumber_Button;
        private System.Windows.Forms.Button documentTemplate_button;
    }
}

