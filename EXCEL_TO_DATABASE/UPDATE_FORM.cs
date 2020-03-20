using LOGIN_UI;
using SYS_MODELS;
using SYS_MODELS._ENUM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace EXCEL_TO_DATABASE
{
    public partial class UPDATE_FORM : Form
    {
        private OpenFileDialog Dialog;
        private DialogResult dResult = DialogResult.Cancel;
        private string Path1, Path2;

        Unblock unblock = new Unblock(_SERVER.ServerName.Database);

        private Views.SettingForm SettingForm = new Views.SettingForm();
        private Views.ExcelColumnDef ExcelColumnDef = new Views.ExcelColumnDef();

        private AppUser User;
        private LOGIN_FORM FLogin;

        Views.HelpForm helpForm = new Views.HelpForm();
        private void FUpdateDb_Load(object sender, EventArgs e)
        {
            FLogin = new LOGIN_FORM(2);
            FLogin.ShowDialog();

            if (!FLogin.LoginStatus)
                this.Close();

            User = new AppUser();
            User = FLogin.User;
        }

        public UPDATE_FORM()
        {
            InitializeComponent();

            string temp = Properties.Settings.Default.SettingParameters;
            try
            {
                if (temp != string.Empty)
                    ExcelColumnDef = Newtonsoft.Json.JsonConvert.DeserializeObject<Views.ExcelColumnDef>(temp);
            }
            catch { }
        }

        private void Btn_Browse2_Click(object sender, EventArgs e)
        {
            using (Dialog = new OpenFileDialog())
            {
                dResult = Dialog.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    if (Dialog.FileName != null)
                    {
                        Path2 = Dialog.FileName;
                        try
                        {
                            unblock.OledB_ReadComponentTable(Path2);
                            txt_Link2.Text = Path2;
                            lb_Exeption2.Text = "Ready to start";
                        }
                        catch
                        {
                            MessageBox.Show("Please rechecking your file!");
                        }
                    }
                }
            }
        }

        private void Btn_Start1_Click(object sender, EventArgs e)
        {
            unblock.ExcelColumnDef = ExcelColumnDef;

            if (Path1 == null || Path1 == "")
                return;

            Thread thead = new Thread(() =>
            {
                Handle_UpdateSequenceRoot();

                AppHistory his = new AppHistory
                {
                    AppUser_Id = User.id,
                    SysActionCode = (int)SysActionCode.UPDATE_SEQUENCE,
                    Description = Path1,
                };
                unblock.SysHistoryQuery.AddNewAppHistory(his);
            });
            thead.Start();
        }

        private void Btn_Browse1_Click(object sender, EventArgs e)
        {
            unblock.ExcelColumnDef = ExcelColumnDef;

            using (Dialog = new OpenFileDialog())
            {
                dResult = Dialog.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    if (Dialog.FileName != null)
                    {
                        Path1 = Dialog.FileName;
                        try
                        {
                            unblock.OleDb_readTable(Path1);
                            txt_Link1.Text = Path1;
                            lb_Exeption1.Text = "Ready to start";
                        }
                        catch
                        {
                            MessageBox.Show("Please rechecking your file!");
                        }
                    }
                }
            }
        }

        // update sequence to database func
        private void Handle_UpdateSequenceRoot()
        {
            try
            {
                unblock.Handle_getPreFilterOrder();

            }
            catch
            {
                MessageBox.Show("Excel parameters are wrong");
                return;
            }

            if (unblock.PreviewPos == null)
                return;

            unblock.TotalPO_Error = 0;
            unblock.TotalPO_Added = 0;
            int totalModified = 0, totalSkip = 0;

            BeginInvoke(new MethodInvoker(() =>
            {
                lb_Exeption1.Text = "...";
                progressBar1.Maximum = unblock.PreviewPos.Count;
                progressBar1.Value = 0;
            }));

            foreach (var item in unblock.PreviewPos)
            {
                if (item.PO.Quantity == 0 || item.PO.Quantity == null)
                    continue;
                else
                {
                    // add new po to database
                    int checkPoException = unblock.SequenceQuery.CheckOriginalPo(item.PO);

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
                            var seq = unblock.Handle_getOriginalPOsequences(item);
                            if (seq != null)
                            {
                                item.PO.OriginalPOsequences = seq;

                                if (unblock.SequenceQuery.AddNewOriginalPo(item.PO))
                                {
                                    try
                                    {
                                        unblock.TotalPO_Added++;
                                        unblock.UpdateSequenceLog += $"Add new Po:{item.PO.PoNumber}, Line: {unblock.BuildingQuery.GetProductionLineByCode(item.PO.Line).LineName}, Status: Success\r\n";
                                    }
                                    catch { }
                                }
                                else
                                {
                                    try
                                    {
                                        unblock.TotalPO_Error++;
                                        unblock.UpdateSequenceLog += $"Add new Po:{item.PO.PoNumber}, Line: {unblock.BuildingQuery.GetProductionLineByCode(item.PO.Line).LineName}, Status: Success\r\n";
                                    }
                                    catch { }
                                }
                            }
                            break;
                        case 1:
                            totalModified++;
                            try
                            {
                                unblock.UpdateSequenceLog += $"Update Article of Po:{item.PO.PoNumber}, Article: {item.PO.Article}, Status: Success\r\n";
                            }
                            catch { }
                            break;
                        case 2:
                            totalModified++;
                            try
                            {
                                unblock.UpdateSequenceLog += $"Update Production Line of Po:{item.PO.PoNumber}, Line: {unblock.BuildingQuery.GetProductionLineByCode(item.PO.Line).LineName}, Status: Success\r\n";
                            }
                            catch { }
                            break;
                        case 3:
                            //skip
                            totalSkip++;
                            try
                            {
                                if (!ExcelColumnDef.NewProductionLineFormat)
                                    unblock.UpdateSequenceLog += $"Skip Po:{item.PO.PoNumber}, Line: {unblock.BuildingQuery.GetProductionLineByCode(item.PO.Line).LineName}, Status: Success\r\n";
                                else
                                    unblock.UpdateSequenceLog += $"Skip Po:{item.PO.PoNumber}, Line: {unblock.BuildingQuery.GetProductionLineByName(item.PO.Line).LineName}, Status: Success\r\n";
                            }
                            catch { }
                            break;

                        case 4:
                            break;
                        case 5:
                            break;

                    }
                }
                BeginInvoke(new MethodInvoker(() =>
                {
                    progressBar1.Value++;
                    lb_Exeption1.Text = $"{progressBar1.Value * 100 / progressBar1.Maximum} %";
                    lb_TotalPO.Text = unblock.TotalPO_Added.ToString();
                    lb_TotalError.Text = unblock.TotalPO_Error.ToString();
                    lbTotalModified.Text = totalModified.ToString();
                    lbTotalSkip.Text = totalSkip.ToString();
                }));
            }

            MessageBox.Show("Update sequence successfully", "Excel to database");
        }

        private void Btn_Start2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Path2))
                return;

            bool success = unblock.ComponentQuery.ClearAllModelComponents();
            string exp = success == true ? "Successflly" : "Error";

            BeginInvoke(new MethodInvoker(() => { lb_Exeption2.Text = $"Clear Model component {exp}"; }));

            unblock.OledB_ReadComponentTable(Path2);

            if (unblock._AutoCutTable == null || unblock._AutoCutTable.Rows.Count == 0)
            {
                MessageBox.Show("_AutoCutTable is null or have no row");
                return;
            }
            try
            {
                unblock.ClearComponent();
                Thread thread = new Thread(() =>
                {
                    Handle_CuttingComponents(unblock._AutoCutTable, true);
                    Handle_CuttingComponents(unblock._BeamCutTable, false);

                    AppHistory his = new AppHistory
                    {
                        AppUser_Id = User.id,
                        SysActionCode = (int)SysActionCode.UPDATE_COMPONENT,
                        Description = Path2,
                    };
                    unblock.SysHistoryQuery.AddNewAppHistory(his);

                    MessageBox.Show("Update component successfully");

                });
                thread.Start();

            }
            catch
            {
                MessageBox.Show("Error occure while update components to database");
            }
        }

        /// <summary>
        /// Temp function
        /// </summary>
        /// <param name="cellValue"></param>
        /// <param name="Select_ModelName"></param>
        /// <param name="cuttingType"></param>
        /// <returns></returns>
        private List<ShoeModel> Add_SameModel(object cellValue, string Select_ModelName, string cuttingType)
        {
            if (cellValue != null)
            {
                List<ShoeModel> modelList = new List<ShoeModel>();

                try
                {
                    string s = cellValue.ToString().Trim();
                    string[] models = s.Split(new string[] { "," }, StringSplitOptions.None);
                    foreach (string m in models)
                    {
                        string model_num = m.Trim();
                        if (model_num != "")
                        {
                            ShoeModel checkM = new ShoeModel
                            {
                                Model_Number = model_num,
                                Model_Name = Select_ModelName
                            };

                            var currentM = unblock.ComponentQuery.GetAndAddShoeModel(checkM);

                            if (currentM != null)
                            {
                                modelList.Add(currentM);
                            }
                        }
                    }

                    List<ShoeModel> AddModels = new List<ShoeModel>();
                    foreach (ShoeModel currentModel in modelList)
                    {
                        var modelComponent = unblock.ComponentQuery.GetModelComponent(currentModel.Id, cuttingType);

                        if (modelComponent == null)
                        {
                            AddModels.Add(currentModel);
                        }
                    }
                    return AddModels;

                }
                catch { return null; }
            }
            else
                return null;
        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            Form logForm = new Form();
            TextBox logText = new TextBox();
            logForm.Controls.Add(logText);
            logText.Dock = DockStyle.Fill;
            logText.BackColor = Color.LightGray;
            logText.Multiline = true;
            logText.Text = unblock.UpdateSequenceLog;
            logForm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //SettingForm.ExcelColumnDef = ExcelColumnDef;
            if (ExcelColumnDef == null)
                ExcelColumnDef = new Views.ExcelColumnDef();

            SettingForm = new Views.SettingForm(ExcelColumnDef);
            if (SettingForm.ShowDialog() == DialogResult.OK)
            {
                ExcelColumnDef = SettingForm.ExcelColumnDef;
                Properties.Settings.Default.SettingParameters = Newtonsoft.Json.JsonConvert.SerializeObject(ExcelColumnDef);
                Properties.Settings.Default.Save();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (helpForm.IsDisposed)
            {
                helpForm = new Views.HelpForm();
            }

            helpForm.Show();
            helpForm.BringToFront();
        }

        private void btnGetTable_Click(object sender, EventArgs e)
        {

        }

        // handle update component to database
        private void Handle_CuttingComponents(DataTable table, bool auto_cut)
        {
            string Select_ModelName = "";
            int initial_row = 4;

            string cutting_type = "auto";

            if (!auto_cut)
            {
                cutting_type = "beam";
                initial_row = 2;
                unblock.TotalModel2 = 0;
            }
            else
                unblock.TotalModel1 = 0;

            BeginInvoke(new MethodInvoker(() =>
            {
                lb_Exeption2.Text = "...";
                progressBar2.Value = 0;
                progressBar2.Maximum = table.Rows.Count - initial_row;
            }));

            for (int i = initial_row; i < table.Rows.Count; i++)
            {
                BeginInvoke(new MethodInvoker(() =>
                {
                    progressBar2.Value++;
                    lb_TotalModel1.Text = unblock.TotalModel1.ToString();
                    lb_TotalModel2.Text = unblock.TotalModel2.ToString();
                }));

                var row = table.Rows[i];
                object model_name = row[1]; // model name column
                object model = row[2];  // model column
                object first_component_cell = row[5]; // first column of parts
                object samemodel = row[4]; // first column of parts
                object articleCell = row[5];

                if (model_name != null)
                {
                    if (model_name.ToString() != "")
                    {
                        Select_ModelName = model_name.ToString();
                    }
                }

                if (model != null && model.ToString() != "")
                {
                    ShoeModel Select_Model = new ShoeModel
                    {
                        Model_Number = model.ToString().Trim().ToUpper(),
                        Model_Name = Select_ModelName.Trim().ToUpper()
                    };


                    Select_Model = unblock.ComponentQuery.GetAndAddShoeModel(Select_Model);

                    if (Select_Model == null)
                        continue;

                    if (auto_cut)
                        unblock.TotalModel1++;
                    else

                        unblock.TotalModel2++;

                    if (first_component_cell != null && first_component_cell.ToString() != "")
                    {
                        List<ShoeComponent> Select_Components = new List<ShoeComponent>();
                        for (int c = 0; c < 30; c++)
                        {
                            if (row[c + 5] != null)
                            {
                                string cellvalue = row[c + 5].ToString().Trim();

                                // break out from the for loop
                                if (cellvalue == "" ||
                                   cellvalue == " " ||
                                   cellvalue == "  " ||
                                   cellvalue.IndexOf("  ") > -1)
                                    break;

                                ShoeComponent shoeComponent = unblock.ComponentQuery.GetAndAddShoeComponent(cellvalue.Trim());
                                if (shoeComponent != null)
                                {
                                    Select_Components.Add(shoeComponent);
                                }

                            }
                        }

                        CuttingType ctype = unblock.ComponentQuery.GetCuttingType(cutting_type);

                        if (Select_Components.Count > 0)
                        {
                            foreach (ShoeComponent c in Select_Components)
                            {
                                unblock.ComponentQuery.AddNewModelComponent(Select_Model.Id, c.Id, ctype.id);
                            }
                        }
                    }
                }
                BeginInvoke(new MethodInvoker(() =>
                {
                    lb_Exeption2.Text = $"{progressBar2.Value * 100 / progressBar2.Maximum} %";
                }));
            }
        }
    }
}
