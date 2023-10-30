namespace PluginsConvention
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
            buttonCancel=new Button();
            buttonOk=new Button();
            controlInputNullableInt=new ControlsLibraryNet60.Input.ControlInputNullableInt();
            labelPrice=new Label();
            textBoxDescr=new TextBox();
            textBoxTitle=new TextBox();
            labelGanre=new Label();
            labelDesrc=new Label();
            labelTitle=new Label();
            customComboBoxGanre=new CustomComponents_Lab1.CustomComboBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            buttonCancel.Location=new Point(106, 204);
            buttonCancel.Name="buttonCancel";
            buttonCancel.Size=new Size(68, 33);
            buttonCancel.TabIndex=20;
            buttonCancel.Text="Cancel";
            buttonCancel.UseVisualStyleBackColor=true;
            // 
            // buttonOk
            // 
            buttonOk.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            buttonOk.Location=new Point(11, 204);
            buttonOk.Name="buttonOk";
            buttonOk.Size=new Size(75, 33);
            buttonOk.TabIndex=19;
            buttonOk.Text="Ok";
            buttonOk.UseVisualStyleBackColor=true;
            // 
            // controlInputNullableInt
            // 
            controlInputNullableInt.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            controlInputNullableInt.Location=new Point(21, 162);
            controlInputNullableInt.Margin=new Padding(5, 3, 5, 3);
            controlInputNullableInt.Name="controlInputNullableInt";
            controlInputNullableInt.Size=new Size(153, 23);
            controlInputNullableInt.TabIndex=18;
            controlInputNullableInt.Value=null;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize=true;
            labelPrice.Location=new Point(19, 144);
            labelPrice.Name="labelPrice";
            labelPrice.Size=new Size(33, 15);
            labelPrice.TabIndex=17;
            labelPrice.Text="Price";
            // 
            // textBoxDescr
            // 
            textBoxDescr.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            textBoxDescr.Location=new Point(19, 73);
            textBoxDescr.Name="textBoxDescr";
            textBoxDescr.Size=new Size(155, 23);
            textBoxDescr.TabIndex=16;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            textBoxTitle.Location=new Point(19, 26);
            textBoxTitle.Name="textBoxTitle";
            textBoxTitle.Size=new Size(155, 23);
            textBoxTitle.TabIndex=15;
            // 
            // labelGanre
            // 
            labelGanre.AutoSize=true;
            labelGanre.Location=new Point(19, 99);
            labelGanre.Name="labelGanre";
            labelGanre.Size=new Size(38, 15);
            labelGanre.TabIndex=14;
            labelGanre.Text="Ganre";
            // 
            // labelDesrc
            // 
            labelDesrc.AutoSize=true;
            labelDesrc.Location=new Point(19, 55);
            labelDesrc.Name="labelDesrc";
            labelDesrc.Size=new Size(67, 15);
            labelDesrc.TabIndex=13;
            labelDesrc.Text="Description";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize=true;
            labelTitle.Location=new Point(19, 8);
            labelTitle.Name="labelTitle";
            labelTitle.Size=new Size(29, 15);
            labelTitle.TabIndex=12;
            labelTitle.Text="Title";
            // 
            // customComboBoxGanre
            // 
            customComboBoxGanre.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            customComboBoxGanre.Location=new Point(19, 116);
            customComboBoxGanre.Margin=new Padding(3, 2, 3, 2);
            customComboBoxGanre.Name="customComboBoxGanre";
            customComboBoxGanre.SelectElement="";
            customComboBoxGanre.Size=new Size(155, 26);
            customComboBoxGanre.TabIndex=11;
            // 
            // FormBook
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(185, 245);
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
            Name="FormBook";
            Text="FormBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonOk;
        private ControlsLibraryNet60.Input.ControlInputNullableInt controlInputNullableInt;
        private Label labelPrice;
        private TextBox textBoxDescr;
        private TextBox textBoxTitle;
        private Label labelGanre;
        private Label labelDesrc;
        private Label labelTitle;
        private CustomComponents_Lab1.CustomComboBox customComboBoxGanre;
    }
}