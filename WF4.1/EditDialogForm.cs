using System;
using System.Windows.Forms;

namespace WF4._1
{
    public partial class EditDialogForm : Form
    {
        private readonly CheckedListBox _parentItemList;
        public EditDialogForm()
        {
            InitializeComponent();

            var itemListCollection = Form.ActiveForm.Controls.Find("itemListBox", searchAllChildren: false);
            _parentItemList = (CheckedListBox)itemListCollection[0];

            nameTextBox.Text = (string) _parentItemList.SelectedItem;
            itemCheckBox.CheckState = _parentItemList.GetItemCheckState(_parentItemList.SelectedIndex);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = nameTextBox.Text.Length > 0;
        }

        private void OnOkButton(object sender, EventArgs e)
        {
            if (Form.ActiveForm != null)
            {
                var tmpItemIndex = _parentItemList.SelectedIndex;
                _parentItemList.Items.RemoveAt(tmpItemIndex);
                _parentItemList.Items.Insert(tmpItemIndex, nameTextBox.Text);
                _parentItemList.SetItemCheckState(tmpItemIndex, itemCheckBox.CheckState);
            }
        }
    }
}
