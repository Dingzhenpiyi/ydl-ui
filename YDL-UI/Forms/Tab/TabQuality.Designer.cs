﻿namespace Maxstupo.YdlUi.Forms.Tab {
    partial class TabQuality {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cbIgnoreErrors = new System.Windows.Forms.CheckBox();
            this.cbAbortOnErrors = new System.Windows.Forms.CheckBox();
            this.gbFileSystem = new System.Windows.Forms.GroupBox();
            this.cbNoOverwrites = new System.Windows.Forms.CheckBox();
            this.cbRestrictFilenames = new System.Windows.Forms.CheckBox();
            this.cbWriteThumbnail = new System.Windows.Forms.CheckBox();
            this.cbWriteAnnotations = new System.Windows.Forms.CheckBox();
            this.cbWriteDescription = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbCustomFormatSelector = new System.Windows.Forms.CheckBox();
            this.txtCustomFormatSelector = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.frameRateSelector = new Maxstupo.YdlUi.Controls.FrameRateSelector();
            this.videoQualitySelector = new Maxstupo.YdlUi.Controls.VideoQualitySelector();
            this.cbWriteSub = new System.Windows.Forms.CheckBox();
            this.gbGeneral.SuspendLayout();
            this.gbFileSystem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbGeneral, 2);
            this.gbGeneral.Controls.Add(this.cbIgnoreErrors);
            this.gbGeneral.Controls.Add(this.cbAbortOnErrors);
            this.gbGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGeneral.Location = new System.Drawing.Point(3, 105);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(620, 68);
            this.gbGeneral.TabIndex = 3;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Tag = "general";
            this.gbGeneral.Text = "General";
            // 
            // cbIgnoreErrors
            // 
            this.cbIgnoreErrors.AutoSize = true;
            this.cbIgnoreErrors.Checked = true;
            this.cbIgnoreErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreErrors.Location = new System.Drawing.Point(6, 21);
            this.cbIgnoreErrors.Name = "cbIgnoreErrors";
            this.cbIgnoreErrors.Size = new System.Drawing.Size(93, 17);
            this.cbIgnoreErrors.TabIndex = 0;
            this.cbIgnoreErrors.Tag = "ignore_errors";
            this.cbIgnoreErrors.Text = "Ignore Errors";
            this.toolTip.SetToolTip(this.cbIgnoreErrors, "Continue downloading on download errors (e.g. Skip unavailable videos in a playli" +
        "st).");
            this.cbIgnoreErrors.UseVisualStyleBackColor = true;
            // 
            // cbAbortOnErrors
            // 
            this.cbAbortOnErrors.AutoSize = true;
            this.cbAbortOnErrors.Location = new System.Drawing.Point(6, 44);
            this.cbAbortOnErrors.Name = "cbAbortOnErrors";
            this.cbAbortOnErrors.Size = new System.Drawing.Size(107, 17);
            this.cbAbortOnErrors.TabIndex = 1;
            this.cbAbortOnErrors.Tag = "abort_on_errors";
            this.cbAbortOnErrors.Text = "Abort On Errors";
            this.toolTip.SetToolTip(this.cbAbortOnErrors, "Abort downloading of further videos (in a playlist) if an error occurs.");
            this.cbAbortOnErrors.UseVisualStyleBackColor = true;
            // 
            // gbFileSystem
            // 
            this.gbFileSystem.AutoSize = true;
            this.gbFileSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbFileSystem.Controls.Add(this.cbWriteSub);
            this.gbFileSystem.Controls.Add(this.cbNoOverwrites);
            this.gbFileSystem.Controls.Add(this.cbRestrictFilenames);
            this.gbFileSystem.Controls.Add(this.cbWriteThumbnail);
            this.gbFileSystem.Controls.Add(this.cbWriteAnnotations);
            this.gbFileSystem.Controls.Add(this.cbWriteDescription);
            this.gbFileSystem.Location = new System.Drawing.Point(629, 3);
            this.gbFileSystem.MinimumSize = new System.Drawing.Size(100, 170);
            this.gbFileSystem.Name = "gbFileSystem";
            this.tableLayoutPanel1.SetRowSpan(this.gbFileSystem, 2);
            this.gbFileSystem.Size = new System.Drawing.Size(133, 170);
            this.gbFileSystem.TabIndex = 2;
            this.gbFileSystem.TabStop = false;
            this.gbFileSystem.Tag = "file_system";
            this.gbFileSystem.Text = "File System";
            // 
            // cbNoOverwrites
            // 
            this.cbNoOverwrites.AutoSize = true;
            this.cbNoOverwrites.Checked = true;
            this.cbNoOverwrites.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoOverwrites.Location = new System.Drawing.Point(6, 136);
            this.cbNoOverwrites.Name = "cbNoOverwrites";
            this.cbNoOverwrites.Size = new System.Drawing.Size(99, 17);
            this.cbNoOverwrites.TabIndex = 4;
            this.cbNoOverwrites.Tag = "no_overwrites";
            this.cbNoOverwrites.Text = "No Overwrites";
            this.toolTip.SetToolTip(this.cbNoOverwrites, "Don\'t overwrite files.");
            this.cbNoOverwrites.UseVisualStyleBackColor = true;
            // 
            // cbRestrictFilenames
            // 
            this.cbRestrictFilenames.AutoSize = true;
            this.cbRestrictFilenames.Location = new System.Drawing.Point(6, 113);
            this.cbRestrictFilenames.Name = "cbRestrictFilenames";
            this.cbRestrictFilenames.Size = new System.Drawing.Size(118, 17);
            this.cbRestrictFilenames.TabIndex = 3;
            this.cbRestrictFilenames.Tag = "restrict_filenames";
            this.cbRestrictFilenames.Text = "Restrict Filenames";
            this.toolTip.SetToolTip(this.cbRestrictFilenames, "Restrict filenames to only ASCII characters, and avoid \"&\" and spaces in filename" +
        "s.");
            this.cbRestrictFilenames.UseVisualStyleBackColor = true;
            // 
            // cbWriteThumbnail
            // 
            this.cbWriteThumbnail.AutoSize = true;
            this.cbWriteThumbnail.Location = new System.Drawing.Point(6, 67);
            this.cbWriteThumbnail.Name = "cbWriteThumbnail";
            this.cbWriteThumbnail.Size = new System.Drawing.Size(112, 17);
            this.cbWriteThumbnail.TabIndex = 2;
            this.cbWriteThumbnail.Tag = "write_thumbnail";
            this.cbWriteThumbnail.Text = "Write Thumbnail";
            this.toolTip.SetToolTip(this.cbWriteThumbnail, "Write thumbnail to disk.");
            this.cbWriteThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbWriteAnnotations
            // 
            this.cbWriteAnnotations.AutoSize = true;
            this.cbWriteAnnotations.Location = new System.Drawing.Point(6, 44);
            this.cbWriteAnnotations.Name = "cbWriteAnnotations";
            this.cbWriteAnnotations.Size = new System.Drawing.Size(121, 17);
            this.cbWriteAnnotations.TabIndex = 1;
            this.cbWriteAnnotations.Tag = "write_annotations";
            this.cbWriteAnnotations.Text = "Write Annotations";
            this.toolTip.SetToolTip(this.cbWriteAnnotations, "Write video annotations to a .annotations.xml file.");
            this.cbWriteAnnotations.UseVisualStyleBackColor = true;
            // 
            // cbWriteDescription
            // 
            this.cbWriteDescription.AutoSize = true;
            this.cbWriteDescription.Location = new System.Drawing.Point(6, 21);
            this.cbWriteDescription.Name = "cbWriteDescription";
            this.cbWriteDescription.Size = new System.Drawing.Size(116, 17);
            this.cbWriteDescription.TabIndex = 0;
            this.cbWriteDescription.Tag = "write_description";
            this.cbWriteDescription.Text = "Write Description";
            this.toolTip.SetToolTip(this.cbWriteDescription, "Write video description to a .description file.");
            this.cbWriteDescription.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // cbCustomFormatSelector
            // 
            this.cbCustomFormatSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCustomFormatSelector.AutoSize = true;
            this.cbCustomFormatSelector.Location = new System.Drawing.Point(6, 312);
            this.cbCustomFormatSelector.Name = "cbCustomFormatSelector";
            this.cbCustomFormatSelector.Size = new System.Drawing.Size(148, 17);
            this.cbCustomFormatSelector.TabIndex = 1;
            this.cbCustomFormatSelector.Tag = "selector";
            this.cbCustomFormatSelector.Text = "Custom Format Selector";
            this.cbCustomFormatSelector.UseVisualStyleBackColor = true;
            // 
            // txtCustomFormatSelector
            // 
            this.txtCustomFormatSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomFormatSelector.Location = new System.Drawing.Point(6, 335);
            this.txtCustomFormatSelector.Name = "txtCustomFormatSelector";
            this.txtCustomFormatSelector.ReadOnly = true;
            this.txtCustomFormatSelector.Size = new System.Drawing.Size(760, 22);
            this.txtCustomFormatSelector.TabIndex = 2;
            this.txtCustomFormatSelector.Tag = "selector.value";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.frameRateSelector, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoQualitySelector, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbGeneral, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbFileSystem, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // frameRateSelector
            // 
            this.frameRateSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameRateSelector.Location = new System.Drawing.Point(316, 3);
            this.frameRateSelector.Name = "frameRateSelector";
            this.frameRateSelector.OnChange = null;
            this.frameRateSelector.Size = new System.Drawing.Size(307, 96);
            this.frameRateSelector.TabIndex = 1;
            this.frameRateSelector.Tag = "#";
            // 
            // videoQualitySelector
            // 
            this.videoQualitySelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoQualitySelector.Location = new System.Drawing.Point(3, 3);
            this.videoQualitySelector.MinimumSize = new System.Drawing.Size(150, 50);
            this.videoQualitySelector.Name = "videoQualitySelector";
            this.videoQualitySelector.OnChange = null;
            this.videoQualitySelector.Size = new System.Drawing.Size(307, 96);
            this.videoQualitySelector.TabIndex = 0;
            this.videoQualitySelector.Tag = "#";
            // 
            // cbWriteSub
            // 
            this.cbWriteSub.AutoSize = true;
            this.cbWriteSub.Location = new System.Drawing.Point(6, 90);
            this.cbWriteSub.Name = "cbWriteSub";
            this.cbWriteSub.Size = new System.Drawing.Size(97, 17);
            this.cbWriteSub.TabIndex = 5;
            this.cbWriteSub.Tag = "write_sub";
            this.cbWriteSub.Text = "Write Subtitle";
            this.toolTip.SetToolTip(this.cbWriteSub, "Write subtitle file.");
            this.cbWriteSub.UseVisualStyleBackColor = true;
            // 
            // TabQuality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtCustomFormatSelector);
            this.Controls.Add(this.cbCustomFormatSelector);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabQuality";
            this.Size = new System.Drawing.Size(772, 366);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.TabQuality_Load);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbFileSystem.ResumeLayout(false);
            this.gbFileSystem.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.CheckBox cbIgnoreErrors;
        private System.Windows.Forms.CheckBox cbAbortOnErrors;
        private System.Windows.Forms.GroupBox gbFileSystem;
        private System.Windows.Forms.CheckBox cbWriteAnnotations;
        private System.Windows.Forms.CheckBox cbWriteDescription;
        public Controls.FrameRateSelector frameRateSelector;
        public Controls.VideoQualitySelector videoQualitySelector;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.CheckBox cbNoOverwrites;
        public System.Windows.Forms.CheckBox cbRestrictFilenames;
        public System.Windows.Forms.CheckBox cbWriteThumbnail;
        private System.Windows.Forms.CheckBox cbCustomFormatSelector;
        private System.Windows.Forms.TextBox txtCustomFormatSelector;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.CheckBox cbWriteSub;
    }
}
