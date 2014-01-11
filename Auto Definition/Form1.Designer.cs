namespace Auto_Definition
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openListDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnTranslate = new System.Windows.Forms.PictureBox();
            this.btnImport = new System.Windows.Forms.PictureBox();
            this.btnWipeCache = new System.Windows.Forms.Label();
            this.matchingProgLabel = new System.Windows.Forms.Label();
            this.saveListDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveOptionPanel = new System.Windows.Forms.Panel();
            this.saveOptionLabel = new System.Windows.Forms.Label();
            this.r2_C = new System.Windows.Forms.RadioButton();
            this.r1_EC = new System.Windows.Forms.RadioButton();
            this.waitTimer = new System.Windows.Forms.Timer(this.components);
            this.matchingProgPanel = new System.Windows.Forms.Panel();
            this.bgW = new System.ComponentModel.BackgroundWorker();
            this.listChinese = new System.Windows.Forms.ListBox();
            this.listEnglish = new System.Windows.Forms.ListBox();
            this.listItemNavigator = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTranslate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            this.saveOptionPanel.SuspendLayout();
            this.matchingProgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listItemNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // openListDialog
            // 
            this.openListDialog.Filter = "Formatted List(*.txt)|*.txt";
            this.openListDialog.Title = "Import List";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::Auto_Definition.Properties.Resources.mini;
            this.btnMinimize.Location = new System.Drawing.Point(453, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 14);
            this.btnMinimize.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Auto_Definition.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(475, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 14);
            this.btnClose.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Auto_Definition.Properties.Resources.Notepad_Metro;
            this.btnSave.Location = new System.Drawing.Point(234, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSave.TabIndex = 11;
            this.btnSave.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Image = global::Auto_Definition.Properties.Resources.Google_Translate_Metro;
            this.btnTranslate.Location = new System.Drawing.Point(234, 214);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(32, 32);
            this.btnTranslate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnTranslate.TabIndex = 12;
            this.btnTranslate.TabStop = false;
            this.toolTip1.SetToolTip(this.btnTranslate, "Translate");
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::Auto_Definition.Properties.Resources.Blank_Folder_Metro;
            this.btnImport.Location = new System.Drawing.Point(234, 176);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(32, 32);
            this.btnImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnImport.TabIndex = 13;
            this.btnImport.TabStop = false;
            this.toolTip1.SetToolTip(this.btnImport, "Import");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnWipeCache
            // 
            this.btnWipeCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWipeCache.BackColor = System.Drawing.Color.Transparent;
            this.btnWipeCache.Image = global::Auto_Definition.Properties.Resources.clear;
            this.btnWipeCache.Location = new System.Drawing.Point(431, 9);
            this.btnWipeCache.Name = "btnWipeCache";
            this.btnWipeCache.Size = new System.Drawing.Size(18, 14);
            this.btnWipeCache.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnWipeCache, "Wipe cache\r\nThis may solve some problems with AD. Do wisely! Rebuilding the cache" +
        " takes extra time.");
            this.btnWipeCache.Click += new System.EventHandler(this.btnWipeCache_Click);
            // 
            // matchingProgLabel
            // 
            this.matchingProgLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.matchingProgLabel.AutoSize = true;
            this.matchingProgLabel.BackColor = System.Drawing.Color.LightYellow;
            this.matchingProgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchingProgLabel.ForeColor = System.Drawing.Color.Brown;
            this.matchingProgLabel.Image = global::Auto_Definition.Properties.Resources.loader;
            this.matchingProgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.matchingProgLabel.Location = new System.Drawing.Point(159, 420);
            this.matchingProgLabel.Name = "matchingProgLabel";
            this.matchingProgLabel.Size = new System.Drawing.Size(127, 24);
            this.matchingProgLabel.TabIndex = 0;
            this.matchingProgLabel.Text = "     Matching...";
            this.matchingProgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.matchingProgLabel, "Click to terminate");
            this.matchingProgLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // saveListDialog
            // 
            this.saveListDialog.Filter = "Formatted List(*.txt)|*.txt";
            this.saveListDialog.Title = "Save List";
            // 
            // saveOptionPanel
            // 
            this.saveOptionPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveOptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveOptionPanel.Controls.Add(this.saveOptionLabel);
            this.saveOptionPanel.Controls.Add(this.r2_C);
            this.saveOptionPanel.Controls.Add(this.r1_EC);
            this.saveOptionPanel.Location = new System.Drawing.Point(257, 275);
            this.saveOptionPanel.Name = "saveOptionPanel";
            this.saveOptionPanel.Size = new System.Drawing.Size(117, 73);
            this.saveOptionPanel.TabIndex = 14;
            this.saveOptionPanel.Visible = false;
            // 
            // saveOptionLabel
            // 
            this.saveOptionLabel.AutoSize = true;
            this.saveOptionLabel.Location = new System.Drawing.Point(3, 5);
            this.saveOptionLabel.Name = "saveOptionLabel";
            this.saveOptionLabel.Size = new System.Drawing.Size(43, 13);
            this.saveOptionLabel.TabIndex = 2;
            this.saveOptionLabel.Text = "Options";
            // 
            // r2_C
            // 
            this.r2_C.AutoSize = true;
            this.r2_C.Location = new System.Drawing.Point(5, 48);
            this.r2_C.Name = "r2_C";
            this.r2_C.Size = new System.Drawing.Size(63, 17);
            this.r2_C.TabIndex = 1;
            this.r2_C.Text = "Chinese";
            this.r2_C.UseVisualStyleBackColor = true;
            this.r2_C.CheckedChanged += new System.EventHandler(this.r2_C_CheckedChanged);
            // 
            // r1_EC
            // 
            this.r1_EC.AutoSize = true;
            this.r1_EC.Location = new System.Drawing.Point(5, 26);
            this.r1_EC.Name = "r1_EC";
            this.r1_EC.Size = new System.Drawing.Size(109, 17);
            this.r1_EC.TabIndex = 0;
            this.r1_EC.Text = "English && Chinese";
            this.r1_EC.UseVisualStyleBackColor = true;
            this.r1_EC.CheckedChanged += new System.EventHandler(this.r1_EC_CheckedChanged);
            // 
            // waitTimer
            // 
            this.waitTimer.Interval = 1000;
            this.waitTimer.Tick += new System.EventHandler(this.waitTimer_Tick);
            // 
            // matchingProgPanel
            // 
            this.matchingProgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchingProgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.matchingProgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("matchingProgPanel.BackgroundImage")));
            this.matchingProgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.matchingProgPanel.Controls.Add(this.matchingProgLabel);
            this.matchingProgPanel.Location = new System.Drawing.Point(2, 34);
            this.matchingProgPanel.Name = "matchingProgPanel";
            this.matchingProgPanel.Size = new System.Drawing.Size(501, 443);
            this.matchingProgPanel.TabIndex = 15;
            this.matchingProgPanel.Visible = false;
            // 
            // bgW
            // 
            this.bgW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_DoWork);
            this.bgW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgW_RunWorkerCompleted);
            // 
            // listChinese
            // 
            this.listChinese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listChinese.Enabled = false;
            this.listChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChinese.ItemHeight = 15;
            this.listChinese.Location = new System.Drawing.Point(272, 34);
            this.listChinese.Name = "listChinese";
            this.listChinese.Size = new System.Drawing.Size(217, 422);
            this.listChinese.TabIndex = 18;
            // 
            // listEnglish
            // 
            this.listEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listEnglish.Enabled = false;
            this.listEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEnglish.ItemHeight = 15;
            this.listEnglish.Location = new System.Drawing.Point(16, 34);
            this.listEnglish.Name = "listEnglish";
            this.listEnglish.Size = new System.Drawing.Size(212, 422);
            this.listEnglish.TabIndex = 17;
            // 
            // listItemNavigator
            // 
            this.listItemNavigator.BackColor = System.Drawing.Color.LightYellow;
            this.listItemNavigator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listItemNavigator.Location = new System.Drawing.Point(444, 455);
            this.listItemNavigator.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listItemNavigator.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listItemNavigator.Name = "listItemNavigator";
            this.listItemNavigator.Size = new System.Drawing.Size(46, 16);
            this.listItemNavigator.TabIndex = 19;
            this.listItemNavigator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listItemNavigator.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listItemNavigator.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.BackgroundImage = global::Auto_Definition.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 479);
            this.Controls.Add(this.matchingProgPanel);
            this.Controls.Add(this.saveOptionPanel);
            this.Controls.Add(this.listChinese);
            this.Controls.Add(this.listItemNavigator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWipeCache);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listEnglish);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Definition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTranslate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            this.saveOptionPanel.ResumeLayout(false);
            this.saveOptionPanel.PerformLayout();
            this.matchingProgPanel.ResumeLayout(false);
            this.matchingProgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listItemNavigator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openListDialog;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveListDialog;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnTranslate;
        private System.Windows.Forms.PictureBox btnImport;
        private System.Windows.Forms.Panel saveOptionPanel;
        private System.Windows.Forms.Label saveOptionLabel;
        private System.Windows.Forms.RadioButton r2_C;
        private System.Windows.Forms.RadioButton r1_EC;
        private System.Windows.Forms.Timer waitTimer;
        private System.Windows.Forms.Panel matchingProgPanel;
        private System.Windows.Forms.Label matchingProgLabel;
        private System.ComponentModel.BackgroundWorker bgW;
        private System.Windows.Forms.Label btnWipeCache;
        private System.Windows.Forms.ListBox listChinese;
        private System.Windows.Forms.ListBox listEnglish;
        private System.Windows.Forms.NumericUpDown listItemNavigator;
    }
}

