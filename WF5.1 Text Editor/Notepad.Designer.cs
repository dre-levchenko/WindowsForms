namespace WF5._1_Text_Editor
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.notepadMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolFileNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFileOpen = new System.Windows.Forms.ToolStripButton();
            this.toolFileSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolEditCopy = new System.Windows.Forms.ToolStripButton();
            this.toolEditCut = new System.Windows.Forms.ToolStripButton();
            this.toolEditPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFormatFont = new System.Windows.Forms.ToolStripButton();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.notepadMenu.SuspendLayout();
            this.notepadToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notepadMenu
            // 
            this.notepadMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuFormat});
            this.notepadMenu.Location = new System.Drawing.Point(0, 0);
            this.notepadMenu.Name = "notepadMenu";
            this.notepadMenu.Size = new System.Drawing.Size(584, 24);
            this.notepadMenu.TabIndex = 0;
            this.notepadMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.toolStripSeparator1,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(167, 22);
            this.menuFileNew.Text = "Новый документ";
            this.menuFileNew.Click += new System.EventHandler(this.OnNewDocumentClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(167, 22);
            this.menuFileOpen.Text = "Открыть...";
            this.menuFileOpen.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(167, 22);
            this.menuFileSave.Text = "Сохранить";
            this.menuFileSave.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(167, 22);
            this.menuFileSaveAs.Text = "Сохранить как...";
            this.menuFileSaveAs.Click += new System.EventHandler(this.OnSaveAsClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(167, 22);
            this.menuFileExit.Text = "Выход";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCopy,
            this.menuEditCut,
            this.menuEditPaste,
            this.toolStripSeparator3,
            this.menuEditCancel});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(59, 20);
            this.menuEdit.Text = "Правка";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Size = new System.Drawing.Size(139, 22);
            this.menuEditCopy.Text = "Копировать";
            this.menuEditCopy.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.Size = new System.Drawing.Size(139, 22);
            this.menuEditCut.Text = "Вырезать";
            this.menuEditCut.Click += new System.EventHandler(this.OnCutClick);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.Size = new System.Drawing.Size(139, 22);
            this.menuEditPaste.Text = "Вставить";
            this.menuEditPaste.Click += new System.EventHandler(this.OnPasteClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // menuEditCancel
            // 
            this.menuEditCancel.Name = "menuEditCancel";
            this.menuEditCancel.Size = new System.Drawing.Size(139, 22);
            this.menuEditCancel.Text = "Отменить";
            this.menuEditCancel.Click += new System.EventHandler(this.OnUndoClick);
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatFont});
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(62, 20);
            this.menuFormat.Text = "Формат";
            // 
            // menuFormatFont
            // 
            this.menuFormatFont.Name = "menuFormatFont";
            this.menuFormatFont.Size = new System.Drawing.Size(122, 22);
            this.menuFormatFont.Text = "Шрифт...";
            this.menuFormatFont.Click += new System.EventHandler(this.OnFontClick);
            // 
            // notepadToolStrip
            // 
            this.notepadToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileNew,
            this.toolStripSeparator4,
            this.toolFileOpen,
            this.toolFileSave,
            this.toolStripSeparator5,
            this.toolEditCopy,
            this.toolEditCut,
            this.toolEditPaste,
            this.toolStripSeparator6,
            this.toolEditCancel,
            this.toolStripSeparator7,
            this.toolFormatFont});
            this.notepadToolStrip.Location = new System.Drawing.Point(0, 24);
            this.notepadToolStrip.Name = "notepadToolStrip";
            this.notepadToolStrip.Size = new System.Drawing.Size(584, 25);
            this.notepadToolStrip.TabIndex = 1;
            this.notepadToolStrip.Text = "toolStrip1";
            // 
            // toolFileNew
            // 
            this.toolFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFileNew.Image = global::WF5._1_Text_Editor.Icons.NewFile;
            this.toolFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFileNew.Name = "toolFileNew";
            this.toolFileNew.Size = new System.Drawing.Size(23, 22);
            this.toolFileNew.Text = "Новый документ";
            this.toolFileNew.Click += new System.EventHandler(this.OnNewDocumentClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolFileOpen
            // 
            this.toolFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFileOpen.Image = global::WF5._1_Text_Editor.Icons.Open;
            this.toolFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFileOpen.Name = "toolFileOpen";
            this.toolFileOpen.Size = new System.Drawing.Size(23, 22);
            this.toolFileOpen.Text = "Открыть";
            this.toolFileOpen.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // toolFileSave
            // 
            this.toolFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFileSave.Image = global::WF5._1_Text_Editor.Icons.Save;
            this.toolFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFileSave.Name = "toolFileSave";
            this.toolFileSave.Size = new System.Drawing.Size(23, 22);
            this.toolFileSave.Text = "Сохранить";
            this.toolFileSave.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolEditCopy
            // 
            this.toolEditCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditCopy.Image = global::WF5._1_Text_Editor.Icons.Copy;
            this.toolEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditCopy.Name = "toolEditCopy";
            this.toolEditCopy.Size = new System.Drawing.Size(23, 22);
            this.toolEditCopy.Text = "Копировать";
            this.toolEditCopy.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // toolEditCut
            // 
            this.toolEditCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditCut.Image = global::WF5._1_Text_Editor.Icons.Cut;
            this.toolEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditCut.Name = "toolEditCut";
            this.toolEditCut.Size = new System.Drawing.Size(23, 22);
            this.toolEditCut.Text = "Вырезать";
            this.toolEditCut.Click += new System.EventHandler(this.OnCutClick);
            // 
            // toolEditPaste
            // 
            this.toolEditPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditPaste.Image = global::WF5._1_Text_Editor.Icons.Paste;
            this.toolEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditPaste.Name = "toolEditPaste";
            this.toolEditPaste.Size = new System.Drawing.Size(23, 22);
            this.toolEditPaste.Text = "Вставить";
            this.toolEditPaste.Click += new System.EventHandler(this.OnPasteClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolEditCancel
            // 
            this.toolEditCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditCancel.Image = global::WF5._1_Text_Editor.Icons.Undo;
            this.toolEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditCancel.Name = "toolEditCancel";
            this.toolEditCancel.Size = new System.Drawing.Size(23, 22);
            this.toolEditCancel.Text = "Отменить";
            this.toolEditCancel.Click += new System.EventHandler(this.OnUndoClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolFormatFont
            // 
            this.toolFormatFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFormatFont.Image = global::WF5._1_Text_Editor.Icons.Font;
            this.toolFormatFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFormatFont.Name = "toolFormatFont";
            this.toolFormatFont.Size = new System.Drawing.Size(23, 22);
            this.toolFormatFont.Text = "Шрифт";
            this.toolFormatFont.Click += new System.EventHandler(this.OnFontClick);
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.AutoWordSelection = true;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox.Location = new System.Drawing.Point(0, 49);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(584, 412);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "Text|*.txt";
            this.OpenFileDialog.Filter = "Text|*.txt|RTF Files|*.rtf|All Files|*.*";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "Text|*.txt";
            this.SaveFileDialog.Filter = "Text|*.txt|Rich Text|*.rtf";
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.notepadToolStrip);
            this.Controls.Add(this.notepadMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.notepadMenu;
            this.Name = "Notepad";
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnNotepadClosing);
            this.notepadMenu.ResumeLayout(false);
            this.notepadMenu.PerformLayout();
            this.notepadToolStrip.ResumeLayout(false);
            this.notepadToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip notepadMenu;
        private System.Windows.Forms.ToolStrip notepadToolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuEditCancel;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStripMenuItem menuFormatFont;
        private System.Windows.Forms.ToolStripButton toolFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolFileOpen;
        private System.Windows.Forms.ToolStripButton toolFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolEditCopy;
        private System.Windows.Forms.ToolStripButton toolEditCut;
        private System.Windows.Forms.ToolStripButton toolEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolFormatFont;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.FontDialog FontDialog;
    }
}

