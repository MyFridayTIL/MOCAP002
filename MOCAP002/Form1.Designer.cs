namespace MOCAP002
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
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.btnSetMinMax = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.txtPredictedWord = new System.Windows.Forms.TextBox();
            this.txtSensorValues = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(60, 38);
            this.comboBoxPorts.MaximumSize = new System.Drawing.Size(120, 0);
            this.comboBoxPorts.MaxLength = 100;
            this.comboBoxPorts.MinimumSize = new System.Drawing.Size(100, 0);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(120, 33);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.Text = "Select Port";
            this.comboBoxPorts.TextChanged += new System.EventHandler(this.comboBoxPorts_TextChanged);
            // 
            // btnSetMinMax
            // 
            this.btnSetMinMax.Location = new System.Drawing.Point(49, 112);
            this.btnSetMinMax.MaximumSize = new System.Drawing.Size(200, 100);
            this.btnSetMinMax.MinimumSize = new System.Drawing.Size(200, 100);
            this.btnSetMinMax.Name = "btnSetMinMax";
            this.btnSetMinMax.Size = new System.Drawing.Size(200, 100);
            this.btnSetMinMax.TabIndex = 1;
            this.btnSetMinMax.Text = "Set Min-Max";
            this.btnSetMinMax.UseVisualStyleBackColor = true;
            this.btnSetMinMax.Click += new System.EventHandler(this.btnSetMinMax_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(49, 239);
            this.btnStartRecording.MaximumSize = new System.Drawing.Size(200, 100);
            this.btnStartRecording.MinimumSize = new System.Drawing.Size(200, 100);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(200, 100);
            this.btnStartRecording.TabIndex = 2;
            this.btnStartRecording.Text = "Start Recording";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Location = new System.Drawing.Point(49, 368);
            this.btnStopRecording.MaximumSize = new System.Drawing.Size(200, 100);
            this.btnStopRecording.MinimumSize = new System.Drawing.Size(200, 100);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(200, 100);
            this.btnStopRecording.TabIndex = 3;
            this.btnStopRecording.Text = "Stop Recording";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // txtPredictedWord
            // 
            this.txtPredictedWord.Location = new System.Drawing.Point(716, 38);
            this.txtPredictedWord.MaximumSize = new System.Drawing.Size(600, 500);
            this.txtPredictedWord.MinimumSize = new System.Drawing.Size(600, 500);
            this.txtPredictedWord.Multiline = true;
            this.txtPredictedWord.Name = "txtPredictedWord";
            this.txtPredictedWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPredictedWord.Size = new System.Drawing.Size(600, 500);
            this.txtPredictedWord.TabIndex = 4;
            this.txtPredictedWord.Click += new System.EventHandler(this.txtPredictedWord_Click);
            this.txtPredictedWord.TextChanged += new System.EventHandler(this.txtPredictedWord_TextChanged);
            // 
            // txtSensorValues
            // 
            this.txtSensorValues.Location = new System.Drawing.Point(716, 578);
            this.txtSensorValues.MaximumSize = new System.Drawing.Size(600, 250);
            this.txtSensorValues.MinimumSize = new System.Drawing.Size(600, 250);
            this.txtSensorValues.Multiline = true;
            this.txtSensorValues.Name = "txtSensorValues";
            this.txtSensorValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSensorValues.Size = new System.Drawing.Size(600, 250);
            this.txtSensorValues.TabIndex = 5;
            this.txtSensorValues.TextChanged += new System.EventHandler(this.txtSensorValues_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 862);
            this.Controls.Add(this.txtSensorValues);
            this.Controls.Add(this.txtPredictedWord);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.btnStartRecording);
            this.Controls.Add(this.btnSetMinMax);
            this.Controls.Add(this.comboBoxPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button btnSetMinMax;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Button btnStopRecording;
        private System.Windows.Forms.TextBox txtPredictedWord;
        private System.Windows.Forms.TextBox txtSensorValues;
    }
}

