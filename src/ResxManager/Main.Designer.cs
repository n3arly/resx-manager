namespace ResxManager
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            mainTabCtrl = new TabControl();
            createTabPage = new TabPage();
            languagesToCreateGrid = new DataGridView();
            gridCmbCulture = new DataGridViewComboBoxColumn();
            gridTxtPath = new DataGridViewTextBoxColumn();
            createProgressBar = new ProgressBar();
            lblLanguagesToCreate = new Label();
            btnGenerate = new Button();
            lblSourceFileCulture = new Label();
            cmbSupportedCultures = new ComboBox();
            txtCreateResourceFile = new TextBox();
            lblCreateResourceFile = new Label();
            readTabPage = new TabPage();
            btnGet = new Button();
            keyValueGrid = new DataGridView();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            lblKey = new Label();
            txtKey = new TextBox();
            rdbOneKey = new RadioButton();
            rdbAllKeys = new RadioButton();
            lblReadResourceFile = new Label();
            txtReadResourceFile = new TextBox();
            mainTabCtrl.SuspendLayout();
            createTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)languagesToCreateGrid).BeginInit();
            readTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)keyValueGrid).BeginInit();
            SuspendLayout();
            // 
            // mainTabCtrl
            // 
            mainTabCtrl.Controls.Add(createTabPage);
            mainTabCtrl.Controls.Add(readTabPage);
            mainTabCtrl.Location = new Point(12, 2);
            mainTabCtrl.Name = "mainTabCtrl";
            mainTabCtrl.SelectedIndex = 0;
            mainTabCtrl.Size = new Size(504, 436);
            mainTabCtrl.TabIndex = 5;
            // 
            // createTabPage
            // 
            createTabPage.Controls.Add(languagesToCreateGrid);
            createTabPage.Controls.Add(createProgressBar);
            createTabPage.Controls.Add(lblLanguagesToCreate);
            createTabPage.Controls.Add(btnGenerate);
            createTabPage.Controls.Add(lblSourceFileCulture);
            createTabPage.Controls.Add(cmbSupportedCultures);
            createTabPage.Controls.Add(txtCreateResourceFile);
            createTabPage.Controls.Add(lblCreateResourceFile);
            createTabPage.Location = new Point(4, 24);
            createTabPage.Name = "createTabPage";
            createTabPage.Padding = new Padding(3);
            createTabPage.Size = new Size(496, 408);
            createTabPage.TabIndex = 0;
            createTabPage.Text = "Create";
            createTabPage.UseVisualStyleBackColor = true;
            // 
            // languagesToCreateGrid
            // 
            languagesToCreateGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            languagesToCreateGrid.Columns.AddRange(new DataGridViewColumn[] { gridCmbCulture, gridTxtPath });
            languagesToCreateGrid.Location = new Point(6, 94);
            languagesToCreateGrid.Name = "languagesToCreateGrid";
            languagesToCreateGrid.RowTemplate.Height = 25;
            languagesToCreateGrid.Size = new Size(484, 242);
            languagesToCreateGrid.TabIndex = 3;
            // 
            // gridCmbCulture
            // 
            gridCmbCulture.HeaderText = "Culture";
            gridCmbCulture.Name = "gridCmbCulture";
            gridCmbCulture.Width = 220;
            // 
            // gridTxtPath
            // 
            gridTxtPath.HeaderText = "Path";
            gridTxtPath.Name = "gridTxtPath";
            gridTxtPath.Width = 220;
            // 
            // createProgressBar
            // 
            createProgressBar.Location = new Point(6, 342);
            createProgressBar.Name = "createProgressBar";
            createProgressBar.Size = new Size(484, 31);
            createProgressBar.TabIndex = 7;
            // 
            // lblLanguagesToCreate
            // 
            lblLanguagesToCreate.AutoSize = true;
            lblLanguagesToCreate.Location = new Point(6, 76);
            lblLanguagesToCreate.Name = "lblLanguagesToCreate";
            lblLanguagesToCreate.Size = new Size(118, 15);
            lblLanguagesToCreate.TabIndex = 6;
            lblLanguagesToCreate.Text = "Languages to Create:";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(6, 379);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(484, 23);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblSourceFileCulture
            // 
            lblSourceFileCulture.AutoSize = true;
            lblSourceFileCulture.Location = new Point(6, 50);
            lblSourceFileCulture.Name = "lblSourceFileCulture";
            lblSourceFileCulture.Size = new Size(109, 15);
            lblSourceFileCulture.TabIndex = 3;
            lblSourceFileCulture.Text = "Source File Culture:";
            // 
            // cmbSupportedCultures
            // 
            cmbSupportedCultures.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupportedCultures.FormattingEnabled = true;
            cmbSupportedCultures.Location = new Point(130, 47);
            cmbSupportedCultures.Name = "cmbSupportedCultures";
            cmbSupportedCultures.Size = new Size(360, 23);
            cmbSupportedCultures.TabIndex = 2;
            // 
            // txtCreateResourceFile
            // 
            txtCreateResourceFile.Location = new Point(130, 18);
            txtCreateResourceFile.Name = "txtCreateResourceFile";
            txtCreateResourceFile.Size = new Size(360, 23);
            txtCreateResourceFile.TabIndex = 1;
            // 
            // lblCreateResourceFile
            // 
            lblCreateResourceFile.AutoSize = true;
            lblCreateResourceFile.Location = new Point(6, 21);
            lblCreateResourceFile.Name = "lblCreateResourceFile";
            lblCreateResourceFile.Size = new Size(79, 15);
            lblCreateResourceFile.TabIndex = 0;
            lblCreateResourceFile.Text = "Resource File:";
            // 
            // readTabPage
            // 
            readTabPage.Controls.Add(btnGet);
            readTabPage.Controls.Add(keyValueGrid);
            readTabPage.Controls.Add(lblKey);
            readTabPage.Controls.Add(txtKey);
            readTabPage.Controls.Add(rdbOneKey);
            readTabPage.Controls.Add(rdbAllKeys);
            readTabPage.Controls.Add(lblReadResourceFile);
            readTabPage.Controls.Add(txtReadResourceFile);
            readTabPage.Location = new Point(4, 24);
            readTabPage.Name = "readTabPage";
            readTabPage.Padding = new Padding(3);
            readTabPage.Size = new Size(496, 408);
            readTabPage.TabIndex = 1;
            readTabPage.Text = "Read";
            readTabPage.UseVisualStyleBackColor = true;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(6, 379);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(484, 23);
            btnGet.TabIndex = 6;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // keyValueGrid
            // 
            keyValueGrid.AllowUserToAddRows = false;
            keyValueGrid.AllowUserToDeleteRows = false;
            keyValueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            keyValueGrid.Columns.AddRange(new DataGridViewColumn[] { Key, Value });
            keyValueGrid.Location = new Point(6, 102);
            keyValueGrid.Name = "keyValueGrid";
            keyValueGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            keyValueGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            keyValueGrid.RowTemplate.Height = 25;
            keyValueGrid.Size = new Size(484, 271);
            keyValueGrid.TabIndex = 5;
            // 
            // Key
            // 
            Key.HeaderText = "Key";
            Key.Name = "Key";
            Key.ReadOnly = true;
            Key.Width = 220;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            Value.ReadOnly = true;
            Value.Width = 220;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(6, 76);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(29, 15);
            lblKey.TabIndex = 5;
            lblKey.Text = "Key:";
            // 
            // txtKey
            // 
            txtKey.Enabled = false;
            txtKey.Location = new Point(91, 73);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(399, 23);
            txtKey.TabIndex = 4;
            // 
            // rdbOneKey
            // 
            rdbOneKey.AutoSize = true;
            rdbOneKey.Location = new Point(415, 48);
            rdbOneKey.Name = "rdbOneKey";
            rdbOneKey.Size = new Size(69, 19);
            rdbOneKey.TabIndex = 3;
            rdbOneKey.Text = "One Key";
            rdbOneKey.UseVisualStyleBackColor = true;
            rdbOneKey.Click += rdbOneKey_Click;
            // 
            // rdbAllKeys
            // 
            rdbAllKeys.AutoSize = true;
            rdbAllKeys.Checked = true;
            rdbAllKeys.Location = new Point(313, 48);
            rdbAllKeys.Name = "rdbAllKeys";
            rdbAllKeys.Size = new Size(66, 19);
            rdbAllKeys.TabIndex = 2;
            rdbAllKeys.TabStop = true;
            rdbAllKeys.Text = "All Keys";
            rdbAllKeys.UseVisualStyleBackColor = true;
            rdbAllKeys.Click += rdbAllKeys_Click;
            // 
            // lblReadResourceFile
            // 
            lblReadResourceFile.AutoSize = true;
            lblReadResourceFile.Location = new Point(6, 22);
            lblReadResourceFile.Name = "lblReadResourceFile";
            lblReadResourceFile.Size = new Size(79, 15);
            lblReadResourceFile.TabIndex = 1;
            lblReadResourceFile.Text = "Resource File:";
            // 
            // txtReadResourceFile
            // 
            txtReadResourceFile.Location = new Point(91, 19);
            txtReadResourceFile.Name = "txtReadResourceFile";
            txtReadResourceFile.Size = new Size(399, 23);
            txtReadResourceFile.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(mainTabCtrl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resx Manager";
            Load += Main_Load;
            mainTabCtrl.ResumeLayout(false);
            createTabPage.ResumeLayout(false);
            createTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)languagesToCreateGrid).EndInit();
            readTabPage.ResumeLayout(false);
            readTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)keyValueGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabCtrl;
        private TabPage createTabPage;
        private TabPage readTabPage;
        private Label lblReadResourceFile;
        private TextBox txtReadResourceFile;
        private Label lblKey;
        private TextBox txtKey;
        private RadioButton rdbOneKey;
        private RadioButton rdbAllKeys;
        private DataGridView keyValueGrid;
        private Button btnGet;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private ComboBox cmbSupportedCultures;
        private TextBox txtCreateResourceFile;
        private Label lblCreateResourceFile;
        private Label lblSourceFileCulture;
        private Button btnGenerate;
        private Label lblLanguagesToCreate;
        private ProgressBar createProgressBar;
        private DataGridView languagesToCreateGrid;
        private DataGridViewComboBoxColumn gridCmbCulture;
        private DataGridViewTextBoxColumn gridTxtPath;
    }
}