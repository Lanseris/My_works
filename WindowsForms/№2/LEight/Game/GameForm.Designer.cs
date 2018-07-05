namespace Game
{
    partial class GameForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.начатьНовуюИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenNew = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.False_RB = new System.Windows.Forms.RadioButton();
            this.True_RB = new System.Windows.Forms.RadioButton();
            this.Ansver_But = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьНовуюИгруToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // начатьНовуюИгруToolStripMenuItem
            // 
            this.начатьНовуюИгруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_NewGame,
            this.Menu_OpenNew});
            this.начатьНовуюИгруToolStripMenuItem.Name = "начатьНовуюИгруToolStripMenuItem";
            this.начатьНовуюИгруToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.начатьНовуюИгруToolStripMenuItem.Text = "Меню";
            // 
            // Menu_NewGame
            // 
            this.Menu_NewGame.Name = "Menu_NewGame";
            this.Menu_NewGame.Size = new System.Drawing.Size(160, 22);
            this.Menu_NewGame.Text = "Начать заново";
            this.Menu_NewGame.Click += new System.EventHandler(this.Menu_NewGame_Click);
            // 
            // Menu_OpenNew
            // 
            this.Menu_OpenNew.Name = "Menu_OpenNew";
            this.Menu_OpenNew.Size = new System.Drawing.Size(160, 22);
            this.Menu_OpenNew.Text = "Открыть новую";
            this.Menu_OpenNew.Click += new System.EventHandler(this.Menu_OpenNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.False_RB);
            this.groupBox1.Controls.Add(this.True_RB);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ответы";
            // 
            // False_RB
            // 
            this.False_RB.AutoSize = true;
            this.False_RB.Location = new System.Drawing.Point(28, 55);
            this.False_RB.Name = "False_RB";
            this.False_RB.Size = new System.Drawing.Size(44, 17);
            this.False_RB.TabIndex = 1;
            this.False_RB.TabStop = true;
            this.False_RB.Text = "Нет";
            this.False_RB.UseVisualStyleBackColor = true;
            // 
            // True_RB
            // 
            this.True_RB.AutoSize = true;
            this.True_RB.Location = new System.Drawing.Point(28, 31);
            this.True_RB.Name = "True_RB";
            this.True_RB.Size = new System.Drawing.Size(40, 17);
            this.True_RB.TabIndex = 0;
            this.True_RB.TabStop = true;
            this.True_RB.Text = "Да";
            this.True_RB.UseVisualStyleBackColor = true;
            // 
            // Ansver_But
            // 
            this.Ansver_But.Location = new System.Drawing.Point(21, 107);
            this.Ansver_But.Name = "Ansver_But";
            this.Ansver_But.Size = new System.Drawing.Size(75, 23);
            this.Ansver_But.TabIndex = 3;
            this.Ansver_But.Text = "Ответить";
            this.Ansver_But.UseVisualStyleBackColor = true;
            this.Ansver_But.Click += new System.EventHandler(this.Ansver_But_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Ansver_But);
            this.panel1.Location = new System.Drawing.Point(365, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 148);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameForm";
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem начатьНовуюИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_NewGame;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton False_RB;
        private System.Windows.Forms.RadioButton True_RB;
        private System.Windows.Forms.Button Ansver_But;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

