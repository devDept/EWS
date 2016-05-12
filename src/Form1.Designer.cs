namespace EyeshotWcfClientWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
                

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.treePicView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblConnectionId = new System.Windows.Forms.Label();            
            this.chkDeleteFiles = new System.Windows.Forms.CheckBox();
            this.numWidthImages = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeightImages = new System.Windows.Forms.NumericUpDown();
            this.grpBuffer = new System.Windows.Forms.GroupBox();
            this.trackDownload = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.trackUpload = new System.Windows.Forms.TrackBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExtraFiles = new System.Windows.Forms.Button();
            this.txtExtraFiles = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.pgImages = new System.Windows.Forms.TabPage();
            this.chkOs = new System.Windows.Forms.CheckBox();
            this.chkCsi = new System.Windows.Forms.CheckBox();
            this.grpImagesColors = new System.Windows.Forms.GroupBox();
            this.lblBottom = new System.Windows.Forms.Label();
            this.btnBottomColor = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnTopColor = new System.Windows.Forms.Button();
            this.grpImagesSize = new System.Windows.Forms.GroupBox();
            this.pgAutodesk = new System.Windows.Forms.TabPage();
            this.lblRegenAutodesk = new System.Windows.Forms.Label();
            this.numTolAutodesk = new System.Windows.Forms.NumericUpDown();
            this.chkAciColors = new System.Windows.Forms.CheckBox();
            this.pgObj = new System.Windows.Forms.TabPage();
            this.lblRegenObj = new System.Windows.Forms.Label();
            this.numTolObj = new System.Windows.Forms.NumericUpDown();
            this.pgStl = new System.Windows.Forms.TabPage();
            this.lblRegenStl = new System.Windows.Forms.Label();
            this.numTolStl = new System.Windows.Forms.NumericUpDown();
            this.pgGeneral = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpReadingSettings = new System.Windows.Forms.GroupBox();
            this.btnUpdateSettings = new System.Windows.Forms.Button();
            this.grpStepReading = new System.Windows.Forms.GroupBox();
            this.chkIncludeWires = new System.Windows.Forms.CheckBox();
            this.grpAutodeskReading = new System.Windows.Forms.GroupBox();
            this.chkSkipProxies = new System.Windows.Forms.CheckBox();
            this.chkSkipHatches = new System.Windows.Forms.CheckBox();
            this.grpConversionSettings = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.progressBarDownloads = new EyeshotWcfClientWinForms.ProgressBarWithText();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.btnGetFullLog = new System.Windows.Forms.Button();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.grpAddInquiries = new System.Windows.Forms.GroupBox();
            this.btnAddInquiries = new System.Windows.Forms.Button();
            this.cmbAddInquiries = new System.Windows.Forms.ComboBox();
            this.grpAddConversion = new System.Windows.Forms.GroupBox();
            this.btnAddConversion = new System.Windows.Forms.Button();
            this.cmbAddConversion = new System.Windows.Forms.ComboBox();
            this.grpAddTransformation = new System.Windows.Forms.GroupBox();
            this.cmbAddTransformation = new System.Windows.Forms.ComboBox();
            this.btnAddTransformation = new System.Windows.Forms.Button();
            this.grpAddImage = new System.Windows.Forms.GroupBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.cmbAddImage = new System.Windows.Forms.ComboBox();
            this.progressBarOperations = new EyeshotWcfClientWinForms.ProgressBarWithText();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstBoxTasks = new System.Windows.Forms.ListBox();
            this.linkWorkingMode = new System.Windows.Forms.LinkLabel();
            this.progressBarUploads = new EyeshotWcfClientWinForms.ProgressBarWithText();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeightImages)).BeginInit();
            this.grpBuffer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackUpload)).BeginInit();
            this.tabControlSettings.SuspendLayout();
            this.pgImages.SuspendLayout();
            this.grpImagesColors.SuspendLayout();
            this.grpImagesSize.SuspendLayout();
            this.pgAutodesk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTolAutodesk)).BeginInit();
            this.pgObj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTolObj)).BeginInit();
            this.pgStl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTolStl)).BeginInit();
            this.pgGeneral.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpReadingSettings.SuspendLayout();
            this.grpStepReading.SuspendLayout();
            this.grpAutodeskReading.SuspendLayout();
            this.grpConversionSettings.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.grpTasks.SuspendLayout();
            this.grpAddInquiries.SuspendLayout();
            this.grpAddConversion.SuspendLayout();
            this.grpAddTransformation.SuspendLayout();
            this.grpAddImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(88, 21);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(662, 20);
            this.txtInput.TabIndex = 5;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(7, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1107, 131);
            this.txtLog.TabIndex = 4;
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(6, 246);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(76, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Location = new System.Drawing.Point(19, 129);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(76, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnInputFile
            // 
            this.btnInputFile.Enabled = false;
            this.btnInputFile.Location = new System.Drawing.Point(6, 19);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(76, 23);
            this.btnInputFile.TabIndex = 7;
            this.btnInputFile.Text = "Input file";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(19, 632);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(85, 23);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(19, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(76, 23);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // treePicView
            // 
            this.treePicView.Location = new System.Drawing.Point(6, 17);
            this.treePicView.Name = "treePicView";
            this.treePicView.Size = new System.Drawing.Size(263, 225);
            this.treePicView.TabIndex = 16;
            this.treePicView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treePicView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblConnectionId
            // 
            this.lblConnectionId.Location = new System.Drawing.Point(101, 16);
            this.lblConnectionId.Name = "lblConnectionId";
            this.lblConnectionId.Size = new System.Drawing.Size(150, 17);
            this.lblConnectionId.TabIndex = 17;
            this.lblConnectionId.Text = "Id:";            
            // 
            // chkDeleteFiles
            // 
            this.chkDeleteFiles.AutoSize = true;
            this.chkDeleteFiles.Checked = true;
            this.chkDeleteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeleteFiles.Location = new System.Drawing.Point(6, 112);
            this.chkDeleteFiles.Name = "chkDeleteFiles";
            this.chkDeleteFiles.Size = new System.Drawing.Size(218, 17);
            this.chkDeleteFiles.TabIndex = 21;
            this.chkDeleteFiles.Text = "Delete downloaded files after disconnect";
            this.chkDeleteFiles.UseVisualStyleBackColor = true;
            // 
            // numWidthImages
            // 
            this.numWidthImages.Location = new System.Drawing.Point(53, 19);
            this.numWidthImages.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numWidthImages.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWidthImages.Name = "numWidthImages";
            this.numWidthImages.Size = new System.Drawing.Size(55, 20);
            this.numWidthImages.TabIndex = 24;
            this.numWidthImages.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 21);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 25;
            this.lblWidth.Text = "Width:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(3, 49);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 27;
            this.lblHeight.Text = "Height:";
            // 
            // numHeightImages
            // 
            this.numHeightImages.Location = new System.Drawing.Point(53, 47);
            this.numHeightImages.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numHeightImages.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeightImages.Name = "numHeightImages";
            this.numHeightImages.Size = new System.Drawing.Size(55, 20);
            this.numHeightImages.TabIndex = 26;
            this.numHeightImages.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // grpBuffer
            // 
            this.grpBuffer.Controls.Add(this.trackDownload);
            this.grpBuffer.Controls.Add(this.lblSpeed);
            this.grpBuffer.Controls.Add(this.lblDownload);
            this.grpBuffer.Controls.Add(this.lblUpload);
            this.grpBuffer.Controls.Add(this.trackUpload);
            this.grpBuffer.Location = new System.Drawing.Point(6, 6);
            this.grpBuffer.Name = "grpBuffer";
            this.grpBuffer.Size = new System.Drawing.Size(363, 100);
            this.grpBuffer.TabIndex = 28;
            this.grpBuffer.TabStop = false;
            this.grpBuffer.Text = "Connection Speed";
            // 
            // trackDownload
            // 
            this.trackDownload.AutoSize = false;
            this.trackDownload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackDownload.LargeChange = 1;
            this.trackDownload.Location = new System.Drawing.Point(67, 68);
            this.trackDownload.Maximum = 5;
            this.trackDownload.Name = "trackDownload";
            this.trackDownload.Size = new System.Drawing.Size(250, 24);
            this.trackDownload.TabIndex = 29;
            this.trackDownload.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackDownload.Value = 3;
            this.trackDownload.ValueChanged += new System.EventHandler(this.trackDownload_ValueChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(51, 19);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(282, 13);
            this.lblSpeed.TabIndex = 28;
            this.lblSpeed.Text = "Very Slow    Slow      Normal     Fast   Very Fast   Ultra Fast";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(6, 79);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(55, 13);
            this.lblDownload.TabIndex = 1;
            this.lblDownload.Text = "Download";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(6, 46);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(41, 13);
            this.lblUpload.TabIndex = 0;
            this.lblUpload.Text = "Upload";
            // 
            // trackUpload
            // 
            this.trackUpload.AutoSize = false;
            this.trackUpload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackUpload.LargeChange = 1;
            this.trackUpload.Location = new System.Drawing.Point(67, 35);
            this.trackUpload.Maximum = 5;
            this.trackUpload.Name = "trackUpload";
            this.trackUpload.Size = new System.Drawing.Size(250, 24);
            this.trackUpload.TabIndex = 27;
            this.trackUpload.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackUpload.Value = 2;
            this.trackUpload.ValueChanged += new System.EventHandler(this.trackUpload_ValueChanged);
            // 
            // btnExtraFiles
            // 
            this.btnExtraFiles.Enabled = false;
            this.btnExtraFiles.Location = new System.Drawing.Point(6, 48);
            this.btnExtraFiles.Name = "btnExtraFiles";
            this.btnExtraFiles.Size = new System.Drawing.Size(76, 23);
            this.btnExtraFiles.TabIndex = 30;
            this.btnExtraFiles.Text = "Extra files";
            this.toolTip1.SetToolTip(this.btnExtraFiles, "You can send additional files for OBJ (material and texture) or DWG (external ref" +
        "erences) files.");
            this.btnExtraFiles.UseVisualStyleBackColor = true;
            this.btnExtraFiles.Click += new System.EventHandler(this.btnExtraFiles_Click);
            // 
            // txtExtraFiles
            // 
            this.txtExtraFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtraFiles.BackColor = System.Drawing.Color.White;
            this.txtExtraFiles.Enabled = false;
            this.txtExtraFiles.Location = new System.Drawing.Point(88, 50);
            this.txtExtraFiles.Name = "txtExtraFiles";
            this.txtExtraFiles.ReadOnly = true;
            this.txtExtraFiles.Size = new System.Drawing.Size(662, 20);
            this.txtExtraFiles.TabIndex = 29;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.pgImages);
            this.tabControlSettings.Controls.Add(this.pgAutodesk);
            this.tabControlSettings.Controls.Add(this.pgObj);
            this.tabControlSettings.Controls.Add(this.pgStl);
            this.tabControlSettings.Controls.Add(this.pgGeneral);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Location = new System.Drawing.Point(3, 16);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(355, 249);
            this.tabControlSettings.TabIndex = 31;
            // 
            // pgImages
            // 
            this.pgImages.Controls.Add(this.chkOs);
            this.pgImages.Controls.Add(this.chkCsi);
            this.pgImages.Controls.Add(this.grpImagesColors);
            this.pgImages.Controls.Add(this.grpImagesSize);
            this.pgImages.Location = new System.Drawing.Point(4, 22);
            this.pgImages.Name = "pgImages";
            this.pgImages.Padding = new System.Windows.Forms.Padding(3);
            this.pgImages.Size = new System.Drawing.Size(347, 223);
            this.pgImages.TabIndex = 1;
            this.pgImages.Text = "Images";
            this.pgImages.UseVisualStyleBackColor = true;
            // 
            // chkOs
            // 
            this.chkOs.AutoSize = true;
            this.chkOs.Enabled = false;
            this.chkOs.Location = new System.Drawing.Point(6, 91);
            this.chkOs.Name = "chkOs";
            this.chkOs.Size = new System.Drawing.Size(120, 17);
            this.chkOs.TabIndex = 24;
            this.chkOs.Text = "Show Origin Symbol";
            this.chkOs.UseVisualStyleBackColor = true;
            // 
            // chkCsi
            // 
            this.chkCsi.AutoSize = true;
            this.chkCsi.Enabled = false;
            this.chkCsi.Location = new System.Drawing.Point(141, 91);
            this.chkCsi.Name = "chkCsi";
            this.chkCsi.Size = new System.Drawing.Size(168, 17);
            this.chkCsi.TabIndex = 22;
            this.chkCsi.Text = "Show Coordinate System Icon";
            this.chkCsi.UseVisualStyleBackColor = true;
            // 
            // grpImagesColors
            // 
            this.grpImagesColors.Controls.Add(this.lblBottom);
            this.grpImagesColors.Controls.Add(this.btnBottomColor);
            this.grpImagesColors.Controls.Add(this.lblTop);
            this.grpImagesColors.Controls.Add(this.btnTopColor);
            this.grpImagesColors.Location = new System.Drawing.Point(141, 6);
            this.grpImagesColors.Name = "grpImagesColors";
            this.grpImagesColors.Size = new System.Drawing.Size(129, 79);
            this.grpImagesColors.TabIndex = 1;
            this.grpImagesColors.TabStop = false;
            this.grpImagesColors.Text = "Colors";
            // 
            // lblBottom
            // 
            this.lblBottom.AutoSize = true;
            this.lblBottom.Location = new System.Drawing.Point(6, 49);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(40, 13);
            this.lblBottom.TabIndex = 85;
            this.lblBottom.Text = "Bottom";
            // 
            // btnBottomColor
            // 
            this.btnBottomColor.BackColor = System.Drawing.Color.White;
            this.btnBottomColor.Location = new System.Drawing.Point(57, 44);
            this.btnBottomColor.Name = "btnBottomColor";
            this.btnBottomColor.Size = new System.Drawing.Size(66, 22);
            this.btnBottomColor.TabIndex = 84;
            this.btnBottomColor.UseVisualStyleBackColor = false;
            this.btnBottomColor.Click += new System.EventHandler(this.btnBottomColor_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(6, 21);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(26, 13);
            this.lblTop.TabIndex = 83;
            this.lblTop.Text = "Top";
            // 
            // btnTopColor
            // 
            this.btnTopColor.BackColor = System.Drawing.Color.White;
            this.btnTopColor.Location = new System.Drawing.Point(57, 16);
            this.btnTopColor.Name = "btnTopColor";
            this.btnTopColor.Size = new System.Drawing.Size(66, 22);
            this.btnTopColor.TabIndex = 82;
            this.btnTopColor.UseVisualStyleBackColor = false;
            this.btnTopColor.Click += new System.EventHandler(this.btnTopColor_Click);
            // 
            // grpImagesSize
            // 
            this.grpImagesSize.Controls.Add(this.numWidthImages);
            this.grpImagesSize.Controls.Add(this.lblWidth);
            this.grpImagesSize.Controls.Add(this.numHeightImages);
            this.grpImagesSize.Controls.Add(this.lblHeight);
            this.grpImagesSize.Location = new System.Drawing.Point(6, 6);
            this.grpImagesSize.Name = "grpImagesSize";
            this.grpImagesSize.Size = new System.Drawing.Size(129, 79);
            this.grpImagesSize.TabIndex = 0;
            this.grpImagesSize.TabStop = false;
            this.grpImagesSize.Text = "Size";
            // 
            // pgAutodesk
            // 
            this.pgAutodesk.Controls.Add(this.lblRegenAutodesk);
            this.pgAutodesk.Controls.Add(this.numTolAutodesk);
            this.pgAutodesk.Controls.Add(this.chkAciColors);
            this.pgAutodesk.Location = new System.Drawing.Point(4, 22);
            this.pgAutodesk.Name = "pgAutodesk";
            this.pgAutodesk.Padding = new System.Windows.Forms.Padding(3);
            this.pgAutodesk.Size = new System.Drawing.Size(347, 223);
            this.pgAutodesk.TabIndex = 2;
            this.pgAutodesk.Text = "DWG/DXF";
            this.pgAutodesk.UseVisualStyleBackColor = true;
            // 
            // lblRegenAutodesk
            // 
            this.lblRegenAutodesk.AutoSize = true;
            this.lblRegenAutodesk.Location = new System.Drawing.Point(7, 63);
            this.lblRegenAutodesk.Name = "lblRegenAutodesk";
            this.lblRegenAutodesk.Size = new System.Drawing.Size(86, 13);
            this.lblRegenAutodesk.TabIndex = 28;
            this.lblRegenAutodesk.Text = "Regen tolerance";
            // 
            // numTolAutodesk
            // 
            this.numTolAutodesk.DecimalPlaces = 4;
            this.numTolAutodesk.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTolAutodesk.Location = new System.Drawing.Point(99, 61);
            this.numTolAutodesk.Name = "numTolAutodesk";
            this.numTolAutodesk.Size = new System.Drawing.Size(90, 20);
            this.numTolAutodesk.TabIndex = 27;
            this.numTolAutodesk.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // chkAciColors
            // 
            this.chkAciColors.AutoSize = true;
            this.chkAciColors.Checked = true;
            this.chkAciColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAciColors.Location = new System.Drawing.Point(10, 19);
            this.chkAciColors.Name = "chkAciColors";
            this.chkAciColors.Size = new System.Drawing.Size(215, 30);
            this.chkAciColors.TabIndex = 26;
            this.chkAciColors.Text = "Save the colors as Aci colors if possible.\r\n(Autocad color index)";
            this.chkAciColors.UseVisualStyleBackColor = true;
            // 
            // pgObj
            // 
            this.pgObj.Controls.Add(this.lblRegenObj);
            this.pgObj.Controls.Add(this.numTolObj);
            this.pgObj.Location = new System.Drawing.Point(4, 22);
            this.pgObj.Name = "pgObj";
            this.pgObj.Padding = new System.Windows.Forms.Padding(3);
            this.pgObj.Size = new System.Drawing.Size(347, 223);
            this.pgObj.TabIndex = 3;
            this.pgObj.Text = "OBJ";
            this.pgObj.UseVisualStyleBackColor = true;
            // 
            // lblRegenObj
            // 
            this.lblRegenObj.AutoSize = true;
            this.lblRegenObj.Location = new System.Drawing.Point(7, 22);
            this.lblRegenObj.Name = "lblRegenObj";
            this.lblRegenObj.Size = new System.Drawing.Size(86, 13);
            this.lblRegenObj.TabIndex = 28;
            this.lblRegenObj.Text = "Regen tolerance";
            // 
            // numTolObj
            // 
            this.numTolObj.DecimalPlaces = 4;
            this.numTolObj.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTolObj.Location = new System.Drawing.Point(99, 20);
            this.numTolObj.Name = "numTolObj";
            this.numTolObj.Size = new System.Drawing.Size(90, 20);
            this.numTolObj.TabIndex = 27;
            this.numTolObj.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // pgStl
            // 
            this.pgStl.Controls.Add(this.lblRegenStl);
            this.pgStl.Controls.Add(this.numTolStl);
            this.pgStl.Location = new System.Drawing.Point(4, 22);
            this.pgStl.Name = "pgStl";
            this.pgStl.Padding = new System.Windows.Forms.Padding(3);
            this.pgStl.Size = new System.Drawing.Size(347, 223);
            this.pgStl.TabIndex = 4;
            this.pgStl.Text = "STL";
            this.pgStl.UseVisualStyleBackColor = true;
            // 
            // lblRegenStl
            // 
            this.lblRegenStl.AutoSize = true;
            this.lblRegenStl.Location = new System.Drawing.Point(7, 22);
            this.lblRegenStl.Name = "lblRegenStl";
            this.lblRegenStl.Size = new System.Drawing.Size(86, 13);
            this.lblRegenStl.TabIndex = 28;
            this.lblRegenStl.Text = "Regen tolerance";
            // 
            // numTolStl
            // 
            this.numTolStl.DecimalPlaces = 4;
            this.numTolStl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTolStl.Location = new System.Drawing.Point(99, 20);
            this.numTolStl.Name = "numTolStl";
            this.numTolStl.Size = new System.Drawing.Size(90, 20);
            this.numTolStl.TabIndex = 27;
            this.numTolStl.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // pgGeneral
            // 
            this.pgGeneral.Controls.Add(this.grpBuffer);
            this.pgGeneral.Controls.Add(this.chkDeleteFiles);
            this.pgGeneral.Location = new System.Drawing.Point(4, 22);
            this.pgGeneral.Name = "pgGeneral";
            this.pgGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.pgGeneral.Size = new System.Drawing.Size(347, 223);
            this.pgGeneral.TabIndex = 0;
            this.pgGeneral.Text = "General";
            this.pgGeneral.UseVisualStyleBackColor = true;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnInputFile);
            this.grpInput.Controls.Add(this.txtInput);            
            this.grpInput.Controls.Add(this.txtExtraFiles);
            this.grpInput.Controls.Add(this.btnExtraFiles);
            this.grpInput.Location = new System.Drawing.Point(13, 45);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(759, 78);
            this.grpInput.TabIndex = 39;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // grpReadingSettings
            // 
            this.grpReadingSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReadingSettings.Controls.Add(this.btnUpdateSettings);
            this.grpReadingSettings.Controls.Add(this.grpStepReading);
            this.grpReadingSettings.Controls.Add(this.grpAutodeskReading);
            this.grpReadingSettings.Location = new System.Drawing.Point(778, 45);
            this.grpReadingSettings.Name = "grpReadingSettings";
            this.grpReadingSettings.Size = new System.Drawing.Size(361, 143);
            this.grpReadingSettings.TabIndex = 40;
            this.grpReadingSettings.TabStop = false;
            this.grpReadingSettings.Text = "Reading settings";
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.Enabled = false;
            this.btnUpdateSettings.Location = new System.Drawing.Point(11, 114);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateSettings.TabIndex = 44;
            this.btnUpdateSettings.Text = "Update settings";
            this.btnUpdateSettings.UseVisualStyleBackColor = true;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click);
            // 
            // grpStepReading
            // 
            this.grpStepReading.Controls.Add(this.chkIncludeWires);
            this.grpStepReading.Location = new System.Drawing.Point(148, 21);
            this.grpStepReading.Name = "grpStepReading";
            this.grpStepReading.Size = new System.Drawing.Size(120, 69);
            this.grpStepReading.TabIndex = 2;
            this.grpStepReading.TabStop = false;
            this.grpStepReading.Text = "STEP";
            // 
            // chkIncludeWires
            // 
            this.chkIncludeWires.AutoSize = true;
            this.chkIncludeWires.Location = new System.Drawing.Point(6, 20);
            this.chkIncludeWires.Name = "chkIncludeWires";
            this.chkIncludeWires.Size = new System.Drawing.Size(88, 17);
            this.chkIncludeWires.TabIndex = 0;
            this.chkIncludeWires.Text = "Include wires";
            this.chkIncludeWires.UseVisualStyleBackColor = true;
            // 
            // grpAutodeskReading
            // 
            this.grpAutodeskReading.Controls.Add(this.chkSkipProxies);
            this.grpAutodeskReading.Controls.Add(this.chkSkipHatches);
            this.grpAutodeskReading.Location = new System.Drawing.Point(11, 21);
            this.grpAutodeskReading.Name = "grpAutodeskReading";
            this.grpAutodeskReading.Size = new System.Drawing.Size(120, 69);
            this.grpAutodeskReading.TabIndex = 0;
            this.grpAutodeskReading.TabStop = false;
            this.grpAutodeskReading.Text = "DWG/DXF";
            // 
            // chkSkipProxies
            // 
            this.chkSkipProxies.AutoSize = true;
            this.chkSkipProxies.Checked = true;
            this.chkSkipProxies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipProxies.Location = new System.Drawing.Point(6, 43);
            this.chkSkipProxies.Name = "chkSkipProxies";
            this.chkSkipProxies.Size = new System.Drawing.Size(83, 17);
            this.chkSkipProxies.TabIndex = 1;
            this.chkSkipProxies.Text = "Skip proxies";
            this.chkSkipProxies.UseVisualStyleBackColor = true;
            // 
            // chkSkipHatches
            // 
            this.chkSkipHatches.AutoSize = true;
            this.chkSkipHatches.Checked = true;
            this.chkSkipHatches.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipHatches.Location = new System.Drawing.Point(6, 20);
            this.chkSkipHatches.Name = "chkSkipHatches";
            this.chkSkipHatches.Size = new System.Drawing.Size(88, 17);
            this.chkSkipHatches.TabIndex = 0;
            this.chkSkipHatches.Text = "Skip hatches";
            this.chkSkipHatches.UseVisualStyleBackColor = true;
            // 
            // grpConversionSettings
            // 
            this.grpConversionSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConversionSettings.Controls.Add(this.tabControlSettings);
            this.grpConversionSettings.Location = new System.Drawing.Point(778, 194);
            this.grpConversionSettings.Name = "grpConversionSettings";
            this.grpConversionSettings.Size = new System.Drawing.Size(361, 268);
            this.grpConversionSettings.TabIndex = 41;
            this.grpConversionSettings.TabStop = false;
            this.grpConversionSettings.Text = "Settings";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.treePicView);
            this.grpOutput.Controls.Add(this.btnDownload);
            this.grpOutput.Controls.Add(this.progressBarDownloads);
            this.grpOutput.Location = new System.Drawing.Point(497, 160);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(278, 302);
            this.grpOutput.TabIndex = 43;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // progressBarDownloads
            // 
            this.progressBarDownloads.CustomText = null;
            this.progressBarDownloads.DisplayMode = EyeshotWcfClientWinForms.ProgressBarDisplayType.TextAndPercentage;
            this.progressBarDownloads.Location = new System.Drawing.Point(6, 272);
            this.progressBarDownloads.Name = "progressBarDownloads";
            this.progressBarDownloads.Size = new System.Drawing.Size(263, 23);
            this.progressBarDownloads.TabIndex = 48;
            this.progressBarDownloads.TextLocation = EyeshotWcfClientWinForms.ProgressBarTextLocation.Left;
            // 
            // grpLog
            // 
            this.grpLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Location = new System.Drawing.Point(19, 464);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(1120, 162);
            this.grpLog.TabIndex = 44;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // btnGetFullLog
            // 
            this.btnGetFullLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFullLog.Enabled = false;
            this.btnGetFullLog.Location = new System.Drawing.Point(1054, 632);
            this.btnGetFullLog.Name = "btnGetFullLog";
            this.btnGetFullLog.Size = new System.Drawing.Size(85, 23);
            this.btnGetFullLog.TabIndex = 49;
            this.btnGetFullLog.Text = "Get Full Log";
            this.btnGetFullLog.UseVisualStyleBackColor = true;
            this.btnGetFullLog.Visible = false;
            this.btnGetFullLog.Click += new System.EventHandler(this.btnGetFullLog_Click);
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.grpAddInquiries);
            this.grpTasks.Controls.Add(this.grpAddConversion);
            this.grpTasks.Controls.Add(this.grpAddTransformation);
            this.grpTasks.Controls.Add(this.grpAddImage);
            this.grpTasks.Controls.Add(this.progressBarOperations);
            this.grpTasks.Controls.Add(this.btnExecute);
            this.grpTasks.Controls.Add(this.btnClear);
            this.grpTasks.Controls.Add(this.lstBoxTasks);
            this.grpTasks.Enabled = false;
            this.grpTasks.Location = new System.Drawing.Point(19, 160);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(472, 302);
            this.grpTasks.TabIndex = 50;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Tasks";
            // 
            // grpAddInquiries
            // 
            this.grpAddInquiries.Controls.Add(this.btnAddInquiries);
            this.grpAddInquiries.Controls.Add(this.cmbAddInquiries);
            this.grpAddInquiries.Location = new System.Drawing.Point(250, 191);
            this.grpAddInquiries.Name = "grpAddInquiries";
            this.grpAddInquiries.Size = new System.Drawing.Size(215, 49);
            this.grpAddInquiries.TabIndex = 19;
            this.grpAddInquiries.TabStop = false;
            this.grpAddInquiries.Text = "Analyze";
            // 
            // btnAddInquiries
            // 
            this.btnAddInquiries.Location = new System.Drawing.Point(133, 19);
            this.btnAddInquiries.Name = "btnAddInquiries";
            this.btnAddInquiries.Size = new System.Drawing.Size(75, 23);
            this.btnAddInquiries.TabIndex = 1;
            this.btnAddInquiries.Text = "Add";
            this.btnAddInquiries.UseVisualStyleBackColor = true;
            this.btnAddInquiries.Click += new System.EventHandler(this.btnAddInquiries_Click);
            // 
            // cmbAddInquiries
            // 
            this.cmbAddInquiries.FormattingEnabled = true;
            this.cmbAddInquiries.Location = new System.Drawing.Point(6, 19);
            this.cmbAddInquiries.Name = "cmbAddInquiries";
            this.cmbAddInquiries.Size = new System.Drawing.Size(121, 21);
            this.cmbAddInquiries.TabIndex = 0;
            // 
            // grpAddConversion
            // 
            this.grpAddConversion.Controls.Add(this.btnAddConversion);
            this.grpAddConversion.Controls.Add(this.cmbAddConversion);
            this.grpAddConversion.Location = new System.Drawing.Point(250, 75);
            this.grpAddConversion.Name = "grpAddConversion";
            this.grpAddConversion.Size = new System.Drawing.Size(215, 49);
            this.grpAddConversion.TabIndex = 17;
            this.grpAddConversion.TabStop = false;
            this.grpAddConversion.Text = "Conversion";
            // 
            // btnAddConversion
            // 
            this.btnAddConversion.Location = new System.Drawing.Point(133, 19);
            this.btnAddConversion.Name = "btnAddConversion";
            this.btnAddConversion.Size = new System.Drawing.Size(75, 23);
            this.btnAddConversion.TabIndex = 1;
            this.btnAddConversion.Text = "Add";
            this.btnAddConversion.UseVisualStyleBackColor = true;
            this.btnAddConversion.Click += new System.EventHandler(this.btnAddConversion_Click);
            // 
            // cmbAddConversion
            // 
            this.cmbAddConversion.FormattingEnabled = true;
            this.cmbAddConversion.Location = new System.Drawing.Point(6, 19);
            this.cmbAddConversion.Name = "cmbAddConversion";
            this.cmbAddConversion.Size = new System.Drawing.Size(121, 21);
            this.cmbAddConversion.TabIndex = 0;
            // 
            // grpAddTransformation
            // 
            this.grpAddTransformation.Controls.Add(this.cmbAddTransformation);
            this.grpAddTransformation.Controls.Add(this.btnAddTransformation);
            this.grpAddTransformation.Location = new System.Drawing.Point(250, 133);
            this.grpAddTransformation.Name = "grpAddTransformation";
            this.grpAddTransformation.Size = new System.Drawing.Size(215, 49);
            this.grpAddTransformation.TabIndex = 18;
            this.grpAddTransformation.TabStop = false;
            this.grpAddTransformation.Text = "Transform";
            // 
            // cmbAddTransformation
            // 
            this.cmbAddTransformation.FormattingEnabled = true;
            this.cmbAddTransformation.Location = new System.Drawing.Point(6, 19);
            this.cmbAddTransformation.Name = "cmbAddTransformation";
            this.cmbAddTransformation.Size = new System.Drawing.Size(121, 21);
            this.cmbAddTransformation.TabIndex = 0;
            // 
            // btnAddTransformation
            // 
            this.btnAddTransformation.Location = new System.Drawing.Point(133, 17);
            this.btnAddTransformation.Name = "btnAddTransformation";
            this.btnAddTransformation.Size = new System.Drawing.Size(76, 23);
            this.btnAddTransformation.TabIndex = 11;
            this.btnAddTransformation.Text = "Add";
            this.btnAddTransformation.UseVisualStyleBackColor = true;
            this.btnAddTransformation.Click += new System.EventHandler(this.btnTransformationsAdd_Click);
            // 
            // grpAddImage
            // 
            this.grpAddImage.Controls.Add(this.btnAddImage);
            this.grpAddImage.Controls.Add(this.cmbAddImage);
            this.grpAddImage.Location = new System.Drawing.Point(250, 17);
            this.grpAddImage.Name = "grpAddImage";
            this.grpAddImage.Size = new System.Drawing.Size(215, 49);
            this.grpAddImage.TabIndex = 16;
            this.grpAddImage.TabStop = false;
            this.grpAddImage.Text = "Image";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(133, 19);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 1;
            this.btnAddImage.Text = "Add";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // cmbAddImage
            // 
            this.cmbAddImage.FormattingEnabled = true;
            this.cmbAddImage.Location = new System.Drawing.Point(6, 19);
            this.cmbAddImage.Name = "cmbAddImage";
            this.cmbAddImage.Size = new System.Drawing.Size(121, 21);
            this.cmbAddImage.TabIndex = 0;
            // 
            // progressBarOperations
            // 
            this.progressBarOperations.CustomText = "Idle";
            this.progressBarOperations.DisplayMode = EyeshotWcfClientWinForms.ProgressBarDisplayType.TextAndPercentage;
            this.progressBarOperations.Location = new System.Drawing.Point(6, 273);
            this.progressBarOperations.Name = "progressBarOperations";
            this.progressBarOperations.Size = new System.Drawing.Size(459, 23);
            this.progressBarOperations.TabIndex = 12;
            this.progressBarOperations.TextLocation = EyeshotWcfClientWinForms.ProgressBarTextLocation.Left;
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(99, 246);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(87, 23);
            this.btnExecute.TabIndex = 15;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(6, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstBoxTasks
            // 
            this.lstBoxTasks.FormattingEnabled = true;
            this.lstBoxTasks.Location = new System.Drawing.Point(6, 17);
            this.lstBoxTasks.Name = "lstBoxTasks";
            this.lstBoxTasks.Size = new System.Drawing.Size(237, 225);
            this.lstBoxTasks.TabIndex = 0;
            // 
            // linkWorkingMode
            // 
            this.linkWorkingMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkWorkingMode.Location = new System.Drawing.Point(1037, 16);
            this.linkWorkingMode.Name = "linkWorkingMode";
            this.linkWorkingMode.Size = new System.Drawing.Size(102, 13);
            this.linkWorkingMode.TabIndex = 51;
            this.linkWorkingMode.TabStop = true;
            this.linkWorkingMode.Text = "Basic mode";
            this.linkWorkingMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkWorkingMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdvanced_LinkClicked);
            // 
            // progressBarUploads
            // 
            this.progressBarUploads.CustomText = "";
            this.progressBarUploads.DisplayMode = EyeshotWcfClientWinForms.ProgressBarDisplayType.TextAndPercentage;
            this.progressBarUploads.Location = new System.Drawing.Point(101, 129);
            this.progressBarUploads.Name = "progressBarUploads";
            this.progressBarUploads.Size = new System.Drawing.Size(665, 23);
            this.progressBarUploads.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarUploads.TabIndex = 47;
            this.progressBarUploads.TextLocation = EyeshotWcfClientWinForms.ProgressBarTextLocation.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 666);
            this.Controls.Add(this.linkWorkingMode);
            this.Controls.Add(this.grpTasks);
            this.Controls.Add(this.btnGetFullLog);
            this.Controls.Add(this.progressBarUploads);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpConversionSettings);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.grpReadingSettings);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblConnectionId);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "EWS Client";
            ((System.ComponentModel.ISupportInitialize)(this.numWidthImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeightImages)).EndInit();
            this.grpBuffer.ResumeLayout(false);
            this.grpBuffer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackUpload)).EndInit();
            this.tabControlSettings.ResumeLayout(false);
            this.pgImages.ResumeLayout(false);
            this.pgImages.PerformLayout();
            this.grpImagesColors.ResumeLayout(false);
            this.grpImagesColors.PerformLayout();
            this.grpImagesSize.ResumeLayout(false);
            this.grpImagesSize.PerformLayout();
            this.pgAutodesk.ResumeLayout(false);
            this.pgAutodesk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTolAutodesk)).EndInit();
            this.pgObj.ResumeLayout(false);
            this.pgObj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTolObj)).EndInit();
            this.pgStl.ResumeLayout(false);
            this.pgStl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTolStl)).EndInit();
            this.pgGeneral.ResumeLayout(false);
            this.pgGeneral.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpReadingSettings.ResumeLayout(false);
            this.grpStepReading.ResumeLayout(false);
            this.grpStepReading.PerformLayout();
            this.grpAutodeskReading.ResumeLayout(false);
            this.grpAutodeskReading.PerformLayout();
            this.grpConversionSettings.ResumeLayout(false);
            this.grpOutput.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.grpTasks.ResumeLayout(false);
            this.grpAddInquiries.ResumeLayout(false);
            this.grpAddConversion.ResumeLayout(false);
            this.grpAddTransformation.ResumeLayout(false);
            this.grpAddImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ProgressBarWithText progressBarOperations;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TreeView treePicView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblConnectionId;        
        private System.Windows.Forms.CheckBox chkDeleteFiles;
        private System.Windows.Forms.NumericUpDown numWidthImages;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numHeightImages;
        private System.Windows.Forms.GroupBox grpBuffer;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblUpload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExtraFiles;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtExtraFiles;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trackUpload;
        private System.Windows.Forms.TrackBar trackDownload;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage pgGeneral;
        private System.Windows.Forms.TabPage pgImages;
        private System.Windows.Forms.GroupBox grpImagesSize;
        private System.Windows.Forms.TabPage pgAutodesk;
        private System.Windows.Forms.GroupBox grpImagesColors;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Button btnBottomColor;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button btnTopColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox chkCsi;
        private System.Windows.Forms.CheckBox chkAciColors;
        private System.Windows.Forms.GroupBox grpReadingSettings;
        private System.Windows.Forms.GroupBox grpConversionSettings;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnUpdateSettings;
        private System.Windows.Forms.GroupBox grpStepReading;
        private System.Windows.Forms.CheckBox chkIncludeWires;
        private System.Windows.Forms.GroupBox grpAutodeskReading;
        private System.Windows.Forms.CheckBox chkSkipProxies;
        private System.Windows.Forms.CheckBox chkSkipHatches;
        private System.Windows.Forms.GroupBox grpLog;
        private ProgressBarWithText progressBarUploads;
        private ProgressBarWithText progressBarDownloads;
        private System.Windows.Forms.Button btnGetFullLog;
        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddTransformation;
        private System.Windows.Forms.ListBox lstBoxTasks;
        private System.Windows.Forms.LinkLabel linkWorkingMode;
        private System.Windows.Forms.CheckBox chkOs;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox grpAddImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.ComboBox cmbAddImage;
        private System.Windows.Forms.GroupBox grpAddInquiries;
        private System.Windows.Forms.Button btnAddInquiries;
        private System.Windows.Forms.ComboBox cmbAddInquiries;
        private System.Windows.Forms.GroupBox grpAddConversion;
        private System.Windows.Forms.Button btnAddConversion;
        private System.Windows.Forms.ComboBox cmbAddConversion;
        private System.Windows.Forms.GroupBox grpAddTransformation;
        private System.Windows.Forms.ComboBox cmbAddTransformation;
        private System.Windows.Forms.Label lblRegenAutodesk;
        private System.Windows.Forms.NumericUpDown numTolAutodesk;
        private System.Windows.Forms.TabPage pgObj;
        private System.Windows.Forms.Label lblRegenObj;
        private System.Windows.Forms.NumericUpDown numTolObj;
        private System.Windows.Forms.TabPage pgStl;
        private System.Windows.Forms.Label lblRegenStl;
        private System.Windows.Forms.NumericUpDown numTolStl;
    }
}

