namespace LSevenHW
{
    partial class GuessNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrueOrFalse_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NewNumber_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfTrys_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваше число:";
            // 
            // TrueOrFalse_Button
            // 
            this.TrueOrFalse_Button.Location = new System.Drawing.Point(111, 143);
            this.TrueOrFalse_Button.Name = "TrueOrFalse_Button";
            this.TrueOrFalse_Button.Size = new System.Drawing.Size(75, 23);
            this.TrueOrFalse_Button.TabIndex = 2;
            this.TrueOrFalse_Button.Text = "Оно?";
            this.TrueOrFalse_Button.UseVisualStyleBackColor = true;
            this.TrueOrFalse_Button.Click += new System.EventHandler(this.TrueOrFalse_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Проверку на то, то ли это число можно осуществлять\r\n как с помощью кнопки,\r\n так " +
    "и по нажатию клавиши Enter после ввода числа";
            // 
            // NewNumber_button
            // 
            this.NewNumber_button.Location = new System.Drawing.Point(87, 172);
            this.NewNumber_button.Name = "NewNumber_button";
            this.NewNumber_button.Size = new System.Drawing.Size(121, 23);
            this.NewNumber_button.TabIndex = 4;
            this.NewNumber_button.Text = "Новое число";
            this.NewNumber_button.UseVisualStyleBackColor = true;
            this.NewNumber_button.Click += new System.EventHandler(this.NewNumber_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество попыток:";
            // 
            // NumberOfTrys_Label
            // 
            this.NumberOfTrys_Label.AutoSize = true;
            this.NumberOfTrys_Label.Location = new System.Drawing.Point(151, 107);
            this.NumberOfTrys_Label.Name = "NumberOfTrys_Label";
            this.NumberOfTrys_Label.Size = new System.Drawing.Size(13, 13);
            this.NumberOfTrys_Label.TabIndex = 6;
            this.NumberOfTrys_Label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Загаданное число...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfTrys_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewNumber_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrueOrFalse_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "GuessNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Number";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuessNumber_FormClosing);
            this.Shown += new System.EventHandler(this.GuessNumber_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TrueOrFalse_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewNumber_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberOfTrys_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}