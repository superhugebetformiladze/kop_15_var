namespace WinFormsControlLibraryS
{
    partial class TextBoxControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxNull = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // checkBoxNull
            // 
            this.checkBoxNull.AutoSize = true;
            this.checkBoxNull.Location = new System.Drawing.Point(24, 78);
            this.checkBoxNull.Name = "checkBoxNull";
            this.checkBoxNull.Size = new System.Drawing.Size(46, 19);
            this.checkBoxNull.TabIndex = 1;
            this.checkBoxNull.Text = "null";
            this.checkBoxNull.UseVisualStyleBackColor = true;
            // 
            // TextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxNull);
            this.Controls.Add(this.textBox1);
            this.Name = "TextBoxControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkBoxNull;
    }
}
