namespace CustomComponents_Lab1
{
    partial class CustomTextBox
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
            components = new System.ComponentModel.Container();
            textBox = new TextBox();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(3, 2);
            textBox.Margin = new Padding(3, 2, 3, 2);
            textBox.Name = "textBox";
            textBox.Size = new Size(127, 23);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // CustomTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomTextBox";
            Size = new Size(132, 29);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private ToolTip toolTip;
    }
}
