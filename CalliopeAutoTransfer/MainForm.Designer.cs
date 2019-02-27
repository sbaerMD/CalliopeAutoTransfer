namespace CalliopeAutoTransfer
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PrüfenLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AutomaticON = new System.Windows.Forms.CheckBox();
            this.CalliopeVerbundenLabel = new System.Windows.Forms.Panel();
            this.CalliopeVerbundenLabel_ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TransferDateiLabel = new System.Windows.Forms.Label();
            this.SettingsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadFolderTextbox = new System.Windows.Forms.TextBox();
            this.ÜbernehmenButton = new System.Windows.Forms.Button();
            this.calliopeDriveDropdown = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.transferPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.calliopePicture = new System.Windows.Forms.PictureBox();
            this.filePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CalliopeVerbundenLabel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SettingsTablePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.transferPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calliopePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 853);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(197, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calliope Auto Transfer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.PrüfenLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.AutomaticON, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CalliopeVerbundenLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.transferPanel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.filesPanel, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(197, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 597);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // PrüfenLabel
            // 
            this.PrüfenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrüfenLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrüfenLabel.Location = new System.Drawing.Point(147, 205);
            this.PrüfenLabel.Name = "PrüfenLabel";
            this.PrüfenLabel.Size = new System.Drawing.Size(282, 100);
            this.PrüfenLabel.TabIndex = 10;
            this.PrüfenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(3, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 71);
            this.label4.TabIndex = 5;
            this.label4.Text = "vorhandene übertragen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AutomaticON
            // 
            this.AutomaticON.Checked = true;
            this.AutomaticON.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutomaticON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutomaticON.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.AutomaticON.Location = new System.Drawing.Point(147, 3);
            this.AutomaticON.Name = "AutomaticON";
            this.AutomaticON.Size = new System.Drawing.Size(282, 54);
            this.AutomaticON.TabIndex = 8;
            this.AutomaticON.Text = "neue Projekte automatisch auf den Calliope übertragen";
            this.AutomaticON.UseVisualStyleBackColor = true;
            // 
            // CalliopeVerbundenLabel
            // 
            this.CalliopeVerbundenLabel.Controls.Add(this.calliopePicture);
            this.CalliopeVerbundenLabel.Controls.Add(this.CalliopeVerbundenLabel_);
            this.CalliopeVerbundenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalliopeVerbundenLabel.Location = new System.Drawing.Point(435, 63);
            this.CalliopeVerbundenLabel.Name = "CalliopeVerbundenLabel";
            this.CalliopeVerbundenLabel.Size = new System.Drawing.Size(138, 139);
            this.CalliopeVerbundenLabel.TabIndex = 11;
            // 
            // CalliopeVerbundenLabel_
            // 
            this.CalliopeVerbundenLabel_.BackColor = System.Drawing.Color.Transparent;
            this.CalliopeVerbundenLabel_.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CalliopeVerbundenLabel_.Location = new System.Drawing.Point(0, 111);
            this.CalliopeVerbundenLabel_.Name = "CalliopeVerbundenLabel_";
            this.CalliopeVerbundenLabel_.Size = new System.Drawing.Size(138, 28);
            this.CalliopeVerbundenLabel_.TabIndex = 3;
            this.CalliopeVerbundenLabel_.Text = "Calliope nicht verbunden";
            this.CalliopeVerbundenLabel_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filePicture);
            this.panel1.Controls.Add(this.TransferDateiLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 139);
            this.panel1.TabIndex = 12;
            // 
            // TransferDateiLabel
            // 
            this.TransferDateiLabel.BackColor = System.Drawing.Color.Transparent;
            this.TransferDateiLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TransferDateiLabel.Location = new System.Drawing.Point(0, 111);
            this.TransferDateiLabel.Name = "TransferDateiLabel";
            this.TransferDateiLabel.Size = new System.Drawing.Size(138, 28);
            this.TransferDateiLabel.TabIndex = 2;
            this.TransferDateiLabel.Text = "keine Übertragungsdatei";
            this.TransferDateiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsTablePanel
            // 
            this.SettingsTablePanel.BackColor = System.Drawing.Color.Linen;
            this.SettingsTablePanel.ColumnCount = 2;
            this.SettingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.SettingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SettingsTablePanel.Controls.Add(this.SettingsLabel, 0, 0);
            this.SettingsTablePanel.Controls.Add(this.label2, 0, 1);
            this.SettingsTablePanel.Controls.Add(this.label3, 0, 2);
            this.SettingsTablePanel.Controls.Add(this.downloadFolderTextbox, 1, 1);
            this.SettingsTablePanel.Controls.Add(this.ÜbernehmenButton, 1, 3);
            this.SettingsTablePanel.Controls.Add(this.calliopeDriveDropdown, 1, 2);
            this.SettingsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTablePanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsTablePanel.Name = "SettingsTablePanel";
            this.SettingsTablePanel.RowCount = 4;
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsTablePanel.Size = new System.Drawing.Size(971, 853);
            this.SettingsTablePanel.TabIndex = 1;
            // 
            // SettingsLabel
            // 
            this.SettingsTablePanel.SetColumnSpan(this.SettingsLabel, 2);
            this.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.Location = new System.Drawing.Point(3, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(965, 40);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Einstellungen";
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Download-Ordner:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calliope-Laufwerk:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // downloadFolderTextbox
            // 
            this.downloadFolderTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadFolderTextbox.Location = new System.Drawing.Point(153, 43);
            this.downloadFolderTextbox.Name = "downloadFolderTextbox";
            this.downloadFolderTextbox.Size = new System.Drawing.Size(815, 20);
            this.downloadFolderTextbox.TabIndex = 2;
            this.downloadFolderTextbox.TabStop = false;
            // 
            // ÜbernehmenButton
            // 
            this.ÜbernehmenButton.Location = new System.Drawing.Point(153, 93);
            this.ÜbernehmenButton.Name = "ÜbernehmenButton";
            this.ÜbernehmenButton.Size = new System.Drawing.Size(114, 48);
            this.ÜbernehmenButton.TabIndex = 5;
            this.ÜbernehmenButton.TabStop = false;
            this.ÜbernehmenButton.Text = "Übernehmen";
            this.ÜbernehmenButton.UseVisualStyleBackColor = true;
            this.ÜbernehmenButton.Click += new System.EventHandler(this.ÜbernehmenButton_Click);
            // 
            // calliopeDriveDropdown
            // 
            this.calliopeDriveDropdown.FormattingEnabled = true;
            this.calliopeDriveDropdown.Items.AddRange(new object[] {
            "A:\\",
            "B:\\",
            "C:\\",
            "D:\\",
            "E:\\",
            "F:\\",
            "G:\\",
            "H:\\",
            "I:\\",
            "J:\\",
            "K:\\",
            "L:\\",
            "M:\\",
            "N:\\",
            "O:\\",
            "P:\\",
            "Q:\\",
            "R:\\",
            "S:\\",
            "T:\\",
            "U:\\",
            "V:\\",
            "W:\\",
            "X:\\",
            "Y:\\",
            "Z:\\"});
            this.calliopeDriveDropdown.Location = new System.Drawing.Point(153, 68);
            this.calliopeDriveDropdown.Name = "calliopeDriveDropdown";
            this.calliopeDriveDropdown.Size = new System.Drawing.Size(71, 21);
            this.calliopeDriveDropdown.TabIndex = 4;
            this.calliopeDriveDropdown.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 885);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(977, 859);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SettingsTablePanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(977, 859);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Einstellungen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // transferPanel
            // 
            this.transferPanel.Controls.Add(this.pictureBox1);
            this.transferPanel.Controls.Add(this.label5);
            this.transferPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferPanel.Location = new System.Drawing.Point(147, 63);
            this.transferPanel.Name = "transferPanel";
            this.transferPanel.Size = new System.Drawing.Size(282, 139);
            this.transferPanel.TabIndex = 13;
            this.transferPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 59);
            this.label5.TabIndex = 3;
            this.label5.Text = "Projekt wird zum Calliope übertragen";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calliopePicture
            // 
            this.calliopePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calliopePicture.Image = global::CalliopeAutoTransfer.Properties.Resources.Calliope;
            this.calliopePicture.Location = new System.Drawing.Point(0, 0);
            this.calliopePicture.Name = "calliopePicture";
            this.calliopePicture.Size = new System.Drawing.Size(138, 111);
            this.calliopePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calliopePicture.TabIndex = 4;
            this.calliopePicture.TabStop = false;
            // 
            // filePicture
            // 
            this.filePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePicture.Image = global::CalliopeAutoTransfer.Properties.Resources.Projekt_grau;
            this.filePicture.Location = new System.Drawing.Point(0, 0);
            this.filePicture.Name = "filePicture";
            this.filePicture.Size = new System.Drawing.Size(138, 111);
            this.filePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filePicture.TabIndex = 5;
            this.filePicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CalliopeAutoTransfer.Properties.Resources.transfer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // filesPanel
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.filesPanel, 3);
            this.filesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesPanel.Location = new System.Drawing.Point(3, 379);
            this.filesPanel.Name = "filesPanel";
            this.filesPanel.Size = new System.Drawing.Size(570, 215);
            this.filesPanel.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(985, 885);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "CalliopeAutoTransfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.CalliopeVerbundenLabel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SettingsTablePanel.ResumeLayout(false);
            this.SettingsTablePanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.transferPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calliopePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel SettingsTablePanel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox downloadFolderTextbox;
        private System.Windows.Forms.Button ÜbernehmenButton;
        private System.Windows.Forms.ComboBox calliopeDriveDropdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label TransferDateiLabel;
        private System.Windows.Forms.Label CalliopeVerbundenLabel_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox AutomaticON;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label PrüfenLabel;
        private System.Windows.Forms.Panel CalliopeVerbundenLabel;
        private System.Windows.Forms.PictureBox calliopePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox filePicture;
        private System.Windows.Forms.Panel transferPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel filesPanel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

