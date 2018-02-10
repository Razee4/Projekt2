namespace ServerProject
{
    partial class ServerForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listBoxConnections = new System.Windows.Forms.ListBox();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(37, 423);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(37, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Adres:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(273, 426);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Port:";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(306, 423);
            this.numericUpDownPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownPort.TabIndex = 3;
            this.numericUpDownPort.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(59, 463);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 57);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(306, 463);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(116, 57);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // listBoxConnections
            // 
            this.listBoxConnections.FormattingEnabled = true;
            this.listBoxConnections.Location = new System.Drawing.Point(5, 21);
            this.listBoxConnections.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxConnections.Name = "listBoxConnections";
            this.listBoxConnections.Size = new System.Drawing.Size(446, 381);
            this.listBoxConnections.TabIndex = 6;
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(78, 420);
            this.comboBoxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(138, 21);
            this.comboBoxAddress.TabIndex = 7;
            this.comboBoxAddress.Text = "127.0.0.1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 552);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.listBoxConnections);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelAddress);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ServerForm";
            this.Text = "RCP Server";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListBox listBoxConnections;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

