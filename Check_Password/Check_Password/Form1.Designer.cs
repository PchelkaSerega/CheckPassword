namespace Check_Password
{
    partial class Check_password
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
            this.vvod1 = new System.Windows.Forms.TextBox();
            this.label_vvod = new System.Windows.Forms.Label();
            this.wrong = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vvod1
            // 
            this.vvod1.Location = new System.Drawing.Point(27, 43);
            this.vvod1.Name = "vvod1";
            this.vvod1.Size = new System.Drawing.Size(216, 20);
            this.vvod1.TabIndex = 0;
            // 
            // label_vvod
            // 
            this.label_vvod.AutoSize = true;
            this.label_vvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vvod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_vvod.Location = new System.Drawing.Point(24, 24);
            this.label_vvod.Name = "label_vvod";
            this.label_vvod.Size = new System.Drawing.Size(132, 16);
            this.label_vvod.TabIndex = 1;
            this.label_vvod.Text = "Введите пароль:\r\n";
            // 
            // wrong
            // 
            this.wrong.BackColor = System.Drawing.Color.White;
            this.wrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrong.ForeColor = System.Drawing.Color.Black;
            this.wrong.Location = new System.Drawing.Point(24, 78);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(219, 63);
            this.wrong.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(81, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Check_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(277, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.label_vvod);
            this.Controls.Add(this.vvod1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Check_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vvod1;
        private System.Windows.Forms.Label label_vvod;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.Button button1;
    }
}

