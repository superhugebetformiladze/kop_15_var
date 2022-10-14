using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonVisualComponentLibraryS.HelperModels
{
    public class WordInfo
    {
        public WordInfo(string fileName, string title)
        {
            FileName = fileName;
            Title = title;
        }

        public string FileName { get; set; }
        public string Title { get; set; }
    }
}
