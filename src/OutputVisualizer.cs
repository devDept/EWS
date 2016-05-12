using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeshotWcfClientWinForms
{
    /// <summary>
    /// Utility class to show the output files.
    /// </summary>
    public partial class OutputVisualizer : Form
    {
        public OutputVisualizer() : this("Output Visualizer")
        {
            
        }

        /// <summary>
        /// The collection of the tab control's pages.
        /// </summary>
        private readonly List<TabPage> _pages;
        public OutputVisualizer(string title)
        {
            InitializeComponent();
            Text = title;
            txtFileName.AutoSize = true;

            // Hides pages on the tab control(UI refinement)
            tabControlOutput.Appearance = TabAppearance.FlatButtons;
            tabControlOutput.ItemSize = new Size(0, 1);
            tabControlOutput.SizeMode = TabSizeMode.Fixed;

            _pages = new List<TabPage>();

            while (tabControlOutput.TabPages.Count > 0)
            {
                _pages.Add(tabControlOutput.TabPages[0]);
                tabControlOutput.TabPages.RemoveAt(0);
            }            

        }

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

            DisposeImage();

            base.Dispose(disposing);
        }

        /// <summary>
        /// Dispose the image.
        /// </summary>
        private void DisposeImage()
        {            
            if (picPreview.Image != null)
            {
                picPreview.Image.Dispose();
                picPreview.Image = null;
            }
        }

        /// <summary>
        /// The full path of the file to show.
        /// </summary>
        public string FullPath { get; private set; }

        /// <summary>
        /// Load and show the file.
        /// </summary>
        /// <param name="path">The fullpath of the file to show.</param>
        /// <param name="showForm">When true the form is shown.</param>
        public void LoadFile(string path, bool showForm = true)
        {
            if (showForm)
            {                
                // I want to show the form in front of all the controls.
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;

                Show();
                Activate();
                tabControlOutput.BringToFront();
            }
            
            FullPath = path;
            txtFileName.Text = String.Format("File: {0}", FullPath);
            string ext = GetExtension().ToLower();                     

            // I want to show one tab page at time.
            if (tabControlOutput.TabPages.Count > 0)
                tabControlOutput.TabPages.RemoveAt(0);

            DisposeImage();

            switch (ext)
            {
                case "bmp":
                    Bitmap bmp = new Bitmap(path);
                    picPreview.Image = bmp;
                    tabControlOutput.TabPages.Add(_pages[0]);
                    break;
                case "xml":
                    xmlWebBrowser.Navigate(path);
                    tabControlOutput.TabPages.Add(_pages[1]);
                    break;                
                default:
                    throw new Exception("Unsupported type.");
            }            
        }

        private string GetExtension()
        {
            return FullPath.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
        }
    }
}
