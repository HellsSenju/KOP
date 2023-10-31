namespace View
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            формыToolStripMenuItem = new ToolStripMenuItem();
            действияToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            документыToolStripMenuItem = new ToolStripMenuItem();
            документСТекстомToolStripMenuItem = new ToolStripMenuItem();
            документToolStripMenuItem = new ToolStripMenuItem();
            круговаяДиагрPdfToolStripMenuItem = new ToolStripMenuItem();
            componentDocumentWithTableMultiHeaderWord = new ComponentsLibraryNet60.DocumentWithTable.ComponentDocumentWithTableMultiHeaderWord(components);
            customTree = new WinFormsLibrary1.MyTree();
            excelDocument = new CustomComponents_Lab1.ExcelDocument(components);
            diagramTopdf = new WinFormsLibrary1.DiagramToPDF();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, действияToolStripMenuItem, документыToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(914, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { формыToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(117, 24);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // формыToolStripMenuItem
            // 
            формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            формыToolStripMenuItem.Size = new Size(142, 26);
            формыToolStripMenuItem.Text = "Жанры";
            формыToolStripMenuItem.Click += жанрыToolStripMenuItem_Click;
            // 
            // действияToolStripMenuItem
            // 
            действияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, изменитьToolStripMenuItem, удалитьToolStripMenuItem });
            действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            действияToolStripMenuItem.Size = new Size(88, 24);
            действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.K;
            добавитьToolStripMenuItem.Size = new Size(213, 26);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            изменитьToolStripMenuItem.Size = new Size(213, 26);
            изменитьToolStripMenuItem.Text = "Изменить";
            изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            удалитьToolStripMenuItem.Size = new Size(213, 26);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // документыToolStripMenuItem
            // 
            документыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { документСТекстомToolStripMenuItem, документToolStripMenuItem, круговаяДиагрPdfToolStripMenuItem });
            документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            документыToolStripMenuItem.Size = new Size(101, 24);
            документыToolStripMenuItem.Text = "Документы";
            // 
            // документСТекстомToolStripMenuItem
            // 
            документСТекстомToolStripMenuItem.Name = "документСТекстомToolStripMenuItem";
            документСТекстомToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            документСТекстомToolStripMenuItem.Size = new Size(278, 26);
            документСТекстомToolStripMenuItem.Text = "Строчки в excel";
            документСТекстомToolStripMenuItem.Click += CreateExcel;
            // 
            // документToolStripMenuItem
            // 
            документToolStripMenuItem.Name = "документToolStripMenuItem";
            документToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            документToolStripMenuItem.Size = new Size(278, 26);
            документToolStripMenuItem.Text = "Таблица word";
            документToolStripMenuItem.Click += CreateWord;
            // 
            // круговаяДиагрPdfToolStripMenuItem
            // 
            круговаяДиагрPdfToolStripMenuItem.Name = "круговаяДиагрPdfToolStripMenuItem";
            круговаяДиагрPdfToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            круговаяДиагрPdfToolStripMenuItem.Size = new Size(278, 26);
            круговаяДиагрPdfToolStripMenuItem.Text = "Круговая диагр pdf";
            круговаяДиагрPdfToolStripMenuItem.Click += CreatePdf;
            // 
            // customTree
            // 
            customTree.Location = new Point(14, 35);
            customTree.Name = "customTree";
            customTree.SelectedIndex = -1;
            customTree.Size = new Size(888, 553);
            customTree.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(customTree);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            KeyDown += FormMain_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem документыToolStripMenuItem;
        private ToolStripMenuItem формыToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem документСТекстомToolStripMenuItem;
        private ToolStripMenuItem документToolStripMenuItem;
        private ToolStripMenuItem круговаяДиагрPdfToolStripMenuItem;
        private ComponentsLibraryNet60.DocumentWithTable.ComponentDocumentWithTableMultiHeaderWord componentDocumentWithTableMultiHeaderWord;
        private WinFormsLibrary1.MyTree customTree;
        private CustomComponents_Lab1.ExcelDocument excelDocument;
        private WinFormsLibrary1.DiagramToPDF diagramTopdf;
    }
}