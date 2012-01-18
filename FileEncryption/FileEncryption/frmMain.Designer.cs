namespace FileEncryption
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.btnDestinationBrowse = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.nudBlock = new System.Windows.Forms.NumericUpDown();
            this.nudCycle = new System.Windows.Forms.NumericUpDown();
            this.nudFrequency = new System.Windows.Forms.NumericUpDown();
            this.lblBlock = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblCycle = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Location = new System.Drawing.Point(8, 24);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(74, 16);
            this.lblSourcePath.TabIndex = 0;
            this.lblSourcePath.Text = "Tệp nguồn:";
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.Location = new System.Drawing.Point(8, 53);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(62, 16);
            this.lblDestinationPath.TabIndex = 1;
            this.lblDestinationPath.Text = "Tệp đích:";
            this.lblDestinationPath.Click += new System.EventHandler(this.lblDestinationPath_Click);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(100, 23);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(267, 23);
            this.txtSourcePath.TabIndex = 1;
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(100, 52);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(267, 23);
            this.txtDestinationPath.TabIndex = 3;
            this.txtDestinationPath.TextChanged += new System.EventHandler(this.txtDestinationPath_TextChanged);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSourceBrowse.Location = new System.Drawing.Point(361, 21);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(35, 23);
            this.btnSourceBrowse.TabIndex = 2;
            this.btnSourceBrowse.Text = "...";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // btnDestinationBrowse
            // 
            this.btnDestinationBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDestinationBrowse.Location = new System.Drawing.Point(361, 50);
            this.btnDestinationBrowse.Name = "btnDestinationBrowse";
            this.btnDestinationBrowse.Size = new System.Drawing.Size(35, 23);
            this.btnDestinationBrowse.TabIndex = 4;
            this.btnDestinationBrowse.Text = "...";
            this.btnDestinationBrowse.UseVisualStyleBackColor = true;
            this.btnDestinationBrowse.Click += new System.EventHandler(this.btnDestinationBrowse_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEncrypt.Location = new System.Drawing.Point(273, 222);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDecrypt.Location = new System.Drawing.Point(354, 222);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // nudBlock
            // 
            this.nudBlock.Location = new System.Drawing.Point(89, 51);
            this.nudBlock.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudBlock.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBlock.Name = "nudBlock";
            this.nudBlock.Size = new System.Drawing.Size(58, 23);
            this.nudBlock.TabIndex = 6;
            this.nudBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBlock.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBlock.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudCycle
            // 
            this.nudCycle.Location = new System.Drawing.Point(297, 51);
            this.nudCycle.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCycle.Name = "nudCycle";
            this.nudCycle.Size = new System.Drawing.Size(58, 23);
            this.nudCycle.TabIndex = 7;
            this.nudCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCycle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCycle.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudFrequency
            // 
            this.nudFrequency.Location = new System.Drawing.Point(89, 80);
            this.nudFrequency.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrequency.Name = "nudFrequency";
            this.nudFrequency.Size = new System.Drawing.Size(58, 23);
            this.nudFrequency.TabIndex = 8;
            this.nudFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrequency.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(8, 53);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(56, 16);
            this.lblBlock.TabIndex = 1;
            this.lblBlock.Text = "Bộ đệm:";
            this.lblBlock.Click += new System.EventHandler(this.lblDestinationPath_Click);
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(8, 82);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(52, 16);
            this.lblFrequency.TabIndex = 1;
            this.lblFrequency.Text = "Tần số:";
            this.lblFrequency.Click += new System.EventHandler(this.lblDestinationPath_Click);
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(238, 56);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(51, 16);
            this.lblCycle.TabIndex = 1;
            this.lblCycle.Text = "Chu kỳ:";
            this.lblCycle.Click += new System.EventHandler(this.lblDestinationPath_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(8, 25);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(60, 16);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Từ khóa:";
            this.lblKey.Click += new System.EventHandler(this.lblDestinationPath_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(88, 22);
            this.txtKey.MaxLength = 50;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(267, 23);
            this.txtKey.TabIndex = 5;
            this.txtKey.TextChanged += new System.EventHandler(this.txtDestinationPath_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.nudFrequency);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.nudCycle);
            this.groupBox1.Controls.Add(this.lblBlock);
            this.groupBox1.Controls.Add(this.nudBlock);
            this.groupBox1.Controls.Add(this.lblCycle);
            this.groupBox1.Controls.Add(this.lblFrequency);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDestinationPath);
            this.groupBox2.Controls.Add(this.lblSourcePath);
            this.groupBox2.Controls.Add(this.btnSourceBrowse);
            this.groupBox2.Controls.Add(this.btnDestinationBrowse);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(441, 257);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "File Encryption";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.Label lblDestinationPath;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.Button btnDestinationBrowse;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.NumericUpDown nudBlock;
        private System.Windows.Forms.NumericUpDown nudCycle;
        private System.Windows.Forms.NumericUpDown nudFrequency;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

