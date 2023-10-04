namespace Test
{
    partial class FormTest
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
            components = new System.ComponentModel.Container();
            customComboBox = new CustomComponents_Lab1.CustomComboBox();
            customListBox = new CustomComponents_Lab1.CustomListBox();
            customTextBox = new CustomComponents_Lab1.CustomTextBox();
            groupBoxVisual = new GroupBox();
            buttonShow = new Button();
            label = new Label();
            labelSelected = new Label();
            buttonAddData = new Button();
            buttonClear = new Button();
            buttonAdd = new Button();
            textBox = new TextBox();
            groupBoxUnvisual = new GroupBox();
            buttonDiagram = new Button();
            buttonTable = new Button();
            buttonDoc = new Button();
            excelDiagram = new CustomComponents_Lab1.ExcelDiagram(components);
            excelDocument = new CustomComponents_Lab1.ExcelDocument(components);
            excelTable = new CustomComponents_Lab1.ExcelTable(components);
            groupBoxVisual.SuspendLayout();
            groupBoxUnvisual.SuspendLayout();
            SuspendLayout();
            // 
            // customComboBox
            // 
            customComboBox.Location = new Point(5, 20);
            customComboBox.Margin = new Padding(3, 2, 3, 2);
            customComboBox.Name = "customComboBox";
            customComboBox.SelectElement = "";
            customComboBox.Size = new Size(149, 28);
            customComboBox.TabIndex = 0;
            // 
            // customListBox
            // 
            customListBox.index = -1;
            customListBox.Location = new Point(291, 20);
            customListBox.Margin = new Padding(3, 2, 3, 2);
            customListBox.Name = "customListBox";
            customListBox.Size = new Size(382, 158);
            customListBox.TabIndex = 1;
            // 
            // customTextBox
            // 
            customTextBox.Location = new Point(160, 20);
            customTextBox.Margin = new Padding(3, 2, 3, 2);
            customTextBox.Name = "customTextBox";
            customTextBox.Size = new Size(125, 28);
            customTextBox.TabIndex = 2;
            customTextBox.template = "";
            // 
            // groupBoxVisual
            // 
            groupBoxVisual.Controls.Add(buttonShow);
            groupBoxVisual.Controls.Add(label);
            groupBoxVisual.Controls.Add(labelSelected);
            groupBoxVisual.Controls.Add(buttonAddData);
            groupBoxVisual.Controls.Add(buttonClear);
            groupBoxVisual.Controls.Add(buttonAdd);
            groupBoxVisual.Controls.Add(textBox);
            groupBoxVisual.Controls.Add(customTextBox);
            groupBoxVisual.Controls.Add(customComboBox);
            groupBoxVisual.Controls.Add(customListBox);
            groupBoxVisual.Location = new Point(10, 9);
            groupBoxVisual.Margin = new Padding(3, 2, 3, 2);
            groupBoxVisual.Name = "groupBoxVisual";
            groupBoxVisual.Padding = new Padding(3, 2, 3, 2);
            groupBoxVisual.Size = new Size(678, 214);
            groupBoxVisual.TabIndex = 3;
            groupBoxVisual.TabStop = false;
            groupBoxVisual.Text = "Визуальные компоненты";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(291, 182);
            buttonShow.Margin = new Padding(3, 2, 3, 2);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(82, 22);
            buttonShow.TabIndex = 8;
            buttonShow.Text = "Получить";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(178, 85);
            label.Name = "label";
            label.Size = new Size(0, 15);
            label.TabIndex = 7;
            // 
            // labelSelected
            // 
            labelSelected.AutoSize = true;
            labelSelected.Location = new Point(379, 186);
            labelSelected.Name = "labelSelected";
            labelSelected.Size = new Size(0, 15);
            labelSelected.TabIndex = 4;
            // 
            // buttonAddData
            // 
            buttonAddData.Location = new Point(173, 50);
            buttonAddData.Margin = new Padding(3, 2, 3, 2);
            buttonAddData.Name = "buttonAddData";
            buttonAddData.Size = new Size(91, 22);
            buttonAddData.TabIndex = 6;
            buttonAddData.Text = "Добавить";
            buttonAddData.UseVisualStyleBackColor = true;
            buttonAddData.Click += buttonAddData_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(25, 107);
            buttonClear.Margin = new Padding(3, 2, 3, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(91, 22);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(25, 81);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(91, 22);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(25, 52);
            textBox.Margin = new Padding(3, 2, 3, 2);
            textBox.Name = "textBox";
            textBox.Size = new Size(92, 23);
            textBox.TabIndex = 3;
            // 
            // groupBoxUnvisual
            // 
            groupBoxUnvisual.Controls.Add(buttonDiagram);
            groupBoxUnvisual.Controls.Add(buttonTable);
            groupBoxUnvisual.Controls.Add(buttonDoc);
            groupBoxUnvisual.Location = new Point(10, 228);
            groupBoxUnvisual.Name = "groupBoxUnvisual";
            groupBoxUnvisual.Size = new Size(678, 49);
            groupBoxUnvisual.TabIndex = 4;
            groupBoxUnvisual.TabStop = false;
            groupBoxUnvisual.Text = "Невизуальные компоненты";
            // 
            // buttonDiagram
            // 
            buttonDiagram.Location = new Point(316, 20);
            buttonDiagram.Name = "buttonDiagram";
            buttonDiagram.Size = new Size(134, 23);
            buttonDiagram.TabIndex = 2;
            buttonDiagram.Text = "С диаграммой";
            buttonDiagram.UseVisualStyleBackColor = true;
            buttonDiagram.Click += buttonDiagram_Click;
            // 
            // buttonTable
            // 
            buttonTable.Location = new Point(122, 20);
            buttonTable.Name = "buttonTable";
            buttonTable.Size = new Size(188, 23);
            buttonTable.TabIndex = 1;
            buttonTable.Text = "С настраиваемое таблицей";
            buttonTable.UseVisualStyleBackColor = true;
            buttonTable.Click += buttonTable_Click;
            // 
            // buttonDoc
            // 
            buttonDoc.Location = new Point(6, 20);
            buttonDoc.Name = "buttonDoc";
            buttonDoc.Size = new Size(110, 23);
            buttonDoc.TabIndex = 0;
            buttonDoc.Text = "С контекстом";
            buttonDoc.UseVisualStyleBackColor = true;
            buttonDoc.Click += buttonDoc_Click;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 289);
            Controls.Add(groupBoxUnvisual);
            Controls.Add(groupBoxVisual);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTest";
            Text = "Тестирование";
            groupBoxVisual.ResumeLayout(false);
            groupBoxVisual.PerformLayout();
            groupBoxUnvisual.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomComponents_Lab1.CustomComboBox customComboBox;
        private CustomComponents_Lab1.CustomListBox customListBox;
        private CustomComponents_Lab1.CustomTextBox customTextBox;
        private GroupBox groupBoxVisual;
        private Button buttonClear;
        private Button buttonAdd;
        private TextBox textBox;
        private Button buttonAddData;
        private Label label;
        private Label labelSelected;
        private Button buttonShow;
        private GroupBox groupBoxUnvisual;
        private Button buttonDiagram;
        private Button buttonTable;
        private Button buttonDoc;
        private CustomComponents_Lab1.ExcelDiagram excelDiagram;
        private CustomComponents_Lab1.ExcelDocument excelDocument;
        private CustomComponents_Lab1.ExcelTable excelTable;
    }
}