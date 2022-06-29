namespace Aglaia
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Numeric.Notation notation1 = new Numeric.Notation();
            Numeric.Notation notation2 = new Numeric.Notation();
            Numeric.Notation notation3 = new Numeric.Notation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvKeywords = new System.Windows.Forms.DataGridView();
            this.cmsKeywords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiKeywordsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTEST = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTESTLAB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiISSUEDATE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMANUFAC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLUMCAT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLUMINAIRE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLAMPCAT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLAMP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTESTDATE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNEARFIELD = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBALLAST = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBALLASTCAT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMAINTCAT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDISTRIBUTION = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFLASHAREA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCOLORCONSTANT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLAMPPOSITION = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFILEGENINFO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSEARCH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMORE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbUSERDEFINE = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiKeywordsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbChunk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIlluView = new System.Windows.Forms.ToolStripMenuItem();
            this.直射水平面照度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配光特性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTilt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTilt = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbLumensPerLamp = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbMultiplier = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbNumberOfVerticalAngles = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tbNumberOfHorizontalAngles = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tbFutureUse = new System.Windows.Forms.TextBox();
            this.tbFutureUseOfFileGenerationInfoLabel = new System.Windows.Forms.TextBox();
            this.tbBallastFactor = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.tbInputWatts = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.cmbPhotometricType = new System.Windows.Forms.ComboBox();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNumberOfTiltAngles = new System.Windows.Forms.TextBox();
            this.tbNumberOfTiltAnglesLabel = new System.Windows.Forms.TextBox();
            this.tbLampToLuminaireGeometryLabel = new System.Windows.Forms.TextBox();
            this.dgvTilt = new System.Windows.Forms.DataGridView();
            this.cmsTilt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTiltAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTiltDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLampToLuminaireGeometry = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfLamps = new System.Windows.Forms.NumericUpDown();
            this.cbLength = new System.Windows.Forms.CheckBox();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.cbSpace = new System.Windows.Forms.CheckBox();
            this.cbReserved = new System.Windows.Forms.CheckBox();
            this.cbDuplication = new System.Windows.Forms.CheckBox();
            this.cbUserDefine = new System.Windows.Forms.CheckBox();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVersionInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ndgvCandela = new Numeric.NumericDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeywords)).BeginInit();
            this.cmsKeywords.SuspendLayout();
            this.ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTilt)).BeginInit();
            this.cmsTilt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLampToLuminaireGeometry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfLamps)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKeywords
            // 
            this.dgvKeywords.AllowDrop = true;
            this.dgvKeywords.AllowUserToAddRows = false;
            this.dgvKeywords.AllowUserToDeleteRows = false;
            this.dgvKeywords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeywords.ContextMenuStrip = this.cmsKeywords;
            this.dgvKeywords.Location = new System.Drawing.Point(12, 65);
            this.dgvKeywords.Name = "dgvKeywords";
            this.dgvKeywords.RowHeadersVisible = false;
            this.dgvKeywords.RowTemplate.Height = 21;
            this.dgvKeywords.Size = new System.Drawing.Size(229, 187);
            this.dgvKeywords.TabIndex = 0;
            this.dgvKeywords.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKeywords_CellMouseDown);
            this.dgvKeywords.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvKeywords_DragDrop);
            this.dgvKeywords.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvKeywords_DragOver);
            this.dgvKeywords.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvKeywords_MouseDown);
            this.dgvKeywords.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvKeywords_MouseMove);
            // 
            // cmsKeywords
            // 
            this.cmsKeywords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKeywordsAdd,
            this.tsmiKeywordsDelete});
            this.cmsKeywords.Name = "cmsKeywords";
            this.cmsKeywords.Size = new System.Drawing.Size(99, 48);
            this.cmsKeywords.Opening += new System.ComponentModel.CancelEventHandler(this.cmsKeywords_Opening);
            // 
            // tsmiKeywordsAdd
            // 
            this.tsmiKeywordsAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTEST,
            this.tsmiTESTLAB,
            this.tsmiISSUEDATE,
            this.tsmiMANUFAC,
            this.toolStripSeparator1,
            this.tsmiLUMCAT,
            this.tsmiLUMINAIRE,
            this.tsmiLAMPCAT,
            this.tsmiLAMP,
            this.toolStripSeparator2,
            this.tsmiTESTDATE,
            this.tsmiNEARFIELD,
            this.tsmiBALLAST,
            this.tsmiBALLASTCAT,
            this.tsmiMAINTCAT,
            this.tsmiDISTRIBUTION,
            this.tsmiFLASHAREA,
            this.tsmiCOLORCONSTANT,
            this.tsmiLAMPPOSITION,
            this.tsmiFILEGENINFO,
            this.tsmiSEARCH,
            this.tsmiMORE,
            this.toolStripSeparator3,
            this.tstbUSERDEFINE});
            this.tsmiKeywordsAdd.Name = "tsmiKeywordsAdd";
            this.tsmiKeywordsAdd.Size = new System.Drawing.Size(98, 22);
            this.tsmiKeywordsAdd.Text = "追加";
            // 
            // tsmiTEST
            // 
            this.tsmiTEST.Name = "tsmiTEST";
            this.tsmiTEST.Size = new System.Drawing.Size(172, 22);
            this.tsmiTEST.Text = "TEST";
            this.tsmiTEST.Click += new System.EventHandler(this.tsmiTEST_Click);
            // 
            // tsmiTESTLAB
            // 
            this.tsmiTESTLAB.Name = "tsmiTESTLAB";
            this.tsmiTESTLAB.Size = new System.Drawing.Size(172, 22);
            this.tsmiTESTLAB.Text = "TESTLAB";
            this.tsmiTESTLAB.Click += new System.EventHandler(this.tsmiTESTLAB_Click);
            // 
            // tsmiISSUEDATE
            // 
            this.tsmiISSUEDATE.Name = "tsmiISSUEDATE";
            this.tsmiISSUEDATE.Size = new System.Drawing.Size(172, 22);
            this.tsmiISSUEDATE.Text = "ISSUEDATE";
            this.tsmiISSUEDATE.Click += new System.EventHandler(this.tsmiISSUEDATE_Click);
            // 
            // tsmiMANUFAC
            // 
            this.tsmiMANUFAC.Name = "tsmiMANUFAC";
            this.tsmiMANUFAC.Size = new System.Drawing.Size(172, 22);
            this.tsmiMANUFAC.Text = "MANUFAC";
            this.tsmiMANUFAC.Click += new System.EventHandler(this.tsmiMANUFAC_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // tsmiLUMCAT
            // 
            this.tsmiLUMCAT.Name = "tsmiLUMCAT";
            this.tsmiLUMCAT.Size = new System.Drawing.Size(172, 22);
            this.tsmiLUMCAT.Text = "LUMCAT";
            this.tsmiLUMCAT.Click += new System.EventHandler(this.tsmiLUMCAT_Click);
            // 
            // tsmiLUMINAIRE
            // 
            this.tsmiLUMINAIRE.Name = "tsmiLUMINAIRE";
            this.tsmiLUMINAIRE.Size = new System.Drawing.Size(172, 22);
            this.tsmiLUMINAIRE.Text = "LUMINAIRE";
            this.tsmiLUMINAIRE.Click += new System.EventHandler(this.tsmiLUMINAIRE_Click);
            // 
            // tsmiLAMPCAT
            // 
            this.tsmiLAMPCAT.Name = "tsmiLAMPCAT";
            this.tsmiLAMPCAT.Size = new System.Drawing.Size(172, 22);
            this.tsmiLAMPCAT.Text = "LAMPCAT";
            this.tsmiLAMPCAT.Click += new System.EventHandler(this.tsmiLAMPCAT_Click);
            // 
            // tsmiLAMP
            // 
            this.tsmiLAMP.Name = "tsmiLAMP";
            this.tsmiLAMP.Size = new System.Drawing.Size(172, 22);
            this.tsmiLAMP.Text = "LAMP";
            this.tsmiLAMP.Click += new System.EventHandler(this.tsmiLAMP_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // tsmiTESTDATE
            // 
            this.tsmiTESTDATE.Name = "tsmiTESTDATE";
            this.tsmiTESTDATE.Size = new System.Drawing.Size(172, 22);
            this.tsmiTESTDATE.Text = "TESTDATE";
            this.tsmiTESTDATE.Click += new System.EventHandler(this.tsmiTESTDATE_Click);
            // 
            // tsmiNEARFIELD
            // 
            this.tsmiNEARFIELD.Name = "tsmiNEARFIELD";
            this.tsmiNEARFIELD.Size = new System.Drawing.Size(172, 22);
            this.tsmiNEARFIELD.Text = "NEARFIELD";
            this.tsmiNEARFIELD.Click += new System.EventHandler(this.tsmiNEARFIELD_Click);
            // 
            // tsmiBALLAST
            // 
            this.tsmiBALLAST.Name = "tsmiBALLAST";
            this.tsmiBALLAST.Size = new System.Drawing.Size(172, 22);
            this.tsmiBALLAST.Text = "BALLAST";
            this.tsmiBALLAST.Click += new System.EventHandler(this.tsmiBALLAST_Click);
            // 
            // tsmiBALLASTCAT
            // 
            this.tsmiBALLASTCAT.Name = "tsmiBALLASTCAT";
            this.tsmiBALLASTCAT.Size = new System.Drawing.Size(172, 22);
            this.tsmiBALLASTCAT.Text = "BALLASTCAT";
            this.tsmiBALLASTCAT.Click += new System.EventHandler(this.tsmiBALLASTCAT_Click);
            // 
            // tsmiMAINTCAT
            // 
            this.tsmiMAINTCAT.Name = "tsmiMAINTCAT";
            this.tsmiMAINTCAT.Size = new System.Drawing.Size(172, 22);
            this.tsmiMAINTCAT.Text = "MAINTCAT";
            this.tsmiMAINTCAT.Click += new System.EventHandler(this.tsmiMAINTCAT_Click);
            // 
            // tsmiDISTRIBUTION
            // 
            this.tsmiDISTRIBUTION.Name = "tsmiDISTRIBUTION";
            this.tsmiDISTRIBUTION.Size = new System.Drawing.Size(172, 22);
            this.tsmiDISTRIBUTION.Text = "DISTRIBUTION";
            this.tsmiDISTRIBUTION.Click += new System.EventHandler(this.tsmiDISTRIBUTION_Click);
            // 
            // tsmiFLASHAREA
            // 
            this.tsmiFLASHAREA.Name = "tsmiFLASHAREA";
            this.tsmiFLASHAREA.Size = new System.Drawing.Size(172, 22);
            this.tsmiFLASHAREA.Text = "FLASHAREA";
            this.tsmiFLASHAREA.Click += new System.EventHandler(this.tsmiFLASHAREA_Click);
            // 
            // tsmiCOLORCONSTANT
            // 
            this.tsmiCOLORCONSTANT.Name = "tsmiCOLORCONSTANT";
            this.tsmiCOLORCONSTANT.Size = new System.Drawing.Size(172, 22);
            this.tsmiCOLORCONSTANT.Text = "COLORCONSTANT";
            this.tsmiCOLORCONSTANT.Click += new System.EventHandler(this.tsmiCOLORCONSTANT_Click);
            // 
            // tsmiLAMPPOSITION
            // 
            this.tsmiLAMPPOSITION.Name = "tsmiLAMPPOSITION";
            this.tsmiLAMPPOSITION.Size = new System.Drawing.Size(172, 22);
            this.tsmiLAMPPOSITION.Text = "LAMPPOSITION";
            this.tsmiLAMPPOSITION.Click += new System.EventHandler(this.tsmiLAMPPOSITION_Click);
            // 
            // tsmiFILEGENINFO
            // 
            this.tsmiFILEGENINFO.Name = "tsmiFILEGENINFO";
            this.tsmiFILEGENINFO.Size = new System.Drawing.Size(172, 22);
            this.tsmiFILEGENINFO.Text = "FILEGENINFO";
            this.tsmiFILEGENINFO.Click += new System.EventHandler(this.tsmiFILEGENINFO_Click);
            // 
            // tsmiSEARCH
            // 
            this.tsmiSEARCH.Name = "tsmiSEARCH";
            this.tsmiSEARCH.Size = new System.Drawing.Size(172, 22);
            this.tsmiSEARCH.Text = "SEARCH";
            this.tsmiSEARCH.Click += new System.EventHandler(this.tsmiSEARCH_Click);
            // 
            // tsmiMORE
            // 
            this.tsmiMORE.Name = "tsmiMORE";
            this.tsmiMORE.Size = new System.Drawing.Size(172, 22);
            this.tsmiMORE.Text = "MORE";
            this.tsmiMORE.Click += new System.EventHandler(this.tsmiMORE_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // tstbUSERDEFINE
            // 
            this.tstbUSERDEFINE.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.tstbUSERDEFINE.ForeColor = System.Drawing.Color.Black;
            this.tstbUSERDEFINE.Name = "tstbUSERDEFINE";
            this.tstbUSERDEFINE.Size = new System.Drawing.Size(100, 23);
            this.tstbUSERDEFINE.Text = "USER DEFINE";
            this.tstbUSERDEFINE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstbUSERDEFINE_KeyPress);
            // 
            // tsmiKeywordsDelete
            // 
            this.tsmiKeywordsDelete.Name = "tsmiKeywordsDelete";
            this.tsmiKeywordsDelete.Size = new System.Drawing.Size(98, 22);
            this.tsmiKeywordsDelete.Text = "削除";
            this.tsmiKeywordsDelete.Click += new System.EventHandler(this.tsmiKeywordsDelete_Click);
            // 
            // cmbChunk
            // 
            this.cmbChunk.FormattingEnabled = true;
            this.cmbChunk.Location = new System.Drawing.Point(12, 27);
            this.cmbChunk.Name = "cmbChunk";
            this.cmbChunk.Size = new System.Drawing.Size(229, 20);
            this.cmbChunk.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Keywords";
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiGraph,
            this.tsmiHelp});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(1024, 24);
            this.ms.TabIndex = 7;
            this.ms.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(53, 20);
            this.tsmiFile.Text = "ファイル";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(98, 22);
            this.tsmiOpen.Text = "開く";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(98, 22);
            this.tsmiSave.Text = "保存";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiGraph
            // 
            this.tsmiGraph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIlluView,
            this.直射水平面照度ToolStripMenuItem,
            this.配光特性ToolStripMenuItem});
            this.tsmiGraph.Name = "tsmiGraph";
            this.tsmiGraph.Size = new System.Drawing.Size(44, 20);
            this.tsmiGraph.Text = "グラフ";
            this.tsmiGraph.Visible = false;
            // 
            // tsmiIlluView
            // 
            this.tsmiIlluView.Name = "tsmiIlluView";
            this.tsmiIlluView.Size = new System.Drawing.Size(158, 22);
            this.tsmiIlluView.Text = "照度分布図";
            this.tsmiIlluView.Click += new System.EventHandler(this.tsmiIlluView_Click);
            // 
            // 直射水平面照度ToolStripMenuItem
            // 
            this.直射水平面照度ToolStripMenuItem.Name = "直射水平面照度ToolStripMenuItem";
            this.直射水平面照度ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.直射水平面照度ToolStripMenuItem.Text = "直射水平面照度";
            // 
            // 配光特性ToolStripMenuItem
            // 
            this.配光特性ToolStripMenuItem.Name = "配光特性ToolStripMenuItem";
            this.配光特性ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.配光特性ToolStripMenuItem.Text = "配光特性";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data";
            // 
            // cmbTilt
            // 
            this.cmbTilt.FormattingEnabled = true;
            this.cmbTilt.Location = new System.Drawing.Point(12, 314);
            this.cmbTilt.Name = "cmbTilt";
            this.cmbTilt.Size = new System.Drawing.Size(229, 20);
            this.cmbTilt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Horizontal＼Vertical";
            // 
            // tbTilt
            // 
            this.tbTilt.Location = new System.Drawing.Point(12, 340);
            this.tbTilt.Name = "tbTilt";
            this.tbTilt.Size = new System.Drawing.Size(229, 19);
            this.tbTilt.TabIndex = 14;
            // 
            // ofdFile
            // 
            this.ofdFile.DefaultExt = "ies";
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "IES|*.ies|全て|*.*";
            // 
            // sfdFile
            // 
            this.sfdFile.DefaultExt = "ies";
            this.sfdFile.Filter = "IES|*.ies|全て|*.*";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(10, 622);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(151, 19);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "number of lamps";
            // 
            // tbLumensPerLamp
            // 
            this.tbLumensPerLamp.Location = new System.Drawing.Point(160, 640);
            this.tbLumensPerLamp.Name = "tbLumensPerLamp";
            this.tbLumensPerLamp.Size = new System.Drawing.Size(79, 19);
            this.tbLumensPerLamp.TabIndex = 18;
            this.tbLumensPerLamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLumensPerLamp.Validating += new System.ComponentModel.CancelEventHandler(this.Double_Validating);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(10, 640);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(151, 19);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "lumens per lamp";
            // 
            // tbMultiplier
            // 
            this.tbMultiplier.Location = new System.Drawing.Point(160, 658);
            this.tbMultiplier.Name = "tbMultiplier";
            this.tbMultiplier.Size = new System.Drawing.Size(79, 19);
            this.tbMultiplier.TabIndex = 20;
            this.tbMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMultiplier.Validating += new System.ComponentModel.CancelEventHandler(this.Double_Validating);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(10, 658);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(151, 19);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "multiplier";
            // 
            // tbNumberOfVerticalAngles
            // 
            this.tbNumberOfVerticalAngles.Location = new System.Drawing.Point(160, 676);
            this.tbNumberOfVerticalAngles.Name = "tbNumberOfVerticalAngles";
            this.tbNumberOfVerticalAngles.ReadOnly = true;
            this.tbNumberOfVerticalAngles.Size = new System.Drawing.Size(79, 19);
            this.tbNumberOfVerticalAngles.TabIndex = 22;
            this.tbNumberOfVerticalAngles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.Location = new System.Drawing.Point(10, 676);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(151, 19);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "number of vertical angles";
            // 
            // tbNumberOfHorizontalAngles
            // 
            this.tbNumberOfHorizontalAngles.Location = new System.Drawing.Point(160, 694);
            this.tbNumberOfHorizontalAngles.Name = "tbNumberOfHorizontalAngles";
            this.tbNumberOfHorizontalAngles.ReadOnly = true;
            this.tbNumberOfHorizontalAngles.Size = new System.Drawing.Size(79, 19);
            this.tbNumberOfHorizontalAngles.TabIndex = 24;
            this.tbNumberOfHorizontalAngles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Window;
            this.textBox10.Location = new System.Drawing.Point(10, 694);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(151, 19);
            this.textBox10.TabIndex = 23;
            this.textBox10.Text = "number of horizontal angles";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Window;
            this.textBox12.Location = new System.Drawing.Point(10, 712);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(151, 19);
            this.textBox12.TabIndex = 25;
            this.textBox12.Text = "photometric type";
            // 
            // tbFutureUse
            // 
            this.tbFutureUse.Location = new System.Drawing.Point(160, 820);
            this.tbFutureUse.Name = "tbFutureUse";
            this.tbFutureUse.Size = new System.Drawing.Size(79, 19);
            this.tbFutureUse.TabIndex = 38;
            this.tbFutureUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFutureUse.Validating += new System.ComponentModel.CancelEventHandler(this.Double_Validating);
            // 
            // tbFutureUseOfFileGenerationInfoLabel
            // 
            this.tbFutureUseOfFileGenerationInfoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tbFutureUseOfFileGenerationInfoLabel.Location = new System.Drawing.Point(10, 820);
            this.tbFutureUseOfFileGenerationInfoLabel.Name = "tbFutureUseOfFileGenerationInfoLabel";
            this.tbFutureUseOfFileGenerationInfoLabel.ReadOnly = true;
            this.tbFutureUseOfFileGenerationInfoLabel.Size = new System.Drawing.Size(151, 19);
            this.tbFutureUseOfFileGenerationInfoLabel.TabIndex = 37;
            this.tbFutureUseOfFileGenerationInfoLabel.Text = "file generation info";
            // 
            // tbBallastFactor
            // 
            this.tbBallastFactor.Location = new System.Drawing.Point(160, 802);
            this.tbBallastFactor.Name = "tbBallastFactor";
            this.tbBallastFactor.Size = new System.Drawing.Size(79, 19);
            this.tbBallastFactor.TabIndex = 36;
            this.tbBallastFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBallastFactor.Validating += new System.ComponentModel.CancelEventHandler(this.Double_Validating);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Window;
            this.textBox16.Location = new System.Drawing.Point(10, 802);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(151, 19);
            this.textBox16.TabIndex = 35;
            this.textBox16.Text = "ballast factor";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(160, 784);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(79, 19);
            this.tbHeight.TabIndex = 34;
            this.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHeight.Validating += new System.ComponentModel.CancelEventHandler(this.Double_Validating);
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.Window;
            this.textBox18.Location = new System.Drawing.Point(10, 784);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(151, 19);
            this.textBox18.TabIndex = 33;
            this.textBox18.Text = "height";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(160, 766);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(79, 19);
            this.tbLength.TabIndex = 32;
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLength.Validating += new System.ComponentModel.CancelEventHandler(this.Double_Validating);
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.Window;
            this.textBox20.Location = new System.Drawing.Point(10, 766);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(151, 19);
            this.textBox20.TabIndex = 31;
            this.textBox20.Text = "length";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(160, 748);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(79, 19);
            this.tbWidth.TabIndex = 30;
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWidth.Validating += new System.ComponentModel.CancelEventHandler(this.Double_Validating);
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.Window;
            this.textBox22.Location = new System.Drawing.Point(10, 748);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(151, 19);
            this.textBox22.TabIndex = 29;
            this.textBox22.Text = "width";
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.Window;
            this.textBox24.Location = new System.Drawing.Point(10, 730);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(151, 19);
            this.textBox24.TabIndex = 27;
            this.textBox24.Text = "units type";
            // 
            // tbInputWatts
            // 
            this.tbInputWatts.Location = new System.Drawing.Point(160, 838);
            this.tbInputWatts.Name = "tbInputWatts";
            this.tbInputWatts.Size = new System.Drawing.Size(79, 19);
            this.tbInputWatts.TabIndex = 40;
            this.tbInputWatts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInputWatts.Validating += new System.ComponentModel.CancelEventHandler(this.Double_Validating);
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.SystemColors.Window;
            this.textBox26.Location = new System.Drawing.Point(10, 838);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(151, 19);
            this.textBox26.TabIndex = 39;
            this.textBox26.Text = "input watts";
            // 
            // cmbPhotometricType
            // 
            this.cmbPhotometricType.FormattingEnabled = true;
            this.cmbPhotometricType.Location = new System.Drawing.Point(160, 712);
            this.cmbPhotometricType.Name = "cmbPhotometricType";
            this.cmbPhotometricType.Size = new System.Drawing.Size(79, 20);
            this.cmbPhotometricType.TabIndex = 41;
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Location = new System.Drawing.Point(160, 730);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(79, 20);
            this.cmbUnitType.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNumberOfTiltAngles
            // 
            this.tbNumberOfTiltAngles.Location = new System.Drawing.Point(162, 383);
            this.tbNumberOfTiltAngles.Name = "tbNumberOfTiltAngles";
            this.tbNumberOfTiltAngles.ReadOnly = true;
            this.tbNumberOfTiltAngles.Size = new System.Drawing.Size(79, 19);
            this.tbNumberOfTiltAngles.TabIndex = 48;
            this.tbNumberOfTiltAngles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNumberOfTiltAnglesLabel
            // 
            this.tbNumberOfTiltAnglesLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tbNumberOfTiltAnglesLabel.Location = new System.Drawing.Point(12, 383);
            this.tbNumberOfTiltAnglesLabel.Name = "tbNumberOfTiltAnglesLabel";
            this.tbNumberOfTiltAnglesLabel.ReadOnly = true;
            this.tbNumberOfTiltAnglesLabel.Size = new System.Drawing.Size(151, 19);
            this.tbNumberOfTiltAnglesLabel.TabIndex = 47;
            this.tbNumberOfTiltAnglesLabel.Text = "number of tilt angles";
            // 
            // tbLampToLuminaireGeometryLabel
            // 
            this.tbLampToLuminaireGeometryLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tbLampToLuminaireGeometryLabel.Location = new System.Drawing.Point(12, 365);
            this.tbLampToLuminaireGeometryLabel.Name = "tbLampToLuminaireGeometryLabel";
            this.tbLampToLuminaireGeometryLabel.ReadOnly = true;
            this.tbLampToLuminaireGeometryLabel.Size = new System.Drawing.Size(151, 19);
            this.tbLampToLuminaireGeometryLabel.TabIndex = 45;
            this.tbLampToLuminaireGeometryLabel.Text = "lamp to luminaire geometry";
            // 
            // dgvTilt
            // 
            this.dgvTilt.AllowUserToAddRows = false;
            this.dgvTilt.AllowUserToDeleteRows = false;
            this.dgvTilt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTilt.ContextMenuStrip = this.cmsTilt;
            this.dgvTilt.Location = new System.Drawing.Point(12, 408);
            this.dgvTilt.Name = "dgvTilt";
            this.dgvTilt.RowHeadersVisible = false;
            this.dgvTilt.RowTemplate.Height = 21;
            this.dgvTilt.Size = new System.Drawing.Size(229, 187);
            this.dgvTilt.TabIndex = 49;
            // 
            // cmsTilt
            // 
            this.cmsTilt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTiltAdd,
            this.tsmiTiltDelete});
            this.cmsTilt.Name = "cmsTilt";
            this.cmsTilt.Size = new System.Drawing.Size(99, 48);
            // 
            // tsmiTiltAdd
            // 
            this.tsmiTiltAdd.Name = "tsmiTiltAdd";
            this.tsmiTiltAdd.Size = new System.Drawing.Size(98, 22);
            this.tsmiTiltAdd.Text = "追加";
            this.tsmiTiltAdd.Click += new System.EventHandler(this.tsmiTiltAdd_Click);
            // 
            // tsmiTiltDelete
            // 
            this.tsmiTiltDelete.Name = "tsmiTiltDelete";
            this.tsmiTiltDelete.Size = new System.Drawing.Size(98, 22);
            this.tsmiTiltDelete.Text = "削除";
            this.tsmiTiltDelete.Click += new System.EventHandler(this.tsmiTiltDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tilt";
            // 
            // nudLampToLuminaireGeometry
            // 
            this.nudLampToLuminaireGeometry.Location = new System.Drawing.Point(162, 365);
            this.nudLampToLuminaireGeometry.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudLampToLuminaireGeometry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLampToLuminaireGeometry.Name = "nudLampToLuminaireGeometry";
            this.nudLampToLuminaireGeometry.Size = new System.Drawing.Size(79, 19);
            this.nudLampToLuminaireGeometry.TabIndex = 51;
            this.nudLampToLuminaireGeometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLampToLuminaireGeometry.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNumberOfLamps
            // 
            this.nudNumberOfLamps.Location = new System.Drawing.Point(160, 622);
            this.nudNumberOfLamps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumberOfLamps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfLamps.Name = "nudNumberOfLamps";
            this.nudNumberOfLamps.Size = new System.Drawing.Size(79, 19);
            this.nudNumberOfLamps.TabIndex = 52;
            this.nudNumberOfLamps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumberOfLamps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfLamps.ValueChanged += new System.EventHandler(this.nudNumberOfLamps_ValueChanged);
            // 
            // cbLength
            // 
            this.cbLength.AutoSize = true;
            this.cbLength.Location = new System.Drawing.Point(12, 258);
            this.cbLength.Name = "cbLength";
            this.cbLength.Size = new System.Drawing.Size(58, 16);
            this.cbLength.TabIndex = 53;
            this.cbLength.Text = "Length";
            this.cbLength.UseVisualStyleBackColor = true;
            // 
            // cbUpper
            // 
            this.cbUpper.AutoSize = true;
            this.cbUpper.Location = new System.Drawing.Point(76, 258);
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.Size = new System.Drawing.Size(54, 16);
            this.cbUpper.TabIndex = 54;
            this.cbUpper.Text = "Upper";
            this.cbUpper.UseVisualStyleBackColor = true;
            // 
            // cbSpace
            // 
            this.cbSpace.AutoSize = true;
            this.cbSpace.Location = new System.Drawing.Point(136, 258);
            this.cbSpace.Name = "cbSpace";
            this.cbSpace.Size = new System.Drawing.Size(55, 16);
            this.cbSpace.TabIndex = 55;
            this.cbSpace.Text = "Space";
            this.cbSpace.UseVisualStyleBackColor = true;
            // 
            // cbReserved
            // 
            this.cbReserved.AutoSize = true;
            this.cbReserved.Location = new System.Drawing.Point(12, 280);
            this.cbReserved.Name = "cbReserved";
            this.cbReserved.Size = new System.Drawing.Size(72, 16);
            this.cbReserved.TabIndex = 56;
            this.cbReserved.Text = "Reserved";
            this.cbReserved.UseVisualStyleBackColor = true;
            // 
            // cbDuplication
            // 
            this.cbDuplication.AutoSize = true;
            this.cbDuplication.Location = new System.Drawing.Point(89, 280);
            this.cbDuplication.Name = "cbDuplication";
            this.cbDuplication.Size = new System.Drawing.Size(81, 16);
            this.cbDuplication.TabIndex = 57;
            this.cbDuplication.Text = "Duplication";
            this.cbDuplication.UseVisualStyleBackColor = true;
            // 
            // cbUserDefine
            // 
            this.cbUserDefine.AutoSize = true;
            this.cbUserDefine.Location = new System.Drawing.Point(167, 280);
            this.cbUserDefine.Name = "cbUserDefine";
            this.cbUserDefine.Size = new System.Drawing.Size(85, 16);
            this.cbUserDefine.TabIndex = 58;
            this.cbUserDefine.Text = "User Define";
            this.cbUserDefine.UseVisualStyleBackColor = true;
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVersionInfo});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(48, 20);
            this.tsmiHelp.Text = "ヘルプ";
            // 
            // tsmiVersionInfo
            // 
            this.tsmiVersionInfo.Name = "tsmiVersionInfo";
            this.tsmiVersionInfo.Size = new System.Drawing.Size(180, 22);
            this.tsmiVersionInfo.Text = "バージョン情報";
            this.tsmiVersionInfo.Click += new System.EventHandler(this.tsmiVersionInfo_Click);
            // 
            // ndgvCandela
            // 
            notation1.decimal_digit = 3;
            notation1.exponential_digit = 2;
            notation1.exponential_flag = false;
            this.ndgvCandela.CellsNotation = notation1;
            notation2.decimal_digit = 3;
            notation2.exponential_digit = 2;
            notation2.exponential_flag = false;
            this.ndgvCandela.ColumnsNotation = notation2;
            this.ndgvCandela.Location = new System.Drawing.Point(258, 65);
            this.ndgvCandela.Name = "ndgvCandela";
            notation3.decimal_digit = 3;
            notation3.exponential_digit = 2;
            notation3.exponential_flag = false;
            this.ndgvCandela.RowsNotation = notation3;
            this.ndgvCandela.Size = new System.Drawing.Size(752, 792);
            this.ndgvCandela.TabIndex = 43;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 866);
            this.Controls.Add(this.cbUserDefine);
            this.Controls.Add(this.cbDuplication);
            this.Controls.Add(this.cbReserved);
            this.Controls.Add(this.cbSpace);
            this.Controls.Add(this.cbUpper);
            this.Controls.Add(this.cbLength);
            this.Controls.Add(this.nudNumberOfLamps);
            this.Controls.Add(this.dgvKeywords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTilt);
            this.Controls.Add(this.tbNumberOfTiltAngles);
            this.Controls.Add(this.tbNumberOfTiltAnglesLabel);
            this.Controls.Add(this.tbLampToLuminaireGeometryLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ndgvCandela);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.cmbUnitType);
            this.Controls.Add(this.cmbPhotometricType);
            this.Controls.Add(this.tbInputWatts);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.tbFutureUse);
            this.Controls.Add(this.tbFutureUseOfFileGenerationInfoLabel);
            this.Controls.Add(this.tbBallastFactor);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.tbNumberOfHorizontalAngles);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.tbNumberOfVerticalAngles);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tbMultiplier);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tbLumensPerLamp);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbTilt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChunk);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.nudLampToLuminaireGeometry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms;
            this.MinimumSize = new System.Drawing.Size(1028, 607);
            this.Name = "MainForm";
            this.Text = "Aglaia";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeywords)).EndInit();
            this.cmsKeywords.ResumeLayout(false);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTilt)).EndInit();
            this.cmsTilt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLampToLuminaireGeometry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfLamps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKeywords;
        private System.Windows.Forms.ComboBox cmbChunk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTilt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTilt;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiGraph;
        private System.Windows.Forms.ToolStripMenuItem tsmiIlluView;
        private System.Windows.Forms.ToolStripMenuItem 直射水平面照度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配光特性ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbLumensPerLamp;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbMultiplier;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbNumberOfVerticalAngles;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbNumberOfHorizontalAngles;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox tbFutureUse;
        private System.Windows.Forms.TextBox tbFutureUseOfFileGenerationInfoLabel;
        private System.Windows.Forms.TextBox tbBallastFactor;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox tbInputWatts;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.ComboBox cmbPhotometricType;
        private System.Windows.Forms.ComboBox cmbUnitType;
        private System.Windows.Forms.ContextMenuStrip cmsKeywords;
        private System.Windows.Forms.ToolStripMenuItem tsmiKeywordsAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiKeywordsDelete;
        private Numeric.NumericDataGridView ndgvCandela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTEST;
        private System.Windows.Forms.ToolStripMenuItem tsmiTESTLAB;
        private System.Windows.Forms.ToolStripMenuItem tsmiISSUEDATE;
        private System.Windows.Forms.ToolStripMenuItem tsmiMANUFAC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLUMCAT;
        private System.Windows.Forms.ToolStripMenuItem tsmiLUMINAIRE;
        private System.Windows.Forms.ToolStripMenuItem tsmiLAMPCAT;
        private System.Windows.Forms.ToolStripMenuItem tsmiLAMP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiTESTDATE;
        private System.Windows.Forms.ToolStripMenuItem tsmiNEARFIELD;
        private System.Windows.Forms.ToolStripMenuItem tsmiBALLAST;
        private System.Windows.Forms.ToolStripMenuItem tsmiBALLASTCAT;
        private System.Windows.Forms.ToolStripMenuItem tsmiMAINTCAT;
        private System.Windows.Forms.ToolStripMenuItem tsmiDISTRIBUTION;
        private System.Windows.Forms.ToolStripMenuItem tsmiFLASHAREA;
        private System.Windows.Forms.ToolStripMenuItem tsmiCOLORCONSTANT;
        private System.Windows.Forms.ToolStripMenuItem tsmiLAMPPOSITION;
        private System.Windows.Forms.ToolStripMenuItem tsmiFILEGENINFO;
        private System.Windows.Forms.ToolStripMenuItem tsmiSEARCH;
        private System.Windows.Forms.ToolStripMenuItem tsmiMORE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox tstbUSERDEFINE;
        private System.Windows.Forms.TextBox tbNumberOfTiltAngles;
        private System.Windows.Forms.TextBox tbNumberOfTiltAnglesLabel;
        private System.Windows.Forms.TextBox tbLampToLuminaireGeometryLabel;
        private System.Windows.Forms.DataGridView dgvTilt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsTilt;
        private System.Windows.Forms.ToolStripMenuItem tsmiTiltAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiTiltDelete;
        private System.Windows.Forms.NumericUpDown nudLampToLuminaireGeometry;
        private System.Windows.Forms.NumericUpDown nudNumberOfLamps;
        private System.Windows.Forms.CheckBox cbLength;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbSpace;
        private System.Windows.Forms.CheckBox cbReserved;
        private System.Windows.Forms.CheckBox cbDuplication;
        private System.Windows.Forms.CheckBox cbUserDefine;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiVersionInfo;
    }
}

