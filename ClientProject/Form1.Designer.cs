namespace ClientProject
{
    partial class ClientForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.groupBoxTasks = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(298, 28);
            this.listBoxTasks.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(262, 290);
            this.listBoxTasks.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(79, 55);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(125, 77);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(79, 379);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(125, 81);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(79, 226);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(177, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(79, 250);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(177, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(36, 229);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(36, 253);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(39, 13);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Hasło:";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(4, 284);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(132, 32);
            this.buttonLogIn.TabIndex = 9;
            this.buttonLogIn.Text = "Zaloguj";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(162, 284);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(132, 34);
            this.buttonLogOut.TabIndex = 10;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(79, 202);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(177, 20);
            this.textBoxAddress.TabIndex = 11;
            this.textBoxAddress.Text = "127.0.0.1";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(35, 205);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(37, 13);
            this.labelAddress.TabIndex = 12;
            this.labelAddress.Text = "Adres:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(36, 180);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 13;
            this.labelPort.Text = "Port:";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(79, 178);
            this.numericUpDownPort.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(177, 20);
            this.numericUpDownPort.TabIndex = 14;
            this.numericUpDownPort.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTask);
            this.groupBox1.Controls.Add(this.textBoxTask);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Location = new System.Drawing.Point(298, 332);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(258, 154);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj/usuń zadanie";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(157, 78);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 39);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń zadanie";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 78);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 39);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Nowe zadanie";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(4, 36);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(250, 20);
            this.textBoxTask.TabIndex = 5;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(5, 18);
            this.labelTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(124, 13);
            this.labelTask.TabIndex = 6;
            this.labelTask.Text = "Nazwa nowego zadania:";
            // 
            // groupBoxTasks
            // 
            this.groupBoxTasks.Controls.Add(this.groupBox1);
            this.groupBoxTasks.Controls.Add(this.numericUpDownPort);
            this.groupBoxTasks.Controls.Add(this.labelPort);
            this.groupBoxTasks.Controls.Add(this.labelAddress);
            this.groupBoxTasks.Controls.Add(this.textBoxAddress);
            this.groupBoxTasks.Controls.Add(this.buttonLogOut);
            this.groupBoxTasks.Controls.Add(this.buttonLogIn);
            this.groupBoxTasks.Controls.Add(this.labelPassword);
            this.groupBoxTasks.Controls.Add(this.labelLogin);
            this.groupBoxTasks.Controls.Add(this.textBoxPassword);
            this.groupBoxTasks.Controls.Add(this.textBoxLogin);
            this.groupBoxTasks.Controls.Add(this.buttonStop);
            this.groupBoxTasks.Controls.Add(this.buttonStart);
            this.groupBoxTasks.Controls.Add(this.listBoxTasks);
            this.groupBoxTasks.Location = new System.Drawing.Point(10, 11);
            this.groupBoxTasks.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTasks.Name = "groupBoxTasks";
            this.groupBoxTasks.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTasks.Size = new System.Drawing.Size(560, 528);
            this.groupBoxTasks.TabIndex = 0;
            this.groupBoxTasks.TabStop = false;
            this.groupBoxTasks.Text = "Rejestracja czasu pracy";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 548);
            this.Controls.Add(this.groupBoxTasks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientForm";
            this.Text = "RCP Client";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTasks.ResumeLayout(false);
            this.groupBoxTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxTasks;
    }
}

