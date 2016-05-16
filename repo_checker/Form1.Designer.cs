namespace repo_checker
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйРепозиторийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.существующийРепозиторийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showUserInfo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.showRepositoriesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usersRepositoriesListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйРепозиторийToolStripMenuItem,
            this.существующийРепозиторийToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // новыйРепозиторийToolStripMenuItem
            // 
            this.новыйРепозиторийToolStripMenuItem.Name = "новыйРепозиторийToolStripMenuItem";
            this.новыйРепозиторийToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.новыйРепозиторийToolStripMenuItem.Text = "Новый репозиторий...";
            // 
            // существующийРепозиторийToolStripMenuItem
            // 
            this.существующийРепозиторийToolStripMenuItem.Name = "существующийРепозиторийToolStripMenuItem";
            this.существующийРепозиторийToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.существующийРепозиторийToolStripMenuItem.Text = "Существующий репозиторий...";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showUserInfo);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.showRepositoriesButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите логин пользователя";
            // 
            // showUserInfo
            // 
            this.showUserInfo.Location = new System.Drawing.Point(156, 57);
            this.showUserInfo.Name = "showUserInfo";
            this.showUserInfo.Size = new System.Drawing.Size(146, 33);
            this.showUserInfo.TabIndex = 4;
            this.showUserInfo.Text = "Показать информацию";
            this.showUserInfo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сохранить выбранный репозиторий";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(6, 18);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(296, 33);
            this.usernameTextBox.TabIndex = 1;
            // 
            // showRepositoriesButton
            // 
            this.showRepositoriesButton.Location = new System.Drawing.Point(6, 57);
            this.showRepositoriesButton.Name = "showRepositoriesButton";
            this.showRepositoriesButton.Size = new System.Drawing.Size(144, 33);
            this.showRepositoriesButton.TabIndex = 0;
            this.showRepositoriesButton.Text = "Показать репозитории";
            this.showRepositoriesButton.UseVisualStyleBackColor = true;
            this.showRepositoriesButton.Click += new System.EventHandler(this.showRepositoriesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usersRepositoriesListBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список репозиториев";
            // 
            // usersRepositoriesListBox
            // 
            this.usersRepositoriesListBox.FormattingEnabled = true;
            this.usersRepositoriesListBox.Location = new System.Drawing.Point(6, 14);
            this.usersRepositoriesListBox.Name = "usersRepositoriesListBox";
            this.usersRepositoriesListBox.Size = new System.Drawing.Size(290, 95);
            this.usersRepositoriesListBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Location = new System.Drawing.Point(330, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 370);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация репозитория";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(402, 342);
            this.listBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 422);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RepoChecker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйРепозиторийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem существующийРепозиторийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button showRepositoriesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox usersRepositoriesListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button showUserInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox2;
    }
}

