namespace prog2
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
            this.ComboBoxOperation = new System.Windows.Forms.ComboBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ListBoxContent = new System.Windows.Forms.ListBox();
            this.TextBoxInputFile = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.CheckBoxShowEvents = new System.Windows.Forms.CheckBox();
            this.CheckBoxShowErrors = new System.Windows.Forms.CheckBox();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.PanelStartSaveButtons = new System.Windows.Forms.Panel();
            this.ButtonSaveLog = new System.Windows.Forms.Button();
            this.NumericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.TextBoxLogFile = new System.Windows.Forms.TextBox();
            this.TextBoxErrorLogFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonBrowseLog = new System.Windows.Forms.Button();
            this.ButtonOpenLog = new System.Windows.Forms.Button();
            this.ButtonBrowseErrorLog = new System.Windows.Forms.Button();
            this.ButtonOpenErrorLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FormatSelector = new System.Windows.Forms.ComboBox();
            this.PanelStartSaveButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIterations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxOperation
            // 
            this.ComboBoxOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOperation.FormattingEnabled = true;
            this.ComboBoxOperation.Items.AddRange(new object[] {
            "mnożenie",
            "dzielenie",
            "potęgowanie",
            "odejmowanie",
            "dodawanie",
            "modulo"});
            this.ComboBoxOperation.Location = new System.Drawing.Point(386, 105);
            this.ComboBoxOperation.Name = "ComboBoxOperation";
            this.ComboBoxOperation.Size = new System.Drawing.Size(156, 21);
            this.ComboBoxOperation.TabIndex = 0;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonStart.Location = new System.Drawing.Point(0, 0);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 2;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ListBoxContent
            // 
            this.ListBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxContent.FormattingEnabled = true;
            this.ListBoxContent.Location = new System.Drawing.Point(22, 89);
            this.ListBoxContent.Name = "ListBoxContent";
            this.ListBoxContent.Size = new System.Drawing.Size(355, 108);
            this.ListBoxContent.TabIndex = 3;
            // 
            // TextBoxInputFile
            // 
            this.TextBoxInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInputFile.Location = new System.Drawing.Point(22, 53);
            this.TextBoxInputFile.Name = "TextBoxInputFile";
            this.TextBoxInputFile.Size = new System.Drawing.Size(355, 20);
            this.TextBoxInputFile.TabIndex = 4;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowse.Location = new System.Drawing.Point(386, 50);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowse.TabIndex = 5;
            this.ButtonBrowse.Text = "Browse...";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpen.Location = new System.Drawing.Point(467, 50);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 6;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input file path";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Operation";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of iterations";
            // 
            // ButtonSave
            // 
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSave.Location = new System.Drawing.Point(81, 0);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Save...";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // CheckBoxShowEvents
            // 
            this.CheckBoxShowEvents.AutoSize = true;
            this.CheckBoxShowEvents.Checked = true;
            this.CheckBoxShowEvents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxShowEvents.Location = new System.Drawing.Point(25, 336);
            this.CheckBoxShowEvents.Name = "CheckBoxShowEvents";
            this.CheckBoxShowEvents.Size = new System.Drawing.Size(88, 17);
            this.CheckBoxShowEvents.TabIndex = 11;
            this.CheckBoxShowEvents.Text = "Show events";
            this.CheckBoxShowEvents.UseVisualStyleBackColor = true;
            this.CheckBoxShowEvents.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // CheckBoxShowErrors
            // 
            this.CheckBoxShowErrors.AutoSize = true;
            this.CheckBoxShowErrors.Checked = true;
            this.CheckBoxShowErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxShowErrors.Location = new System.Drawing.Point(122, 336);
            this.CheckBoxShowErrors.Name = "CheckBoxShowErrors";
            this.CheckBoxShowErrors.Size = new System.Drawing.Size(82, 17);
            this.CheckBoxShowErrors.TabIndex = 12;
            this.CheckBoxShowErrors.Text = "Show errors";
            this.CheckBoxShowErrors.UseVisualStyleBackColor = true;
            this.CheckBoxShowErrors.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLog.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxLog.Location = new System.Drawing.Point(16, 359);
            this.TextBoxLog.Multiline = true;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.ReadOnly = true;
            this.TextBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxLog.Size = new System.Drawing.Size(535, 204);
            this.TextBoxLog.TabIndex = 13;
            // 
            // PanelStartSaveButtons
            // 
            this.PanelStartSaveButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelStartSaveButtons.Controls.Add(this.ButtonStart);
            this.PanelStartSaveButtons.Controls.Add(this.ButtonSave);
            this.PanelStartSaveButtons.Location = new System.Drawing.Point(374, 161);
            this.PanelStartSaveButtons.Name = "PanelStartSaveButtons";
            this.PanelStartSaveButtons.Size = new System.Drawing.Size(160, 25);
            this.PanelStartSaveButtons.TabIndex = 14;
            // 
            // ButtonSaveLog
            // 
            this.ButtonSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveLog.Location = new System.Drawing.Point(452, 343);
            this.ButtonSaveLog.Name = "ButtonSaveLog";
            this.ButtonSaveLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveLog.TabIndex = 15;
            this.ButtonSaveLog.Text = "Save log...";
            this.ButtonSaveLog.UseVisualStyleBackColor = true;
            this.ButtonSaveLog.Click += new System.EventHandler(this.ButtonSaveLog_Click);
            // 
            // NumericUpDownIterations
            // 
            this.NumericUpDownIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDownIterations.Location = new System.Drawing.Point(386, 149);
            this.NumericUpDownIterations.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownIterations.Name = "NumericUpDownIterations";
            this.NumericUpDownIterations.Size = new System.Drawing.Size(156, 20);
            this.NumericUpDownIterations.TabIndex = 16;
            this.NumericUpDownIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextBoxLogFile
            // 
            this.TextBoxLogFile.Location = new System.Drawing.Point(22, 262);
            this.TextBoxLogFile.Name = "TextBoxLogFile";
            this.TextBoxLogFile.Size = new System.Drawing.Size(355, 20);
            this.TextBoxLogFile.TabIndex = 17;
            // 
            // TextBoxErrorLogFile
            // 
            this.TextBoxErrorLogFile.Location = new System.Drawing.Point(22, 304);
            this.TextBoxErrorLogFile.Name = "TextBoxErrorLogFile";
            this.TextBoxErrorLogFile.Size = new System.Drawing.Size(355, 20);
            this.TextBoxErrorLogFile.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Log file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Error log file";
            // 
            // ButtonBrowseLog
            // 
            this.ButtonBrowseLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonBrowseLog.Location = new System.Drawing.Point(371, 34);
            this.ButtonBrowseLog.Name = "ButtonBrowseLog";
            this.ButtonBrowseLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseLog.TabIndex = 21;
            this.ButtonBrowseLog.Text = "Browse...";
            this.ButtonBrowseLog.UseVisualStyleBackColor = true;
            this.ButtonBrowseLog.Click += new System.EventHandler(this.ButtonBrowseLog_Click);
            // 
            // ButtonOpenLog
            // 
            this.ButtonOpenLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonOpenLog.Location = new System.Drawing.Point(452, 34);
            this.ButtonOpenLog.Name = "ButtonOpenLog";
            this.ButtonOpenLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenLog.TabIndex = 22;
            this.ButtonOpenLog.Text = "Open";
            this.ButtonOpenLog.UseVisualStyleBackColor = true;
            this.ButtonOpenLog.Click += new System.EventHandler(this.ButtonOpenLog_Click);
            // 
            // ButtonBrowseErrorLog
            // 
            this.ButtonBrowseErrorLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonBrowseErrorLog.Location = new System.Drawing.Point(371, 75);
            this.ButtonBrowseErrorLog.Name = "ButtonBrowseErrorLog";
            this.ButtonBrowseErrorLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseErrorLog.TabIndex = 23;
            this.ButtonBrowseErrorLog.Text = "Browse...";
            this.ButtonBrowseErrorLog.UseVisualStyleBackColor = true;
            this.ButtonBrowseErrorLog.Click += new System.EventHandler(this.ButtonBrowseErrorLog_Click);
            // 
            // ButtonOpenErrorLog
            // 
            this.ButtonOpenErrorLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonOpenErrorLog.Location = new System.Drawing.Point(452, 75);
            this.ButtonOpenErrorLog.Name = "ButtonOpenErrorLog";
            this.ButtonOpenErrorLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenErrorLog.TabIndex = 24;
            this.ButtonOpenErrorLog.Text = "Open";
            this.ButtonOpenErrorLog.UseVisualStyleBackColor = true;
            this.ButtonOpenErrorLog.Click += new System.EventHandler(this.ButtonOpenErrorLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PanelStartSaveButtons);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 199);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input file management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ButtonOpenErrorLog);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ButtonBrowseErrorLog);
            this.groupBox2.Controls.Add(this.ButtonSaveLog);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ButtonOpenLog);
            this.groupBox2.Controls.Add(this.ButtonBrowseLog);
            this.groupBox2.Controls.Add(this.FormatSelector);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 372);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(327, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Log file format";
            // 
            // FormatSelector
            // 
            this.FormatSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatSelector.FormattingEnabled = true;
            this.FormatSelector.Items.AddRange(new object[] {
            "TXT",
            "CSV",
            "TSV",
            "XML"});
            this.FormatSelector.Location = new System.Drawing.Point(406, 108);
            this.FormatSelector.Name = "FormatSelector";
            this.FormatSelector.Size = new System.Drawing.Size(121, 21);
            this.FormatSelector.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 610);
            this.Controls.Add(this.TextBoxErrorLogFile);
            this.Controls.Add(this.TextBoxLogFile);
            this.Controls.Add(this.NumericUpDownIterations);
            this.Controls.Add(this.TextBoxLog);
            this.Controls.Add(this.CheckBoxShowErrors);
            this.Controls.Add(this.CheckBoxShowEvents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.TextBoxInputFile);
            this.Controls.Add(this.ListBoxContent);
            this.Controls.Add(this.ComboBoxOperation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Program #2";
            this.PanelStartSaveButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIterations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxOperation;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.ListBox ListBoxContent;
        private System.Windows.Forms.TextBox TextBoxInputFile;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.CheckBox CheckBoxShowEvents;
        private System.Windows.Forms.CheckBox CheckBoxShowErrors;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.Panel PanelStartSaveButtons;
        private System.Windows.Forms.Button ButtonSaveLog;
        private System.Windows.Forms.NumericUpDown NumericUpDownIterations;
        private System.Windows.Forms.TextBox TextBoxLogFile;
        private System.Windows.Forms.TextBox TextBoxErrorLogFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonBrowseLog;
        private System.Windows.Forms.Button ButtonOpenLog;
        private System.Windows.Forms.Button ButtonBrowseErrorLog;
        private System.Windows.Forms.Button ButtonOpenErrorLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox FormatSelector;
        private System.Windows.Forms.Label label6;
    }
}

