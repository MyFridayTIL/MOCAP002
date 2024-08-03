using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace MOCAP002
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);

            btnSetMinMax.Enabled = false;
            btnStartRecording.Enabled = false;
            btnStopRecording.Enabled = false;
        }

        private void btnSetMinMax_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.WriteLine("C");
                txtPredictedWord.Text = "Calibrating...";
            }
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.WriteLine("S");
                btnStartRecording.Enabled = false;
                btnStopRecording.Enabled = true;
                txtPredictedWord.Clear();
            }
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.WriteLine("E");
                btnStartRecording.Enabled = true;
                btnStopRecording.Enabled = false;
            }
        }

        private void comboBoxPorts_TextChanged(object sender, EventArgs e)
        {
            if (!isConnected && comboBoxPorts.SelectedItem != null)
            {
                try
                {
                    serialPort = new SerialPort(comboBoxPorts.SelectedItem.ToString(), 9600);
                    serialPort.DataReceived += SerialPort_DataReceived;
                    serialPort.Open();
                    isConnected = true;
                    btnSetMinMax.Enabled = true;
                    btnStartRecording.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening port: " + ex.Message);
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                string data = serialPort.ReadLine();
                this.Invoke((MethodInvoker)delegate
                {
                    ProcessReceivedData(data);
                });
            }
        }

        private void ProcessReceivedData(string data)
        {
            string[] parts = data.Split(',');

            if (parts[0] == "GESTURE")
            {
                txtPredictedWord.Text = parts[1];
            }
            else if (parts[0] == "DATA")
            {
                txtSensorValues.Text = $"Roll: {parts[1]}, Pitch: {parts[2]}, Yaw: {parts[3]}\r\n" +
                                       $"Flex1: {parts[4]}, Flex2: {parts[5]}, Flex3: {parts[6]}, " +
                                       $"Flex4: {parts[7]}, Flex5: {parts[8]}";
            }
        }

        // These methods can be left empty or removed if not needed
        private void txtPredictedWord_Click(object sender, EventArgs e)
        {
        }

        private void txtPredictedWord_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSensorValues_TextChanged(object sender, EventArgs e)
        {
        }
    }
}