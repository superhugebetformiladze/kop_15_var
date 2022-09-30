using System.Windows.Forms;
using WinFormsControlLibraryS;

namespace CopView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxControl.Add(textBoxInputItems.Text);
            textBoxInputItems.Clear();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxControl.Clear();
        }

        private void ButtonAddText_Click(object sender, EventArgs e)
        {
            labelNumb.Text = "Число: ";
            labelNumb.Text += textBoxControl.ValueTextBox.ToString();
        }
        public class MyObject
        {
            public string name { get; set; }

            public int count { get; set; }
        }
        private void dataGridViewControl1_Load(object sender, EventArgs e)
        {
            MyObject firstObj = new MyObject();
            firstObj.count = 5;
            firstObj.name = "First";
            MyObject secondObj = new MyObject();
            secondObj.count = 10;
            secondObj.name = "Second";
            ColumnsDataGrid column = new ColumnsDataGrid();
            column.CountColumn = 2;
            column.NameColumn = new string[] { "name", "value" };
            column.Width = new int[] { 100, 100 };
            column.Visible = new bool[] { true, true };
            column.PropertiesObject = new string[] { "name", "value" };
            dataGridViewControl1.ConfigColumn(column);
            dataGridViewControl1.AddRow(firstObj);
            dataGridViewControl1.AddRow(secondObj);
        }

        private void buttonClearDataGrid_Click(object sender, EventArgs e)
        {
            dataGridViewControl1.ClearDataGrid();
        }

        private void listBoxControl_Load(object sender, EventArgs e)
        {
            listBoxControl.Add("Москва");
            listBoxControl.Add("Ташкент");
            listBoxControl.Add("Ульяновск");
            listBoxControl.SelectedItem = "Ульяновск";
        }


    }
}