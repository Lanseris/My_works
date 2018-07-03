namespace LSevenHW
{
    partial class DocTemplate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Start_DTP = new System.Windows.Forms.DateTimePicker();
            this.End_DTP = new System.Windows.Forms.DateTimePicker();
            this.OrgName_TB = new System.Windows.Forms.TextBox();
            this.OrgFace_TB = new System.Windows.Forms.TextBox();
            this.PersPost_TB = new System.Windows.Forms.TextBox();
            this.FIO_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Request_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование организации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Лицо данной организации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ваша должность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ваши ФИО:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата начала отпуска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата конца отпуска:";
            // 
            // Start_DTP
            // 
            this.Start_DTP.Location = new System.Drawing.Point(226, 204);
            this.Start_DTP.Name = "Start_DTP";
            this.Start_DTP.Size = new System.Drawing.Size(200, 20);
            this.Start_DTP.TabIndex = 6;
            // 
            // End_DTP
            // 
            this.End_DTP.Location = new System.Drawing.Point(226, 232);
            this.End_DTP.Name = "End_DTP";
            this.End_DTP.Size = new System.Drawing.Size(200, 20);
            this.End_DTP.TabIndex = 7;
            // 
            // OrgName_TB
            // 
            this.OrgName_TB.Location = new System.Drawing.Point(265, 95);
            this.OrgName_TB.Name = "OrgName_TB";
            this.OrgName_TB.Size = new System.Drawing.Size(143, 20);
            this.OrgName_TB.TabIndex = 8;
            // 
            // OrgFace_TB
            // 
            this.OrgFace_TB.Location = new System.Drawing.Point(265, 120);
            this.OrgFace_TB.Name = "OrgFace_TB";
            this.OrgFace_TB.Size = new System.Drawing.Size(143, 20);
            this.OrgFace_TB.TabIndex = 9;
            // 
            // PersPost_TB
            // 
            this.PersPost_TB.Location = new System.Drawing.Point(265, 146);
            this.PersPost_TB.Name = "PersPost_TB";
            this.PersPost_TB.Size = new System.Drawing.Size(143, 20);
            this.PersPost_TB.TabIndex = 10;
            // 
            // FIO_TB
            // 
            this.FIO_TB.Location = new System.Drawing.Point(265, 174);
            this.FIO_TB.Name = "FIO_TB";
            this.FIO_TB.Size = new System.Drawing.Size(143, 20);
            this.FIO_TB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Форма для заполнения бланка на отпуск";
            // 
            // Request_Button
            // 
            this.Request_Button.Location = new System.Drawing.Point(204, 298);
            this.Request_Button.Name = "Request_Button";
            this.Request_Button.Size = new System.Drawing.Size(135, 23);
            this.Request_Button.TabIndex = 13;
            this.Request_Button.Text = "Отправить запрос";
            this.Request_Button.UseVisualStyleBackColor = true;
            this.Request_Button.Click += new System.EventHandler(this.Request_Button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "ТО ЧТО ПОЛУЧИЛОСЬ:";
            // 
            // DocTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 456);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Request_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FIO_TB);
            this.Controls.Add(this.PersPost_TB);
            this.Controls.Add(this.OrgFace_TB);
            this.Controls.Add(this.OrgName_TB);
            this.Controls.Add(this.End_DTP);
            this.Controls.Add(this.Start_DTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DocTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание документа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocTemplate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Start_DTP;
        private System.Windows.Forms.DateTimePicker End_DTP;
        private System.Windows.Forms.TextBox OrgName_TB;
        private System.Windows.Forms.TextBox OrgFace_TB;
        private System.Windows.Forms.TextBox PersPost_TB;
        private System.Windows.Forms.TextBox FIO_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Request_Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}