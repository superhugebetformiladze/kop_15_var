using Xceed.Document.NET;
using Xceed.Words.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NonVisualComponentLibraryS.HelperModels;

namespace NonVisualComponentLibraryS
{
    public partial class GistagramWord : Component
    {
        public GistagramWord()
        {
            InitializeComponent();
        }

        public GistagramWord(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void ReportSaveGistogram(string filename, string title, string nameGistogram,
            LocationLegend legend, List<TestData> list)
        {
            if (string.IsNullOrEmpty(filename) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(nameGistogram) || list.Count == 0)
            {
                throw new Exception("Fields is empty!");
            }
            CreateDoc(filename, title, nameGistogram, legend, list);

        }
        /// <summary>
        /// Создание документа
        /// </summary>
        private void CreateDoc(string fileName, string title, string nameDiagram, LocationLegend chartLegendPosition, List<TestData> list)
        {
            try
            {
                DocX document = DocX.Create(fileName);
                document.InsertParagraph(title);
                document.Paragraphs[0].Direction = Direction.RightToLeft;
                document.Paragraphs[0].Alignment = Alignment.center;
                document.Paragraphs[0].FontSize(20);
                document.Paragraphs[0].Bold();
                // создаём линейную диаграмму
                BarChart gistogramChart = new BarChart();
                // добавляем легенду 
                gistogramChart.AddLegend((ChartLegendPosition)chartLegendPosition, false);
                Series seriesFirst = new Series(nameDiagram);
                // заполняем данными
                seriesFirst.Bind(list, "name", "value");
                // создаём набор данных и добавляем на диаграмму
                gistogramChart.AddSeries(seriesFirst);
                document.InsertChart(gistogramChart);
                document.Save();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
