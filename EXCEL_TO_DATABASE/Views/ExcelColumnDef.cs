using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL_TO_DATABASE.Views
{
    public class ExcelColumnDef
    {
        public int PoCol { get; set; }
        public int ExtendCol { get; set; }
        public int ArticleCol { get; set; }
        public bool  EnableArtilce { get; set; }
        public int QuantityCol { get; set; }
        public int ModelNumberCol { get; set; }
        public bool EnableModelCol { get; set; }
        public int  ModelNameCol { get; set; }
        public bool  EnableModelName { get; set; }
        public int ProductionLineCol { get; set; }
        public int StitchingDateCol { get; set; }
        public int CuttingDateCol { get; set; }
        public bool EnableCuttingDate { get; set; }
        public bool EnableStitchingDate { get; set; }

        public int SequenceCol { get; set; }

        public int StartKidFirst { get; set; }
        public int StopKidFirst { get; set; }
        public int StartKidSec { get; set; }
        public int StopKidSec { get; set; }
        public int StartMen { get; set; }
        public int StopMen { get; set; }

        public int StartKidFirstSizeId { get; set; }
        public int StopKidFirstSizeid { get; set; }
        public int StartKidSecSizeId { get; set; }
        public int StopKidSecSizeId { get; set; }
        public int StartMenSizeId { get; set; }
        public int StopMenSizeId { get; set; }

        public bool NewProductionLineFormat { get; set; }
        public int ExcelSheetNumber { get; set; }
        public bool  EnableSelectSheetIndex { get; set; }
    }
}
