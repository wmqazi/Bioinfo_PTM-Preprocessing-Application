using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Qazi.GUI.CommonDialogs;
using PTMUtilityLibrary;

namespace PTMDatabaseInConsistencyAnalyzer
{
    public partial class MainFrame : Form
    {
        private DataTable dtPTM;
        private DataTable dtReport;
        private DataTable dtDuplication;

        
        private bool ApplicationCanBeReset;
        private bool CancelAllProcessDueToException;
        private bool AnalysisCompleted;

        private List<string> ListOfProteinIDWithInconsistencyInPositionInfo;
        private List<DataRow> RowsWithInconsistencyInAminoAcidInfo;
        private List<string> ListOfProteinIDWithInconsistencyInAminoAcidInfo;
        private List<DataRow> RowsWithInconsistencyInPositionInfo;

        private List<string> ProteinsWithInConsistencyInSequenceInformation;

        private Dictionary<DataRow, int> DuplicateEntries;

        List<string> UniqueListOfInConsistentProteins;

        private bool GenerateInConsistencyReport;
        private bool GenerateDuplicationReport;

        //private List<string>

        public MainFrame()
        {
            InitializeComponent();
            grdPTM.DataSource = dtPTM;
            ApplicationCanBeReset = false;
            CancelAllProcessDueToException = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ResetUI();
            openDlg.ShowDialog(this);
        }

        private void ResetUI()
        {
            lblTotalRecords.Text = "";
            txtPTMDataFileName.Text = "";
            listBox1.Items.Clear();
            lblPIDFeildName.Text = "";
            lblPositionFeildName.Text = "";
            lblSequenceFeildName.Text = "";
            lblSequenceLengthFeildName.Text = "";
            lblAminoAcidFeildName.Text = "";
            lblProgress.Text = "";
            lblTotalRecords.Text = "";
            chkDuplicateAnalysis.Checked = true;
            chkInsertSequenceLengthFeild.Checked = true;
            chkModifiedResidueAndPositionProfileAnalysis.Checked = true;
            chkProteinToSequenceAnalysis.Checked = true;
            listBox2.Items.Clear();
            progressBar.Value = 0;
        }
        private void openDlg_FileOk(object sender, CancelEventArgs e)
        {
            txtPTMDataFileName.Text = openDlg.FileName;
            DataSet ds = new DataSet();
            ds.ReadXml(txtPTMDataFileName.Text);

            using (DataTableSelectorWnd dtswnd = new DataTableSelectorWnd("Select PTM Data Table", ds))
            {
                dtswnd.ShowDialog(this);
                try
                {
                    dtPTM = ds.Tables[dtswnd.TableName];
                    lblTotalRecords.Text = dtPTM.Rows.Count.ToString();
                    foreach(DataColumn col in dtPTM.Columns)
                    {
                        listBox1.Items.Add(col.ColumnName);
                    }
                    ApplicationCanBeReset = true;
                }
                catch (NullReferenceException exp)
                {
                    ResetUI();
                }
                ds = null;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (dtPTM != null)
            {
                if (chkDuplicateAnalysis.Checked == true)
                {
                    if (listBox2.Items.Count == 0)
                    {
                        MessageBox.Show("No Columns is selected for duplicate search");
                        return;
                    }
                }

                if (lblPIDFeildName.Text.Equals("") == true)
                {
                    MessageBox.Show("Assign column to PID");
                    return;
                }

                AnalysisCompleted = false;
                PerformAnalysis();
                if (CancelAllProcessDueToException == false)
                {
                    MessageBox.Show("Requested process is completed");
                    progressBar.Value = 0;
                    lblProgress.Text = "";
                }
                else
                {
                    MessageBox.Show("Preprocessing was not sucessfully completed");
                    CancelAllProcessDueToException = false;
                }
                AnalysisCompleted = true;
            }
        }

        private void PerformAnalysis()
        {
            UniqueListOfInConsistentProteins = new List<string>();
            GenerateDuplicationReport = false;
            GenerateInConsistencyReport = false;

            if (chkInsertSequenceLengthFeild.Checked == true)
            {
                if (CancelAllProcessDueToException == false)
                {
                    InsertSequenceLengthFeild();
                }

                if (CancelAllProcessDueToException == true)
                {
                    return;
                }
            }
            if (chkModifiedResidueAndPositionProfileAnalysis.Checked == true)
            {
                if (CancelAllProcessDueToException == false)
                {
                    ModifiedResidueAndPositionProfileAnalysis();
                    GenerateInConsistencyReport = true;
                }

                if (CancelAllProcessDueToException == true)
                {
                    return;
                }
            }
            if (chkProteinToSequenceAnalysis.Checked == true)
            {
                if (CancelAllProcessDueToException == false)
                {
                    SequenceAnalysis();
                    GenerateInConsistencyReport = true;
                }

                if (CancelAllProcessDueToException == true)
                {
                    return;
                }
            }

            if (chkDuplicateAnalysis.Checked == true)
            {
                if (CancelAllProcessDueToException == false)
                {
                    DuplicateSearch();
                    GenerateDuplicationReport = true;
                }

                if (CancelAllProcessDueToException == true)
                {
                    return;
                }
            }
        }

        private void DuplicateSearch()
        {
            List<string> colList = new List<string>();
            foreach (object o in listBox2.Items)
            {
                colList.Add(o.ToString());
            }

            DuplicateSearchManager d = new DuplicateSearchManager(dtPTM,colList);
            d.RowUnderEvaluation += new RowUnderEvaluationHandler(ProgressIndicator);
            try
            {
                d.Run();
                DuplicateEntries = d.DuplicateEntriesList;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                d.Cancel();
                CancelAllProcessDueToException = true;
                ResetApplication();
            }
            
        }

        private void SequenceAnalysis()
        {
            ProteinInfoExtractionManager s = new ProteinInfoExtractionManager(dtPTM, lblPIDFeildName.Text, lblSequenceFeildName.Text, lblSequenceLengthFeildName.Text);
            s.RowUnderEvaluation += new RowUnderEvaluationHandler(ProgressIndicator);
            try
            {
                s.Run();
                ProteinsWithInConsistencyInSequenceInformation = s.ProteinsWithInConsistencyInSequenceInformation;
                foreach (string pid in ProteinsWithInConsistencyInSequenceInformation)
                {
                    if (UniqueListOfInConsistentProteins.Contains(pid) == false)
                        UniqueListOfInConsistentProteins.Add(pid);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                s.Cancel();
                CancelAllProcessDueToException = true;
                ResetApplication();
            }
        }

        private void ResetApplication()
        {
            if (ApplicationCanBeReset == true)
            {
                ApplicationCanBeReset = false;
                
                ResetUI();

                try
                {
                    ListOfProteinIDWithInconsistencyInPositionInfo.Clear();
                    RowsWithInconsistencyInAminoAcidInfo.Clear();
                    ListOfProteinIDWithInconsistencyInAminoAcidInfo.Clear();
                    RowsWithInconsistencyInPositionInfo.Clear();
                    ProteinsWithInConsistencyInSequenceInformation.Clear();

                    ListOfProteinIDWithInconsistencyInPositionInfo = null;
                    RowsWithInconsistencyInAminoAcidInfo = null;
                    ListOfProteinIDWithInconsistencyInAminoAcidInfo = null;
                    RowsWithInconsistencyInPositionInfo = null;
                    ProteinsWithInConsistencyInSequenceInformation = null;

                    UniqueListOfInConsistentProteins.Clear();
                    UniqueListOfInConsistentProteins = null;

                    dtPTM.Dispose();
                    dtPTM = null;
                }
                catch (Exception exp)
                { 
                    
                }
            }
            
        }

        private void ModifiedResidueAndPositionProfileAnalysis()
        {
            //This methods checks that wether the modified residue exsists in the sequences or not
            ResidueExistanceInSequenceManager r = new ResidueExistanceInSequenceManager(dtPTM, lblPIDFeildName.Text, lblSequenceFeildName.Text, lblPositionFeildName.Text, lblAminoAcidFeildName.Text, lblSequenceLengthFeildName.Text);
            r.RowUnderEvaluation += new RowUnderEvaluationHandler(ProgressIndicator);
            try
            {
                r.Run();
                ListOfProteinIDWithInconsistencyInAminoAcidInfo = r.ListOfProteinIDWithInconsistencyInAminoAcidInfo;
                ListOfProteinIDWithInconsistencyInPositionInfo = r.ListOfProteinIDWithInconsistencyInPositionInfo;
                RowsWithInconsistencyInAminoAcidInfo = r.RowsWithInconsistencyInAminoAcidInfo;
                RowsWithInconsistencyInPositionInfo = r.RowsWithInconsistencyInPositionInfo;
                foreach (string pid in ListOfProteinIDWithInconsistencyInAminoAcidInfo)
                {
                    if (UniqueListOfInConsistentProteins.Contains(pid) == false)
                        UniqueListOfInConsistentProteins.Add(pid);
                }

                foreach (string pid in ListOfProteinIDWithInconsistencyInPositionInfo)
                {
                    if (UniqueListOfInConsistentProteins.Contains(pid) == false)
                        UniqueListOfInConsistentProteins.Add(pid);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                r.Cancel();
                CancelAllProcessDueToException = true;
                ResetApplication();
            }
        }

        private void InsertSequenceLengthFeild()
        {
            SequenceLengthAdditionManager s = new SequenceLengthAdditionManager(dtPTM, lblSequenceFeildName.Text);
            s.RowUnderEvaluation += new RowUnderEvaluationHandler(ProgressIndicator);
            try
            {
                s.Run();
                lblSequenceLengthFeildName.Text = "SequenceLength";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                s.Cancel();
                CancelAllProcessDueToException = true;
                ResetApplication();
            }
        }

        private void ProgressIndicator(object sender, RowUnderEvaluationEventArgs e)
        {
            float status;
            status = e.RowIndex + 1;
            status = ((status) / dtPTM.Rows.Count) * 100;

            lblProgress.Text = e.ProgressStatusMessage; 
            progressBar.Value = ((int)status);
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                lblPIDFeildName.Text = listBox1.SelectedItem.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                lblSequenceFeildName.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                lblSequenceLengthFeildName.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                lblPositionFeildName.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                lblAminoAcidFeildName.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void lblSequenceLengthFeildName_TextChanged(object sender, EventArgs e)
        {
            if(lblSequenceLengthFeildName.Text.Equals("") == true)
            {
                chkInsertSequenceLengthFeild.Checked = true;
                chkInsertSequenceLengthFeild.Enabled = true;
            }
            else
            {
                chkInsertSequenceLengthFeild.Checked = false;
                chkInsertSequenceLengthFeild.Enabled = false;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblAminoAcidFeildName.Text = "";
            lblPIDFeildName.Text = "";
            lblPositionFeildName.Text = "";
            lblSequenceFeildName.Text = "";
            lblSequenceLengthFeildName.Text = "";
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                GenerateReport();
            }
            else
            if (e.TabPageIndex == 2)
            {
                grdPTM.DataSource = dtPTM;    
            }
        }

        private void GenerateReport()
        {
            
            if (AnalysisCompleted == true)
            {
                tabControl1.SelectTab(0);
                lblProgress.Text = "Generating report. Please Wait";

                float index;
                string pid;
                #region Generate Inconsistency Report
                if(GenerateInConsistencyReport == true)
                {
                    if (dtReport == null)
                    {
                        dtReport = new DataTable("Preprocessing Report");
                        dtReport.Columns.Add(lblPIDFeildName.Text);
                        dtReport.Columns.Add("HasSequenceInConsistency");
                        dtReport.Columns.Add("HasPositionalInConsistancy");
                        dtReport.Columns.Add("HasAminoAcidInfoInConsistancy");
                        DataRow newRow;
                        string strtemp;
                        int ctr;
                        DataRow trow;

                        for (index = 0; index < UniqueListOfInConsistentProteins.Count; index++)
                        {
                            progressBar.Value = ((int)((index / UniqueListOfInConsistentProteins.Count) * 100));
                            newRow = dtReport.NewRow();

                            pid = UniqueListOfInConsistentProteins[(int)index];
                            newRow[lblPIDFeildName.Text] = pid;
                            if (chkModifiedResidueAndPositionProfileAnalysis.Checked == true)
                            {
                                if (ListOfProteinIDWithInconsistencyInPositionInfo.Contains(pid) == true)
                                {
                                    newRow["HasPositionalInConsistancy"] = "Yes";
                                }
                                else
                                {
                                    newRow["HasPositionalInConsistancy"] = "No";
                                }

                                if (ListOfProteinIDWithInconsistencyInAminoAcidInfo.Contains(pid) == true)
                                {
                                    newRow["HasAminoAcidInfoInConsistancy"] = "Yes";
                                }
                                else
                                {
                                    newRow["HasAminoAcidInfoInConsistancy"] = "No";
                                }
                            }

                            if (chkProteinToSequenceAnalysis.Checked == true)
                            {
                                if (ProteinsWithInConsistencyInSequenceInformation.Contains(pid) == true)
                                {
                                    newRow["HasSequenceInConsistency"] = "Yes";
                                }
                                else
                                {
                                    newRow["HasSequenceInConsistency"] = "No";
                                }
                            }
                            dtReport.Rows.Add(newRow);
                        }
                    }
                    grd.DataSource = dtReport;
                    lblInconsistentRecordCount.Text = dtReport.Rows.Count.ToString();
                }
                
                
                #endregion Generate Inconsistency Report Report

                
                #region Generate Duplication Report
                if (GenerateDuplicationReport == true)
                {
                    if (dtDuplication == null)
                    {
                        dtDuplication = new DataTable();
                        dtDuplication = dtPTM.Clone();
                        dtDuplication.TableName = "Duplicate Entries Information";
                        foreach (DataRow r in DuplicateEntries.Keys)
                        {
                            dtDuplication.ImportRow(r);
                        }
                    }
                    grdDuplcateEntries.DataSource = dtDuplication;
                    lblDuplicateRecordCount.Text = dtDuplication.Rows.Count.ToString();
                }
                #endregion Generate Duplication Report

                
                tabControl1.SelectTab(1);
            }
            else
            {
                
                MessageBox.Show("No analysis exsist to generate report");
                tabControl1.SelectTab(0);
            }
        }

        private void chkDuplicateAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Enabled = chkDuplicateAnalysis.Checked;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox2.Enabled == true)
                {
                    if (listBox2.Items.Contains(listBox1.SelectedItem.ToString()) == false)
                        listBox2.Items.Add(listBox1.SelectedItem.ToString());
                    else
                        MessageBox.Show("Already selected");
                }
                else
                    MessageBox.Show("You have not selected duplicate entries search");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            saveDlg.ShowDialog(this);
            if (saveDlg.FileName.Equals("") == false)
            {
                dtReport.WriteXml(saveDlg.FileName);
                MessageBox.Show("Export completed");
            }
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            saveDlg.ShowDialog(this);
            if (saveDlg.FileName.Equals("") == false)
            {
                dtDuplication.WriteXml(saveDlg.FileName);
                MessageBox.Show("Export completed");
            }
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            saveDlg.ShowDialog(this);
            if (saveDlg.FileName.Equals("") == false)
            {
                if (dtPTM.DataSet == null)
                    dtPTM.WriteXml(saveDlg.FileName);
                else 
                {
                    dtPTM.DataSet.WriteXml(saveDlg.FileName);
                }
                MessageBox.Show("Export completed");
            }
        }

        
    }
}


