namespace BeliveOrNotBelive
{
    partial class StudentsForm
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
            this.Load_CSV_But = new System.Windows.Forms.Button();
            this.Ser_But = new System.Windows.Forms.Button();
            this.DeSer_But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load_CSV_But
            // 
            this.Load_CSV_But.Location = new System.Drawing.Point(69, 39);
            this.Load_CSV_But.Name = "Load_CSV_But";
            this.Load_CSV_But.Size = new System.Drawing.Size(164, 23);
            this.Load_CSV_But.TabIndex = 0;
            this.Load_CSV_But.Text = "Загрузить из CSV";
            this.Load_CSV_But.UseVisualStyleBackColor = true;
            this.Load_CSV_But.Click += new System.EventHandler(this.Load_CSV_But_Click);
            // 
            // Ser_But
            // 
            this.Ser_But.Location = new System.Drawing.Point(69, 69);
            this.Ser_But.Name = "Ser_But";
            this.Ser_But.Size = new System.Drawing.Size(164, 23);
            this.Ser_But.TabIndex = 1;
            this.Ser_But.Text = "Сериализовать";
            this.Ser_But.UseVisualStyleBackColor = true;
            this.Ser_But.Click += new System.EventHandler(this.Ser_But_Click);
            // 
            // DeSer_But
            // 
            this.DeSer_But.Location = new System.Drawing.Point(69, 99);
            this.DeSer_But.Name = "DeSer_But";
            this.DeSer_But.Size = new System.Drawing.Size(164, 23);
            this.DeSer_But.TabIndex = 2;
            this.DeSer_But.Text = "Десериализовать";
            this.DeSer_But.UseVisualStyleBackColor = true;
            this.DeSer_But.Click += new System.EventHandler(this.DeSer_But_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.DeSer_But);
            this.Controls.Add(this.Ser_But);
            this.Controls.Add(this.Load_CSV_But);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_CSV_But;
        private System.Windows.Forms.Button Ser_But;
        private System.Windows.Forms.Button DeSer_But;
    }
}