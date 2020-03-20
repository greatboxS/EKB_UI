using EKANBAN_SYS_LIB;
using SYS_MODELS;
using SYS_MODELS._ENUM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MAIN_UI
{
    public partial class MFORM : Form
    {
        static IDbName database = _SERVER.ServerName.Database;
        public bool ViewAllCart { get; set; }
        public bool ModelNameFilter { get; set; }

        BuildingQuery BuildingQuery = new BuildingQuery(database);
        ScheduleQuery ScheduleQuery = new ScheduleQuery(database);
        EKanbanTaskQuery EKanbanTaskQuery = new EKanbanTaskQuery(database);
        SysHistoryQuery SysHistoryQuery = new SysHistoryQuery(database);
        SequenceQuery SequenceQuery = new SequenceQuery(database);
        EmployeeQuery EmployeeQuery = new EmployeeQuery(database);
        ComponentQuery ComponentQuery = new ComponentQuery(database);
        StockQuery StockQuery = new StockQuery(database);

        //
        private ICollection<ScheduleClass> ScheduleClasses;
        private ProductionLine SelectedProductionLine = new ProductionLine();
        private Building SelectedBuilding = new Building();
        private ICollection<EKanbanDevice> eKanbanDevices = new List<EKanbanDevice>();
        private ICollection<Schedule> Schedules = new List<Schedule>();
        private Schedule SelectedSchedule = new Schedule();
        private string SelectedScheduleLine { get; set; }
        private ScheduleClass SelectedScheduleClass = new ScheduleClass();
        private ICollection<ShoeComponent> SelectShoeComponent = new List<ShoeComponent>();
        private OriginalPOsequence SelectedSequence = new OriginalPOsequence();
        private OriginalPO SelectedOriginalPo = new OriginalPO();
        private EKanbanDevice SelectedEKanbanDevice = new EKanbanDevice();
        private EKanbanInterface SelectedEKanbanInterface = new EKanbanInterface();
        ContextMenu lbScheduleMenuContext;

        MANAGER_FORM.MANG_FORM MANG_FORM;
        public MFORM()
        {
            InitializeComponent();
            Checkbox_ViewAllCart.DataBindings.Add(new Binding("Checked", this, "ViewAllCart", false, DataSourceUpdateMode.OnPropertyChanged));
            chbx_modelFilter.DataBindings.Add(new Binding("Checked", this, "ModelNameFilter", false, DataSourceUpdateMode.OnPropertyChanged));
            lbScheduleMenuContext = new ContextMenu(new MenuItem[] { new MenuItem { Text = "Edit" } });
            lbScheduleMenuContext.MenuItems[0].Click += ScheduleEditClick;
            lbSchedule.ContextMenu = lbScheduleMenuContext;
            MANG_FORM = new MANAGER_FORM.MANG_FORM();
        }

        private void ScheduleEditClick(object sender, EventArgs e)
        {
            if (lbSchedule.SelectedItem == null)
                return;
            var currentSchedule = lbSchedule.SelectedItem as Schedule;
            Views.EditScheduleForm editScheduleForm = new Views.EditScheduleForm(currentSchedule);
            editScheduleForm.ShowDialog();
        }

        private void MForm_Load(object sender, EventArgs e)
        {
            DS_Building.DataSource = BuildingQuery.GetBuildings();
            SelectBuildingChanges();

            //cbx_ScheduleTime.Items.Clear();
            //for (int i = 1; i <= 12; i++)
            //{
            //    cbx_ScheduleTime.Items.Add($"{i.ToString("00")}/{DateTime.Now.Year}");
            //}
            //cbx_ScheduleTime.SelectedIndex = DateTime.Now.Month - 1;
            ScheduleClasses = new List<ScheduleClass>();
            ScheduleClasses = ScheduleQuery.GetScheduleClasses();
            DS_ScheduleClass.DataSource = ScheduleClasses;
        }
        private void SelectBuildingChanges()
        {
            if (cbx_Building.SelectedItem == null)
                return;

            SelectedBuilding = cbx_Building.SelectedItem as Building;

            DS_ProductionLine.DataSource = SelectedBuilding.ProductionLines;
            SelectProductionLineChanges();
        }

        private void cbx_Building_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBuildingChanges();
        }

        private void UpdateEKanbanDevices()
        {
            eKanbanDevices = EKanbanTaskQuery.GetEKanbanDevicesByBuilding(SelectedBuilding.id);

            try
            {
                if (ViewAllCart)
                {
                    DS_EKanbanDevice.DataSource = eKanbanDevices;
                }
                else
                {
                    DS_EKanbanDevice.DataSource = eKanbanDevices = EKanbanTaskQuery.GetEKanbanDevicesByProductionLine(SelectedProductionLine.id);
                }
            }
            catch { }
        }

        private void SelectProductionLineChanges()
        {
            if (lb_ProductionLine.SelectedItem == null)
                return;

            SelectedProductionLine = lb_ProductionLine.SelectedItem as ProductionLine;
            UpdateEKanbanDevices();
        }

        private void lb_ProductionLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectProductionLineChanges();
        }

        private void Checkbox_ViewAllCart_CheckStateChanged(object sender, EventArgs e)
        {
            UpdateEKanbanDevices();
        }

        private void UpdateSelectedEkanbanDevice()
        {
            SelectedEKanbanDevice = new EKanbanDevice();
            SelectedEKanbanInterface = new EKanbanInterface();

            if (lbEKanbanDevice.SelectedItem == null)
                return;

            SelectedEKanbanDevice = lbEKanbanDevice.SelectedItem as EKanbanDevice;

            SelectedEKanbanInterface = EKanbanTaskQuery.GetLastEKanbanInterface(SelectedEKanbanDevice.id);

            DS_EKBInterface.DataSource = new EKanbanInterface();
            if (SelectedEKanbanInterface != null)
            {
                lbStatus.Text = (SysActionCode)SelectedEKanbanInterface.SysActionCode == SysActionCode.EKANBAN_CONFIRM_ITEM ? "CONFORM OK" : "WAITING";
                DS_EKBInterface.DataSource = SelectedEKanbanInterface;
            }
        }

        private void lbEKanbanDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedEkanbanDevice();
        }

        private void UpdateSchedules(int _updateType)
        {
            if (_updateType == 1)
            {
                Schedules = ScheduleQuery.GetSchedules(SelectedScheduleClass);
                if (SelectedProductionLine == null)
                {
                    MessageBox.Show("An error occurred during execution", "Error");
                    return;
                }
                try
                {
                    DS_Schedule.DataSource = Schedules = Schedules
                        .Where(i => i.ProductionLine_Id == SelectedProductionLine.id)
                        .ToList();
                }
                catch
                {
                    DS_Schedule.DataSource = new List<Schedule>();
                }
            }
            if (_updateType == 2)
            {
                if (Schedules != null)
                    DS_Schedule.DataSource = Schedules;
                else
                    DS_Schedule.DataSource = new List<Schedule>();
            }

            GetModelFilter();
            UpdateScheduleGroupByModelName();
        }

        private void cbx_ScheduleTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedScheduleClass = ScheduleQuery.GetScheduleClass(cbx_ScheduleTime.Text);
            UpdateSchedules(1);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UpdateSchedules(1);
        }

        private void UpdateSelectedSchedule()
        {
            SelectedOriginalPo = new OriginalPO();
            SelectedSchedule = new Schedule();
            SelectedSequence = new OriginalPOsequence();
            SelectedScheduleLine = string.Empty;
            txtProductionLine.Text = string.Empty;
            if (lbSchedule.SelectedItem == null)
                return;


            SelectedSchedule = ScheduleQuery.GetSchedule((lbSchedule.SelectedItem as Schedule).id);

            SelectedProductionLine = BuildingQuery.GetProductionLine(ShareFuncs.GetInt(SelectedSchedule.ProductionLine_Id));

            txtProductionLine.Text = SelectedScheduleLine = SelectedProductionLine.LineName;

            UpdateModelComponent();

            UpdateOgiginalSequence();
        }

        private void UpdateModelComponent()
        {
            SelectShoeComponent = new List<ShoeComponent>();
            SelectShoeComponent = ComponentQuery.GetModelComponents(SelectedSchedule.Model);

            try
            {
                DS_Component.DataSource = SelectShoeComponent;
            }
            catch
            {
                DS_Component.DataSource = new List<ShoeComponent>();
            }
        }

        private void lbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedSchedule();
        }

        private void UpdateOgiginalSequence()
        {
            try
            {
                SelectedOriginalPo = SequenceQuery.GetOriginalPo(SelectedSchedule);

                DS_Sequence.DataSource = SequenceQuery.GetOriginalSequence(SelectedSchedule);
            }
            catch { }
        }

        private void GetModelFilter()
        {
            cbxModelName.DataSource = null;
            List<string> ModelName = new List<string>();
            if (Schedules == null)
                return;

            if (ModelNameFilter)
            {

                var group = Schedules.GroupBy(i => i.ModelName);

                foreach (var item in group)
                {
                    ModelName.Add(item.Key);
                }

                cbxModelName.DataSource = ModelName;
            }
            else
                DS_Schedule.DataSource = Schedules;
        }

        private void chbx_modelFilter_CheckStateChanged(object sender, EventArgs e)
        {
            GetModelFilter();
        }

        private void UpdateScheduleGroupByModelName()
        {
            if (Schedules == null)
                return;

            foreach (var item in Schedules.GroupBy(i => i.ModelName))
            {
                if (item.Key == cbxModelName.Text)
                {
                    DS_Schedule.DataSource = item.ToList();
                }
            }
        }

        private void cbxModelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScheduleGroupByModelName();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EXCEL_TO_DATABASE.UPDATE_FORM uPDATE_FORM = new EXCEL_TO_DATABASE.UPDATE_FORM();
            uPDATE_FORM.ShowDialog();
        }

        private void btnSequence_Click(object sender, EventArgs e)
        {
            if (SelectedSchedule.id == 0)
                return;

            VIEW_SEQUENCE_FORM.SEQUENCE_FORM sEQUENCE_FORM = new VIEW_SEQUENCE_FORM.SEQUENCE_FORM(SelectedSchedule);

            sEQUENCE_FORM.Show();
            sEQUENCE_FORM.BringToFront();
        }

        private void UpdateShoeSizes()
        {
            var sizes = SequenceQuery.GetOriginalSizes(SelectedSequence.id);
            if (sizes == null)
                return;

            ICollection<SizeRef> Size = new List<SizeRef>();
            int index = 0;
            foreach (var size in sizes)
            {
                index++;
                Size.Add(new SizeRef
                {
                    Index = index,
                    Size = ComponentQuery.GetShoeSize(ShareFuncs.GetInt(size.SizeId)).SizeName,
                    Quantity = ShareFuncs.GetInt(size.Quantity)
                });
            }

            try
            {
                DS_Size.DataSource = Size;
            }
            catch
            {
                DS_Size.DataSource = new List<SizeRef>();
            }

        }

        private void UpdateSelectedOriginalSequence()
        {
            lb_checkout_seq.Text = SelectedSequence.EKanbanStatus = string.Empty;

            if (cb_Sequence.SelectedItem == null)
                return;

            SelectedSequence = new OriginalPOsequence();

            SelectedSequence = SequenceQuery.GetOriginalSequence((cb_Sequence.SelectedItem as OriginalPOsequence).id);

            if (SelectedSequence != null)
            {
                var EKanbanLoading = EKanbanTaskQuery.GetEKanbanLoadingBySequence(SelectedSequence.id);

                if (EKanbanLoading != null)
                {
                    SelectedSequence.EKanbanStatus = ((SysActionCode)EKanbanLoading.SysActionCode).ToString();
                    lb_checkout_seq.Text = SelectedSequence.EKanbanStatus;
                }
            }
        }

        private void cb_Sequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedOriginalSequence();
            UpdateShoeSizes();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddSequenceToEKanban();
        }

        private string GetShortPoNumber(string _fullPoNumber)
        {
            if (_fullPoNumber.IndexOf("-") > -1)
                return _fullPoNumber.Remove(0, _fullPoNumber.Length - 6);
            else
                return _fullPoNumber.Remove(0, _fullPoNumber.Length - 4);
        }

        /// <summary>
        /// Thêm thông tin vào Ekanban
        /// </summary>
        private void AddSequenceToEKanban()
        {
            if (SelectedEKanbanDevice == null || SelectedEKanbanDevice.id == 0)
            {
                MessageBox.Show("An Error orcured while adding Sequence to EKanban.\r\nError: Missing Ekanban device.", "Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ekbLoading = EKanbanTaskQuery.GetEKanbanLoading(SelectedSequence.id);
            if (ekbLoading != null)
            {
                MessageBox.Show("An Error orcured while adding Sequence to EKanban.\r\nError: The sequence is already added.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SelectedOriginalPo.id == 0 || SelectedSequence.id == 0 || SelectedSchedule.id == 0)
            {
                MessageBox.Show("An Error orcured while adding Sequence to EKanban.\r\nError: Missing data.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dresult = MessageBox.Show("Make sure you want to continue?", "Question",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dresult != DialogResult.Yes)
                return;

            int action = 0;
            SysActionCode SysCode = SysActionCode.UNKNOW;

            EKanbanHis EkanbanHis = new EKanbanHis();

            if (SelectedEKanbanInterface == null)
            {
                action = 0;
            }
            else
            {
                if (SelectedEKanbanInterface.id != 0)
                {
                    SysCode = (SysActionCode)SelectedEKanbanInterface.SysActionCode;
                    EkanbanHis = SysHistoryQuery.GetEKanbanHistory(SelectedEKanbanInterface);
                }
            }


            switch (SysCode)
            {
                case SysActionCode.SEQUENCE_PREPARING:
                case SysActionCode.EKANBAN_ADD_NEW_ITEM:
                    dresult = MessageBox.Show("EKanban is holding data, do you want to continue?", "Message",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dresult != DialogResult.Yes)
                        return;
                    action = 1;
                    break;

                case SysActionCode.SEQUENCE_CONFORM:
                case SysActionCode.EKANBAN_CONFIRM_ITEM:
                    action = 0;
                    break;

                default:
                    break;
            }

            switch (action)
            {
                case 0: // add new interface
                    List<EKanbanComponent> eKanbanComponent = new List<EKanbanComponent>();
                    foreach (var item in SelectShoeComponent)
                    {
                        if (item.AddToEkanban)
                        {
                            eKanbanComponent.Add(new EKanbanComponent
                            {
                                ShoeComponent_Id = item.Id,
                                CuttingType_Id = item.CuttingType.id,
                            });
                        }
                    }
                    // add new interface
                    EKanbanInterface eKanbanInterface = new EKanbanInterface
                    {
                        LastUpdate = DateTime.Now,
                        PO = GetShortPoNumber(SelectedSchedule.PoNumber),
                        Line = SelectedScheduleLine,
                        EKanbanDevice_Id = SelectedEKanbanDevice.id,
                        POqty = SelectedSchedule.Quantity.ToString(),
                        SysActionCode = (int)SysActionCode.EKANBAN_ADD_NEW_ITEM,
                        EkanbanComponents = new List<EKanbanComponent>(eKanbanComponent),
                        SequenceNo = SelectedSequence.SequenceNo.ToString(),
                        CartQty = SelectedSequence.Quantity.ToString(),

                        EKanbanLoadings = new List<EKanbanLoading>
                        {
                            new EKanbanLoading
                            {
                                SysActionCode = (int)SysActionCode.SEQUENCE_PREPARING,
                                OriginalPo_Id = SelectedOriginalPo.id,
                                OriginalSequence_Id = SelectedSequence.id,
                                LastUpdate = DateTime.Now,
                                SequenceQty = SelectedSequence.Quantity
                            }
                        }
                    };

                    if (EKanbanTaskQuery.AddNewEKanbanInterface(eKanbanInterface))
                    {
                        var inf1 = EKanbanTaskQuery.FindEKanbanInterface(eKanbanInterface.id);

                        string jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(inf1);
                        EkanbanHis = new EKanbanHis
                        {
                            EKanbanInterface_Id = eKanbanInterface.id,
                            EKanbanDevice_Id = SelectedEKanbanDevice.id,
                            DateTime = DateTime.Now,
                            ProductionLine_Id = SelectedSchedule.ProductionLine_Id,
                            Data = jsonStr,
                        };

                        MessageBox.Show("Add new Ekanban Interface successfully", "Message");

                        bool success = SysHistoryQuery.AddNewEKanbanHisotry(EkanbanHis);

                        if (!success)
                        {
                            MessageBox.Show("Add new Ekanban history record error", "Message");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error orcured while adding new Po to Ekanban.\r\nError: Failed to add new Ekanban interface to database.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case 1: // update interface

                    EKanbanLoading eKanbanLoading = new EKanbanLoading
                    {
                        EKanbanInterface_Id = SelectedEKanbanInterface.id,
                        SysActionCode = (int)SysActionCode.SEQUENCE_PREPARING,
                        OriginalPo_Id = SelectedOriginalPo.id,
                        OriginalSequence_Id = SelectedSequence.id,
                        LastUpdate = DateTime.Now,
                        SequenceQty = SelectedSequence.Quantity,
                    };

                    bool exp1 = EKanbanTaskQuery.AddNewEKanbanLoading(eKanbanLoading);

                    if (!exp1)
                    {
                        MessageBox.Show("An error orcured while adding new Po to Ekanban.\r\nError: Failed to add EkanbanLoading to database.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SelectedEKanbanInterface.PO += $",{GetShortPoNumber(SelectedSchedule.PoNumber)}";
                    SelectedEKanbanInterface.SequenceNo += $",{SelectedSequence.SequenceNo}";
                    SelectedEKanbanInterface.POqty += $",{SelectedSchedule.Quantity}";
                    SelectedEKanbanInterface.CartQty += $",{SelectedSequence.Quantity}";
                    SelectedEKanbanInterface.LastUpdate = DateTime.Now;
                    bool exp2 = EKanbanTaskQuery.UpdateEKanbanInterface(SelectedEKanbanInterface);

                    EKanbanInterface inf2 = EKanbanTaskQuery.FindEKanbanInterface(SelectedEKanbanInterface.id);

                    var his = SysHistoryQuery.GetEKanbanHistory(SelectedEKanbanInterface);
                    string jsonStr2 = Newtonsoft.Json.JsonConvert.SerializeObject(inf2);
                    his.Data = jsonStr2;
                    his.DateTime = DateTime.Now;
                    SysHistoryQuery.UpdateEKanbanHis(his);



                    if (exp1 && exp2)
                    {
                        MessageBox.Show("Add new Po to Ekanban succeesfully", "Message");
                    }

                    if (!exp2)
                    {
                        MessageBox.Show("An error orcured while adding new Po to Ekanban.\r\nError: Failed to update Ekanban interface.", "Message");
                        EKanbanTaskQuery.DeleteEKanbanLoading(eKanbanLoading);
                        return;
                    }

                    // update interface
                    break;
            }

            UpdateSelectedSchedule();

            UpdateSelectedEkanbanDevice();

            UpdateSelectedOriginalSequence();

            AddNewStockMeasure();

            AddNewHistory(EkanbanHis.id);
        }

        private void AddNewHistory(int _ekanbanHisId)
        {
            try
            {
                AppHistory his = new AppHistory
                {
                    SysActionCode = (int)SysActionCode.EKANBAN_ADD_NEW_ITEM,
                    DateTime = DateTime.Now,
                    Description = $"Add new Ekanban information: {SelectedEKanbanDevice.Name}",
                    Remark = $"PO:{SelectedSchedule.PoNumber}, Line:{SelectedProductionLine.LineName}, Sequence:{SelectedSequence.SequenceNo}",
                };
                SysHistoryQuery.AddNewAppHistory(his);
                EKanbanAddHis addHis = new EKanbanAddHis
                {
                    DateTime = DateTime.Now,
                    Added = true,
                    EKanbanHis_Id = _ekanbanHisId,
                    OriginalSequence_Id = SelectedSequence.id,
                    SequenceNo = SelectedSequence.SequenceNo,
                    SequenceQty = SelectedSequence.Quantity,
                };

                SysHistoryQuery.AddNewAddHistory(addHis);
            }
            catch (Exception e)
            { }
        }

        private void AddNewStockMeasure()
        {
            var Stock = StockQuery.GetPrepareStockMeasure(SelectedSchedule);
            if (Stock == null)
                return;

            StockQuery.AddNewStockPreaparing(SelectedSequence, Stock.id);
        }

        private void dgvSize_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSize_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (e.RowIndex % 2 != 0)
                e.CellStyle.BackColor = Color.LightCyan;

            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {

                e.CellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void dgv_Components_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex % 2 != 0)
                e.CellStyle.BackColor = Color.LightCyan;

            if (e.ColumnIndex == 1)
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void txt_search_po_TextChanged(object sender, EventArgs e)
        {
            Schedules = ScheduleQuery.GetSchedules(txt_search_po.Text);
            UpdateSchedules(2);
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {

            var dresult = MessageBox.Show("Do you really want to delete this Ekanban data?", "Question",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dresult != DialogResult.Yes)
                return;

            int oldId = SelectedEKanbanInterface.id;

            ICollection<EKanbanLoading> EkanbanLoadings = EKanbanTaskQuery.GetEKanbanLoadings(SelectedEKanbanInterface.id);

            if (EKanbanTaskQuery.DeleteEKanbanInterface(SelectedEKanbanInterface))
            {
                MessageBox.Show("Clear Po from Ekanban succeesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error orcured while delete Ekanban interface.\r\nError: Failed to delete Ekanban interface.", "Message",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateSelectedSchedule();
            UpdateSelectedEkanbanDevice();
            UpdateSelectedOriginalSequence();


            // Thêm mới Stock record
            var Stock = StockQuery.GetPrepareStockMeasure(SelectedSchedule);
            if (Stock == null)
                return;

            foreach (var item in EkanbanLoadings)
            {
                var seq = SequenceQuery.GetOriginalSequence(ShareFuncs.GetInt(item.OriginalSequence_Id));
                StockQuery.DeleteStockPreparing(Stock.id, ShareFuncs.GetInt(seq.SequenceNo));
            }

            try
            {
                // thêm mới history cho ekanban
                AppHistory his = new AppHistory
                {
                    SysActionCode = (int)SysActionCode.EKANBAN_CLEAR_ITEM,
                    DateTime = DateTime.Now,
                    Description = $"Clear Ekanban information: {SelectedEKanbanDevice.Name}",
                };

                SysHistoryQuery.AddNewAppHistory(his);

                var EkanbanHis = SysHistoryQuery.GetEKanbanHistoryByInterface(oldId);

                EKanbanClearHis addHis = new EKanbanClearHis
                {
                    DateTime = DateTime.Now,
                    Removed = true,
                    EKanbanHis_Id = EkanbanHis.id,
                };

                SysHistoryQuery.AddNewClearHistory(addHis);
            }
            catch (Exception ee)
            { }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            if(MANG_FORM.IsDisposed)
                MANG_FORM = new MANAGER_FORM.MANG_FORM();

            MANG_FORM.Show();
            MANG_FORM.BringToFront();
        }

        private void btn_viewKBHis_Click(object sender, EventArgs e)
        {
            Form EkanbanHisForm = new Form { Text = "EKanban History" };
            MANAGER_FORM.Pages.EKanbanHistories eKanbanHistoriesnew = new MANAGER_FORM.Pages.EKanbanHistories();
            EkanbanHisForm.Controls.Add(eKanbanHistoriesnew);
            eKanbanHistoriesnew.Dock = DockStyle.Fill;
            EkanbanHisForm.WindowState = FormWindowState.Maximized;
            EkanbanHisForm.Show();
        }


        private void lbSchedule_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                // Draw the background of the ListBox control for each item.
                e.DrawBackground();
                // Define the default color of the brush as black.
                Brush myBrush = Brushes.Black;

                Schedule currentSche = lbSchedule.Items[e.Index] as Schedule;
                var stock = StockQuery.GetStockMeasure(currentSche);

                e.Graphics.DrawString(currentSche.PoNumber, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                if (stock == null)
                    return;

                myBrush = Brushes.DarkRed;
                // Draw the current item text based on the current Font 
                // and the custom brush settings.
                e.Graphics.DrawString(currentSche.PoNumber, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                // If the ListBox has focus, draw a focus rectangle around the selected item.
                e.DrawFocusRectangle();
            }
            catch { }
        }

        private void btn_viewSequence_Click(object sender, EventArgs e)
        {
            if (SelectedSchedule.id == 0)
                return;

            VIEW_SEQUENCE_FORM.SEQUENCE_FORM sEQUENCE_FORM = new VIEW_SEQUENCE_FORM.SEQUENCE_FORM(SelectedSchedule);

            sEQUENCE_FORM.Show();
            sEQUENCE_FORM.BringToFront();
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            if (lbSchedule.SelectedItem == null)
                return;
            var currentSchedule = lbSchedule.SelectedItem as Schedule;
            Views.EditScheduleForm editScheduleForm = new Views.EditScheduleForm(currentSchedule);
            editScheduleForm.ShowDialog();
        }
    }
}
