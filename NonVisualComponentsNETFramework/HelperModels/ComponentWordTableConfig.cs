using NonVisualComponentsNETFramework.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonVisualComponentsNETFramework.HelperModels
{
    public class ComponentWordTableConfig<T>
    {       
        public WordInfo WordInfo { get; set; }

        public List<int> ColumnsWidth { get; set; }
        public List<int> RowsHeight { get; set; }
        public List<string> Headers { get; set; }
        public List<string> PropertiesQueue { get; set; }
        public List<T> ListData { get; set; }

       public ComponentWordTableConfig(WordInfo wordInfo, List<int> columnsWidth, List<int> rowsHeight, List<string> headers, List<string> propertiesQueue, List<T> listData)
        {
            WordInfo = wordInfo;
            ColumnsWidth = columnsWidth;
            RowsHeight = rowsHeight;
            Headers = headers;
            PropertiesQueue = propertiesQueue;
            ListData = listData;
        }
    }
}
