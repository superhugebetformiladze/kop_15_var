using NonVisualComponentLibraryS;
using NonVisualComponentLibraryS.HelperModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string[,] data = new string[,] { { "Anya", "Vasya" }, { "Dasha", "Mark" } };
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
            wordComplicatedComponent.SaveData<TestData>(new ComponentWordTableConfig<TestData>
            {
                WordInfo = new WordInfo
                {
                    FileName = fileName,
                    Title = "Тестовая данная"
                },
                ColumnsWidth = data.getColumnsWidth(2, 2400),
                RowsHeight = data.getRowsHeight(5, 1000),
                Headers = data.GetHeader(2),
                PropertiesQueue = data.GetHeader(2),
                ListData = data.GetTests()
            });
        }

    }
}
