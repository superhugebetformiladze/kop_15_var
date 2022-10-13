namespace CopView
{
    partial class Form2
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
            this.button_SimpleTable = new System.Windows.Forms.Button();
            this.button_ComplicatedTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SimpleTable
            // 
            this.button_SimpleTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_SimpleTable.Location = new System.Drawing.Point(107, 46);
            this.button_SimpleTable.Name = "button_SimpleTable";
            this.button_SimpleTable.Size = new System.Drawing.Size(281, 80);
            this.button_SimpleTable.TabIndex = 0;
            this.button_SimpleTable.Text = "обычная таблица в ворд";
            this.button_SimpleTable.UseVisualStyleBackColor = true;
            this.button_SimpleTable.Click += new System.EventHandler(this.buttonSimpleTable_Click);
            // 
            // button_ComplicatedTable
            // 
            this.button_ComplicatedTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ComplicatedTable.Location = new System.Drawing.Point(107, 174);
            this.button_ComplicatedTable.Name = "button_ComplicatedTable";
            this.button_ComplicatedTable.Size = new System.Drawing.Size(281, 80);
            this.button_ComplicatedTable.TabIndex = 1;
            this.button_ComplicatedTable.Text = "таблица в ворд с шапкой";
            this.button_ComplicatedTable.UseVisualStyleBackColor = true;
            this.button_ComplicatedTable.Click += new System.EventHandler(this.buttonComplicatedTable_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 456);
            this.Controls.Add(this.button_ComplicatedTable);
            this.Controls.Add(this.button_SimpleTable);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_SimpleTable;
        private NonVisualComponentLibraryS.WordSimpleComponent wordSimpleComponent;
        private NonVisualComponentLibraryS.WordComplicatedComponent wordComplicatedComponent;
        private Button button_ComplicatedTable;
    }
}