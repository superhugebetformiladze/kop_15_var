using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLibraryS
{
    public partial class ListBoxControl : UserControl
    {
        private event EventHandler SelectedElementChange;
        private object _checkedItems;
        public ListBoxControl()
        {
            InitializeComponent();
            listBox1.SelectedValueChanged += (sender, e)
                => {
                    SelectedElementChange?.Invoke(sender, e);
                    CheckedItems = listBox1.SelectedItems;
                };
        }
        public void Add(string str)
        {
            listBox1.Items.Add(str);
        }
        public void Clear()
        {
            listBox1.Items.Clear();
        }

        public object CheckedItems
        {
            get
            {
                return _checkedItems;
            }
            set
            {
                if (listBox1.SelectedItems == null)
                {
                    _checkedItems = "";
                }
                else
                {
                    _checkedItems = value;
                }
            }
        }
    }
}
