using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IESNA;
using IlluView;

namespace Aglaia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        LM63 _ies = null;
        LM63 ies
        {
            get
            {
                return _ies;
            }
            set
            {
                if (_ies == value)
                {
                    return;
                }

                _ies = value;

                if (IESChanged != null)
                {
                    IESChanged(this, new EventArgs());
                }
            }
        }

        event EventHandler IESChanged;

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbChunk.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChunk.DataSource = LM63.EditionList;

            cmbTilt.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPhotometricType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPhotometricType.DataSource = Data.PhotometricTypeList;

            cmbUnitType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitType.DataSource = Data.UnitsTypeList;

            IESChanged += MainForm_IESChanged;
            cmbTilt.SelectedValueChanged += CmbTilt_SelectedValueChanged;

            ies = new LM63();
        }

        ErrorProvider ep = new ErrorProvider();

        private void EditionChanged()
        {
            cmbTilt.DataSource = ies.tilt.TiltList;

            switch (ies.Edition)
            {
                case Editions.LM631995:
                case Editions.LM632002:
                    tbFutureUseOfFileGenerationInfoLabel.Text = "future use";
                    break;
                case Editions.LM632019:
                    tbFutureUseOfFileGenerationInfoLabel.Text = "file generation info";
                    break;
                case Editions.LM631986:
                case Editions.LM631991:
                default:
                    tbFutureUseOfFileGenerationInfoLabel.Text = "ballast-lamp photometric factor";
                    break;
            }
        }

        private void MainForm_IESChanged(object sender, EventArgs e)
        {
            //
            // Chunk
            //
            ies.EditionChanged += EditionChanged;
            cmbChunk.DataBindings.Clear();
            cmbChunk.DataBindings.Add("SelectedItem", ies, "Edition", true, DataSourceUpdateMode.OnPropertyChanged);

            //
            // Keywords
            //
            //dgvKeywords.DataSource = null;
            dgvKeywords.DataSource = ies.keywords.dt;

            cbLength.DataBindings.Clear();
            cbLength.DataBindings.Add("Checked", ies.keywords.rule_option, "LengthCheck", true, DataSourceUpdateMode.OnPropertyChanged);
            cbUpper.DataBindings.Clear();
            cbUpper.DataBindings.Add("Checked", ies.keywords.rule_option, "UpperCheck", true, DataSourceUpdateMode.OnPropertyChanged);
            cbSpace.DataBindings.Clear();
            cbSpace.DataBindings.Add("Checked", ies.keywords.rule_option, "SpaceCheck", true, DataSourceUpdateMode.OnPropertyChanged);
            cbReserved.DataBindings.Clear();
            cbReserved.DataBindings.Add("Checked", ies.keywords.rule_option, "ReservedCheck", true, DataSourceUpdateMode.OnPropertyChanged);
            cbDuplication.DataBindings.Clear();
            cbDuplication.DataBindings.Add("Checked", ies.keywords.rule_option, "DuplicationCheck", true, DataSourceUpdateMode.OnPropertyChanged);
            cbUserDefine.DataBindings.Clear();
            cbUserDefine.DataBindings.Add("Checked", ies.keywords.rule_option, "UserDefineCheck", true, DataSourceUpdateMode.OnPropertyChanged);

            //ies.keywords.rule_option.RuleOptionChanged += RuleOptionChanged;
            ies.keywords.rule_option.RuleOptionChanged += RuleOptionChanged;

            //
            // Tilt
            //
            {

                //cmbTilt.DropDownStyle = ComboBoxStyle.DropDownList;
                //cmbTilt.DataBindings.Clear();
                cmbTilt.DataBindings.Clear();
                cmbTilt.DataSource = ies.tilt.TiltList; // この実行でCmbTilt_SelectedValueChangedに飛ぶ
                cmbTilt.DataBindings.Add("SelectedItem", ies.tilt, "status", true, DataSourceUpdateMode.OnPropertyChanged);
                ies.tilt.PropertyChanged += TiltPropertyChanged;

                tbTilt.DataBindings.Clear();
                tbTilt.DataBindings.Add("Text", ies.tilt, "filepath", true, DataSourceUpdateMode.OnPropertyChanged);

                nudLampToLuminaireGeometry.DataBindings.Clear();
                nudLampToLuminaireGeometry.DataBindings.Add("Value", ies.tilt, "lamp_to_luminaire_geometry", true, DataSourceUpdateMode.OnPropertyChanged);

                tbNumberOfTiltAngles.DataBindings.Clear();
                tbNumberOfTiltAngles.DataBindings.Add("Text", ies.tilt, "number_of_tilt_angles", true, DataSourceUpdateMode.OnPropertyChanged);

                //dgvTilt.DataSource = null;
                dgvTilt.DataSource = ies.tilt.dt.DefaultView;
            }

            //
            // Data(Condition)
            //
            nudNumberOfLamps.DataBindings.Clear();
            nudNumberOfLamps.DataBindings.Add("Value", ies.data, "number_of_lamps", true, DataSourceUpdateMode.OnPropertyChanged);

            tbLumensPerLamp.DataBindings.Clear();
            tbLumensPerLamp.DataBindings.Add("Text", ies.data, "lumens_per_lamp", true, DataSourceUpdateMode.OnPropertyChanged);

            tbMultiplier.DataBindings.Clear();
            tbMultiplier.DataBindings.Add("Text", ies.data, "multiplier", true, DataSourceUpdateMode.OnPropertyChanged);

            tbNumberOfVerticalAngles.DataBindings.Clear();
            tbNumberOfVerticalAngles.DataBindings.Add("Text", ies.data, "number_of_vertical_angles", true, DataSourceUpdateMode.OnPropertyChanged);

            tbNumberOfHorizontalAngles.DataBindings.Clear();
            tbNumberOfHorizontalAngles.DataBindings.Add("Text", ies.data, "number_of_horizontal_angles", true, DataSourceUpdateMode.OnPropertyChanged);

            cmbPhotometricType.DataBindings.Clear();
            cmbPhotometricType.DataBindings.Add("Text", ies.data, "photometric_type", true, DataSourceUpdateMode.OnPropertyChanged);

            cmbUnitType.DataBindings.Clear();
            cmbUnitType.DataBindings.Add("Text", ies.data, "units_type", true, DataSourceUpdateMode.OnPropertyChanged);

            tbWidth.DataBindings.Clear();
            tbWidth.DataBindings.Add("Text", ies.data, "width", true, DataSourceUpdateMode.OnPropertyChanged);

            tbLength.DataBindings.Clear();
            tbLength.DataBindings.Add("Text", ies.data, "length", true, DataSourceUpdateMode.OnPropertyChanged);

            tbHeight.DataBindings.Clear();
            tbHeight.DataBindings.Add("Text", ies.data, "height", true, DataSourceUpdateMode.OnPropertyChanged);

            tbBallastFactor.DataBindings.Clear();
            tbBallastFactor.DataBindings.Add("Text", ies.data, "ballast_factor", true, DataSourceUpdateMode.OnPropertyChanged);

            tbFutureUse.DataBindings.Clear();
            tbFutureUse.DataBindings.Add("Text", ies.data, "future_use", true, DataSourceUpdateMode.OnPropertyChanged);

            tbInputWatts.DataBindings.Clear();
            tbInputWatts.DataBindings.Add("Text", ies.data, "input_watts", true, DataSourceUpdateMode.OnPropertyChanged);

            ies.data.PropertyChanged += DataPropertyChanged;

            //EditionChanged();

            //
            // Data(VertiAngle, HorizAngle, Candela)
            //
            ndgvCandela.ColumnsNotation = ies.data.vertical_angles_notation;
            ndgvCandela.RowsNotation = ies.data.horizontal_angles_notation;
            ndgvCandela.CellsNotation = ies.data.candela_notation;
            ndgvCandela.SetDataSource(ies.data.candela);


            //
            // DataGridViewの整形
            //
            {
                //
                // Keywords
                //
                dgvKeywords.Columns[0].Width = 99;
                dgvKeywords.Columns[1].Width = 110;
                dgvKeywords.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvKeywords.Columns[2].Visible = false;

                //
                // Tilt
                //
                dgvTilt.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTilt.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            //ies.EditionChanged += EditionChanged;
            //ies.keywords.rule_option.RuleOptionChanged += RuleOptionChanged;
            //ies.data.PropertyChanged += DataPropertyChanged;
            //ies.TiltMenuChanged += TiltMenuChanged;
            //PropertyChanged("status");
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                ies = LM63.LoadFile(ofdFile.FileName);
            }
            catch (Error err)
            {
                string msg = err.ErrorMessageInLoadFile();
                MessageBox.Show(msg);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            try
            {
                ies = LM63.LoadFile(fileName[0]);
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (sfdFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                ies.Save(sfdFile.FileName, " ");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvKeywords_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvKeywords.CurrentCell = dgvKeywords[e.ColumnIndex, e.RowIndex];
                dgvKeywords.CurrentCell.Selected = true;
            }
        }

        private void cmsKeywords_Opening(object sender, CancelEventArgs e)
        {
            Keyword[] keywords = null;
            if (ies.keywords.rule_option.DuplicationCheck == true)
            {
                keywords = ies.keywords.Search("TEST");
                tsmiTEST.Enabled = keywords == null;

                keywords = ies.keywords.Search("TESTLAB");
                tsmiTESTLAB.Enabled = keywords == null;

                keywords = ies.keywords.Search("ISSUEDATE");
                tsmiISSUEDATE.Enabled = keywords == null;

                keywords = ies.keywords.Search("MANUFAC");
                tsmiMANUFAC.Enabled = keywords == null;

                keywords = ies.keywords.Search("LUMCAT");
                tsmiLUMCAT.Enabled = keywords == null;

                keywords = ies.keywords.Search("LUMINAIRE");
                tsmiLUMINAIRE.Enabled = keywords == null;

                keywords = ies.keywords.Search("LAMPCAT");
                tsmiLAMPCAT.Enabled = keywords == null;

                keywords = ies.keywords.Search("LAMP");
                tsmiLAMP.Enabled = keywords == null;

                keywords = ies.keywords.Search("TESTDATE");
                tsmiTESTDATE.Enabled = keywords == null;

                keywords = ies.keywords.Search("NEARFIELD");
                tsmiNEARFIELD.Enabled = keywords == null;

                keywords = ies.keywords.Search("BALLAST");
                tsmiBALLAST.Enabled = keywords == null;

                keywords = ies.keywords.Search("BALLASTCAT");
                tsmiBALLASTCAT.Enabled = keywords == null;

                keywords = ies.keywords.Search("MAINTCAT");
                tsmiMAINTCAT.Enabled = keywords == null;

                keywords = ies.keywords.Search("DISTRIBUTION");
                tsmiDISTRIBUTION.Enabled = keywords == null;

                keywords = ies.keywords.Search("FLASHAREA");
                tsmiFLASHAREA.Enabled = keywords == null;

                keywords = ies.keywords.Search("COLORCONSTANT");
                tsmiCOLORCONSTANT.Enabled = keywords == null;

                keywords = ies.keywords.Search("LAMPPOSITION");
                tsmiLAMPPOSITION.Enabled = keywords == null;

                keywords = ies.keywords.Search("FILEGENINFO");
                tsmiFILEGENINFO.Enabled = keywords == null;

                keywords = ies.keywords.Search("SEARCH");
                tsmiSEARCH.Enabled = keywords == null;
            }
            else
            {
                tsmiTEST.Enabled = true;
                tsmiTESTLAB.Enabled = true;
                tsmiISSUEDATE.Enabled = true;
                tsmiMANUFAC.Enabled = true;
                tsmiLUMCAT.Enabled = true;
                tsmiLUMINAIRE.Enabled = true;
                tsmiLAMPCAT.Enabled = true;
                tsmiLAMP.Enabled = true;
                tsmiTESTDATE.Enabled = true;
                tsmiNEARFIELD.Enabled = true;
                tsmiBALLAST.Enabled = true;
                tsmiBALLASTCAT.Enabled = true;
                tsmiMAINTCAT.Enabled = true;
                tsmiDISTRIBUTION.Enabled = true;
                tsmiFLASHAREA.Enabled = true;
                tsmiCOLORCONSTANT.Enabled = true;
                tsmiLAMPPOSITION.Enabled = true;
                tsmiFILEGENINFO.Enabled = true;
                tsmiSEARCH.Enabled = true;
            }
        }

        private void tsmiTEST_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("TEST", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiTESTLAB_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("TESTLAB", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiISSUEDATE_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("ISSUEDATE", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiMANUFAC_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("MANUFAC", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiLUMCAT_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("LUMCAT", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiLUMINAIRE_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("LUMINAIRE", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiLAMPCAT_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("LAMPCAT", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiLAMP_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("LAMP", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiTESTDATE_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("TESTDATE", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiNEARFIELD_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("NEARFIELD", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiBALLAST_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("BALLAST", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiBALLASTCAT_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("BALLASTCAT", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiMAINTCAT_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("MAINTCAT", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiDISTRIBUTION_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("DISTRIBUTION", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiFLASHAREA_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("FLASHAREA", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiCOLORCONSTANT_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("COLORCONSTANT", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiLAMPPOSITION_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("LAMPPOSITION", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiFILEGENINFO_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("FILEGENINFO", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiSEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("SEARCH", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tsmiMORE_Click(object sender, EventArgs e)
        {
            try
            {
                ies.keywords.Add("MORE", "");
            }
            catch (Error err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tstbUSERDEFINE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    ies.keywords.Add(tstbUSERDEFINE.Text, "");
                }
                catch (Error err)
                {
                    e.Handled = false;
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    tstbUSERDEFINE.Text = "USER DEFINE";
                }

                cmsKeywords.Close();
            }
        }

        private void tsmiKeywordsDelete_Click(object sender, EventArgs e)
        {
            Guid guid = (Guid)dgvKeywords[2, dgvKeywords.CurrentCell.RowIndex].Value;
            ies.keywords.Delete(guid);
        }

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void dgvKeywords_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvKeywords.HitTest(e.X, e.Y).RowIndex;

            // ヘッダー以外
            if (rowIndexFromMouseDown > -1)
            {
                var dragSize = SystemInformation.DragSize;
                // ドラッグ操作が開始されない範囲を取得
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2), dragSize);
            }
            else
            {
                dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        private void dgvKeywords_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvKeywords_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((dragBoxFromMouseDown != Rectangle.Empty) && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DragDropEffects dropEffect = dgvKeywords.DoDragDrop(dgvKeywords.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
                }
            }
        }
        
        private void dgvKeywords_DragDrop(object sender, DragEventArgs e)
        {
            // データグリッドのポイントを取得
            Point clientPoint = dgvKeywords.PointToClient(new Point(e.X, e.Y));
            // 移動先INDEX
            rowIndexOfItemUnderMouseToDrop = dgvKeywords.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // ドラッグ＆ドロップ効果【移動】の場合・INDEX範囲内の場合
            if ((e.Effect == DragDropEffects.Move) && (rowIndexOfItemUnderMouseToDrop > -1))
            {
                ies.keywords.Move(rowIndexFromMouseDown, rowIndexOfItemUnderMouseToDrop);
            }

        }

        private void RuleOptionChanged(string name)
        {
            if (name == "LengthCheck")
            {
                cbLength.Checked = ies.keywords.rule_option.LengthCheck;
            }
            else if (name == "UpperCheck")
            {
                cbUpper.Checked = ies.keywords.rule_option.UpperCheck;
            }
            else if (name == "SpaceCheck")
            {
                cbSpace.Checked = ies.keywords.rule_option.SpaceCheck;
            }
            else if (name == "ReservedCheck")
            {
                cbReserved.Checked = ies.keywords.rule_option.ReservedCheck;
            }
            else if (name == "DuplicationCheck")
            {
                cbDuplication.Checked = ies.keywords.rule_option.DuplicationCheck;
            }
            else if (name == "UserDefineCheck")
            {
                cbUserDefine.Checked = ies.keywords.rule_option.UserDefineCheck;
            }

        }

        private void tsmiTiltAdd_Click(object sender, EventArgs e)
        {
            ies.tilt.Add();
        }

        private void tsmiTiltDelete_Click(object sender, EventArgs e)
        {
            int row_num = dgvTilt.CurrentCell.RowIndex;
            ies.tilt.Delete(row_num);

        }

        private void CmbTilt_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((Tilts)cmbTilt.SelectedItem == Tilts.NONE)
            {
                tbTilt.Enabled = false;
                tbLampToLuminaireGeometryLabel.Enabled = false;
                nudLampToLuminaireGeometry.Enabled = false;
                tbNumberOfTiltAnglesLabel.Enabled = false;
                tbNumberOfTiltAngles.Enabled = false;
                dgvTilt.Enabled = false;
            }
            else if ((Tilts)cmbTilt.SelectedItem == Tilts.INCLUDE)
            {
                tbTilt.Enabled = false;
                tbLampToLuminaireGeometryLabel.Enabled = true;
                nudLampToLuminaireGeometry.Enabled = true;
                tbNumberOfTiltAnglesLabel.Enabled = true;
                tbNumberOfTiltAngles.Enabled = true;
                dgvTilt.Enabled = true;
            }
            else
            {
                tbTilt.Enabled = true;
                tbLampToLuminaireGeometryLabel.Enabled = true;
                nudLampToLuminaireGeometry.Enabled = true;
                tbNumberOfTiltAnglesLabel.Enabled = true;
                tbNumberOfTiltAngles.Enabled = true;
                dgvTilt.Enabled = true;
            }
        }

        private void TiltPropertyChanged(string name)
        {
            if (name == "status")
            {
                cmbTilt.SelectedItem = ies.tilt.status;
            }
            else if (name == "filepath")
            {
                tbTilt.Text = ies.tilt.filepath;
            }
            else if (name == "number_of_tilt_angles")
            {
                tbNumberOfTiltAngles.Text = ies.tilt.number_of_tilt_angles.ToString();
            }
            else if (name == "lamp_to_lumilaire_geometry")
            {
                nudLampToLuminaireGeometry.Value = ies.tilt.lamp_to_luminaire_geometry;
            }
        }

        private void DataPropertyChanged(string name)
        {
            if (name == "number_of_lamps")
            {
                nudNumberOfLamps.Value = ies.data.number_of_lamps;
            }
            else if (name == "lumens_per_lamp")
            {
                tbLumensPerLamp.Text = ies.data.lumens_per_lamp.ToString();
            }
            else if (name == "multiplier")
            {
                tbMultiplier.Text = ies.data.multiplier.ToString();
            }
            else if (name == "number_of_vertical_angles")
            {
                tbNumberOfVerticalAngles.Text = ies.data.number_of_vertical_angles.ToString();
            }
            else if (name == "number_of_horizontal_angles")
            {
                tbNumberOfHorizontalAngles.Text = ies.data.number_of_horizontal_angles.ToString();
            }
            else if (name == "photometric_type")
            {
                cmbPhotometricType.SelectedItem = ies.data.photometric_type;
            }
            else if (name == "units_type")
            {
                cmbUnitType.SelectedItem = ies.data.units_type;
            }
            else if (name == "width")
            {
                tbWidth.Text = ies.data.width.ToString();
            }
            else if (name == "length")
            {
                tbLength.Text = ies.data.length.ToString();
            }
            else if (name == "height")
            {
                tbHeight.Text = ies.data.height.ToString();
            }
            else if (name == "ballast_factor")
            {
                tbBallastFactor.Text = ies.data.ballast_factor.ToString();
            }
            else if (name == "future_use")
            {
                tbFutureUse.Text = ies.data.future_use.ToString();
            }
            else if (name == "input_watts")
            {
                tbInputWatts.Text = ies.data.input_watts.ToString();
            }
        }

        private void Double_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                double tmp = double.Parse(tb.Text);
                ep.SetError(tb, "");
            }
            catch (Exception)
            {
                e.Cancel = true;

                ep.SetError(tb, "有効なのは実数");
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Size space = new Size(29, 51);
            ndgvCandela.Size = new Size(this.Size.Width - (ndgvCandela.Location.X + space.Width), this.Size.Height - (ndgvCandela.Location.Y + space.Height));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //ies.edition = Edition.LM632002;
            //ies.keywords.Add("_HOGE", "HOGEHOGE");  // USER DEFINE Pass
            //ies.keywords.Add("_HOGE", "Error");  // Dup Error
            //ies.keywords.Add("HOGE", "Error");  // Lost Underscore Error
            //ies.keywords.Add("_HOGE HOGE", "Error");  // Found Space Error
            //ies.keywords.Add("_goge HOGE", "Error");  // Not Upper Error
            //ies.keywords.Add("_234567890123456789", "Error");  // Length Error
            //ies.keywords.Add("BALLAST", "PASS");  // REGULAR
            ies.data.width = 0;
            ies.data.length = 0;
            ies.data.height = 1.0;
            Apertures ap = ies.data.aperture;
            return;
            //ies.tilt.status = TiltStatus.FILE;  // 2019ならエラーにならないといけない
            //ies.tilt.status = TiltStatus.INCLUDE; // pass
            //ies.tilt.status = TiltStatus.NONE; // pass
            //ies.tilt.lamp_to_luminaire_geometry = 0; // Invalid Specification
            //ies.tilt.lamp_to_luminaire_geometry = 2; // Invalid Specification
            //ies.tilt.number_of_tilt_angles = 10; // Error
            //ies.tilt.filepath = "HOGE"; // StatusIsNotFile
            //ies.data.number_of_lamps = 0;    // Invalid Specification
            //ies.data.lumens_per_lamp = 1.2; // pass
            //ies.data.multiplier = 3.2;  // pass
            //ies.data.number_of_vertical_angles = 4;   // Error
            //ies.data.number_of_horizontal_angles = 4;   // Error
            //ies.data.photometric_type = PhotometricTypes.A;  // pass
            //ies.data.units_type = UnitsTypes.FEET;   // pass
            //ies.data.width = -.1;
            //ies.data.length = -.2;
            //ies.data.height = -.3;
            //ies.data.ballast_factor = 4.3;
            //ies.data.future_use = 4;
            //ies.data.file_generation_info = 1.10001;
            //ies.data.input_watts = 40.2;
            //ies.data.candela.AddX(0.5);
            //ies.data.candela.AddY(0.6);
            //ies.data.candela.SetX(1, 91.5);
            //ies.data.candela.SetZ(0, 2, 2.0);
            ies.data.candela.UpdateDataTable += TESTRESULT;
            ies.data.candela.SetZ(0, 0, 1);
            ies.data.candela.SetZ(0, 1, 2);
            ies.data.candela.AddX(0);
            ies.data.candela.AddY(0);
            ies.data.candela.SetX(0, 10);
            ies.data.candela.SetY(0, 1.5);
            ies.data.candela.RemoveX(0);
            ies.data.candela.RemoveY(0);
        }

        int count = 0;
        private void TESTRESULT(Numeric.UpdateDataTableArgs e)
        {
            count++;
            string command_msg = e.Action.ToString();
            string x_msg = "";
            string y_msg = "";

            if (e.XIndexes == null)
            {
                x_msg = "null";
            }
            else
            {
                for (int i = 0; i < e.XIndexes.Length - 1; i++)
                {
                    x_msg += e.XIndexes[i].ToString() + ",";
                }
                x_msg += e.XIndexes[e.XIndexes.Length - 1].ToString() + "\t";
            }
            if (e.YIndexes == null)
            {
                y_msg += "null";
            }
            else
            {
                for (int i = 0; i < e.YIndexes.Length - 1; i++)
                {
                    y_msg += e.YIndexes[i].ToString() + ",";
                }
                y_msg += e.YIndexes[e.YIndexes.Length - 1].ToString();
            }
        }

        private void tsmiIlluView_Click(object sender, EventArgs e)
        {
            IlluViewForm form = new IlluViewForm();
            form.Show();
            form.SetIES(_ies);
        }

        private void nudNumberOfLamps_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tsmiVersionInfo_Click(object sender, EventArgs e)
        {
            VerForm verform = new VerForm();
            verform.ShowDialog();
        }
    }
}
