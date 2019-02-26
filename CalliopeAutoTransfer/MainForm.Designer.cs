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
            this.SettingsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadFolderTextbox = new System.Windows.Forms.TextBox();
            this.ÜbernehmenButton = new System.Windows.Forms.Button();
            this.calliopeDriveDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PrüfenLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.TransferDateiLabel = new System.Windows.Forms.Label();
            this.CalliopeVerbundenLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SettingsTablePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 5000;
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
            this.tableLayoutPanel1.Controls.Add(this.SettingsTablePanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calliope Auto Transfer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.SettingsTablePanel.Location = new System.Drawing.Point(198, 476);
            this.SettingsTablePanel.Name = "SettingsTablePanel";
            this.SettingsTablePanel.RowCount = 4;
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsTablePanel.Size = new System.Drawing.Size(580, 194);
            this.SettingsTablePanel.TabIndex = 1;
            // 
            // SettingsLabel
            // 
            this.SettingsTablePanel.SetColumnSpan(this.SettingsLabel, 2);
            this.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.Location = new System.Drawing.Point(3, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(574, 40);
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
            this.downloadFolderTextbox.Size = new System.Drawing.Size(424, 20);
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
            "G:\\"});
            this.calliopeDriveDropdown.Location = new System.Drawing.Point(153, 68);
            this.calliopeDriveDropdown.Name = "calliopeDriveDropdown";
            this.calliopeDriveDropdown.Size = new System.Drawing.Size(71, 21);
            this.calliopeDriveDropdown.TabIndex = 4;
            this.calliopeDriveDropdown.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.CalliopeVerbundenLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.PrüfenLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.OkButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TransferDateiLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(198, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(580, 317);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // PrüfenLabel
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.PrüfenLabel, 3);
            this.PrüfenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrüfenLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrüfenLabel.Location = new System.Drawing.Point(3, 0);
            this.PrüfenLabel.Name = "PrüfenLabel";
            this.PrüfenLabel.Size = new System.Drawing.Size(574, 100);
            this.PrüfenLabel.TabIndex = 0;
            this.PrüfenLabel.Text = "Prüfe ...";
            this.PrüfenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.Beige;
            this.OkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkButton.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(148, 103);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(284, 94);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TransferDateiLabel
            // 
            this.TransferDateiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransferDateiLabel.Location = new System.Drawing.Point(3, 100);
            this.TransferDateiLabel.Name = "TransferDateiLabel";
            this.TransferDateiLabel.Size = new System.Drawing.Size(139, 100);
            this.TransferDateiLabel.TabIndex = 2;
            this.TransferDateiLabel.Text = ".";
            this.TransferDateiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalliopeVerbundenLabel
            // 
            this.CalliopeVerbundenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalliopeVerbundenLabel.Location = new System.Drawing.Point(438, 100);
            this.CalliopeVerbundenLabel.Name = "CalliopeVerbundenLabel";
            this.CalliopeVerbundenLabel.Size = new System.Drawing.Size(139, 100);
            this.CalliopeVerbundenLabel.TabIndex = 3;
            this.CalliopeVerbundenLabel.Text = ".";
            this.CalliopeVerbundenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(977, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "CalliopeAutoTransfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SettingsTablePanel.ResumeLayout(false);
            this.SettingsTablePanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label PrüfenLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TransferDateiLabel;
        private System.Windows.Forms.Label CalliopeVerbundenLabel;
    }
}

