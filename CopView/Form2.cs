using NonVisualComponentLibraryS.HelperModels;

namespace CopView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSimpleTable_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }
            List<string[,]> datas = new List<string[,]>();
            string[,] data = new string[,] { { "товар", "цена" }, { "яблоко", "10 рублей" } };
            datas.Add(data);
            wordSimpleComponent.SaveData(fileName, "otchet", datas);
        }

        private void buttonComplicatedTable_Click(object sender, EventArgs e)
        {
            DataClass data = new DataClass();
            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }
            WordInfo wordInfo = new WordInfo(fileName, "Тестовая таблица");
            ComponentWordTableConfig<TestData> config = new ComponentWordTableConfig<TestData>(wordInfo, 
                data.getColumnsWidth(2, 2400), data.getRowsHeight(5, 1000), data.GetHeader(2), data.GetHeader(2), data.GetTests());

            /*wordComplicatedComponent.SaveData<TestData>(new ComponentWordTableConfig<TestData>
            {
                WordInfo = new WordInfo
                {
                    FileName = fileName,
                    Title = "Тестовая данная"
                }
                WordInfo = wordInfo,
                ColumnsWidth = data.getColumnsWidth(2, 2400),
                RowsHeight = data.getRowsHeight(5, 1000),
                Headers = data.GetHeader(2),
                PropertiesQueue = data.GetHeader(2),
                ListData = data.GetTests()
            });*/
            wordComplicatedComponent.SaveData<TestData>(config);

        }

        private void button_Gistagram_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }
            List<TestData> data = new List<TestData>();
            data.Add(new TestData { name = "яблоки", value = 1 });
            data.Add(new TestData { name = "арбузы", value = 51 });
            data.Add(new TestData { name = "печенье", value = 11 });
            data.Add(new TestData { name = "суп", value = 43 });
            data.Add(new TestData { name = "каша", value = 32 });
            LocationLegend legend = new LocationLegend();
            gistagramWord.ReportSaveGistogram(fileName, "Крутость продуктов в школе", "продукты", legend, data);
        }
    }
}
