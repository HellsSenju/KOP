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
            customTree = new WinFormsLibrary1.MyTree();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, действияToolStripMenuItem, документыToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { формыToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // формыToolStripMenuItem
            // 
            формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            формыToolStripMenuItem.Size = new Size(180, 22);
            формыToolStripMenuItem.Text = "Жанры";
            формыToolStripMenuItem.Click += жанрыToolStripMenuItem_Click;
            // 
            // действияToolStripMenuItem
            // 
            действияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, изменитьToolStripMenuItem, удалитьToolStripMenuItem });
            действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            действияToolStripMenuItem.Size = new Size(70, 20);
            действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.K;
            добавитьToolStripMenuItem.Size = new Size(180, 22);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            изменитьToolStripMenuItem.Size = new Size(180, 22);
            изменитьToolStripMenuItem.Text = "Изменить";
            изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            удалитьToolStripMenuItem.Size = new Size(180, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // документыToolStripMenuItem
            // 
            документыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { документСТекстомToolStripMenuItem, документToolStripMenuItem });
            документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            документыToolStripMenuItem.Size = new Size(82, 20);
            документыToolStripMenuItem.Text = "Документы";
            // 
            // документСТекстомToolStripMenuItem
            // 
            документСТекстомToolStripMenuItem.Name = "документСТекстомToolStripMenuItem";
            документСТекстомToolStripMenuItem.Size = new Size(128, 22);
            документСТекстомToolStripMenuItem.Text = "Чтото";
            // 
            // документToolStripMenuItem
            // 
            документToolStripMenuItem.Name = "документToolStripMenuItem";
            документToolStripMenuItem.Size = new Size(128, 22);
            документToolStripMenuItem.Text = "Документ";
            // 
            // customTree
            // 
            customTree.Location = new Point(0, 26);
            customTree.Margin = new Padding(3, 2, 3, 2);
            customTree.Name = "customTree";
            customTree.SelectedIndex = -1;
            customTree.Size = new Size(800, 424);
            customTree.TabIndex = 1;
            customTree.Click += жанрыToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customTree);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
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
        private WinFormsLibrary1.MyTree customTree;
    }
}