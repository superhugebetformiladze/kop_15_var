﻿using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NonVisualComponentsNETFramework.HelperModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NonVisualComponentsNETFramework
{
    public partial class WordComplicatedComponent : Component
    {
        public WordComplicatedComponent()
        {
            InitializeComponent();
        }

        public WordComplicatedComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SaveData<T>(ComponentWordTableConfig<T> config)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument
             .Create(config.WordInfo.FileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body docBody = mainPart.Document.AppendChild(new Body());

                docBody.AppendChild(CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> { (config.WordInfo.Title, new
                        WordTextProperties {Bold = true, Size = "24", } ) },
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationValues = JustificationValues.Center
                    }
                }));
                CheckDataAndProperties(config);
                Table table = CreateWordTable(config);
                // Добавляем таблицу в документ
                docBody.AppendChild(table);
                wordDocument.MainDocumentPart.Document.Save();
            }
        }

        /// <summary>
        /// Метод создания таблицы. Принимает на вход ComponentWordTableConfig со всеми необходимыма параметрами, исходя
        /// из которых настраивает и создает таблицу.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="config"></param>

        private static Table CreateWordTable<T>(ComponentWordTableConfig<T> config)
        {
            Table table = new Table();

            TableProperties tblProp = new TableProperties(
                new TableBorders(
                    new TopBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 14
                    },
                    new BottomBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 14
                    },
                    new LeftBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 14
                    },
                    new RightBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 14
                    },
                    new InsideHorizontalBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 10
                    },
                    new InsideVerticalBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 12
                    }
                )
            );

            table.AppendChild(tblProp);

            // Создаём строку-шапку

            TableRow tableRowHeader = new TableRow();
            tableRowHeader.Append(
                new TableRowProperties(
                    new TableRowHeight() { Val = Convert.ToUInt32(config.RowsHeight[0]) }
                )
            );

            for (int i = 0; i < config.Headers.Count; i++)
            {
                TableCell cellHeader = new TableCell();
                cellHeader.Append(new TableCellProperties(
                    new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = config.ColumnsWidth[i].ToString() },
                    new Bold())
                );
                cellHeader.Append(CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> { (config.Headers[i], new
                        WordTextProperties {Bold = true, Size = "24", } ) },
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationValues = JustificationValues.Center
                    }
                }));
                tableRowHeader.Append(cellHeader);
            }
            table.Append(tableRowHeader);

            // Получаем поля
            var property = new List<PropertyInfo>();
            var type = typeof(T);
            for (int i = 0; i < config.PropertiesQueue.Count; i++)
            {
                var propInfo = type.GetProperty(config.PropertiesQueue[i]);
                if (propInfo == null)
                {
                    throw new Exception("Not found property" + config.PropertiesQueue[i]);
                }
                property.Add(propInfo);
            }

            //бегаем по нашим данным, одна итерация = одна строка данных
            for (int i = 0; i < config.ListData.Count; i++)
            {
                TableRow tableRow = new TableRow();
                tableRow.Append(new TableRowProperties(
                new TableRowHeight() { Val = Convert.ToUInt32(config.RowsHeight[i]) })
                );
                var Headertext = property[0].GetValue(config.ListData[i]);
                TableCell HeadertableCell = new TableCell();
                HeadertableCell.Append(new TableCellProperties(
                    new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = config.ColumnsWidth[0].ToString() }));
                HeadertableCell.Append(CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> { (Headertext.ToString(), new
                        WordTextProperties {Bold = true, Size = "24", } ) },
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationValues = JustificationValues.Center
                    }
                }));
                tableRow.Append(HeadertableCell);
                //бегаем по полям наших данных, одна итерация = одна запись в строке
                for (int j = 1; j < property.Count; j++)
                {
                    var text = property[j].GetValue(config.ListData[i]);
                    TableCell tableCell = new TableCell();
                    tableCell.Append(new TableCellProperties(
                        new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = config.ColumnsWidth[j].ToString() }));
                    tableCell.Append(new Paragraph(new Run(new Text(text.ToString()))));
                    tableRow.Append(tableCell);
                }
                table.Append(tableRow);
            }
            return table;
        }

        public void CheckDataAndProperties<T>(ComponentWordTableConfig<T> config)
        {
            if (string.IsNullOrEmpty(config.WordInfo.FileName) || string.IsNullOrEmpty(config.WordInfo.Title))
            {
                throw new Exception("Empty path or title");
            }
            if (config.Headers == null || config.Headers.Count == 0)
            {
                throw new Exception("Not found table header");
            }
            if (config.PropertiesQueue == null || config.PropertiesQueue.Count == 0)
            {
                throw new Exception("Not found property queue");
            }
            if (config.ColumnsWidth == null || config.ColumnsWidth.Count == 0)
            {
                throw new Exception("Not found columns width");
            }
            if (config.RowsHeight == null || config.RowsHeight.Count == 0)
            {
                throw new Exception("Not found rows height");
            }
            if (config.ListData == null || config.ListData.Count == 0)
            {
                throw new Exception("Not found list data");
            }
            if (config.PropertiesQueue.Count != config.ColumnsWidth.Count ||
                config.ColumnsWidth.Count != config.Headers.Count ||
                config.RowsHeight.Count != config.ListData.Count)
            {
                throw new Exception("Invalid all property! Data inconsistent");
            }
        }
        /// <summary>
        /// Создание абзаца с текстом
        /// </summary>
        /// <param name="paragraph"></param>
        /// <returns></returns>
        private static Paragraph CreateParagraph(WordParagraph paragraph)
        {
            if (paragraph != null)
            {
                Paragraph docParagraph = new Paragraph();

                docParagraph.AppendChild(CreateParagraphProperties(paragraph.TextProperties));
                foreach (var run in paragraph.Texts)
                {
                    Run docRun = new Run();
                    RunProperties properties = new RunProperties();
                    properties.AppendChild(new FontSize { Val = run.Item2.Size });
                    if (run.Item2.Bold)
                    {
                        properties.AppendChild(new Bold());
                    }
                    docRun.AppendChild(properties);
                    docRun.AppendChild(new Text
                    {
                        Text = run.Item1,
                        Space =
                   SpaceProcessingModeValues.Preserve
                    });
                    docParagraph.AppendChild(docRun);
                }
                return docParagraph;
            }
            return null;
        }

        /// <summary>
        /// Задание форматирования для абзаца
        /// </summary>
        /// <param name="paragraphProperties"></param>
        /// <returns></returns>
        private static ParagraphProperties CreateParagraphProperties(WordTextProperties
       paragraphProperties)
        {
            if (paragraphProperties != null)
            {
                ParagraphProperties properties = new ParagraphProperties();
                properties.AppendChild(new Justification()
                {
                    Val = paragraphProperties.JustificationValues
                });
                properties.AppendChild(new SpacingBetweenLines
                {
                    LineRule = LineSpacingRuleValues.Auto
                });
                properties.AppendChild(new Indentation());
                ParagraphMarkRunProperties paragraphMarkRunProperties = new
               ParagraphMarkRunProperties();
                if (!string.IsNullOrEmpty(paragraphProperties.Size))
                {
                    paragraphMarkRunProperties.AppendChild(new FontSize
                    {
                        Val =
                   paragraphProperties.Size
                    });
                }
                properties.AppendChild(paragraphMarkRunProperties);
                return properties;
            }
            return null;
        }
    }
}
