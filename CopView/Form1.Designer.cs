namespace CopView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxControl = new WinFormsControlLibraryS.ListBoxControl();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxInputItems = new System.Windows.Forms.TextBox();
            this.textBoxControl = new WinFormsControlLibraryS.TextBoxControl();
            this.buttonAddText = new System.Windows.Forms.Button();
            this.labelNumb = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxControl
            // 
            this.listBoxControl.Location = new System.Drawing.Point(27, 53);
            this.listBoxControl.Name = "listBoxControl";
            this.listBoxControl.Size = new System.Drawing.Size(150, 150);
            this.listBoxControl.TabIndex = 0;
            this.listBoxControl.ValueList = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(56, 209);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 39);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(56, 282);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 39);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxInputItems
            // 
            this.textBoxInputItems.Location = new System.Drawing.Point(53, 343);
            this.textBoxInputItems.Name = "textBoxInputItems";
            this.textBoxInputItems.Size = new System.Drawing.Size(100, 23);
            this.textBoxInputItems.TabIndex = 5;
            // 
            // textBoxControl
            // 
            this.textBoxControl.Location = new System.Drawing.Point(293, 44);
            this.textBoxControl.Name = "textBoxControl";
            this.textBoxControl.Size = new System.Drawing.Size(150, 161);
            this.textBoxControl.TabIndex = 6;
            this.textBoxControl.SpecEvent += new System.EventHandler(this.ButtonAddText_Click);
            // 
            // buttonAddText
            // 
            this.buttonAddText.Location = new System.Drawing.Point(321, 209);
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.Size = new System.Drawing.Size(97, 39);
            this.buttonAddText.TabIndex = 7;
            this.buttonAddText.Text = "Добавить";
            this.buttonAddText.UseVisualStyleBackColor = true;
            this.buttonAddText.Click += new System.EventHandler(this.ButtonAddText_Click);
            // 
            // labelNumb
            // 
            this.labelNumb.AutoSize = true;
            this.labelNumb.Location = new System.Drawing.Point(321, 306);
            this.labelNumb.Name = "labelNumb";
            this.labelNumb.Size = new System.Drawing.Size(45, 15);
            this.labelNumb.TabIndex = 8;
            this.labelNumb.Text = "Число:";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(89, 393);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(47, 15);
            this.labelCurrent.TabIndex = 9;
            this.labelCurrent.Text = "Current";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelNumb);
            this.Controls.Add(this.buttonAddText);
            this.Controls.Add(this.textBoxControl);
            this.Controls.Add(this.textBoxInputItems);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsControlLibraryS.ListBoxControl listBoxControl;
        private Button buttonAdd;
        private Button buttonClear;
        private TextBox textBoxInputItems;
        private WinFormsControlLibraryS.TextBoxControl textBoxControl;
        private Button buttonAddText;
        private Label labelNumb;
        private Label labelCurrent;
    }
}