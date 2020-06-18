namespace PP_L13_
{
    partial class Lesson_13
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
            this.List_Box = new System.Windows.Forms.ListBox();
            this.forma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // List_Box
            // 
            this.List_Box.FormattingEnabled = true;
            this.List_Box.ItemHeight = 16;
            this.List_Box.Location = new System.Drawing.Point(12, 12);
            this.List_Box.Name = "List_Box";
            this.List_Box.Size = new System.Drawing.Size(287, 244);
            this.List_Box.TabIndex = 0;
            this.List_Box.SelectedIndexChanged += new System.EventHandler(this.List_Box_SelectedIndexChanged);
            // 
            // forma
            // 
            this.forma.AutoSize = true;
            this.forma.Location = new System.Drawing.Point(12, 274);
            this.forma.Name = "forma";
            this.forma.Size = new System.Drawing.Size(49, 17);
            this.forma.TabIndex = 1;
            this.forma.Text = "Primer";
            // 
            // Lesson_13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 331);
            this.Controls.Add(this.forma);
            this.Controls.Add(this.List_Box);
            this.Name = "Lesson_13";
            this.Text = "Урок 13";
            this.Load += new System.EventHandler(this.Lesson_13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_Box;
        private System.Windows.Forms.Label forma;
    }
}

