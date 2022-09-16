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
        private void listBoxControl_SelectedChangedEvent(object sender, EventArgs e)
        {
            labelCurrent.Text = listBoxControl.ValueList;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            textBoxInputItems.Text = listBoxControl.ValueList;
            Console.WriteLine(listBoxControl.ValueList);
        }
        private void ButtonAddText_Click(object sender, EventArgs e)
        {
            labelNumb.Text += textBoxControl.ValueTextBox.ToString();
        }
    }
}