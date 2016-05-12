namespace EyeshotWcfClientWinForms
{
    partial class OutputVisualizer
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
            this.tabControlOutput = new System.Windows.Forms.TabControl();
            this.pgOutputImages = new System.Windows.Forms.TabPage();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.pgOutputXml = new System.Windows.Forms.TabPage();
            this.xmlWebBrowser = new System.Windows.Forms.WebBrowser();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.tabControlOutput.SuspendLayout();
            this.pgOutputImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pgOutputXml.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOutput
            // 
            this.tabControlOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOutput.Controls.Add(this.pgOutputImages);
            this.tabControlOutput.Controls.Add(this.pgOutputXml);
            this.tabControlOutput.Location = new System.Drawing.Point(12, 58);
            this.tabControlOutput.Name = "tabControlOutput";
            this.tabControlOutput.SelectedIndex = 0;
            this.tabControlOutput.Size = new System.Drawing.Size(526, 544);
            this.tabControlOutput.TabIndex = 18;
            // 
            // pgOutputImages
            // 
            this.pgOutputImages.Controls.Add(this.picPreview);
            this.pgOutputImages.Location = new System.Drawing.Point(4, 22);
            this.pgOutputImages.Name = "pgOutputImages";
            this.pgOutputImages.Padding = new System.Windows.Forms.Padding(3);
            this.pgOutputImages.Size = new System.Drawing.Size(518, 518);
            this.pgOutputImages.TabIndex = 0;
            this.pgOutputImages.Text = "Image";
            this.pgOutputImages.UseVisualStyleBackColor = true;
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(3, 3);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(512, 512);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 11;
            this.picPreview.TabStop = false;
            // 
            // pgOutputXml
            // 
            this.pgOutputXml.Controls.Add(this.xmlWebBrowser);
            this.pgOutputXml.Location = new System.Drawing.Point(4, 22);
            this.pgOutputXml.Name = "pgOutputXml";
            this.pgOutputXml.Padding = new System.Windows.Forms.Padding(3);
            this.pgOutputXml.Size = new System.Drawing.Size(518, 518);
            this.pgOutputXml.TabIndex = 1;
            this.pgOutputXml.Text = "Xml";
            this.pgOutputXml.UseVisualStyleBackColor = true;
            // 
            // xmlWebBrowser
            // 
            this.xmlWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.xmlWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.xmlWebBrowser.Name = "xmlWebBrowser";
            this.xmlWebBrowser.Size = new System.Drawing.Size(512, 512);
            this.xmlWebBrowser.TabIndex = 0;
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Location = new System.Drawing.Point(12, 16);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(522, 36);
            this.txtFileName.TabIndex = 19;
            this.txtFileName.Text = "File:";
            // 
            // OutputVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 614);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.tabControlOutput);
            this.Name = "OutputVisualizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OutputVisualizer";
            this.tabControlOutput.ResumeLayout(false);
            this.pgOutputImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pgOutputXml.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOutput;
        private System.Windows.Forms.TabPage pgOutputImages;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.TabPage pgOutputXml;
        private System.Windows.Forms.WebBrowser xmlWebBrowser;
        private System.Windows.Forms.TextBox txtFileName;
    }
}