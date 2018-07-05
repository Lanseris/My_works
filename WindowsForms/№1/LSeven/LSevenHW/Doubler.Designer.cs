namespace LSevenHW
{
    partial class Doubler
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
            this.label1 = new System.Windows.Forms.Label();
            this.Value_Label = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Double_Button = new System.Windows.Forms.Button();
            this.AddOne_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NeededValue_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfAction_Label = new System.Windows.Forms.Label();
            this.NewGame_Batton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TryNumber_Label = new System.Windows.Forms.Label();
            this.Chit_batton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Текущее значение:";
            // 
            // Value_Label
            // 
            this.Value_Label.AutoSize = true;
            this.Value_Label.Location = new System.Drawing.Point(144, 48);
            this.Value_Label.Name = "Value_Label";
            this.Value_Label.Size = new System.Drawing.Size(13, 13);
            this.Value_Label.TabIndex = 8;
            this.Value_Label.Text = "0";
            this.Value_Label.TextChanged += new System.EventHandler(this.Value_Label_TextChanged);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(194, 128);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 52);
            this.Reset_Button.TabIndex = 7;
            this.Reset_Button.Text = "Сброс";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Double_Button
            // 
            this.Double_Button.Location = new System.Drawing.Point(194, 70);
            this.Double_Button.Name = "Double_Button";
            this.Double_Button.Size = new System.Drawing.Size(75, 52);
            this.Double_Button.TabIndex = 6;
            this.Double_Button.Text = "x2";
            this.Double_Button.UseVisualStyleBackColor = true;
            this.Double_Button.Click += new System.EventHandler(this.Double_Button_Click);
            // 
            // AddOne_Button
            // 
            this.AddOne_Button.Location = new System.Drawing.Point(194, 12);
            this.AddOne_Button.Name = "AddOne_Button";
            this.AddOne_Button.Size = new System.Drawing.Size(75, 52);
            this.AddOne_Button.TabIndex = 5;
            this.AddOne_Button.Text = "+1";
            this.AddOne_Button.UseVisualStyleBackColor = true;
            this.AddOne_Button.Click += new System.EventHandler(this.AddOne_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Необходимое число:";
            // 
            // NeededValue_Label
            // 
            this.NeededValue_Label.AutoSize = true;
            this.NeededValue_Label.Location = new System.Drawing.Point(144, 26);
            this.NeededValue_Label.Name = "NeededValue_Label";
            this.NeededValue_Label.Size = new System.Drawing.Size(13, 13);
            this.NeededValue_Label.TabIndex = 11;
            this.NeededValue_Label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество действий:";
            // 
            // NumberOfAction_Label
            // 
            this.NumberOfAction_Label.AutoSize = true;
            this.NumberOfAction_Label.Location = new System.Drawing.Point(144, 70);
            this.NumberOfAction_Label.Name = "NumberOfAction_Label";
            this.NumberOfAction_Label.Size = new System.Drawing.Size(13, 13);
            this.NumberOfAction_Label.TabIndex = 13;
            this.NumberOfAction_Label.Text = "0";
            // 
            // NewGame_Batton
            // 
            this.NewGame_Batton.Location = new System.Drawing.Point(58, 196);
            this.NewGame_Batton.Name = "NewGame_Batton";
            this.NewGame_Batton.Size = new System.Drawing.Size(211, 54);
            this.NewGame_Batton.TabIndex = 14;
            this.NewGame_Batton.Text = "Задать новое число";
            this.NewGame_Batton.UseVisualStyleBackColor = true;
            this.NewGame_Batton.Click += new System.EventHandler(this.NewGame_Batton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Количество попыток:";
            // 
            // TryNumber_Label
            // 
            this.TryNumber_Label.AutoSize = true;
            this.TryNumber_Label.Location = new System.Drawing.Point(144, 90);
            this.TryNumber_Label.Name = "TryNumber_Label";
            this.TryNumber_Label.Size = new System.Drawing.Size(13, 13);
            this.TryNumber_Label.TabIndex = 16;
            this.TryNumber_Label.Text = "0";
            // 
            // Chit_batton
            // 
            this.Chit_batton.Location = new System.Drawing.Point(58, 133);
            this.Chit_batton.Name = "Chit_batton";
            this.Chit_batton.Size = new System.Drawing.Size(130, 47);
            this.Chit_batton.TabIndex = 17;
            this.Chit_batton.Text = "Отменить последнее действие (чит)";
            this.Chit_batton.UseVisualStyleBackColor = true;
            this.Chit_batton.Click += new System.EventHandler(this.Chit_batton_Click);
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Chit_batton);
            this.Controls.Add(this.TryNumber_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewGame_Batton);
            this.Controls.Add(this.NumberOfAction_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NeededValue_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Value_Label);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Double_Button);
            this.Controls.Add(this.AddOne_Button);
            this.Name = "Doubler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doubler_FormClosing);
            this.Shown += new System.EventHandler(this.Doubler_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Value_Label;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Double_Button;
        private System.Windows.Forms.Button AddOne_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NeededValue_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberOfAction_Label;
        private System.Windows.Forms.Button NewGame_Batton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TryNumber_Label;
        private System.Windows.Forms.Button Chit_batton;
    }
}