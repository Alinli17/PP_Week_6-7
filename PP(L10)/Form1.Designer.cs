namespace PP_L10_
{
    partial class Lesson_10
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
            this.Result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rez1 = new System.Windows.Forms.Label();
            this.rez2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(121, 94);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(160, 47);
            this.Result.TabIndex = 0;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер экрана:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя текущего пользователя:";
            // 
            // rez1
            // 
            this.rez1.AutoSize = true;
            this.rez1.Location = new System.Drawing.Point(220, 9);
            this.rez1.Name = "rez1";
            this.rez1.Size = new System.Drawing.Size(0, 17);
            this.rez1.TabIndex = 3;
            // 
            // rez2
            // 
            this.rez2.AutoSize = true;
            this.rez2.Location = new System.Drawing.Point(220, 45);
            this.rez2.Name = "rez2";
            this.rez2.Size = new System.Drawing.Size(0, 17);
            this.rez2.TabIndex = 4;
            // 
            // Lesson_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 153);
            this.Controls.Add(this.rez2);
            this.Controls.Add(this.rez1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Name = "Lesson_10";
            this.Text = "Урок 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rez1;
        private System.Windows.Forms.Label rez2;
    }
}

