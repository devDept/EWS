using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using EyeshotWcfClientWinForms.EyeshotServiceRef;
using EyeshotWcfClientWinForms.Properties;

namespace EyeshotWcfClientWinForms
{    
    public partial class Form1 : Form
    {
        #warning Remember that you must have a valid access key. Visit https://www.devdept.com/Account to get it.
        string accessKey = ""; // here you must specify the access key.

        /// <summary>
        /// The visualizer for the downloaded files.
        /// </summary>
        private OutputVisualizer _outputVisualizer;            

        /// <summary>
        /// The connection id (callback channel).
        /// </summary>
        private int _connectionId;

        /// <summary>
        /// The Eyeshot client.
        /// </summary>
        private EyeshotClient _client;

        /// <summary>
        /// The Eyeshot callback.
        /// </summary>
        private EyeshotCallback _callback;

        /// <summary>
        /// The offset used during the upload or download operations (Chunking data).
        /// </summary>
        private int _offset = 0;

        /// <summary>
        /// The counter for the uploads progress bar.
        /// </summary>
        private int _uploadProgressCounter = 0;

        /// <summary>
        /// True during the upload. (It is used to manage the extra files queue).
        /// </summary>
        private bool _uploadInProgress = false;

        /// <summary>
        /// The upload text for the progress bar.
        /// </summary>
        private string UploadText = String.Empty;

        /// <summary>
        /// The FileInfo for the upload.
        /// </summary>
        private FileInfo _uploadFileInfo;        

        /// <summary>
        /// True when the first (main) file is uploaded.
        /// </summary>
        /// <remarks>When true the Extra files button will be enabled.</remarks>
        private bool _mainFileUploaded = false;

        /// <summary>
        /// The counter for the downloads progress bar.
        /// </summary>
        private int _downloadProgressCounter = 0;

        /// <summary>
        /// The counter for pending downloads (files that are ready on the server but not downloaded yet).
        /// </summary>
        private int _pendingDownloadCounts = 0;

        /// <summary>
        /// The root folder for the downloaded files.
        /// </summary>
        private readonly string _rootDownloadFolder;

        /// <summary>
        /// The download folder for the current connection.
        /// </summary>
        private string _downloadFolder;                

        /// <summary>
        /// True during the download. (It is used to manage the download's queue).
        /// </summary>
        private bool _downloadInProgress = false;

        /// <summary>
        /// The file size of the current downloading file. (It is used to manage the download's progress bar).
        /// </summary>
        private int _downloadFileSize;            

        /// <summary>
        /// The stream for the current download.
        /// </summary>
        private Stream _downloadStream;

        /// <summary>
        /// The current downloading file.
        /// </summary>
        private string _downloadFile = String.Empty;

        /// <summary>
        /// You can create a list of tasks (named "Job") that must be executed by the web service.
        /// If you add a new Task after executing a Job then you need to reset the task list in the gui.
        /// </summary>
        private bool? _taskListCompleted = null;

        #region Buffer Size (for Chunking data)

        /// <summary>
        /// The buffer size for the upload and download operations
        /// </summary>
        public enum BufferSize
        {
            VerySlow = 32,
            Slow = 64,
            Normal = 128,
            Fast = 256,
            VeryFast = 512,
            UltraFast = 1024
        }

        /// <summary>
        /// Gets the Kilobyte value for each trackbar value.
        /// </summary>
        /// <param name="trackValue">The value of the track bar.</param>
        /// <returns></returns>
        private int GetKb(int trackValue)
        {
            switch (trackValue)
            {
                default:
                    return (int)BufferSize.VerySlow;                   
                case 1:
                    return (int)BufferSize.Slow;
                case 2:
                    return (int)BufferSize.Normal;
                case 3:
                    return (int)BufferSize.Fast;
                case 4:
                    return (int)BufferSize.VeryFast;
                case 5:
                    return (int)BufferSize.UltraFast;
            }            
        }
        
        private int _uploadChunk = -1;
        /// <summary>
        /// Gets the buffer size for the upload chunk.
        /// </summary>
        private int UploadBufferSize
        {
            get
            {
                if (_uploadChunk < 0)
                    _uploadChunk = Convert.ToInt32(1024 * GetKb(trackUpload.Value)); // Kilobyte

                return _uploadChunk;
            }
        }

        private int _downloadChunk = -1;
        /// <summary>
        /// Gets the buffer size for the download chunk.
        /// </summary>
        private int DownloadBufferSize
        {
            get
            {
                if (_downloadChunk < 0)
                    _downloadChunk = Convert.ToInt32(1024 * GetKb(trackDownload.Value)); // Kilobyte

                return _downloadChunk;
            }
        }        

        /// <summary>
        /// When the trackbar's value changes I need to update the Upload buffer size.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void trackUpload_ValueChanged(object sender, EventArgs e)
        {
            _uploadChunk = -1;
        }

        /// <summary>
        /// When the trackbar's value changes I need to update the Download buffer size.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void trackDownload_ValueChanged(object sender, EventArgs e)
        {
            _downloadChunk = -1;
        }
        #endregion

        public Form1()
        {            
            InitializeComponent();

            ShowAdvancedMode(false);

            _rootDownloadFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Downloads\");

            if (!Directory.Exists(_rootDownloadFolder))
                Directory.CreateDirectory(_rootDownloadFolder);
        }

        protected override void OnLoad(EventArgs e)
        {
            InitImageConversion();
            InitConversionTypes();
            InitTransformation();
            InitInquiries();

            base.OnLoad(e);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// <remarks>Shutdwown the client when closing the form.</remarks>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                ClientShutdown();
            }

            base.Dispose(disposing);
        }

        #region Initializations

        private void InitImageConversion()
        {            
            cmbAddImage.DisplayMember = "Key";
            cmbAddImage.ValueMember = "Value";

            cmbAddImage.Items.Add(new KeyValuePair<string, viewType>("Create Trimetric Image", viewType.Trimetric));
            cmbAddImage.Items.Add(new KeyValuePair<string, viewType>("Create Left Image", viewType.Left));
            cmbAddImage.Items.Add(new KeyValuePair<string, viewType>("Create Right Image", viewType.Right));
            cmbAddImage.Items.Add(new KeyValuePair<string, viewType>("Create Top Image", viewType.Top));
            cmbAddImage.Items.Add(new KeyValuePair<string, viewType>("Create Bottom Image", viewType.Bottom));
            cmbAddImage.Items.Add(new KeyValuePair<string, viewType>("Create Front Image", viewType.Front));
            cmbAddImage.Items.Add(new KeyValuePair<string, viewType>("Create Rear Image", viewType.Rear));
        }

        private Dictionary<string, Tuple<OperationsType, object>>  _conversionTypes;
        private void InitConversionTypes()
        {
            _conversionTypes = new Dictionary<string, Tuple<OperationsType, object>>();
            _conversionTypes.Add("Convert to DWG (2018)", new Tuple<OperationsType, object>(OperationsType.ConvertToDwg, WriteAutodeskversionType.Acad2018));
            _conversionTypes.Add("Convert to DWG (2013)", new Tuple<OperationsType, object>(OperationsType.ConvertToDwg, WriteAutodeskversionType.Acad2013));
            _conversionTypes.Add("Convert to DWG (2010)", new Tuple<OperationsType, object>(OperationsType.ConvertToDwg, WriteAutodeskversionType.Acad2010));
            _conversionTypes.Add("Convert to DWG (2000)", new Tuple<OperationsType, object>(OperationsType.ConvertToDwg, WriteAutodeskversionType.Acad2000));
            _conversionTypes.Add("Convert to DXF (2018)", new Tuple<OperationsType, object>(OperationsType.ConvertToDxf, WriteAutodeskversionType.Acad2018));
            _conversionTypes.Add("Convert to DXF (2013)", new Tuple<OperationsType, object>(OperationsType.ConvertToDxf, WriteAutodeskversionType.Acad2013));
            _conversionTypes.Add("Convert to DXF (2010)", new Tuple<OperationsType, object>(OperationsType.ConvertToDxf, WriteAutodeskversionType.Acad2010));
            _conversionTypes.Add("Convert to DXF (2000)", new Tuple<OperationsType, object>(OperationsType.ConvertToDxf, WriteAutodeskversionType.Acad2000));
            _conversionTypes.Add("Convert to OBJ", new Tuple<OperationsType, object>(OperationsType.ConvertToObj, null));
            _conversionTypes.Add("Convert to IGES", new Tuple<OperationsType, object>(OperationsType.ConvertToIges, null));
            _conversionTypes.Add("Convert to STEP", new Tuple<OperationsType, object>(OperationsType.ConvertToStep, null));
            _conversionTypes.Add("Convert to STL", new Tuple<OperationsType, object>(OperationsType.ConvertToStl, null));
            _conversionTypes.Add("Convert to XML", new Tuple<OperationsType, object>(OperationsType.ConvertToXml, null));
            _conversionTypes.Add("Convert to WebGL", new Tuple<OperationsType, object>(OperationsType.ConvertToWebGL, null));
            _conversionTypes.Add("Convert to 3D PDF", new Tuple<OperationsType, object>(OperationsType.ConvertTo3DPdf, null));

            foreach (var conversionType in _conversionTypes)            
                cmbAddConversion.Items.Add(conversionType.Key);                        
        }

        private void InitTransformation()
        {
            cmbAddTransformation.Items.Add(TransformationType.Rotate);
            cmbAddTransformation.Items.Add(TransformationType.Translate);
            cmbAddTransformation.Items.Add(TransformationType.Scale);
        }

        private Dictionary<string, OperationsType> _inquiryTypes;
        private void InitInquiries()
        {
            _inquiryTypes = new Dictionary<string, OperationsType>();
            _inquiryTypes.Add("Compute Area", OperationsType.GetArea);
            _inquiryTypes.Add("Compute Volume", OperationsType.GetVolume);

            foreach (var inquiryType in _inquiryTypes)            
                cmbAddInquiries.Items.Add(inquiryType.Key);            
        }
      

        /// <summary>
        /// Initializes the settings for the reading of the input files.
        /// </summary>
        private void InitReadingSettings()
        {
            chkSkipHatches.Checked = chkSkipProxies.Checked = true;

            if (_connectionId > 0)
                UpdateReadingSettings();

        }
        #endregion

        #region Connect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ClientConnect();
        }

        /// <summary>
        /// Initializes the client and establishes a new connection to the Eyeshot Web Service.
        /// </summary>
        /// <remarks>The client must support the callback for listening the web service replies.</remarks>
        private void ClientConnect()
        {
            btnConnect.Enabled = false;

            if (_client != null)
            {
                try
                {
                    _client.Close();
                }
                catch
                {
                    _client.Abort();
                }
                finally
                {
                    _client = null;
                }
            }            

            _callback = new EyeshotCallback();                
            CallbackEventSubscription(true);                     

            var instanceContext = new InstanceContext(_callback);          
            _client = new EyeshotClient(instanceContext);
            ClientEventSubscription(true);

            bool opened = false;
            try
            {
                _client.Open();
                opened = true;
            }
            catch (Exception ex)
            {
                if (ex is PlatformNotSupportedException)
                    AppendToLog("This platform does not support client side WebSockets natively. Please try with a more recent Windows version (Windows 8 or higher)");
                else
                    AppendToLog(ex.Message);
                btnConnect.Enabled = true;
            }

            if (!opened)
                return;                        

            _connectionId = _client.Connect(accessKey); 
            if (_connectionId > 0)
            {

                lblConnectionId.Text = "Id: " + _connectionId;

                _downloadFolder = System.IO.Path.Combine(_rootDownloadFolder, String.Format(@"{0}\", _connectionId));

                if (!Directory.Exists(_downloadFolder))
                    Directory.CreateDirectory(_downloadFolder);

                InitReadingSettings();

                btnInputFile.Enabled = btnUpdateSettings.Enabled = txtInput.Enabled = btnUpload.Enabled = trackUpload.Enabled = true;
                btnExtraFiles.Enabled = false;
                btnDisconnect.Enabled = true;

                AppendToLog("Connection established.", true);
            }
            else
            {
                AppendToLog("Connection failed.", true);

                if (_connectionId == -1)
                {
                    AppendToLog("Invalid access key. Get it here: https://www.devdept.com/Account");                    
                }
                else if (_connectionId == -2)
                    AppendToLog("The access key has been suspended.");
                else if (_connectionId == -3)
                    AppendToLog("Error while opening the connection.");

                ClientShutdown();
                btnConnect.Enabled = true;
            }
        }
        
        /// <summary>
        /// Some methods are called in an async way, so I need to listen to the events to know when they are completed.
        /// </summary>
        /// <param name="subscribe">True to subscribe the event, False to unsubscribe it.</param>
        private void ClientEventSubscription(bool subscribe)
        {

            if (subscribe)
            {
                _client.UploadDataCompleted += UploadDataCompleted;
                _client.DownloadDataCompleted += DownloadDataCompleted;
                _client.DownloadDataDoneCompleted += DownloadDataDoneCompleted;
                _client.UpdateReadingSettingsCompleted += UpdateReadingSettingsCompleted;
            }
            else
            {
                _client.UploadDataCompleted -= UploadDataCompleted;
                _client.DownloadDataCompleted -= DownloadDataCompleted;
                _client.DownloadDataDoneCompleted -= DownloadDataDoneCompleted;
                _client.UpdateReadingSettingsCompleted -= UpdateReadingSettingsCompleted;
            }
        }

        /// <summary>
        /// Listens to the callback messages from the web service.
        /// </summary>
        /// <param name="subscribe">True to subscribe the event, False to unsubscribe it.</param>
        private void CallbackEventSubscription(bool subscribe)
        {

            if (subscribe)
            {
                _callback.ServiceOnProgressChangedEvent += EyeshotServiceOnOnProgressChangedEvent;
                _callback.ServiceOnOperationCompletedEvent += EyeshotServiceOnOperationCompleted;
                _callback.ServiceOnTransformationCompletedEvent += EyeshotServiceOnTransformationCompleted;
            }
            else
            {
                _callback.ServiceOnProgressChangedEvent -= EyeshotServiceOnOnProgressChangedEvent;
                _callback.ServiceOnOperationCompletedEvent -= EyeshotServiceOnOperationCompleted;
                _callback.ServiceOnTransformationCompletedEvent -= EyeshotServiceOnTransformationCompleted;
            }
        }        

        #endregion

        #region Input

        private void btnInputFile_Click(object sender, EventArgs e)
        {
            // Selects the file that must be uploaded to the web service.
            // This file will be the main file for the reading operation.
            openFileDialog1.Multiselect = false;

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtInput.Text = openFileDialog1.FileName;                
            }
        }

        private readonly List<string> _extraFiles = new List<string>();
        private void btnExtraFiles_Click(object sender, EventArgs e)
        {
            // Selects extra files usefull for the reading operations.
            // For example the OBJ can have material (MTL) and texture (images) files. 
            // or the DWG can have external references to others DWG files.
            openFileDialog1.Multiselect = true;

            DialogResult result = openFileDialog1.ShowDialog();            
            if (result == DialogResult.OK)
            {
                _extraFiles.Clear();
                _extraFiles.AddRange(openFileDialog1.FileNames);

                if (_extraFiles.Count > 1)
                    txtExtraFiles.Text = String.Join("; ", openFileDialog1.SafeFileNames);
                else
                    txtExtraFiles.Text = openFileDialog1.FileName;
                btnUpload.Enabled = trackUpload.Enabled = true;
            }
        }
        #endregion

        #region Upload chunking data

        private void btnUpload_Click(object sender, EventArgs e)
        {
            StartUpload();
        }

        private void StartUpload()
        {            
            // Checks what file must be uploaded: main or extra files.
            string uploadFileName;
            if (_mainFileUploaded)
                uploadFileName = _extraFiles.FirstOrDefault();
            else
                uploadFileName = txtInput.Text;

            if (String.IsNullOrEmpty(uploadFileName))
                return;

            btnInputFile.Enabled =
                btnUpdateSettings.Enabled =
                    txtInput.Enabled =
                        btnExtraFiles.Enabled =
                            txtExtraFiles.Enabled =
                                btnUpload.Enabled = btnDownload.Enabled = trackUpload.Enabled = btnGetFullLog.Enabled = false;

            ResetLog();
            _offset = 0;
            _uploadProgressCounter = 0;

            _uploadFileInfo = new FileInfo(uploadFileName);
            UploadText = String.Format("Uploading file {0}... ", System.IO.Path.GetFileName(uploadFileName));

            ProgressBarUpdate(progressBarUploads, UploadText, 0, unchecked((int) _uploadFileInfo.Length/UploadBufferSize) + 1);

            _uploadInProgress = true;

            UploadFile();
        }

        /// <summary>
        /// Async chunking upload.
        /// </summary>
        private void UploadFile()
        {
            ProgressBarUpdate(progressBarUploads, UploadText, _uploadProgressCounter);
            
            _uploadProgressCounter++;

            // Creates a new uploload request with the needed info.
            var fileData = new UploadRequest();            
            fileData.FileName = _uploadFileInfo.Name;
            fileData.FileSize = _uploadFileInfo.Length;
            fileData.Offset = _offset;
            fileData.Buffer = new byte[UploadBufferSize];            

            using (FileStream fs = _uploadFileInfo.OpenRead())
            {
                // Upload offset: it is mandatory to start from the right position.

                fs.Seek(_offset, SeekOrigin.Begin);
                int read = fs.Read(fileData.Buffer, 0, UploadBufferSize);
                if (read != 0)
                {
                    _offset += read;
                    _client.UploadDataAsync(fileData);
                }
                else
                {
                    // When the upload is completed I need to notify it to the Eyeshot Web Service.
                    _client.UploadDataDoneAsync(_connectionId);
                    _mainFileUploaded = true;
                     SetButtonsEnabled(true);                    
                    trackUpload.Enabled = true;
                    string uploadedFile = txtInput.Text.ToLower();
                    if (uploadedFile.EndsWith("obj") || uploadedFile.EndsWith("dwg"))
                        btnExtraFiles.Enabled = txtExtraFiles.Enabled = true;

                    if (_extraFiles.Count > 0)
                        _extraFiles.RemoveAt(0);
                    _uploadInProgress = false;

                }
            }
        }

        /// <summary>
        /// Enables the operations buttons when the upload is completed. Disables them when the client is disconnected.
        /// </summary>
        /// <param name="enabled">When true the buttons are enabled, otherwise no.</param>
        private void SetButtonsEnabled(bool enabled)
        {
            btnUpdateSettings.Enabled = grpTasks.Enabled = enabled;
        }

        private void UploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
        {
            ResetLog();
            if (e.Error == null && string.IsNullOrEmpty(e.Result))
            {
                UploadFile();      
                if (!_uploadInProgress && _extraFiles.Count > 0)          
                    StartUpload();
            }
            else
            {
                if (e.Error != null)
                    AppendToLog(e.Error.ToString());

                AppendToLog(e.Result);
                
                btnConnect.Enabled = true;

                // Checks what file is uploading: main or extra files.                
                if (!_mainFileUploaded)
                {
                    btnInputFile.Enabled = txtInput.Enabled = true;
                }
                else
                    btnExtraFiles.Enabled = txtExtraFiles.Enabled = true;

                btnUpload.Enabled = trackUpload.Enabled = true;
                ProgressBarReset(progressBarUploads);
            }
        }

        #endregion

        #region Reading Settings

        // Some file formats can have some optional reading settings. 
        // In this case you can update them before starting the Job.
        private void btnUpdateSettings_Click(object sender, EventArgs e)
        {
            UpdateReadingSettings();
        }

        /// <summary>
        /// Updates the reading's setting to the Eyeshot Web Service.
        /// </summary>
        private void UpdateReadingSettings()
        {
            btnUpdateSettings.Enabled = false;
            AppendToLog("Update reading settings started...", true);
            _client.UpdateReadingSettingsAsync(chkSkipHatches.Checked, chkSkipProxies.Checked);
        }

        private void UpdateReadingSettingsCompleted(object sender, UpdateReadingSettingsCompletedEventArgs e)
        {            
            if (e.Error == null && string.IsNullOrEmpty(e.Result))
            {
                AppendToLog("Update reading settings completed.");
            }
            else
            {
                if (e.Error != null)
                    AppendToLog(e.Error.ToString());

                AppendToLog(e.Result);
            }

            btnUpdateSettings.Enabled = true;
        }

        #endregion

        #region Settings

        private void btnTopColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = btnTopColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnTopColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnBottomColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = btnBottomColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnBottomColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnHtmlBodyColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = btnHtmlBodyColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnHtmlBodyColor.BackColor = colorDialog1.Color;
            }
        }
        #endregion

        #region Tasks

        private void TaskListCompleted(bool completed)
        {
            if (_taskListCompleted != completed)
            {                
                if (_taskListCompleted == null || _taskListCompleted.Value)
                {
                    // I'm creating a new Job, so resets the task list when an "Add" button is pressed.
                    lstBoxTasks.Items.Clear();
                    btnClear.Enabled = btnExecute.Enabled = true;
                }
                else
                {
                    btnClear.Enabled = btnExecute.Enabled = false;
                    cmbAddImage.SelectedIndex =
                        cmbAddConversion.SelectedIndex =
                            cmbAddTransformation.SelectedIndex = cmbAddInquiries.SelectedIndex = -1;
                    AppendToLog("Job put in the service queue.");
                }

                _taskListCompleted = completed;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            ProgressBarReset(progressBarOperations);
            _client.ExecuteJob();     
            TaskListCompleted(true);       
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _client.ClearJob();
            lstBoxTasks.Items.Clear();
        }

        #region Transformations

        private void btnTransformationsAdd_Click(object sender, EventArgs e)
        {
            if (cmbAddTransformation.SelectedItem == null)
                return;

            TaskListCompleted(false);

            var transformationsPopup = new TransformationsPopup();

            string transformationText = transformationsPopup.ShowDialog(_client, (TransformationType)cmbAddTransformation.SelectedItem);
            if (!String.IsNullOrEmpty(transformationText))
                lstBoxTasks.Items.Add(transformationText);
        }              

        #endregion

        #region Operations

        #region Convert to...        

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (cmbAddImage.SelectedItem == null)
                return;

            TaskListCompleted(false);
            
            viewType viewType = ((KeyValuePair<string, viewType>)cmbAddImage.SelectedItem).Value;
            int width = (int)numWidthImages.Value;
            int height = (int)numHeightImages.Value;
            _client.ConvertToImages(new[] { viewType }, width, height, btnTopColor.BackColor, btnBottomColor.BackColor, chkCsi.Checked, chkOs.Checked);
            lstBoxTasks.Items.Add(String.Format("{0} ({1}x{2})", ((KeyValuePair<string, viewType>)cmbAddImage.SelectedItem).Key, width, height));
        }

        private void btnAddConversion_Click(object sender, EventArgs e)
        {
            if (cmbAddConversion.SelectedItem == null)
                return;

            TaskListCompleted(false);

            string taskItem = (string)cmbAddConversion.SelectedItem;
            var selected = _conversionTypes[taskItem];
            OperationsType operationsType = selected.Item1;
            var tolerance = (double)numTolerance.Value;

            switch (operationsType)
            {
                case OperationsType.ConvertToDwg:
                    var dwgVersion = (WriteAutodeskversionType)selected.Item2;
                    
                    taskItem = String.Format("{0} (Tol. {1})", taskItem, tolerance);
                    _client.ConvertToDwg(new[] { dwgVersion }, chkAciColors.Checked, tolerance);
                    break;
                case OperationsType.ConvertToDxf:
                    var dxfVersion = (WriteAutodeskversionType)selected.Item2;
                    var dxfTol = (double)numTolerance.Value;
                    taskItem = String.Format("{0} (Tol. {1})", taskItem, dxfTol);
                    _client.ConvertToDxf(new[] { dxfVersion }, chkAciColors.Checked, dxfTol);
                    break;
                case OperationsType.ConvertToIges:
                    _client.ConvertToIges();
                    break;
                case OperationsType.ConvertToObj:                    
                    taskItem = String.Format("{0} (Tol. {1})", taskItem, tolerance);
                    _client.ConvertToObj(tolerance);
                    break;
                case OperationsType.ConvertToStep:
                    _client.ConvertToStep();
                    break;
                case OperationsType.ConvertToStl:                    
                    taskItem = String.Format("{0} (Tol. {1})", taskItem, tolerance);
                    _client.ConvertToStl(tolerance);
                    break;
                case OperationsType.ConvertToXml:
                    _client.ConvertToXml();
                    break;
                case OperationsType.ConvertToWebGL:
                    taskItem = String.Format("{0} (Tol. {1})", taskItem, tolerance);
                    _client.ConvertToWebGL(tolerance, btnHtmlBodyColor.BackColor);
                    break;
                case OperationsType.ConvertTo3DPdf:
                    _client.ConvertTo3DPdf();
                    break;
            }

            lstBoxTasks.Items.Add(taskItem);
        }
        #endregion

        #region Other operations

        private void btnAddInquiries_Click(object sender, EventArgs e)
        {
            var selectedItem = cmbAddInquiries.SelectedItem;
            if (selectedItem == null)
                return;

            TaskListCompleted(false);

            string taskItem = (string)cmbAddInquiries.SelectedItem;
            var selected = _inquiryTypes[taskItem];
            var tolerance = (double)numTolerance.Value;
            switch (selected)
            {                
                case OperationsType.GetArea:
                    taskItem = String.Format("{0} (Tol. {1})", taskItem, tolerance);
                    _client.GetArea(tolerance);
                    break;
                case OperationsType.GetVolume:
                    taskItem = String.Format("{0} (Tol. {1})", taskItem, tolerance);
                    _client.GetVolume(tolerance);
                    break;             
            }

            lstBoxTasks.Items.Add(taskItem);
        }                
        #endregion

        private void EyeshotServiceOnOperationCompleted(object sender, OnOperationCompletedEventArgs e)
        {
            _pendingDownloadCounts += e.ResultsCount;
            AppendToLog(e.Log);

            if (_pendingDownloadCounts > 0 && !_downloadInProgress)
            {
                btnDownload.Enabled = trackDownload.Enabled = btnGetFullLog.Enabled = true;
            }
            else
            {
                btnDownload.Enabled = btnGetFullLog.Enabled = false;
                SetButtonsEnabled(true);
                if (e.Skipped)
                    ProgressBarReset(progressBarOperations);
            }

            if (e.OperationType == OperationsType.GetFullOperationsLog)
                StartDownload();
        }

        private void EyeshotServiceOnTransformationCompleted(object sender, OnTransformationCompletedEventArgs e)
        {
            AppendToLog(e.Log);
        }

        #endregion

        #endregion

        #region Download chunking data

        private void btnDownload_Click(object sender, EventArgs e)
        {
            StartDownload();
        }

        private void StartDownload()
        {
            btnDownload.Enabled = trackDownload.Enabled = btnGetFullLog.Enabled = false;

            if (!_downloadInProgress)
            {
                _offset = 0;
                _client.DownloadDataAsync(_offset, DownloadBufferSize);
            }
        }

        private void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                var response = e.Result;
                Byte[] buffer = (Byte[]) response.Buffer;
                _downloadFileSize = Convert.ToInt32(response.FileSize);
                string downloadFileName = response.FileName;
                string downloadText = String.Format("Downloading file {0}... ", downloadFileName);

                if (!_downloadInProgress)
                {
                    _downloadFile = String.Format("{0}{1}", _downloadFolder, downloadFileName);

                    _downloadStream = File.Open(_downloadFile, FileMode.Create, FileAccess.ReadWrite);
                    _downloadStream.Write(buffer, 0, buffer.Length);
                    _downloadStream.Flush();
                    _offset += DownloadBufferSize;

                    _downloadProgressCounter = 1;
                    ProgressBarUpdate(progressBarDownloads, downloadText, _downloadProgressCounter, _downloadFileSize/DownloadBufferSize + 1);

                    _downloadInProgress = true;

                    _client.DownloadDataAsync(_offset, DownloadBufferSize);
                }
                else
                {
                    if (_downloadInProgress && buffer != null) // I'm downloading the chunks
                    {
                        ProgressBarUpdate(progressBarDownloads, downloadText, _downloadProgressCounter);
                        _downloadProgressCounter++;

                        _downloadStream.Write(buffer, 0, buffer.Length);
                        _downloadStream.Flush();

                        _offset += DownloadBufferSize;
                        _client.DownloadDataAsync(_offset, DownloadBufferSize);
                    }
                    else // The download of the whole file is completed.
                    {
                        _downloadStream.Close();

                        if (response.OperationType == OperationsType.GetFullOperationsLog)
                        {
                            string downloadedFile = String.Format("{0}{1}", _downloadFolder, downloadFileName);
                            AppendToLog(System.IO.File.ReadAllText(downloadedFile), true);
                            try
                            {
                                File.Delete(downloadFileName);
                            }
                            catch
                            {
                            }
                        }
                        else if (response.FileType != FileType.None && response.FileType != FileType.Mtl)
                        {
                            var node = new TreeNode(downloadFileName);
                            node.Tag = _downloadFile;
                            treePicView.Nodes.Add(node);
                            AppendToLog(response.Log);
                        }

                        _pendingDownloadCounts--;

                        ProgressBarUpdate(progressBarDownloads, downloadText, progressBarDownloads.Maximum);
                        _offset = 0;
                        _downloadStream.Close();

                        _client.DownloadDataDoneAsync();

                        _downloadInProgress = false;

                        if (_pendingDownloadCounts == 0)
                            btnGetFullLog.Enabled = true;
                    }
                }
            }
            else
            {
                _downloadInProgress = false;
                AppendToLog(e.Error.Message);
            }
        }

        private void DownloadDataDoneCompleted(object sender, DownloadDataDoneCompletedEventArgs e)
        {
            if (_pendingDownloadCounts > 0)
            {
                StartDownload();
            }
            else
            {
                trackDownload.Enabled = true;
            }
        }

        #endregion

        #region Output

        private void treePicView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var tag = e.Node.Tag;
            string path = (string) tag;
            string extension = System.IO.Path.GetExtension(path).ToLower();

            if (extension.EndsWith("bmp") || extension.EndsWith("xml"))
            {
                if (_outputVisualizer == null || _outputVisualizer.IsDisposed)
                    _outputVisualizer = new OutputVisualizer();
                _outputVisualizer.LoadFile(path);
            }
            else if (extension.EndsWith("htm") || extension.EndsWith("html") || extension.EndsWith("pdf"))
            {
                // Open with default app
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                // Opens the repository folder.
                Process.Start(System.IO.Path.GetDirectoryName(path));
            }
        }

        #endregion

        #region Disconnect

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnInputFile.Enabled = btnUpdateSettings.Enabled = txtInput.Enabled = btnExtraFiles.Enabled = txtExtraFiles.Enabled = btnUpload.Enabled = btnDownload.Enabled = btnGetFullLog.Enabled = btnDisconnect.Enabled = false;
            txtInput.Text = txtExtraFiles.Text = String.Empty;
            ClientShutdown();
            SetButtonsEnabled(false);
            _downloadInProgress = false;
            btnConnect.Enabled = true;
            ResetLog();
        }

        /// <summary>
        /// Disconnect and close the client connection with the Eyeshot Web Service.
        /// </summary>
        private void ClientShutdown()
        {
            if (_callback != null)
            {
                try
                {
                    CallbackEventSubscription(false);
                }
                finally
                {
                    _callback = null;
                }
            }

            if (_client != null)
            {
                try
                {
                    ClientEventSubscription(false);
                    _client.Disconnect();
                    _client.Close();
                }
                catch
                {
                    _client.Abort();
                }
            }

            if (chkDeleteFiles.Checked)
            {
                treePicView.SelectedNode = null;

                // collects nodes of the current connection...
                List<TreeNode> removeList = new List<TreeNode>();
                foreach (TreeNode node in treePicView.Nodes)
                    if (node.Tag.ToString().Contains(_downloadFolder))
                        removeList.Add(node);

                // ...and remove them
                foreach (TreeNode node in removeList)
                    treePicView.Nodes.Remove(node);

                // close the visualizer
                if (_outputVisualizer != null) _outputVisualizer.Close();                

                // finally I can delete the subfolder.                    
                try
                {
                    if (_downloadFolder != null)
                        Directory.Delete(_downloadFolder, true);
                }
                catch (Exception ex)
                {
                    AppendToLog(ex.Message, true);
                }
            }

            _connectionId = 0;
            _mainFileUploaded = false;
            lblConnectionId.Text = "Id: ";
            lstBoxTasks.Items.Clear();
            ProgressBarReset(progressBarUploads);
            ProgressBarReset(progressBarOperations);
            ProgressBarReset(progressBarDownloads);
        }

        #endregion

        #region ProgressBar

        private void EyeshotServiceOnOnProgressChangedEvent(object sender, OnProgressChangedEventArgs e)
        {
            ProgressBarUpdate(progressBarOperations, e.Message, e.Percent, 100);
        }

        private void ProgressBarUpdate(ProgressBarWithText progressBar, string message, int value, int maximum = -1)
        {
            try
            {
                if (maximum > 0)
                    progressBar.Maximum = maximum;

                if (progressBar.Maximum == 0)
                {
                    progressBar.Maximum = 1;
                }

                progressBar.Value = value;
                progressBar.CustomText = message;
            }
            catch (Exception ex)
            {
                AppendToLog(String.Format("ProgressBar Update: {0}", ex.Message));
            }
        }

        private void ProgressBarReset(ProgressBarWithText progressBar)
        {
            ProgressBarUpdate(progressBar, String.Empty, 0, 100);
        }

        #endregion

        #region Log

        /// <summary>
        /// Resets the log.
        /// </summary>
        private void ResetLog()
        {
            txtLog.Text = String.Empty;
        }

        /// <summary>
        /// Appends a message to the log.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="resetLog"></param>
        private void AppendToLog(string message, bool resetLog = false)
        {
            if (String.IsNullOrEmpty(message))
                return;

            if (resetLog)
                ResetLog();

            if (!String.IsNullOrEmpty(txtLog.Text))
                txtLog.AppendText(Environment.NewLine);

            txtLog.AppendText(message);
        }
        
        private void btnGetFullLog_Click(object sender, EventArgs e)
        {
            // Asks to the web service for the full log of all the operations done till now.
            _client.GetFullOperationsLogAsync();
        }

        #endregion

        #region Advanced mode

        private bool _advancedMode = false;

        private void linkAdvanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowAdvancedMode(!_advancedMode);
        }

        private void ShowAdvancedMode(bool value)
        {
            _advancedMode = value;

            grpReadingSettings.Visible = grpConversionSettings.Visible = btnExtraFiles.Visible = txtExtraFiles.Visible = _advancedMode;

            Size newSize;
            if (_advancedMode)
            {
                newSize = new Size((int)(1165 * ScalingLevel.Width), (int)(705 * ScalingLevel.Height));
                linkWorkingMode.Text = "Basic mode";
                btnGetFullLog.Visible = true;
            }
            else
            {
                newSize = new Size((int)(805 * ScalingLevel.Width), (int)(715 * ScalingLevel.Height));
                linkWorkingMode.Text = "Advanced mode";
                btnGetFullLog.Visible = false;
            }

            Size = MinimumSize = newSize;
        }

        #endregion

        #region Helpers

        // For the resolution independence (dpiAware).
        private static SizeF _scalingLevel = SizeF.Empty;
        public static SizeF ScalingLevel
        {
            get
            {
                if (_scalingLevel.IsEmpty)
                {
                    float width, height;
                    using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromHwnd(IntPtr.Zero))
                    {
                        width = graphics.DpiX / 96;
                        height = graphics.DpiY / 96;
                    }

                    _scalingLevel = new SizeF(width, height);
                }

                return _scalingLevel;
            }
        }

        #endregion
    }
}
