
namespace racman
{
    partial class SaveFilesWindow
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
            this.DownloadSavesButton = new System.Windows.Forms.Button();
            this.SaveFilesList = new System.Windows.Forms.ComboBox();
            this.PresetsLabel = new System.Windows.Forms.Label();
            this.UploadSavesButton = new System.Windows.Forms.Button();
            this.AddPresetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DownloadSavesButton
            // 
            this.DownloadSavesButton.Location = new System.Drawing.Point(12, 53);
            this.DownloadSavesButton.Name = "DownloadSavesButton";
            this.DownloadSavesButton.Size = new System.Drawing.Size(121, 23);
            this.DownloadSavesButton.TabIndex = 0;
            this.DownloadSavesButton.Text = "Download";
            this.DownloadSavesButton.UseVisualStyleBackColor = true;
            // 
            // SaveFilesList
            // 
            this.SaveFilesList.FormattingEnabled = true;
            this.SaveFilesList.Location = new System.Drawing.Point(12, 26);
            this.SaveFilesList.Name = "SaveFilesList";
            this.SaveFilesList.Size = new System.Drawing.Size(121, 21);
            this.SaveFilesList.TabIndex = 1;
            // 
            // PresetsLabel
            // 
            this.PresetsLabel.AutoSize = true;
            this.PresetsLabel.Location = new System.Drawing.Point(9, 10);
            this.PresetsLabel.Name = "PresetsLabel";
            this.PresetsLabel.Size = new System.Drawing.Size(45, 13);
            this.PresetsLabel.TabIndex = 2;
            this.PresetsLabel.Text = "Presets:";
            // 
            // UploadSavesButton
            // 
            this.UploadSavesButton.Location = new System.Drawing.Point(12, 82);
            this.UploadSavesButton.Name = "UploadSavesButton";
            this.UploadSavesButton.Size = new System.Drawing.Size(121, 23);
            this.UploadSavesButton.TabIndex = 3;
            this.UploadSavesButton.Text = "Upload";
            this.UploadSavesButton.UseVisualStyleBackColor = true;
            // 
            // AddPresetButton
            // 
            this.AddPresetButton.Location = new System.Drawing.Point(12, 111);
            this.AddPresetButton.Name = "AddPresetButton";
            this.AddPresetButton.Size = new System.Drawing.Size(121, 23);
            this.AddPresetButton.TabIndex = 4;
            this.AddPresetButton.Text = "Add Preset";
            this.AddPresetButton.UseVisualStyleBackColor = true;
            // 
            // SaveFilesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 186);
            this.Controls.Add(this.AddPresetButton);
            this.Controls.Add(this.UploadSavesButton);
            this.Controls.Add(this.PresetsLabel);
            this.Controls.Add(this.SaveFilesList);
            this.Controls.Add(this.DownloadSavesButton);
            this.Name = "SaveFilesWindow";
            this.Text = "SaveFilesWindow";
            this.Load += new System.EventHandler(this.SaveFilesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadSavesButton;
        private System.Windows.Forms.ComboBox SaveFilesList;
        private System.Windows.Forms.Label PresetsLabel;
        private System.Windows.Forms.Button UploadSavesButton;
        private System.Windows.Forms.Button AddPresetButton;
    }
}