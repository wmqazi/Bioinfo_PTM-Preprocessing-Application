namespace PTMDatabaseInConsistencyAnalyzer
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePreprocessingAnalysis = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblAminoAcidFeildName = new System.Windows.Forms.Label();
            this.lblPositionFeildName = new System.Windows.Forms.Label();
            this.lblSequenceLengthFeildName = new System.Windows.Forms.Label();
            this.lblSequenceFeildName = new System.Windows.Forms.Label();
            this.lblPIDFeildName = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPTMDataFileName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.chkDuplicateAnalysis = new System.Windows.Forms.CheckBox();
            this.chkModifiedResidueAndPositionProfileAnalysis = new System.Windows.Forms.CheckBox();
            this.chkProteinToSequenceAnalysis = new System.Windows.Forms.CheckBox();
            this.chkInsertSequenceLengthFeild = new System.Windows.Forms.CheckBox();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInconsistentRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.grd = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDuplicateRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.grdDuplcateEntries = new System.Windows.Forms.DataGridView();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grdPTM = new System.Windows.Forms.DataGridView();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.tabControl1.SuspendLayout();
            this.tabPagePreprocessingAnalysis.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDuplcateEntries)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPTM)).BeginInit();
            this.statusStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePreprocessingAnalysis);
            this.tabControl1.Controls.Add(this.tabPageReport);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 479);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPagePreprocessingAnalysis
            // 
            this.tabPagePreprocessingAnalysis.Controls.Add(this.groupBox3);
            this.tabPagePreprocessingAnalysis.Controls.Add(this.btnAnalyze);
            this.tabPagePreprocessingAnalysis.Controls.Add(this.groupBox2);
            this.tabPagePreprocessingAnalysis.Controls.Add(this.lblProgress);
            this.tabPagePreprocessingAnalysis.Controls.Add(this.progressBar);
            this.tabPagePreprocessingAnalysis.Controls.Add(this.groupBox1);
            this.tabPagePreprocessingAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreprocessingAnalysis.Name = "tabPagePreprocessingAnalysis";
            this.tabPagePreprocessingAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreprocessingAnalysis.Size = new System.Drawing.Size(548, 453);
            this.tabPagePreprocessingAnalysis.TabIndex = 0;
            this.tabPagePreprocessingAnalysis.Text = "Preprocessing Analysis";
            this.tabPagePreprocessingAnalysis.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.lblAminoAcidFeildName);
            this.groupBox3.Controls.Add(this.lblPositionFeildName);
            this.groupBox3.Controls.Add(this.lblSequenceLengthFeildName);
            this.groupBox3.Controls.Add(this.lblSequenceFeildName);
            this.groupBox3.Controls.Add(this.lblPIDFeildName);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 203);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Column Description";
            // 
            // button6
            // 
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(9, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 25);
            this.button6.TabIndex = 23;
            this.button6.Text = "Clear All Assigned Value";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DirOpen.ico");
            this.imageList1.Images.SetKeyName(1, "Run.ico");
            // 
            // lblAminoAcidFeildName
            // 
            this.lblAminoAcidFeildName.AutoSize = true;
            this.lblAminoAcidFeildName.Location = new System.Drawing.Point(322, 147);
            this.lblAminoAcidFeildName.Name = "lblAminoAcidFeildName";
            this.lblAminoAcidFeildName.Size = new System.Drawing.Size(0, 13);
            this.lblAminoAcidFeildName.TabIndex = 22;
            // 
            // lblPositionFeildName
            // 
            this.lblPositionFeildName.AutoSize = true;
            this.lblPositionFeildName.Location = new System.Drawing.Point(322, 116);
            this.lblPositionFeildName.Name = "lblPositionFeildName";
            this.lblPositionFeildName.Size = new System.Drawing.Size(0, 13);
            this.lblPositionFeildName.TabIndex = 21;
            // 
            // lblSequenceLengthFeildName
            // 
            this.lblSequenceLengthFeildName.AutoSize = true;
            this.lblSequenceLengthFeildName.Location = new System.Drawing.Point(322, 85);
            this.lblSequenceLengthFeildName.Name = "lblSequenceLengthFeildName";
            this.lblSequenceLengthFeildName.Size = new System.Drawing.Size(0, 13);
            this.lblSequenceLengthFeildName.TabIndex = 20;
            this.lblSequenceLengthFeildName.TextChanged += new System.EventHandler(this.lblSequenceLengthFeildName_TextChanged);
            // 
            // lblSequenceFeildName
            // 
            this.lblSequenceFeildName.AutoSize = true;
            this.lblSequenceFeildName.Location = new System.Drawing.Point(322, 54);
            this.lblSequenceFeildName.Name = "lblSequenceFeildName";
            this.lblSequenceFeildName.Size = new System.Drawing.Size(0, 13);
            this.lblSequenceFeildName.TabIndex = 19;
            // 
            // lblPIDFeildName
            // 
            this.lblPIDFeildName.AutoSize = true;
            this.lblPIDFeildName.Location = new System.Drawing.Point(322, 23);
            this.lblPIDFeildName.Name = "lblPIDFeildName";
            this.lblPIDFeildName.Size = new System.Drawing.Size(0, 13);
            this.lblPIDFeildName.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(165, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 25);
            this.button5.TabIndex = 17;
            this.button5.Text = "Assign as Amino Acid";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(165, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "Assign as Position";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(165, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "Assign as Sequence Length";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(165, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Assign as Sequence";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(165, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Assign as Protein ID";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 147);
            this.listBox1.TabIndex = 7;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(430, 414);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(110, 33);
            this.btnAnalyze.TabIndex = 12;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPTMDataFileName);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTotalRecords);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 64);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PTM Data table";
            // 
            // txtPTMDataFileName
            // 
            this.txtPTMDataFileName.Location = new System.Drawing.Point(6, 19);
            this.txtPTMDataFileName.Name = "txtPTMDataFileName";
            this.txtPTMDataFileName.Size = new System.Drawing.Size(489, 20);
            this.txtPTMDataFileName.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.ImageIndex = 0;
            this.btnOpen.ImageList = this.imageList1;
            this.btnOpen.Location = new System.Drawing.Point(501, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(27, 21);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Records In Selected DataTable";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalRecords.Location = new System.Drawing.Point(232, 42);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(0, 13);
            this.lblTotalRecords.TabIndex = 6;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(9, 414);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(418, 13);
            this.lblProgress.TabIndex = 14;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(7, 430);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(417, 10);
            this.progressBar.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.chkDuplicateAnalysis);
            this.groupBox1.Controls.Add(this.chkModifiedResidueAndPositionProfileAnalysis);
            this.groupBox1.Controls.Add(this.chkProteinToSequenceAnalysis);
            this.groupBox1.Controls.Add(this.chkInsertSequenceLengthFeild);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 123);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis Option";
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(258, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(269, 100);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // chkDuplicateAnalysis
            // 
            this.chkDuplicateAnalysis.AutoSize = true;
            this.chkDuplicateAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDuplicateAnalysis.Location = new System.Drawing.Point(10, 90);
            this.chkDuplicateAnalysis.Name = "chkDuplicateAnalysis";
            this.chkDuplicateAnalysis.Size = new System.Drawing.Size(153, 17);
            this.chkDuplicateAnalysis.TabIndex = 3;
            this.chkDuplicateAnalysis.Text = "Duplicate Enteries Analysis";
            this.chkDuplicateAnalysis.UseVisualStyleBackColor = true;
            this.chkDuplicateAnalysis.CheckedChanged += new System.EventHandler(this.chkDuplicateAnalysis_CheckedChanged);
            // 
            // chkModifiedResidueAndPositionProfileAnalysis
            // 
            this.chkModifiedResidueAndPositionProfileAnalysis.AutoSize = true;
            this.chkModifiedResidueAndPositionProfileAnalysis.Checked = true;
            this.chkModifiedResidueAndPositionProfileAnalysis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModifiedResidueAndPositionProfileAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModifiedResidueAndPositionProfileAnalysis.Location = new System.Drawing.Point(10, 67);
            this.chkModifiedResidueAndPositionProfileAnalysis.Name = "chkModifiedResidueAndPositionProfileAnalysis";
            this.chkModifiedResidueAndPositionProfileAnalysis.Size = new System.Drawing.Size(242, 17);
            this.chkModifiedResidueAndPositionProfileAnalysis.TabIndex = 2;
            this.chkModifiedResidueAndPositionProfileAnalysis.Text = "Modified Residue and Position Profile Analysis";
            this.chkModifiedResidueAndPositionProfileAnalysis.UseVisualStyleBackColor = true;
            // 
            // chkProteinToSequenceAnalysis
            // 
            this.chkProteinToSequenceAnalysis.AutoSize = true;
            this.chkProteinToSequenceAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProteinToSequenceAnalysis.Location = new System.Drawing.Point(10, 44);
            this.chkProteinToSequenceAnalysis.Name = "chkProteinToSequenceAnalysis";
            this.chkProteinToSequenceAnalysis.Size = new System.Drawing.Size(176, 17);
            this.chkProteinToSequenceAnalysis.TabIndex = 1;
            this.chkProteinToSequenceAnalysis.Text = "Sequence Consistency Analysis";
            this.chkProteinToSequenceAnalysis.UseVisualStyleBackColor = true;
            // 
            // chkInsertSequenceLengthFeild
            // 
            this.chkInsertSequenceLengthFeild.AutoSize = true;
            this.chkInsertSequenceLengthFeild.Checked = true;
            this.chkInsertSequenceLengthFeild.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInsertSequenceLengthFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsertSequenceLengthFeild.ForeColor = System.Drawing.Color.Maroon;
            this.chkInsertSequenceLengthFeild.Location = new System.Drawing.Point(10, 21);
            this.chkInsertSequenceLengthFeild.Name = "chkInsertSequenceLengthFeild";
            this.chkInsertSequenceLengthFeild.Size = new System.Drawing.Size(224, 17);
            this.chkInsertSequenceLengthFeild.TabIndex = 0;
            this.chkInsertSequenceLengthFeild.Text = "Include Sequence Length Attribute";
            this.chkInsertSequenceLengthFeild.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.tabControl2);
            this.tabPageReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(548, 453);
            this.tabPageReport.TabIndex = 1;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(542, 447);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.grd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inconsistency Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblInconsistentRecordCount,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(528, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "Record Count";
            // 
            // lblInconsistentRecordCount
            // 
            this.lblInconsistentRecordCount.Name = "lblInconsistentRecordCount";
            this.lblInconsistentRecordCount.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(92, 20);
            this.toolStripSplitButton1.Text = "Export As XML";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(3, 3);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.Size = new System.Drawing.Size(528, 415);
            this.grd.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Controls.Add(this.grdDuplcateEntries);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(534, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rows with Duplicate Entries";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblDuplicateRecordCount,
            this.toolStripSplitButton2});
            this.statusStrip2.Location = new System.Drawing.Point(3, 396);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(528, 22);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel2.Text = "Record Count";
            // 
            // lblDuplicateRecordCount
            // 
            this.lblDuplicateRecordCount.Name = "lblDuplicateRecordCount";
            this.lblDuplicateRecordCount.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(92, 20);
            this.toolStripSplitButton2.Text = "Export As XML";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // grdDuplcateEntries
            // 
            this.grdDuplcateEntries.AllowUserToAddRows = false;
            this.grdDuplcateEntries.AllowUserToDeleteRows = false;
            this.grdDuplcateEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDuplcateEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDuplcateEntries.Location = new System.Drawing.Point(3, 3);
            this.grdDuplcateEntries.Name = "grdDuplcateEntries";
            this.grdDuplcateEntries.ReadOnly = true;
            this.grdDuplcateEntries.Size = new System.Drawing.Size(528, 415);
            this.grdDuplcateEntries.TabIndex = 1;
            // 
            // openDlg
            // 
            this.openDlg.Filter = "XML File|*.XML";
            this.openDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openDlg_FileOk);
            // 
            // saveDlg
            // 
            this.saveDlg.Filter = "XML Files|*.XML";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.statusStrip3);
            this.tabPage3.Controls.Add(this.grdPTM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(548, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PTM Dataset";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grdPTM
            // 
            this.grdPTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPTM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPTM.Location = new System.Drawing.Point(0, 0);
            this.grdPTM.Name = "grdPTM";
            this.grdPTM.Size = new System.Drawing.Size(548, 453);
            this.grdPTM.TabIndex = 0;
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton3});
            this.statusStrip3.Location = new System.Drawing.Point(0, 431);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(548, 22);
            this.statusStrip3.TabIndex = 1;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(92, 20);
            this.toolStripSplitButton3.Text = "Export As XML";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.toolStripSplitButton3_ButtonClick);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 502);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTM Database Inconsistency Analyzer";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePreprocessingAnalysis.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDuplcateEntries)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPTM)).EndInit();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePreprocessingAnalysis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblAminoAcidFeildName;
        private System.Windows.Forms.Label lblPositionFeildName;
        private System.Windows.Forms.Label lblSequenceLengthFeildName;
        private System.Windows.Forms.Label lblSequenceFeildName;
        private System.Windows.Forms.Label lblPIDFeildName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPTMDataFileName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDuplicateAnalysis;
        private System.Windows.Forms.CheckBox chkModifiedResidueAndPositionProfileAnalysis;
        private System.Windows.Forms.CheckBox chkProteinToSequenceAnalysis;
        private System.Windows.Forms.CheckBox chkInsertSequenceLengthFeild;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdDuplcateEntries;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblDuplicateRecordCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblInconsistentRecordCount;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView grdPTM;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;

    }
}

