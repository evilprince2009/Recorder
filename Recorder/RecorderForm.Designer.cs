
namespace Recorder
{
    partial class RecorderForm
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
            this.PlaybackDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordingDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlaybackDeviceComboBox
            // 
            this.PlaybackDeviceComboBox.FormattingEnabled = true;
            this.PlaybackDeviceComboBox.Location = new System.Drawing.Point(142, 67);
            this.PlaybackDeviceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlaybackDeviceComboBox.Name = "PlaybackDeviceComboBox";
            this.PlaybackDeviceComboBox.Size = new System.Drawing.Size(213, 23);
            this.PlaybackDeviceComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Playback Device";
            // 
            // RecordingDeviceComboBox
            // 
            this.RecordingDeviceComboBox.FormattingEnabled = true;
            this.RecordingDeviceComboBox.Location = new System.Drawing.Point(142, 29);
            this.RecordingDeviceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecordingDeviceComboBox.Name = "RecordingDeviceComboBox";
            this.RecordingDeviceComboBox.Size = new System.Drawing.Size(213, 23);
            this.RecordingDeviceComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recording Device";
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(142, 105);
            this.RecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(94, 33);
            this.RecordButton.TabIndex = 8;
            this.RecordButton.Text = "Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(261, 105);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 33);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 167);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.PlaybackDeviceComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecordingDeviceComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RecorderForm";
            this.Text = "Recorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PlaybackDeviceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RecordingDeviceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Button StopButton;
    }
}

