﻿using NAudio.Wave;
using System.Diagnostics;

namespace Recorder
{
    public partial class RecorderForm : Form
    {
        WaveIn wave;
        WaveFileWriter writer;
        string outputFileName;
        public RecorderForm()
        {
            InitializeComponent();
            LoadDevices();
        }

        private void LoadDevices()
        {
            for (int deviceId = 0; deviceId < WaveIn.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveIn.GetCapabilities(deviceId);
                RecordingDeviceComboBox.Items.Add(deviceInfo.ProductName);
            }

            for (int deviceId = 0; deviceId < WaveOut.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveOut.GetCapabilities(deviceId);
                PlaybackDeviceComboBox.Items.Add(deviceInfo.ProductName);
            }

        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "Wave files | *.wav"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            outputFileName = dialog.FileName;

            RecordButton.Enabled = false;
            StopButton.Enabled = true;
            wave = new WaveIn
            {
                WaveFormat = new WaveFormat(44100, 1),
                DeviceNumber = RecordingDeviceComboBox.SelectedIndex
            };
            wave.DataAvailable += Wave_DataAvailable;
            wave.RecordingStopped += Wave_RecordingStopped;
            writer = new WaveFileWriter(outputFileName, wave.WaveFormat);
            wave.StartRecording();
        }

        private void Wave_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer.Dispose();
            RecordButton.Enabled = true;
            StopButton.Enabled = false;
        }

        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            wave.StopRecording();

            if (outputFileName == null) return;

            var processStartInfo = new ProcessStartInfo
            {
                FileName = Path.GetDirectoryName(outputFileName),
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }
    }
}