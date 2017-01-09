using System;
using System.IO;
using System.Windows.Forms;

namespace WF4._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            itemListBox.Items.Add(newItemTextBox.Text, false);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = newItemTextBox.Text.Length > 0;
        }

        private void OnEditClick(object sender, EventArgs e)
        {
            var editForm = new EditDialogForm();
            editForm.ShowDialog();
        }

        private void OnItemListSelectedValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = itemListBox.SelectedIndex != -1;
            deleteButton.Enabled = itemListBox.SelectedIndex != -1;

            if (itemListBox.SelectedIndex >= 0 && itemListBox.SelectedIndex + 1 < itemListBox.Items.Count)
            {
                downButton.Enabled = true;
            }
            else
            {
                downButton.Enabled = false;
            }

            if (itemListBox.SelectedIndex > 0 && itemListBox.SelectedIndex + 1 <= itemListBox.Items.Count)
            {
                upButton.Enabled = true;
            }
            else
            {
                upButton.Enabled = false;
            }
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            itemListBox.Items.RemoveAt(itemListBox.SelectedIndex);
        }

        private void OnUpClick(object sender, EventArgs e)
        {
            MoveItem(MoveDirection.Up);
        }

        private void OnDownClick(object sender, EventArgs e)
        {
            MoveItem(MoveDirection.Down);
        }

        private void MoveItem(MoveDirection dir)
        {
            var dirValue = (int) dir;
            var tmpItem = itemListBox.SelectedItem;
            var tmpItemIndex = itemListBox.SelectedIndex;
            var tmpItemCheckState = itemListBox.GetItemCheckState(tmpItemIndex);

            itemListBox.Items.RemoveAt(tmpItemIndex);

            tmpItemIndex += dirValue;
            itemListBox.Items.Insert(tmpItemIndex, tmpItem);
            itemListBox.SelectedIndex = tmpItemIndex;
            itemListBox.SetItemCheckState(tmpItemIndex, tmpItemCheckState);
        }

        private void OnSave(object sender, EventArgs e)
        {
            var textFile = new StreamWriter(new FileStream("example.txt", FileMode.Create, FileAccess.Write));
            using (textFile)
            {
                foreach (var item in itemListBox.CheckedItems)
                {
                    textFile.WriteAsync(item.ToString());
                    textFile.WriteAsync("\r\n");
                }
            }
        }
    }
}
