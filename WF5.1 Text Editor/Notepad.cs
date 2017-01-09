using System;
using System.IO;
using System.Windows.Forms;

namespace WF5._1_Text_Editor
{
    public partial class Notepad : Form
    {
        private string _documentPath;

        public bool IsDocumentSaved { get; private set; }
        public bool IsNewDocument { get; private set; }

        public Notepad()
        {
            InitializeComponent();
            NewDocument();
        }

        private DialogResult SaveClosingDocument()
        {
            var result = DialogResult.OK;
            if (IsDocumentSaved == false)
            {
                switch (MessageBox.Show("Вы хотите сохранить документ перед его закрытием?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        result = DialogResult.Cancel;
                        break;
                }
            }
            return result;
        }

        private void NewDocument()
        {
            Text = "Новый документ";
            textBox.Clear();
            textBox.ResetText();
            IsDocumentSaved = true;
            IsNewDocument = true;
        }

        private void OpenFile()
        {
            switch (SaveClosingDocument())
            {
                case DialogResult.OK:
                    if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            var file = new FileStream(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read);
                            _documentPath = OpenFileDialog.FileName;
                            using (var reader = new StreamReader(file))
                            {
                                switch (Path.GetExtension(OpenFileDialog.FileName))
                                {
                                    case ".txt":
                                        textBox.Text = reader.ReadToEnd();
                                        break;
                                    case ".rtf":
                                        textBox.Rtf = reader.ReadToEnd();
                                        break;
                                }
                                Text = Path.GetFullPath(OpenFileDialog.FileName);

                                IsNewDocument = false;
                                IsDocumentSaved = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void Save()
        {
            if (IsNewDocument == true)
            {
                SaveAs();
            }
            else if (IsDocumentSaved == false)
            {
                SaveFile(_documentPath);
            }
        }

        private void SaveAs()
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(SaveFileDialog.FileName);
            }
        }

        private void SaveFile(string path)
        {
            try
            {
                var file = new FileStream(path, FileMode.Truncate, FileAccess.Write);
                using (var writer = new StreamWriter(file))
                {
                    switch (Path.GetExtension(file.Name))
                    {
                        case ".txt":
                            writer.Write(textBox.Text);
                            break;
                        case ".rtf":
                            writer.Write(textBox.Rtf);
                            break;
                    }
                    IsDocumentSaved = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnFontClick(object sender, EventArgs e)
        {
            var result = FontDialog.ShowDialog();

            switch(result)
            {
                case DialogResult.OK:
                    textBox.SelectionFont = FontDialog.Font;
                    textBox.SelectionColor = FontDialog.Color;
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OnSaveAsClick(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void OnUndoClick(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            Save();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            IsDocumentSaved = false;
        }

        private void OnNewDocumentClick(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void OnNotepadClosing(object sender, FormClosingEventArgs e)
        {
            switch(SaveClosingDocument())
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
