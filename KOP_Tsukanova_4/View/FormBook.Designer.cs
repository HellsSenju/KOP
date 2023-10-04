namespace View
{
    partial class FormBook
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
            customComboBoxGanre = new CustomComponents_Lab1.CustomComboBox();
            labelTitle = new Label();
            labelDesrc = new Label();
            labelGanre = new Label();
            textBoxTitle = new TextBox();
            textBoxDescr = new TextBox();
            labelPrice = new Label();
            controlInputNullableInt = new ControlsLibraryNet60.Input.ControlInputNullableInt();
            buttonOk = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // customComboBoxGanre
            // 
            customComboBoxGanre.Location = new Point(12, 117);
            customComboBoxGanre.Margin = new Padding(3, 2, 3, 2);
            customComboBoxGanre.Name = "customComboBoxGanre";
            customComboBoxGanre.SelectElement = "";
            customComboBoxGanre.Size = new Size(155, 26);
            customComboBoxGanre.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(29, 15);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // labelDesrc
            // 
            labelDesrc.AutoSize = true;
            labelDesrc.Location = new Point(12, 56);
            labelDesrc.Name = "labelDesrc";
            labelDesrc.Size = new Size(67, 15);
            labelDesrc.TabIndex = 2;
            labelDesrc.Text = "Description";
            // 
            // labelGanre
            // 
            labelGanre.AutoSize = true;
            labelGanre.Location = new Point(12, 100);
            labelGanre.Name = "labelGanre";
            labelGanre.Size = new Size(38, 15);
            labelGanre.TabIndex = 3;
            labelGanre.Text = "Ganre";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(12, 27);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(155, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // textBoxDescr
            // 
            textBoxDescr.Location = new Point(12, 74);
            textBoxDescr.Name = "textBoxDescr";
            textBoxDescr.Size = new Size(155, 23);
            textBoxDescr.TabIndex = 5;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 145);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Price";
            // 
            // controlInputNullableInt
            // 
            controlInputNullableInt.Location = new Point(14, 163);
            controlInputNullableInt.Margin = new Padding(5, 3, 5, 3);
            controlInputNullableInt.Name = "controlInputNullableInt";
            controlInputNullableInt.Size = new Size(153, 23);
            controlInputNullableInt.TabIndex = 8;
            controlInputNullableInt.Value = null;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(4, 205);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 33);
            buttonOk.TabIndex = 9;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(99, 205);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(68, 33);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(176, 250);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(controlInputNullableInt);
            Controls.Add(labelPrice);
            Controls.Add(textBoxDescr);
            Controls.Add(textBoxTitle);
            Controls.Add(labelGanre);
            Controls.Add(labelDesrc);
            Controls.Add(labelTitle);
            Controls.Add(customComboBoxGanre);
            Name = "FormBook";
            Text = "FormBook";
            Load += FormBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomComponents_Lab1.CustomComboBox customComboBoxGanre;
        private Label labelTitle;
        private Label labelDesrc;
        private Label labelGanre;
        private TextBox textBoxTitle;
        private TextBox textBoxDescr;
        private Label labelPrice;
        private ControlsLibraryNet60.Input.ControlInputNullableInt controlInputNullableInt;
        private Button buttonOk;
        private Button buttonCancel;
    }
}