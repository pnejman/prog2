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
            this.PanelStartSaveButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIterations)).BeginInit();
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
            "odejmowanie"});
            this.ComboBoxOperation.Location = new System.Drawing.Point(395, 67);
            this.ComboBoxOperation.Name = "ComboBoxOperation";
            this.ComboBoxOperation.Size = new System.Drawing.Size(156, 21);
            this.ComboBoxOperation.TabIndex = 0;
            // 
            // ButtonStart
            // 
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
            this.ListBoxContent.Location = new System.Drawing.Point(16, 51);
            this.ListBoxContent.Name = "ListBoxContent";
            this.ListBoxContent.Size = new System.Drawing.Size(373, 108);
            this.ListBoxContent.TabIndex = 3;
            // 
            // TextBoxInputFile
            // 
            this.TextBoxInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInputFile.Location = new System.Drawing.Point(16, 25);
            this.TextBoxInputFile.Name = "TextBoxInputFile";
            this.TextBoxInputFile.Size = new System.Drawing.Size(373, 20);
            this.TextBoxInputFile.TabIndex = 4;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowse.Location = new System.Drawing.Point(395, 22);
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
            this.ButtonOpen.Location = new System.Drawing.Point(476, 22);
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
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input file";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Operation";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of iterations";
            // 
            // ButtonSave
            // 
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
            this.CheckBoxShowEvents.Location = new System.Drawing.Point(16, 176);
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
            this.CheckBoxShowErrors.Location = new System.Drawing.Point(113, 176);
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
            this.TextBoxLog.Location = new System.Drawing.Point(16, 199);
            this.TextBoxLog.Multiline = true;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.ReadOnly = true;
            this.TextBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxLog.Size = new System.Drawing.Size(535, 187);
            this.TextBoxLog.TabIndex = 13;
            // 
            // PanelStartSaveButtons
            // 
            this.PanelStartSaveButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelStartSaveButtons.Controls.Add(this.ButtonStart);
            this.PanelStartSaveButtons.Controls.Add(this.ButtonSave);
            this.PanelStartSaveButtons.Location = new System.Drawing.Point(395, 137);
            this.PanelStartSaveButtons.Name = "PanelStartSaveButtons";
            this.PanelStartSaveButtons.Size = new System.Drawing.Size(160, 25);
            this.PanelStartSaveButtons.TabIndex = 14;
            // 
            // ButtonSaveLog
            // 
            this.ButtonSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveLog.Location = new System.Drawing.Point(476, 392);
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
            this.NumericUpDownIterations.Location = new System.Drawing.Point(395, 111);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 423);
            this.Controls.Add(this.NumericUpDownIterations);
            this.Controls.Add(this.ButtonSaveLog);
            this.Controls.Add(this.PanelStartSaveButtons);
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
            this.Name = "Form1";
            this.Text = "Program #2";
            this.PanelStartSaveButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIterations)).EndInit();
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
    }
}

