﻿namespace src
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.DirButton = new System.Windows.Forms.Button();
            this.FileInput = new System.Windows.Forms.TextBox();
            this.OccurenceCheckBox = new System.Windows.Forms.CheckBox();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.BFSButton = new System.Windows.Forms.RadioButton();
            this.DFSButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(320, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(237, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "Folder Crawler";
            // 
            // OutputPanel
            // 
            this.OutputPanel.Location = new System.Drawing.Point(410, 143);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(436, 419);
            this.OutputPanel.TabIndex = 1;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputLabel.Location = new System.Drawing.Point(410, 90);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(113, 41);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputLabel.Location = new System.Drawing.Point(39, 90);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(88, 41);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Input";
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(39, 143);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(179, 20);
            this.DirectoryLabel.TabIndex = 0;
            this.DirectoryLabel.Text = "Choose Starting Directory";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(39, 254);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(114, 20);
            this.FileLabel.TabIndex = 4;
            this.FileLabel.Text = "Input File Name";
            // 
            // DirButton
            // 
            this.DirButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DirButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DirButton.Location = new System.Drawing.Point(39, 166);
            this.DirButton.Name = "DirButton";
            this.DirButton.Size = new System.Drawing.Size(176, 46);
            this.DirButton.TabIndex = 5;
            this.DirButton.Text = "Choose Folder...";
            this.DirButton.UseVisualStyleBackColor = false;
            this.DirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // FileInput
            // 
            this.FileInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileInput.Location = new System.Drawing.Point(39, 277);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(289, 34);
            this.FileInput.TabIndex = 6;
            // 
            // OccurenceCheckBox
            // 
            this.OccurenceCheckBox.AutoSize = true;
            this.OccurenceCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OccurenceCheckBox.Location = new System.Drawing.Point(39, 330);
            this.OccurenceCheckBox.Name = "OccurenceCheckBox";
            this.OccurenceCheckBox.Size = new System.Drawing.Size(176, 27);
            this.OccurenceCheckBox.TabIndex = 7;
            this.OccurenceCheckBox.Text = "Find all occurences";
            this.OccurenceCheckBox.UseVisualStyleBackColor = true;
            this.OccurenceCheckBox.CheckedChanged += new System.EventHandler(this.OccurenceCheckBox_CheckedChanged);
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Location = new System.Drawing.Point(39, 381);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(147, 20);
            this.MethodLabel.TabIndex = 8;
            this.MethodLabel.Text = "Input Search Method";
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BFSButton.Location = new System.Drawing.Point(39, 404);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(225, 27);
            this.BFSButton.TabIndex = 9;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "BFS (Breadth First Search)";
            this.BFSButton.UseVisualStyleBackColor = true;
            this.BFSButton.CheckedChanged += new System.EventHandler(this.BFSButton_CheckedChanged);
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DFSButton.Location = new System.Drawing.Point(39, 437);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(214, 27);
            this.DFSButton.TabIndex = 10;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "DFS (Depth First Search)";
            this.DFSButton.UseVisualStyleBackColor = true;
            this.DFSButton.CheckedChanged += new System.EventHandler(this.DFSButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Location = new System.Drawing.Point(39, 481);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(176, 46);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search...";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 672);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DFSButton);
            this.Controls.Add(this.BFSButton);
            this.Controls.Add(this.MethodLabel);
            this.Controls.Add(this.OccurenceCheckBox);
            this.Controls.Add(this.DirButton);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.FileInput);
            this.Name = "MainForm";
            this.Text = "Folder Crawler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Panel OutputPanel;
        private Label OutputLabel;
        private Label InputLabel;
        private Label DirectoryLabel;
        private Label FileLabel;
        private Button DirButton;
        private TextBox FileInput;
        private CheckBox OccurenceCheckBox;
        private Label MethodLabel;
        private RadioButton BFSButton;
        private RadioButton DFSButton;
        private Button SearchButton;
    }
}