﻿using ComponentsLibraryNet60.DocumentWithContext;
using ComponentsLibraryNet60.DocumentWithTable;
using ComponentsLibraryNet60.Models;
using Contracts.Book;
using Contracts.Ganre;
using DatabaseImplement;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using PluginsConvention.Plugins;
using Unity;
using WinFormsLibrary1;

namespace View
{
    public partial class FormMain : Form
    {
        private readonly Dictionary<string, IPluginsConvention> _plugins;
        private string _selectedPlugin;
        private ContextMenuStrip contextMenu = new();

        public FormMain(IBookLogic boolLogic, IGanreLogic ganreLogic)
        {
            InitializeComponent();
            _plugins = LoadPlugins();
            _selectedPlugin = string.Empty;
        }

        private Dictionary<string, IPluginsConvention> LoadPlugins()
        {
            // TODO Заполнить IPluginsConvention
            // TODO Заполнить пункт меню "Справочники" на основе IPluginsConvention.PluginName
            // TODO Например, создавать ToolStripMenuItem, привязывать к ним обработку событий и добавлять в menuStrip
            // TODO При выборе пункта меню получать UserControl и заполнять элемент panelControl этим контролом на всю площадь
            // Пример: panelControl.Controls.Clear(); panelControl.Controls.Add(ctrl);
            PluginsManager manager = new PluginsManager();
            var plugins = manager.plugins_dictionary;

            ToolStripItem[] toolStripItems = new ToolStripItem[plugins.Count];
            int i = 0;
            if (plugins.Count > 0)
            {
                foreach (var plugin in plugins)
                {
                    ToolStripMenuItem itemMenu = new ToolStripMenuItem();
                    itemMenu.Text = plugin.Value.PluginName;
                    itemMenu.Click += (sender, e) =>
                    {
                        _selectedPlugin = plugin.Value.PluginName;
                        panelControl.Controls.Clear();
                        panelControl.Controls.Add(_plugins[_selectedPlugin].GetControl);
                        panelControl.Controls[0].Dock = DockStyle.Fill;
                    };
                    toolStripItems[i] = itemMenu;
                    i++;
                }
                spravochkaToolStripMenuItem.DropDownItems.AddRange(toolStripItems);
            }
            return plugins;
        }


        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.A:
                    добавитьToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.U:
                    изменитьToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.D:
                    удалитьToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.S:
                    CreateExcel(sender, e);
                    break;
                case Keys.T:
                    CreateWord(sender, e);
                    break;
                case Keys.C:
                    CreatePdf(sender, e);
                    break;
            }

            switch (e.KeyCode)
            {
                case Keys.A:
                    AddNewElement();
                    break;
                case Keys.U:
                    UpdateElement();
                    break;
                case Keys.D:
                    DeleteElement();
                    break;
                case Keys.S:
                    CreateWordReadersTable();
                    break;
                case Keys.T:
                    CreatePdfBooks();
                    break;
                case Keys.C:
                    CreateExcelShapes();
                    break;
            }
        }

        private void AddNewElement()
        {
            var form = _plugins[_selectedPlugin].GetForm(null);
            if (form != null && form.ShowDialog() == DialogResult.OK)
            {
                _plugins[_selectedPlugin].ReloadData();
            }
        }

        private void UpdateElement()
        {
            var element = _plugins[_selectedPlugin].GetElement;
            if (element == null)
            {
                MessageBox.Show("Нет выбранного элемента", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = _plugins[_selectedPlugin].GetForm(element);
            if (form != null && form.ShowDialog() == DialogResult.OK)
            {
                _plugins[_selectedPlugin].ReloadData();
            }
        }

        private void DeleteElement()
        {
            if (MessageBox.Show("Удалить выбранный элемент", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) { return; }
            var element = _plugins[_selectedPlugin].GetElement;
            if (element == null)
            {
                MessageBox.Show("Нет выбранного элемента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_plugins[_selectedPlugin].DeleteElement(element))
            {
                _plugins[_selectedPlugin].ReloadData();
            }
        }

        private void CreateExcel()
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (_plugins[_selectedPlugin].CreateSimpleDocument(new PluginsConventionSaveDocument { FileName = dialog.FileName }))
                {
                    MessageBox.Show("Документ сохранен", "Создание документа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при создании документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreatePdfBooks()
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (_plugins[_selectedPlugin].CreateTableDocument(new PluginsConventionSaveDocument { FileName = dialog.FileName }))
                {
                    MessageBox.Show("Документ сохранен", "Создание документа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при создании документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateExcelShapes()
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (_plugins[_selectedPlugin].CreateChartDocument(new PluginsConventionSaveDocument { FileName = dialog.FileName }))
                {
                    MessageBox.Show("Документ сохранен", "Создание документа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при создании документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddElementToolStripMenuItem_Click(object sender, EventArgs e) => AddNewElement();

        private void UpdElementToolStripMenuItem_Click(object sender, EventArgs e) => UpdateElement();

        private void DelElementToolStripMenuItem_Click(object sender, EventArgs e) => DeleteElement();

        private void WordDocToolStripMenuItem_Click(object sender, EventArgs e) => CreateWordReadersTable();

        private void PdfDocToolStripMenuItem_Click(object sender, EventArgs e) => CreatePdfBooks();

        private void ExcelDocToolStripMenuItem_Click(object sender, EventArgs e) => CreateExcelShapes();
    }
}
