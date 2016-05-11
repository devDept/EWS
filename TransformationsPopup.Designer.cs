namespace EyeshotWcfClientWinForms
{
    partial class TransformationsPopup
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
            this.grpRotate = new System.Windows.Forms.GroupBox();
            this.lblCenterXyz = new System.Windows.Forms.Label();
            this.numCenterZ = new System.Windows.Forms.NumericUpDown();
            this.numCenterY = new System.Windows.Forms.NumericUpDown();
            this.numCenterX = new System.Windows.Forms.NumericUpDown();
            this.lblCenter = new System.Windows.Forms.Label();
            this.lblVectorXyz = new System.Windows.Forms.Label();
            this.numVectorZ = new System.Windows.Forms.NumericUpDown();
            this.numVectorY = new System.Windows.Forms.NumericUpDown();
            this.numVectorX = new System.Windows.Forms.NumericUpDown();
            this.lblVector3D = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.btnRotate = new System.Windows.Forms.Button();
            this.grpTranslate = new System.Windows.Forms.GroupBox();
            this.lblTranslateXyz = new System.Windows.Forms.Label();
            this.numTranslateZ = new System.Windows.Forms.NumericUpDown();
            this.numTranslateY = new System.Windows.Forms.NumericUpDown();
            this.numTranslateX = new System.Windows.Forms.NumericUpDown();
            this.lblTranslateCoord = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.grpScale = new System.Windows.Forms.GroupBox();
            this.lblScaleXyz = new System.Windows.Forms.Label();
            this.numScaleZ = new System.Windows.Forms.NumericUpDown();
            this.numScaleY = new System.Windows.Forms.NumericUpDown();
            this.numScaleX = new System.Windows.Forms.NumericUpDown();
            this.lblScaleCoord = new System.Windows.Forms.Label();
            this.btnScale = new System.Windows.Forms.Button();
            this.grpRotate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCenterZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenterY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenterX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVectorZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVectorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVectorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            this.grpTranslate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslateX)).BeginInit();
            this.grpScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleX)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRotate
            // 
            this.grpRotate.Controls.Add(this.lblCenterXyz);
            this.grpRotate.Controls.Add(this.numCenterZ);
            this.grpRotate.Controls.Add(this.numCenterY);
            this.grpRotate.Controls.Add(this.numCenterX);
            this.grpRotate.Controls.Add(this.lblCenter);
            this.grpRotate.Controls.Add(this.lblVectorXyz);
            this.grpRotate.Controls.Add(this.numVectorZ);
            this.grpRotate.Controls.Add(this.numVectorY);
            this.grpRotate.Controls.Add(this.numVectorX);
            this.grpRotate.Controls.Add(this.lblVector3D);
            this.grpRotate.Controls.Add(this.lblAngle);
            this.grpRotate.Controls.Add(this.numAngle);
            this.grpRotate.Controls.Add(this.btnRotate);
            this.grpRotate.Location = new System.Drawing.Point(12, 12);
            this.grpRotate.Name = "grpRotate";
            this.grpRotate.Size = new System.Drawing.Size(523, 79);
            this.grpRotate.TabIndex = 51;
            this.grpRotate.TabStop = false;
            // 
            // lblCenterXyz
            // 
            this.lblCenterXyz.AutoSize = true;
            this.lblCenterXyz.Location = new System.Drawing.Point(365, 58);
            this.lblCenterXyz.Name = "lblCenterXyz";
            this.lblCenterXyz.Size = new System.Drawing.Size(115, 13);
            this.lblCenterXyz.TabIndex = 22;
            this.lblCenterXyz.Text = "X              Y               Z";
            // 
            // numCenterZ
            // 
            this.numCenterZ.DecimalPlaces = 2;
            this.numCenterZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numCenterZ.Location = new System.Drawing.Point(459, 36);
            this.numCenterZ.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numCenterZ.Name = "numCenterZ";
            this.numCenterZ.Size = new System.Drawing.Size(47, 20);
            this.numCenterZ.TabIndex = 7;
            // 
            // numCenterY
            // 
            this.numCenterY.DecimalPlaces = 2;
            this.numCenterY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numCenterY.Location = new System.Drawing.Point(406, 36);
            this.numCenterY.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numCenterY.Name = "numCenterY";
            this.numCenterY.Size = new System.Drawing.Size(47, 20);
            this.numCenterY.TabIndex = 6;
            // 
            // numCenterX
            // 
            this.numCenterX.DecimalPlaces = 2;
            this.numCenterX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numCenterX.Location = new System.Drawing.Point(353, 36);
            this.numCenterX.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numCenterX.Name = "numCenterX";
            this.numCenterX.Size = new System.Drawing.Size(47, 20);
            this.numCenterX.TabIndex = 5;
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Location = new System.Drawing.Point(388, 15);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(65, 13);
            this.lblCenter.TabIndex = 18;
            this.lblCenter.Text = "Center Point";
            // 
            // lblVectorXyz
            // 
            this.lblVectorXyz.AutoSize = true;
            this.lblVectorXyz.Location = new System.Drawing.Point(198, 59);
            this.lblVectorXyz.Name = "lblVectorXyz";
            this.lblVectorXyz.Size = new System.Drawing.Size(115, 13);
            this.lblVectorXyz.TabIndex = 17;
            this.lblVectorXyz.Text = "X              Y               Z";
            // 
            // numVectorZ
            // 
            this.numVectorZ.DecimalPlaces = 2;
            this.numVectorZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numVectorZ.Location = new System.Drawing.Point(292, 37);
            this.numVectorZ.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numVectorZ.Name = "numVectorZ";
            this.numVectorZ.Size = new System.Drawing.Size(47, 20);
            this.numVectorZ.TabIndex = 4;
            // 
            // numVectorY
            // 
            this.numVectorY.DecimalPlaces = 2;
            this.numVectorY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numVectorY.Location = new System.Drawing.Point(239, 37);
            this.numVectorY.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numVectorY.Name = "numVectorY";
            this.numVectorY.Size = new System.Drawing.Size(47, 20);
            this.numVectorY.TabIndex = 3;
            // 
            // numVectorX
            // 
            this.numVectorX.DecimalPlaces = 2;
            this.numVectorX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numVectorX.Location = new System.Drawing.Point(186, 37);
            this.numVectorX.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numVectorX.Name = "numVectorX";
            this.numVectorX.Size = new System.Drawing.Size(47, 20);
            this.numVectorX.TabIndex = 2;
            // 
            // lblVector3D
            // 
            this.lblVector3D.AutoSize = true;
            this.lblVector3D.Location = new System.Drawing.Point(236, 15);
            this.lblVector3D.Name = "lblVector3D";
            this.lblVector3D.Size = new System.Drawing.Size(80, 13);
            this.lblVector3D.TabIndex = 13;
            this.lblVector3D.Text = "Axis (Vector3D)";
            this.lblVector3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(114, 8);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(46, 26);
            this.lblAngle.TabIndex = 12;
            this.lblAngle.Text = "Angle\r\n(degree)";
            this.lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numAngle
            // 
            this.numAngle.DecimalPlaces = 1;
            this.numAngle.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numAngle.Location = new System.Drawing.Point(113, 37);
            this.numAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(47, 20);
            this.numAngle.TabIndex = 1;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(6, 36);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(76, 23);
            this.btnRotate.TabIndex = 0;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // grpTranslate
            // 
            this.grpTranslate.Controls.Add(this.lblTranslateXyz);
            this.grpTranslate.Controls.Add(this.numTranslateZ);
            this.grpTranslate.Controls.Add(this.numTranslateY);
            this.grpTranslate.Controls.Add(this.numTranslateX);
            this.grpTranslate.Controls.Add(this.lblTranslateCoord);
            this.grpTranslate.Controls.Add(this.btnTranslate);
            this.grpTranslate.Location = new System.Drawing.Point(12, 97);
            this.grpTranslate.Name = "grpTranslate";
            this.grpTranslate.Size = new System.Drawing.Size(523, 79);
            this.grpTranslate.TabIndex = 52;
            this.grpTranslate.TabStop = false;
            // 
            // lblTranslateXyz
            // 
            this.lblTranslateXyz.AutoSize = true;
            this.lblTranslateXyz.Location = new System.Drawing.Point(123, 60);
            this.lblTranslateXyz.Name = "lblTranslateXyz";
            this.lblTranslateXyz.Size = new System.Drawing.Size(115, 13);
            this.lblTranslateXyz.TabIndex = 22;
            this.lblTranslateXyz.Text = "X              Y               Z";
            // 
            // numTranslateZ
            // 
            this.numTranslateZ.DecimalPlaces = 2;
            this.numTranslateZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numTranslateZ.Location = new System.Drawing.Point(217, 38);
            this.numTranslateZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTranslateZ.Name = "numTranslateZ";
            this.numTranslateZ.Size = new System.Drawing.Size(47, 20);
            this.numTranslateZ.TabIndex = 3;
            // 
            // numTranslateY
            // 
            this.numTranslateY.DecimalPlaces = 2;
            this.numTranslateY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numTranslateY.Location = new System.Drawing.Point(164, 38);
            this.numTranslateY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTranslateY.Name = "numTranslateY";
            this.numTranslateY.Size = new System.Drawing.Size(47, 20);
            this.numTranslateY.TabIndex = 2;
            // 
            // numTranslateX
            // 
            this.numTranslateX.DecimalPlaces = 2;
            this.numTranslateX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numTranslateX.Location = new System.Drawing.Point(111, 38);
            this.numTranslateX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTranslateX.Name = "numTranslateX";
            this.numTranslateX.Size = new System.Drawing.Size(47, 20);
            this.numTranslateX.TabIndex = 1;
            // 
            // lblTranslateCoord
            // 
            this.lblTranslateCoord.AutoSize = true;
            this.lblTranslateCoord.Location = new System.Drawing.Point(146, 17);
            this.lblTranslateCoord.Name = "lblTranslateCoord";
            this.lblTranslateCoord.Size = new System.Drawing.Size(63, 13);
            this.lblTranslateCoord.TabIndex = 18;
            this.lblTranslateCoord.Text = "Coordinates";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(6, 36);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(76, 23);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // grpScale
            // 
            this.grpScale.Controls.Add(this.lblScaleXyz);
            this.grpScale.Controls.Add(this.numScaleZ);
            this.grpScale.Controls.Add(this.numScaleY);
            this.grpScale.Controls.Add(this.numScaleX);
            this.grpScale.Controls.Add(this.lblScaleCoord);
            this.grpScale.Controls.Add(this.btnScale);
            this.grpScale.Location = new System.Drawing.Point(12, 182);
            this.grpScale.Name = "grpScale";
            this.grpScale.Size = new System.Drawing.Size(523, 79);
            this.grpScale.TabIndex = 53;
            this.grpScale.TabStop = false;
            // 
            // lblScaleXyz
            // 
            this.lblScaleXyz.AutoSize = true;
            this.lblScaleXyz.Location = new System.Drawing.Point(123, 60);
            this.lblScaleXyz.Name = "lblScaleXyz";
            this.lblScaleXyz.Size = new System.Drawing.Size(115, 13);
            this.lblScaleXyz.TabIndex = 22;
            this.lblScaleXyz.Text = "X              Y               Z";
            // 
            // numScaleZ
            // 
            this.numScaleZ.DecimalPlaces = 2;
            this.numScaleZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numScaleZ.Location = new System.Drawing.Point(217, 38);
            this.numScaleZ.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numScaleZ.Name = "numScaleZ";
            this.numScaleZ.Size = new System.Drawing.Size(47, 20);
            this.numScaleZ.TabIndex = 3;
            // 
            // numScaleY
            // 
            this.numScaleY.DecimalPlaces = 2;
            this.numScaleY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numScaleY.Location = new System.Drawing.Point(164, 38);
            this.numScaleY.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numScaleY.Name = "numScaleY";
            this.numScaleY.Size = new System.Drawing.Size(47, 20);
            this.numScaleY.TabIndex = 2;
            // 
            // numScaleX
            // 
            this.numScaleX.DecimalPlaces = 2;
            this.numScaleX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numScaleX.Location = new System.Drawing.Point(111, 38);
            this.numScaleX.Minimum = new decimal(new int[] {
            628,
            0,
            0,
            -2147352576});
            this.numScaleX.Name = "numScaleX";
            this.numScaleX.Size = new System.Drawing.Size(47, 20);
            this.numScaleX.TabIndex = 1;
            // 
            // lblScaleCoord
            // 
            this.lblScaleCoord.AutoSize = true;
            this.lblScaleCoord.Location = new System.Drawing.Point(146, 17);
            this.lblScaleCoord.Name = "lblScaleCoord";
            this.lblScaleCoord.Size = new System.Drawing.Size(63, 13);
            this.lblScaleCoord.TabIndex = 18;
            this.lblScaleCoord.Text = "Coordinates";
            // 
            // btnScale
            // 
            this.btnScale.Location = new System.Drawing.Point(6, 36);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(76, 23);
            this.btnScale.TabIndex = 0;
            this.btnScale.Text = "Scale";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // TransformationsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 278);
            this.Controls.Add(this.grpScale);
            this.Controls.Add(this.grpTranslate);
            this.Controls.Add(this.grpRotate);
            this.Name = "TransformationsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransformationsPopup";
            this.grpRotate.ResumeLayout(false);
            this.grpRotate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCenterZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenterY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenterX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVectorZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVectorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVectorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            this.grpTranslate.ResumeLayout(false);
            this.grpTranslate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTranslateX)).EndInit();
            this.grpScale.ResumeLayout(false);
            this.grpScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRotate;
        private System.Windows.Forms.Label lblCenterXyz;
        private System.Windows.Forms.NumericUpDown numCenterZ;
        private System.Windows.Forms.NumericUpDown numCenterY;
        private System.Windows.Forms.NumericUpDown numCenterX;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.Label lblVectorXyz;
        private System.Windows.Forms.NumericUpDown numVectorZ;
        private System.Windows.Forms.NumericUpDown numVectorY;
        private System.Windows.Forms.NumericUpDown numVectorX;
        private System.Windows.Forms.Label lblVector3D;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.GroupBox grpTranslate;
        private System.Windows.Forms.Label lblTranslateXyz;
        private System.Windows.Forms.NumericUpDown numTranslateZ;
        private System.Windows.Forms.NumericUpDown numTranslateY;
        private System.Windows.Forms.NumericUpDown numTranslateX;
        private System.Windows.Forms.Label lblTranslateCoord;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.GroupBox grpScale;
        private System.Windows.Forms.Label lblScaleXyz;
        private System.Windows.Forms.NumericUpDown numScaleZ;
        private System.Windows.Forms.NumericUpDown numScaleY;
        private System.Windows.Forms.NumericUpDown numScaleX;
        private System.Windows.Forms.Label lblScaleCoord;
        private System.Windows.Forms.Button btnScale;
    }
}