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
            menuStrip=new MenuStrip();
            spravochkaToolStripMenuItem=new ToolStripMenuItem();
            действияToolStripMenuItem=new ToolStripMenuItem();
            AddToolStripMenuItem=new ToolStripMenuItem();
            UpdateToolStripMenuItem=new ToolStripMenuItem();
            DeleteToolStripMenuItem=new ToolStripMenuItem();
            документыToolStripMenuItem=new ToolStripMenuItem();
            ExcelToolStripMenuItem=new ToolStripMenuItem();
            WordToolStripMenuItem=new ToolStripMenuItem();
            PdfToolStripMenuItem=new ToolStripMenuItem();
            panelControl=new Panel();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize=new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { spravochkaToolStripMenuItem, действияToolStripMenuItem, документыToolStripMenuItem });
            menuStrip.Location=new Point(0, 0);
            menuStrip.Name="menuStrip";
            menuStrip.Size=new Size(800, 24);
            menuStrip.TabIndex=0;
            menuStrip.Text="menuStrip1";
            // 
            // spravochkaToolStripMenuItem
            // 
            spravochkaToolStripMenuItem.Name="spravochkaToolStripMenuItem";
            spravochkaToolStripMenuItem.Size=new Size(94, 20);
            spravochkaToolStripMenuItem.Text="Справочники";
            // 
            // действияToolStripMenuItem
            // 
            действияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddToolStripMenuItem, UpdateToolStripMenuItem, DeleteToolStripMenuItem });
            действияToolStripMenuItem.Name="действияToolStripMenuItem";
            действияToolStripMenuItem.Size=new Size(70, 20);
            действияToolStripMenuItem.Text="Действия";
            // 
            // AddToolStripMenuItem
            // 
            AddToolStripMenuItem.Name="AddToolStripMenuItem";
            AddToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.K;
            AddToolStripMenuItem.Size=new Size(180, 22);
            AddToolStripMenuItem.Text="Добавить";
            // 
            // UpdateToolStripMenuItem
            // 
            UpdateToolStripMenuItem.Name="UpdateToolStripMenuItem";
            UpdateToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.U;
            UpdateToolStripMenuItem.Size=new Size(180, 22);
            UpdateToolStripMenuItem.Text="Изменить";
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name="DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.D;
            DeleteToolStripMenuItem.Size=new Size(180, 22);
            DeleteToolStripMenuItem.Text="Удалить";
            // 
            // документыToolStripMenuItem
            // 
            документыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExcelToolStripMenuItem, WordToolStripMenuItem, PdfToolStripMenuItem });
            документыToolStripMenuItem.Name="документыToolStripMenuItem";
            документыToolStripMenuItem.Size=new Size(82, 20);
            документыToolStripMenuItem.Text="Документы";
            // 
            // ExcelToolStripMenuItem
            // 
            ExcelToolStripMenuItem.Name="ExcelToolStripMenuItem";
            ExcelToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.S;
            ExcelToolStripMenuItem.Size=new Size(221, 22);
            ExcelToolStripMenuItem.Text="Строчки в excel";
            // 
            // WordToolStripMenuItem
            // 
            WordToolStripMenuItem.Name="WordToolStripMenuItem";
            WordToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.T;
            WordToolStripMenuItem.Size=new Size(221, 22);
            WordToolStripMenuItem.Text="Таблица word";
            // 
            // PdfToolStripMenuItem
            // 
            PdfToolStripMenuItem.Name="PdfToolStripMenuItem";
            PdfToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.C;
            PdfToolStripMenuItem.Size=new Size(221, 22);
            PdfToolStripMenuItem.Text="Круговая диагр pdf";
            // 
            // panelControl
            // 
            panelControl.Location=new Point(12, 27);
            panelControl.Name="panelControl";
            panelControl.Size=new Size(776, 411);
            panelControl.TabIndex=1;
            // 
            // FormMain
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(panelControl);
            Controls.Add(menuStrip);
            MainMenuStrip=menuStrip;
            Name="FormMain";
            Text="FormMain";
            KeyDown+=FormMain_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem spravochkaToolStripMenuItem;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem документыToolStripMenuItem;
        private ToolStripMenuItem AddToolStripMenuItem;
        private ToolStripMenuItem UpdateToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem ExcelToolStripMenuItem;
        private ToolStripMenuItem WordToolStripMenuItem;
        private ToolStripMenuItem PdfToolStripMenuItem;
        private Panel panelControl;
        //private WinFormsLibrary1.DiagramToPDF diagramTopdf;
    }
}