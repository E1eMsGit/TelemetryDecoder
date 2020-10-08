namespace TelemetryDecoder
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.slDecodeTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnStartStopDecode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tlpDecodingParameters = new System.Windows.Forms.TableLayoutPanel();
            this.pRS = new System.Windows.Forms.Panel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.rbRSYes = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbRSNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.pNRZ = new System.Windows.Forms.Panel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.rbNRZYes = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbNRZNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblFileName = new MaterialSkin.Controls.MaterialLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.doubleBufferedPanel1 = new TelemetryDecoder.GuiElements.DoubleBufferedPanel();
            this.rtbDateTimeTitle = new TelemetryDecoder.GuiElements.DisabledRichTextBox();
            this.rtbDateTime = new TelemetryDecoder.GuiElements.DisabledRichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bwImageSaver = new System.ComponentModel.BackgroundWorker();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.pImage1 = new System.Windows.Forms.Panel();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.pImage2 = new System.Windows.Forms.Panel();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.pImage3 = new System.Windows.Forms.Panel();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.pImage4 = new System.Windows.Forms.Panel();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.pImage5 = new System.Windows.Forms.Panel();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.pImage6 = new System.Windows.Forms.Panel();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.pImage7 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.pImage8 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.pImage9 = new System.Windows.Forms.Panel();
            this.pImage10 = new System.Windows.Forms.Panel();
            this.pImage11 = new System.Windows.Forms.Panel();
            this.pImage12 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbMkoData = new TelemetryDecoder.GuiElements.DisabledRichTextBox();
            this.rtbMkoTitle = new TelemetryDecoder.GuiElements.DisabledRichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbServiceTitle = new TelemetryDecoder.GuiElements.DisabledRichTextBox();
            this.rtbServiceData = new TelemetryDecoder.GuiElements.DisabledRichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.statusStrip1.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tlpDecodingParameters.SuspendLayout();
            this.pRS.SuspendLayout();
            this.pNRZ.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.doubleBufferedPanel1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slTime,
            this.slDecodeTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 775);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1570, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slTime
            // 
            this.slTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.slTime.Image = global::TelemetryDecoder.Properties.Resources.time_icon;
            this.slTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(1488, 20);
            this.slTime.Spring = true;
            this.slTime.Text = "01/01/1668 12:12:01";
            this.slTime.ToolTipText = "Текущие дата/время";
            // 
            // slDecodeTime
            // 
            this.slDecodeTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.slDecodeTime.Image = global::TelemetryDecoder.Properties.Resources.time_icon;
            this.slDecodeTime.Name = "slDecodeTime";
            this.slDecodeTime.Size = new System.Drawing.Size(67, 20);
            this.slDecodeTime.Text = "0:00:0";
            this.slDecodeTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.slDecodeTime.ToolTipText = "Время декодирования";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.tableLayoutPanel3);
            this.pnlControls.Controls.Add(this.panel1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlControls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlControls.Location = new System.Drawing.Point(0, 59);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1570, 114);
            this.pnlControls.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tlpDecodingParameters, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1570, 114);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.btnStartStopDecode);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(709, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 108);
            this.panel5.TabIndex = 43;
            // 
            // btnStartStopDecode
            // 
            this.btnStartStopDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStopDecode.Depth = 0;
            this.btnStartStopDecode.Location = new System.Drawing.Point(0, 41);
            this.btnStartStopDecode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartStopDecode.Name = "btnStartStopDecode";
            this.btnStartStopDecode.Primary = true;
            this.btnStartStopDecode.Size = new System.Drawing.Size(151, 43);
            this.btnStartStopDecode.TabIndex = 43;
            this.btnStartStopDecode.Text = "Начать";
            this.btnStartStopDecode.UseVisualStyleBackColor = true;
            this.btnStartStopDecode.Click += new System.EventHandler(this.btnStartStopDecode_Click);
            // 
            // tlpDecodingParameters
            // 
            this.tlpDecodingParameters.BackColor = System.Drawing.SystemColors.Window;
            this.tlpDecodingParameters.ColumnCount = 3;
            this.tlpDecodingParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.59078F));
            this.tlpDecodingParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.9683F));
            this.tlpDecodingParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.44092F));
            this.tlpDecodingParameters.Controls.Add(this.pRS, 2, 0);
            this.tlpDecodingParameters.Controls.Add(this.pNRZ, 1, 0);
            this.tlpDecodingParameters.Controls.Add(this.panel4, 0, 0);
            this.tlpDecodingParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDecodingParameters.Location = new System.Drawing.Point(3, 3);
            this.tlpDecodingParameters.Name = "tlpDecodingParameters";
            this.tlpDecodingParameters.RowCount = 1;
            this.tlpDecodingParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDecodingParameters.Size = new System.Drawing.Size(700, 108);
            this.tlpDecodingParameters.TabIndex = 45;
            // 
            // pRS
            // 
            this.pRS.BackColor = System.Drawing.SystemColors.Window;
            this.pRS.Controls.Add(this.materialLabel9);
            this.pRS.Controls.Add(this.rbRSYes);
            this.pRS.Controls.Add(this.rbRSNo);
            this.pRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRS.Location = new System.Drawing.Point(342, 3);
            this.pRS.Name = "pRS";
            this.pRS.Size = new System.Drawing.Size(355, 102);
            this.pRS.TabIndex = 42;
            // 
            // materialLabel9
            // 
            this.materialLabel9.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 9);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(122, 19);
            this.materialLabel9.TabIndex = 38;
            this.materialLabel9.Text = "Рида-Соломона";
            // 
            // rbRSYes
            // 
            this.rbRSYes.Checked = true;
            this.rbRSYes.Depth = 0;
            this.rbRSYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbRSYes.Location = new System.Drawing.Point(7, 35);
            this.rbRSYes.Margin = new System.Windows.Forms.Padding(0);
            this.rbRSYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbRSYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRSYes.Name = "rbRSYes";
            this.rbRSYes.Ripple = true;
            this.rbRSYes.Size = new System.Drawing.Size(47, 30);
            this.rbRSYes.TabIndex = 36;
            this.rbRSYes.TabStop = true;
            this.rbRSYes.Text = "Да";
            this.rbRSYes.UseVisualStyleBackColor = true;
            // 
            // rbRSNo
            // 
            this.rbRSNo.Depth = 0;
            this.rbRSNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbRSNo.Location = new System.Drawing.Point(7, 65);
            this.rbRSNo.Margin = new System.Windows.Forms.Padding(0);
            this.rbRSNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbRSNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRSNo.Name = "rbRSNo";
            this.rbRSNo.Ripple = true;
            this.rbRSNo.Size = new System.Drawing.Size(53, 30);
            this.rbRSNo.TabIndex = 35;
            this.rbRSNo.Text = "Нет";
            this.rbRSNo.UseVisualStyleBackColor = true;
            // 
            // pNRZ
            // 
            this.pNRZ.BackColor = System.Drawing.SystemColors.Window;
            this.pNRZ.Controls.Add(this.materialLabel7);
            this.pNRZ.Controls.Add(this.rbNRZYes);
            this.pNRZ.Controls.Add(this.rbNRZNo);
            this.pNRZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNRZ.Location = new System.Drawing.Point(252, 3);
            this.pNRZ.Name = "pNRZ";
            this.pNRZ.Size = new System.Drawing.Size(84, 102);
            this.pNRZ.TabIndex = 43;
            // 
            // materialLabel7
            // 
            this.materialLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(3, 9);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(57, 19);
            this.materialLabel7.TabIndex = 37;
            this.materialLabel7.Text = "NRZ";
            // 
            // rbNRZYes
            // 
            this.rbNRZYes.Checked = true;
            this.rbNRZYes.Depth = 0;
            this.rbNRZYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbNRZYes.Location = new System.Drawing.Point(7, 35);
            this.rbNRZYes.Margin = new System.Windows.Forms.Padding(0);
            this.rbNRZYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNRZYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNRZYes.Name = "rbNRZYes";
            this.rbNRZYes.Ripple = true;
            this.rbNRZYes.Size = new System.Drawing.Size(47, 30);
            this.rbNRZYes.TabIndex = 36;
            this.rbNRZYes.TabStop = true;
            this.rbNRZYes.Text = "Да";
            this.rbNRZYes.UseVisualStyleBackColor = true;
            // 
            // rbNRZNo
            // 
            this.rbNRZNo.Depth = 0;
            this.rbNRZNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbNRZNo.Location = new System.Drawing.Point(7, 65);
            this.rbNRZNo.Margin = new System.Windows.Forms.Padding(0);
            this.rbNRZNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNRZNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNRZNo.Name = "rbNRZNo";
            this.rbNRZNo.Ripple = true;
            this.rbNRZNo.Size = new System.Drawing.Size(53, 30);
            this.rbNRZNo.TabIndex = 35;
            this.rbNRZNo.Text = "Нет";
            this.rbNRZNo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.materialLabel10);
            this.panel4.Controls.Add(this.btnOpenFile);
            this.panel4.Controls.Add(this.lblFileName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 102);
            this.panel4.TabIndex = 44;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(9, 9);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(92, 19);
            this.materialLabel10.TabIndex = 40;
            this.materialLabel10.Text = "Имя файла:";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AutoSize = true;
            this.btnOpenFile.Depth = 0;
            this.btnOpenFile.Location = new System.Drawing.Point(37, 41);
            this.btnOpenFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Primary = true;
            this.btnOpenFile.Size = new System.Drawing.Size(151, 43);
            this.btnOpenFile.TabIndex = 44;
            this.btnOpenFile.Text = "Выберите файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoEllipsis = true;
            this.lblFileName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFileName.Depth = 0;
            this.lblFileName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFileName.Location = new System.Drawing.Point(103, 9);
            this.lblFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(126, 19);
            this.lblFileName.TabIndex = 41;
            this.lblFileName.Text = "Файл не выбран";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.tableLayoutPanel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(866, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(701, 108);
            this.panel6.TabIndex = 44;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.45324F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.54676F));
            this.tableLayoutPanel5.Controls.Add(this.doubleBufferedPanel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(701, 108);
            this.tableLayoutPanel5.TabIndex = 45;
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.Controls.Add(this.rtbDateTimeTitle);
            this.doubleBufferedPanel1.Controls.Add(this.rtbDateTime);
            this.doubleBufferedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(3, 3);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(695, 102);
            this.doubleBufferedPanel1.TabIndex = 46;
            // 
            // rtbDateTimeTitle
            // 
            this.rtbDateTimeTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbDateTimeTitle.Location = new System.Drawing.Point(495, 0);
            this.rtbDateTimeTitle.Name = "rtbDateTimeTitle";
            this.rtbDateTimeTitle.Size = new System.Drawing.Size(100, 102);
            this.rtbDateTimeTitle.TabIndex = 46;
            this.rtbDateTimeTitle.Text = "";
            // 
            // rtbDateTime
            // 
            this.rtbDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbDateTime.Location = new System.Drawing.Point(595, 0);
            this.rtbDateTime.Name = "rtbDateTime";
            this.rtbDateTime.Size = new System.Drawing.Size(100, 102);
            this.rtbDateTime.TabIndex = 45;
            this.rtbDateTime.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 22;
            // 
            // bwImageSaver
            // 
            this.bwImageSaver.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwImageSaver_DoWork);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 173);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1570, 40);
            this.materialTabSelector1.TabIndex = 25;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage8);
            this.materialTabControl1.Controls.Add(this.tabPage9);
            this.materialTabControl1.Controls.Add(this.tabPage10);
            this.materialTabControl1.Controls.Add(this.tabPage11);
            this.materialTabControl1.Controls.Add(this.tabPage12);
            this.materialTabControl1.Controls.Add(this.tabPage13);
            this.materialTabControl1.Controls.Add(this.tabPage14);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 213);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1570, 562);
            this.materialTabControl1.TabIndex = 24;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.pImage1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1562, 536);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Канал 1";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // pImage1
            // 
            this.pImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImage1.Location = new System.Drawing.Point(3, 3);
            this.pImage1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pImage1.Name = "pImage1";
            this.pImage1.Size = new System.Drawing.Size(1556, 530);
            this.pImage1.TabIndex = 3;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.pImage2);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1562, 536);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Канал 2";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // pImage2
            // 
            this.pImage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImage2.Location = new System.Drawing.Point(3, 3);
            this.pImage2.Name = "pImage2";
            this.pImage2.Size = new System.Drawing.Size(1556, 530);
            this.pImage2.TabIndex = 4;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.pImage3);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1562, 536);
            this.tabPage10.TabIndex = 2;
            this.tabPage10.Text = "Канал 3";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // pImage3
            // 
            this.pImage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImage3.Location = new System.Drawing.Point(3, 3);
            this.pImage3.Name = "pImage3";
            this.pImage3.Size = new System.Drawing.Size(1556, 530);
            this.pImage3.TabIndex = 5;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.pImage4);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1562, 536);
            this.tabPage11.TabIndex = 3;
            this.tabPage11.Text = "Канал 4";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // pImage4
            // 
            this.pImage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImage4.Location = new System.Drawing.Point(3, 3);
            this.pImage4.Name = "pImage4";
            this.pImage4.Size = new System.Drawing.Size(1556, 530);
            this.pImage4.TabIndex = 6;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.pImage5);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1562, 536);
            this.tabPage12.TabIndex = 4;
            this.tabPage12.Text = "Канал 5";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // pImage5
            // 
            this.pImage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImage5.Location = new System.Drawing.Point(3, 3);
            this.pImage5.Name = "pImage5";
            this.pImage5.Size = new System.Drawing.Size(1556, 530);
            this.pImage5.TabIndex = 6;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.pImage6);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(1562, 536);
            this.tabPage13.TabIndex = 5;
            this.tabPage13.Text = "Канал 6";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // pImage6
            // 
            this.pImage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImage6.Location = new System.Drawing.Point(3, 3);
            this.pImage6.Name = "pImage6";
            this.pImage6.Size = new System.Drawing.Size(1556, 530);
            this.pImage6.TabIndex = 6;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.tableLayoutPanel1);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(1562, 536);
            this.tabPage14.TabIndex = 6;
            this.tabPage14.Text = "Все каналы";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pImage7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pImage8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pImage9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pImage10, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pImage11, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.pImage12, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.73684F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1556, 530);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(97, 4);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Канал 1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(356, 4);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Канал 2";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(615, 4);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(65, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Канал 3";
            // 
            // pImage7
            // 
            this.pImage7.Location = new System.Drawing.Point(10, 30);
            this.pImage7.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pImage7.Name = "pImage7";
            this.pImage7.Size = new System.Drawing.Size(235, 492);
            this.pImage7.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(874, 4);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Канал 4";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(1133, 4);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(65, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Канал 5";
            // 
            // pImage8
            // 
            this.pImage8.Location = new System.Drawing.Point(269, 30);
            this.pImage8.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pImage8.Name = "pImage8";
            this.pImage8.Size = new System.Drawing.Size(235, 492);
            this.pImage8.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(1393, 4);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Канал 6";
            // 
            // pImage9
            // 
            this.pImage9.Location = new System.Drawing.Point(528, 30);
            this.pImage9.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pImage9.Name = "pImage9";
            this.pImage9.Size = new System.Drawing.Size(235, 492);
            this.pImage9.TabIndex = 2;
            // 
            // pImage10
            // 
            this.pImage10.Location = new System.Drawing.Point(787, 30);
            this.pImage10.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pImage10.Name = "pImage10";
            this.pImage10.Size = new System.Drawing.Size(235, 492);
            this.pImage10.TabIndex = 3;
            // 
            // pImage11
            // 
            this.pImage11.Location = new System.Drawing.Point(1046, 30);
            this.pImage11.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pImage11.Name = "pImage11";
            this.pImage11.Size = new System.Drawing.Size(235, 492);
            this.pImage11.TabIndex = 4;
            // 
            // pImage12
            // 
            this.pImage12.Location = new System.Drawing.Point(1305, 30);
            this.pImage12.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pImage12.Name = "pImage12";
            this.pImage12.Size = new System.Drawing.Size(241, 492);
            this.pImage12.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1562, 536);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "МКО";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.04041F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.95959F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.tableLayoutPanel2.Controls.Add(this.rtbMkoData, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rtbMkoTitle, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1562, 490);
            this.tableLayoutPanel2.TabIndex = 107;
            // 
            // rtbMkoData
            // 
            this.rtbMkoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMkoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMkoData.Location = new System.Drawing.Point(964, 3);
            this.rtbMkoData.Name = "rtbMkoData";
            this.rtbMkoData.Size = new System.Drawing.Size(242, 484);
            this.rtbMkoData.TabIndex = 106;
            this.rtbMkoData.Text = "";
            // 
            // rtbMkoTitle
            // 
            this.rtbMkoTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMkoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMkoTitle.Location = new System.Drawing.Point(426, 3);
            this.rtbMkoTitle.Name = "rtbMkoTitle";
            this.rtbMkoTitle.Size = new System.Drawing.Size(532, 484);
            this.rtbMkoTitle.TabIndex = 105;
            this.rtbMkoTitle.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Window;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1562, 46);
            this.splitter1.TabIndex = 108;
            this.splitter1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Controls.Add(this.splitter2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1562, 536);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "Служебная информация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.08559F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.91441F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 507F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel4.Controls.Add(this.rtbServiceTitle, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.rtbServiceData, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1562, 490);
            this.tableLayoutPanel4.TabIndex = 110;
            // 
            // rtbServiceTitle
            // 
            this.rtbServiceTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbServiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbServiceTitle.Location = new System.Drawing.Point(426, 3);
            this.rtbServiceTitle.Name = "rtbServiceTitle";
            this.rtbServiceTitle.Size = new System.Drawing.Size(450, 484);
            this.rtbServiceTitle.TabIndex = 107;
            this.rtbServiceTitle.Text = "";
            // 
            // rtbServiceData
            // 
            this.rtbServiceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbServiceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbServiceData.Location = new System.Drawing.Point(882, 3);
            this.rtbServiceData.Name = "rtbServiceData";
            this.rtbServiceData.Size = new System.Drawing.Size(501, 484);
            this.rtbServiceData.TabIndex = 108;
            this.rtbServiceData.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Window;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1562, 46);
            this.splitter2.TabIndex = 109;
            this.splitter2.TabStop = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Enabled = false;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MaximumSize = new System.Drawing.Size(1, 59);
            this.materialDivider1.MinimumSize = new System.Drawing.Size(1, 59);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 59);
            this.materialDivider1.TabIndex = 26;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // FormDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 800);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "FormDecode";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telemetry Decoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDecode_FormClosing);
            this.Load += new System.EventHandler(this.FormDecode_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tlpDecodingParameters.ResumeLayout(false);
            this.pRS.ResumeLayout(false);
            this.pNRZ.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bwImageSaver;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRadioButton rbRSYes;
        private MaterialSkin.Controls.MaterialRadioButton rbRSNo;
        private MaterialSkin.Controls.MaterialRadioButton rbNRZYes;
        private MaterialSkin.Controls.MaterialRadioButton rbNRZNo;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblFileName;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.Panel pRS;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenFile;
        private System.Windows.Forms.Panel pNRZ;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartStopDecode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tlpDecodingParameters;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Panel pImage1;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Panel pImage2;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Panel pImage3;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Panel pImage4;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Panel pImage5;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Panel pImage6;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private GuiElements.DoubleBufferedPanel doubleBufferedPanel1;
        private GuiElements.DisabledRichTextBox rtbDateTimeTitle;
        private GuiElements.DisabledRichTextBox rtbDateTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Panel pImage7;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel pImage8;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel pImage9;
        private System.Windows.Forms.Panel pImage10;
        private System.Windows.Forms.Panel pImage11;
        private System.Windows.Forms.Panel pImage12;
        private System.Windows.Forms.TabPage tabPage2;
        private GuiElements.DisabledRichTextBox rtbServiceData;
        private GuiElements.DisabledRichTextBox rtbServiceTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private GuiElements.DisabledRichTextBox rtbMkoData;
        private GuiElements.DisabledRichTextBox rtbMkoTitle;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolStripStatusLabel slTime;
        private System.Windows.Forms.ToolStripStatusLabel slDecodeTime;
    }
}

