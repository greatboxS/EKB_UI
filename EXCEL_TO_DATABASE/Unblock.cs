using EKANBAN_SYS_LIB;
using EXCEL_TO_DATABASE.Views;
using SYS_MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EXCEL_TO_DATABASE
{
    public class Unblock
    {
        public string UpdateSequenceLog { get; set; }
        public DataTable _ExcelTable { get; set; }
        public DataTable _AutoCutTable { get; set; }
        public DataTable _BeamCutTable { get; set; }
        public int TotalModel1 { get; set; }
        public int TotalModel2 { get; set; }
        public List<PreFilterPo> PreviewPos { get; set; }
        public string SheetName { get; set; }
        public string FilePath { get; set; }
        public int TotalPoPreview { get; set; }
        public int TotalRowPreview { get; set; }
        public int TotalPO_Added { get; set; }
        public int TotalPO_Exist { get; set; }
        public int TotalPO_Error { get; set; }
        public int TotalSeq_Added { get; set; }
        public int TotalSize_Added { get; set; }
        public int TotalSeq_Error { get; set; }
        public int TotalSize_Error { get; set; }
        public int TableType { get; set; }
        public int MaxColumn { get; set; }

        private IDbName database;
        public BuildingQuery BuildingQuery;
        public SequenceQuery SequenceQuery;
        public SysHistoryQuery SysHistoryQuery;
        public ComponentQuery ComponentQuery;

        public Views.ExcelColumnDef ExcelColumnDef { get; set; } = new Views.ExcelColumnDef();
        public Unblock(IDbName _database)
        {
            database = _database;
            BuildingQuery = new BuildingQuery(database);
            SequenceQuery = new SequenceQuery(database);
            SysHistoryQuery = new SysHistoryQuery(database);
            ComponentQuery = new ComponentQuery(database);
        }
        public OriginalPOsequence Handle_getOrderSequence(int _row, int _totalSeq)
        {
            try
            {
                var seq = new OriginalPOsequence
                {
                    TotalSequence = _totalSeq,
                    Quantity = OleDb_readCellNumber(_row, ExcelColumnDef.QuantityCol),
                    SequenceNo = Handle_getSequenceNumber(_row, ExcelColumnDef.SequenceCol),
                    SizeType = Handle_getSizeType(_row)
                };
                seq.OriginalSizes = Handle_getOriginalSize(_row, seq.SizeType != null ? (int)seq.SizeType : 0);

                return seq;
            }
            catch { return null; }
        }

        /// <summary>
        /// Get current PO sequence list
        /// </summary>
        /// <param name="_PreFilterPo"></param>
        /// <returns></returns>
        public List<OriginalPOsequence> Handle_getOriginalPOsequences(PreFilterPo _PreFilterPo)
        {
            try
            {
                var seqs = new List<OriginalPOsequence>();

                int total_sequence = _PreFilterPo.EndAddr - _PreFilterPo.StartAddr + 1;

                for (int i = _PreFilterPo.StartAddr; i <= _PreFilterPo.EndAddr; i++)
                {
                    var currentSeq = Handle_getOrderSequence(i, total_sequence);
                    if (currentSeq != null)
                        seqs.Add(currentSeq);
                }
                return seqs;
            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// Pre Filtering data form excel table
        /// </summary>
        /// <param name="_Table"></param>
        /// <returns></returns>
        public List<PreFilterPo> Handle_getPreFilterOrder()
        {
            PreviewPos = new List<PreFilterPo>();
            TotalRowPreview = _ExcelTable.Rows.Count;

            PreFilterPo po_addr = new PreFilterPo { StartAddr = 1 };


            for (int i = 0; i < TotalRowPreview; i++)
            {
                //string str = OleDb_readCellValue(i, (int)ExcelNum.ArticleColumn);//_ExcelTable.Rows[i][(int)ExcelNum.ArticleColumn] as string;

                string str = "";
                try
                {
                    str = OleDb_readCellValue(i, ExcelColumnDef.ArticleCol);//_ExcelTable.Rows[i][(int)ExcelNum.ArticleColumn] as string;
                }
                catch (Exception e)
                { }

                if (!ExcelColumnDef.NewProductionLineFormat)
                {
                    if (str == null)
                        continue;

                    if (str.IndexOf("ART") > -1 || str.IndexOf("TOTAL") > -1)
                    {
                        if (i > 0)
                        {
                            po_addr.EndAddr = i - 1;
                            try
                            {
                                if (OleDb_readCellValue(i, ExcelColumnDef.QuantityCol) != null)
                                    po_addr.PO.Quantity = OleDb_readCellNumber(i, ExcelColumnDef.QuantityCol);

                                ProductionLine line = null;
                                if (ExcelColumnDef.NewProductionLineFormat)
                                {
                                    line = BuildingQuery.GetProductionLineByName(po_addr.PO.Line);
                                }
                                else
                                {
                                    line = BuildingQuery.GetProductionLineByCode(po_addr.PO.Line);
                                }

                                if (line != null)
                                {
                                    po_addr.PO.ProductionLine_Id = line.id;
                                    PreviewPos.Add(po_addr);
                                }
                            }
                            catch (Exception e)
                            { }

                            po_addr = new PreFilterPo { StartAddr = i + 1 };
                        }

                        try
                        {
                            po_addr.PO = Handle_getOriginalPO(po_addr.StartAddr);
                        }
                        catch (Exception e)
                        { }
                    }
                }
                else
                {
                    if (str == null)
                    {
                        //get total qty
                        po_addr.EndAddr = i - 1;
                        try
                        {
                            object ok = _ExcelTable.Rows[i];
                            if (OleDb_readCellValue(i, ExcelColumnDef.QuantityCol) != null)
                                po_addr.PO.Quantity = OleDb_readCellNumber(i, ExcelColumnDef.QuantityCol);

                            ProductionLine line = null;
                            if (ExcelColumnDef.NewProductionLineFormat)
                            {
                                line = BuildingQuery.GetProductionLineByName(po_addr.PO.Line);
                            }
                            else
                            {
                                line = BuildingQuery.GetProductionLineByCode(po_addr.PO.Line);
                            }

                            if (line != null)
                            {
                                po_addr.PO.ProductionLine_Id = line.id;
                                PreviewPos.Add(po_addr);
                            }
                        }
                        catch (Exception e)
                        { }

                       
                    }
                    else
                    {
                        if (str.IndexOf("ART") > -1 || str.IndexOf("TOTAL") > -1)
                        {
                            po_addr = new PreFilterPo { StartAddr = i + 1 };
                            try
                            {
                                po_addr.PO = Handle_getOriginalPO(po_addr.StartAddr);
                            }
                            catch (Exception e)
                            { }
                        }
                    }
                }

            }
            return PreviewPos;
        }

        /// <summary>
        /// Read Po from excel file
        /// </summary>
        /// <param name="_row"></param>
        /// <returns></returns>
        public OriginalPO Handle_getOriginalPO(int _row)
        {
            var new_po = new OriginalPO();
            try
            {
                string po = OleDb_readCellValue(_row, ExcelColumnDef.PoCol);

                string extend = OleDb_readCellValue(_row, ExcelColumnDef.ExtendCol);

                new_po.Line = OleDb_readCellValue(_row, ExcelColumnDef.ProductionLineCol);

                new_po.PoNumber = po + extend;

                if (ExcelColumnDef.EnableArtilce)
                    new_po.Article = OleDb_readCellValue(_row, ExcelColumnDef.ArticleCol);

                if (ExcelColumnDef.EnableModelCol)
                    new_po.Model = OleDb_readCellValue(_row, ExcelColumnDef.ModelNumberCol);

                if (ExcelColumnDef.EnableModelName)
                    new_po.ModelName = OleDb_readCellValue(_row, ExcelColumnDef.ModelNameCol);

                if (ExcelColumnDef.EnableCuttingDate)
                    new_po.CuttingDate = OleDb_readCellValue(_row, ExcelColumnDef.CuttingDateCol);

                if (ExcelColumnDef.EnableStitchingDate)
                    new_po.StitchingDate = OleDb_readCellValue(_row, ExcelColumnDef.StitchingDateCol);

            }
            catch { }
            return new_po;
        }

        public List<OriginalSize> Handle_getOriginalSize(int _row, int _type)
        {
            try
            {
                var seq_sizes = new List<OriginalSize>();

                if (_type == 0)
                {
                    for (int i = ExcelColumnDef.StartMen; i < ExcelColumnDef.StopMen; i++)
                    {
                        var seq_s = new OriginalSize();

                        string cell = OleDb_readCellValue(_row, i);

                        if (cell != null)
                        {

                            seq_s.Quantity = OleDb_readCellNumber(_row, i);
                            seq_s.SizeId = Handle_getSizeId_Root(i, _type);
                            //seq_s.SizeId = Handle_getSizeId(i, _type);
                            seq_sizes.Add(seq_s);
                        }
                    }
                }
                else
                {
                    for (int i = ExcelColumnDef.StartKidFirst; i < ExcelColumnDef.StopKidFirst; i++)
                    {
                        var seq_s = new OriginalSize();

                        string cell = OleDb_readCellValue(_row, i);

                        if (cell != null)
                        {
                            seq_s.Quantity = OleDb_readCellNumber(_row, i);
                            seq_s.SizeId = Handle_getSizeId_Root(i, _type);
                            //seq_s.SizeId = Handle_getSizeId(i, _type);
                            seq_sizes.Add(seq_s);
                        }
                    }
                }
                return seq_sizes;
            }
            catch { return null; }
        }

        public int Handle_getSequenceNumber(int _row, int _column)
        {
            int seq_no = 0;
            string cell_text = OleDb_readCellValue(_row, _column);
            if (cell_text != null)
            {
                string[] num = cell_text.Split(new string[] { "#" }, StringSplitOptions.None);
                try
                {
                    seq_no = Convert.ToInt32(num[1]);
                }
                catch { seq_no = 0; }
            }
            return seq_no;
        }

        public void ClearComponent()
        {
            ComponentQuery.ClearAllModelComponents();
        }

        public int Handle_getSizeId_Root(int _column, int _type)
        {
            int sizeId = 0;
            switch (_type)
            {
                case 1:

                    if (_column == ExcelColumnDef.StartKidFirst)
                    {
                        sizeId = ExcelColumnDef.StartKidSecSizeId;
                    }

                    if (_column > ExcelColumnDef.StartKidFirst && _column <= ExcelColumnDef.StopKidFirst)
                    {
                        sizeId = _column - ExcelColumnDef.StartKidFirst + ExcelColumnDef.StartKidSecSizeId + 1;
                    }

                    if (_column >= ExcelColumnDef.StartKidSec && _column <= ExcelColumnDef.StopKidSec)
                    {
                        sizeId = _column - ExcelColumnDef.StartKidSec + ExcelColumnDef.StartKidSecSizeId;
                    }
                    // kid size
                    break;

                default:
                    sizeId = _column - ExcelColumnDef.StartMen + ExcelColumnDef.StartMenSizeId;
                    break;
            }

            return sizeId;

        }
        public int Handle_getSizeId(int _column, int _type)
        {
            int size_id = 0;
            switch (_type)
            {
                case 1:
                    switch (_column)
                    {
                        case (int)ExcelNum.Start_KidColumn:
                            size_id = 1;
                            break;
                        case (int)ExcelNum.Start_KidColumn + 1:
                            size_id = 3;
                            break;
                        case (int)ExcelNum.Start_KidColumn + 2:
                            size_id = 5;
                            break;
                        case (int)ExcelNum.Start_KidColumn + 3:
                            size_id = 7;
                            break;
                        case (int)ExcelNum.Start_KidColumn + 4:
                            size_id = 9;
                            break;
                        case (int)ExcelNum.Start_KidColumn + 5:
                            size_id = 11;
                            break;


                        default:
                            if (_column >= (int)ExcelNum.Start_KidColumn + 6 && _column <= (int)ExcelNum.End_KidColumn)
                            {
                                size_id = _column - 2;
                            }
                            break;
                    }
                    break;


                default:
                    if (_column >= (int)ExcelNum.Start_MenColumn)
                    {
                        size_id = _column - 27;
                    }
                    break;
            }
            return size_id;
        }

        public int Handle_getSizeType(int _row)
        {
            int type = 0;
            for (int i = 0; i < OleDb_ReadRowData(_row).Count; i++)
            {
                string cell_text = OleDb_readCellValue(_row, i);
                if (cell_text != null
                    && i <= ExcelColumnDef.StopKidSec
                    && i >= ExcelColumnDef.StartKidFirst)
                {
                    type = 1;
                }
            }
            return type;
        }

        /// <summary>
        /// Main funcntion
        /// </summary>
        public void Handle_StartAdding()
        {
            UpdateSequenceLog = "";
            if (PreviewPos == null)
            {
                UpdateSequenceLog = "PreviewPos is null";
                return;
            }

            foreach (var item in PreviewPos)
            {

                if (item.PO.Quantity == 0 || item.PO.Quantity == null)
                    continue;
                else
                {
                    // add new po to database
                    int checkPoException = SequenceQuery.CheckOriginalPo(item.PO);

                    /// <returns> 
                    /// 0 not found => add new 
                    /// 1 diff article >> update 
                    /// 2 diff productionline  >> update line Id
                    /// 3 same po same article same modelname same qty >> skip
                    /// </returns>
                    switch (checkPoException)
                    {
                        case 0:

                            // add new Po
                            var seq = Handle_getOriginalPOsequences(item);
                            if (seq != null)
                            {
                                item.PO.OriginalPOsequences = seq;

                                if (SequenceQuery.AddNewOriginalPo(item.PO))
                                {
                                    TotalPO_Added++;
                                    UpdateSequenceLog += $"Add new Po:{item.PO.PoNumber}, Line: {item.PO.Line}, Status: Success\r\n";
                                }
                                else
                                {
                                    TotalPO_Error++;
                                    UpdateSequenceLog += $"Add new Po:{item.PO.PoNumber}, Line: {item.PO.Line}, Status: Success\r\n";
                                }
                            }
                            break;
                        case 1:
                            UpdateSequenceLog += $"Update Article of Po:{item.PO.PoNumber}, Article: {item.PO.Article}, Status: Success\r\n";
                            break;
                        case 2:
                            UpdateSequenceLog += $"Update Production Line of Po:{item.PO.PoNumber}, Line: {item.PO.Line}, Status: Success\r\n";
                            break;
                        case 3:
                            //skip
                            UpdateSequenceLog += $"Skip Po:{item.PO.PoNumber}, Line: {item.PO.Line}, Status: Error\r\n";
                            break;
                    }
                }
            }
        }

        public int OleDb_readCellNumber(int _row, int _column)
        {
            string cell = OleDb_readCellValue(_row, _column);
            if (cell != null)
                return Convert.ToInt32(cell);
            else return 0;
        }

        public string OleDb_readCellValue(int _row, int _column)
        {
            if (_ExcelTable.Rows[_row][_column] as string != null)
                return (_ExcelTable.Rows[_row][_column] as string).ToUpper().Trim();
            else
                return null;
        }

        public List<object> OleDb_ReadRowData(int _index)
        {
            if (_ExcelTable.Rows.Count > _index)
                return _ExcelTable.Rows[_index].ItemArray.ToList();
            else
                return null;
        }

        /// <summary>
        /// Read table from excel file
        /// </summary>
        /// <param name="_Path"></param>
        /// <returns></returns>
        public DataTable OleDb_readTable(string _Path)
        {
            _ExcelTable = new DataTable();
            bool hasHeaders = false;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            string newPath = "";

            try
            {
                Random random = new Random();
                int code = random.Next();
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                newPath = $"{desktopPath}\\{code}.xlsx";
                File.Copy(_Path, newPath);


                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + newPath + ";Extended Properties=\"Excel 12.0;HDR=No;IMEX=1\"";
                using (OleDbConnection conn = new OleDbConnection(strConn))
                {
                    conn.Open();
                    DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    string sheet_name = string.Empty;

                    List<string> sheetName = new List<string>();
                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        sheetName.Add(schemaTable.Rows[i]["TABLE_NAME"].ToString());
                    }

                    SelectNameForm selectNameForm = new SelectNameForm(sheetName.ToArray());

                    if(selectNameForm.ShowDialog() == DialogResult.OK)
                    {
                        sheet_name = selectNameForm.SheetName;
                    }
                    else
                    {
                        if (ExcelColumnDef.EnableSelectSheetIndex)
                        {
                            sheet_name = schemaTable.Rows[ExcelColumnDef.ExcelSheetNumber]["TABLE_NAME"].ToString();
                        }
                        else
                        {
                            foreach (DataRow name in schemaTable.Rows)
                            {
                                if (name["TABLE_NAME"].ToString().IndexOf("160") > -1
                                    && !(name["TABLE_NAME"].ToString().IndexOf("Print") > -1)
                                    && !(name["TABLE_NAME"].ToString().IndexOf("base") > -1))
                                {
                                    sheet_name = name["TABLE_NAME"].ToString();
                                }
                            }
                        }
                    }

                    string query = $"SELECT * FROM [{sheet_name}]";

                    OleDbDataAdapter olead_adapter = new OleDbDataAdapter(query, conn);

                    olead_adapter.Fill(_ExcelTable);
                }
            }
            catch { }

            try
            {
                File.Delete(newPath);
            }
            catch { }

            return _ExcelTable;
        }

        public void OledB_ReadComponentTable(string _Path)
        {
            _AutoCutTable = new DataTable();
            _BeamCutTable = new DataTable();
            string newPath = "";

            try
            {
                Random random = new Random();
                int code = random.Next();
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                newPath = $"{desktopPath}\\{code}.xlsx";
                File.Copy(_Path, newPath);

                string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + newPath + ";Extended Properties=\"Excel 12.0;HDR=No;IMEX=1\"";
                using (OleDbConnection conn = new OleDbConnection(strConn))
                {
                    conn.Open();
                    DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    string sheet_name = string.Empty;

                    string query = $"SELECT * FROM [{schemaTable.Rows[0]["TABLE_NAME"]}]";
                    OleDbDataAdapter olead_adapter = new OleDbDataAdapter(query, conn);
                    olead_adapter.Fill(_AutoCutTable);

                    query = $"SELECT * FROM [{schemaTable.Rows[2]["TABLE_NAME"]}]";
                    olead_adapter = new OleDbDataAdapter(query, conn);
                    olead_adapter.Fill(_BeamCutTable);


                }
            }
            catch (Exception e)
            { }
            try
            {
                File.Delete(newPath);
            }
            catch { }
        }
    }

    public class PreFilterPo
    {
        public int StartAddr { get; set; }
        public int EndAddr { get; set; }
        public int Error { get; set; } = 0;
        public OriginalPO PO { get; set; }
    }
}
