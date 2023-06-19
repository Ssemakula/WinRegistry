namespace WinRegistry
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            tabsMain = new TabControl();
            tabpAppSettings = new TabPage();
            comboLanguage = new ComboBox();
            lblLanguage = new Label();
            txtWebsite = new TextBox();
            lblWebsite = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtActivity = new TextBox();
            lblActivity = new Label();
            txtHandle = new TextBox();
            lblHandle = new Label();
            txtMobile = new TextBox();
            lblMobile = new Label();
            txtTel = new TextBox();
            lblTel = new Label();
            txtAdvertising = new TextBox();
            lblAdvertising = new Label();
            txtManager = new TextBox();
            lblManager = new Label();
            txtCoName = new TextBox();
            lblCoName = new Label();
            tabpLogos = new TabPage();
            btnRestoreDefault = new Button();
            btnSaveChanges = new Button();
            btnSelectLogo = new Button();
            pictureBox1 = new PictureBox();
            btn_Save = new Button();
            btn_Exit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            tabsMain.SuspendLayout();
            tabpAppSettings.SuspendLayout();
            tabpLogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabsMain
            // 
            tabsMain.Controls.Add(tabpAppSettings);
            tabsMain.Controls.Add(tabpLogos);
            tabsMain.Location = new Point(13, 4);
            tabsMain.Name = "tabsMain";
            tabsMain.SelectedIndex = 0;
            tabsMain.Size = new Size(403, 404);
            tabsMain.TabIndex = 0;
            // 
            // tabpAppSettings
            // 
            tabpAppSettings.Controls.Add(comboLanguage);
            tabpAppSettings.Controls.Add(lblLanguage);
            tabpAppSettings.Controls.Add(txtWebsite);
            tabpAppSettings.Controls.Add(lblWebsite);
            tabpAppSettings.Controls.Add(txtEmail);
            tabpAppSettings.Controls.Add(lblEmail);
            tabpAppSettings.Controls.Add(txtAddress);
            tabpAppSettings.Controls.Add(lblAddress);
            tabpAppSettings.Controls.Add(txtActivity);
            tabpAppSettings.Controls.Add(lblActivity);
            tabpAppSettings.Controls.Add(txtHandle);
            tabpAppSettings.Controls.Add(lblHandle);
            tabpAppSettings.Controls.Add(txtMobile);
            tabpAppSettings.Controls.Add(lblMobile);
            tabpAppSettings.Controls.Add(txtTel);
            tabpAppSettings.Controls.Add(lblTel);
            tabpAppSettings.Controls.Add(txtAdvertising);
            tabpAppSettings.Controls.Add(lblAdvertising);
            tabpAppSettings.Controls.Add(txtManager);
            tabpAppSettings.Controls.Add(lblManager);
            tabpAppSettings.Controls.Add(txtCoName);
            tabpAppSettings.Controls.Add(lblCoName);
            tabpAppSettings.Location = new Point(4, 24);
            tabpAppSettings.Name = "tabpAppSettings";
            tabpAppSettings.Padding = new Padding(3);
            tabpAppSettings.Size = new Size(395, 376);
            tabpAppSettings.TabIndex = 0;
            tabpAppSettings.Text = "Application Settings";
            tabpAppSettings.UseVisualStyleBackColor = true;
            // 
            // comboLanguage
            // 
            comboLanguage.FormattingEnabled = true;
            comboLanguage.Items.AddRange(new object[] { "English", "Swahili", "French" });
            comboLanguage.Location = new Point(120, 330);
            comboLanguage.Name = "comboLanguage";
            comboLanguage.Size = new Size(262, 23);
            comboLanguage.TabIndex = 21;
            // 
            // lblLanguage
            // 
            lblLanguage.ImageAlign = ContentAlignment.BottomLeft;
            lblLanguage.Location = new Point(20, 330);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(100, 23);
            lblLanguage.TabIndex = 20;
            lblLanguage.Text = "Language:";
            lblLanguage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(120, 296);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(262, 23);
            txtWebsite.TabIndex = 19;
            // 
            // lblWebsite
            // 
            lblWebsite.ImageAlign = ContentAlignment.BottomLeft;
            lblWebsite.Location = new Point(20, 296);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(100, 23);
            lblWebsite.TabIndex = 18;
            lblWebsite.Text = "Website:";
            lblWebsite.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 23);
            txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.ImageAlign = ContentAlignment.BottomLeft;
            lblEmail.Location = new Point(20, 267);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 238);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(262, 23);
            txtAddress.TabIndex = 15;
            // 
            // lblAddress
            // 
            lblAddress.ImageAlign = ContentAlignment.BottomLeft;
            lblAddress.Location = new Point(20, 238);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address:";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtActivity
            // 
            txtActivity.Location = new Point(120, 209);
            txtActivity.Name = "txtActivity";
            txtActivity.Size = new Size(262, 23);
            txtActivity.TabIndex = 13;
            // 
            // lblActivity
            // 
            lblActivity.ImageAlign = ContentAlignment.BottomLeft;
            lblActivity.Location = new Point(20, 209);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(100, 23);
            lblActivity.TabIndex = 12;
            lblActivity.Text = "Activity:";
            lblActivity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHandle
            // 
            txtHandle.Location = new Point(120, 180);
            txtHandle.Name = "txtHandle";
            txtHandle.Size = new Size(262, 23);
            txtHandle.TabIndex = 11;
            // 
            // lblHandle
            // 
            lblHandle.ImageAlign = ContentAlignment.BottomLeft;
            lblHandle.Location = new Point(20, 180);
            lblHandle.Name = "lblHandle";
            lblHandle.Size = new Size(100, 23);
            lblHandle.TabIndex = 10;
            lblHandle.Text = "Handle:";
            lblHandle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(120, 151);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(262, 23);
            txtMobile.TabIndex = 9;
            // 
            // lblMobile
            // 
            lblMobile.ImageAlign = ContentAlignment.BottomLeft;
            lblMobile.Location = new Point(20, 151);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(100, 23);
            lblMobile.TabIndex = 8;
            lblMobile.Text = "Mobile:";
            lblMobile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(120, 122);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(262, 23);
            txtTel.TabIndex = 7;
            // 
            // lblTel
            // 
            lblTel.ImageAlign = ContentAlignment.BottomLeft;
            lblTel.Location = new Point(20, 122);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(100, 23);
            lblTel.TabIndex = 6;
            lblTel.Text = "Tel:";
            lblTel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAdvertising
            // 
            txtAdvertising.Location = new Point(120, 93);
            txtAdvertising.Name = "txtAdvertising";
            txtAdvertising.Size = new Size(262, 23);
            txtAdvertising.TabIndex = 5;
            // 
            // lblAdvertising
            // 
            lblAdvertising.ImageAlign = ContentAlignment.BottomLeft;
            lblAdvertising.Location = new Point(20, 93);
            lblAdvertising.Name = "lblAdvertising";
            lblAdvertising.Size = new Size(100, 23);
            lblAdvertising.TabIndex = 4;
            lblAdvertising.Text = "Advertising:";
            lblAdvertising.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtManager
            // 
            txtManager.Location = new Point(120, 64);
            txtManager.Name = "txtManager";
            txtManager.Size = new Size(262, 23);
            txtManager.TabIndex = 3;
            // 
            // lblManager
            // 
            lblManager.ImageAlign = ContentAlignment.BottomLeft;
            lblManager.Location = new Point(20, 64);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(100, 23);
            lblManager.TabIndex = 2;
            lblManager.Text = "Manager:";
            lblManager.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCoName
            // 
            txtCoName.Location = new Point(120, 35);
            txtCoName.Name = "txtCoName";
            txtCoName.Size = new Size(262, 23);
            txtCoName.TabIndex = 1;
            // 
            // lblCoName
            // 
            lblCoName.ImageAlign = ContentAlignment.BottomLeft;
            lblCoName.Location = new Point(20, 35);
            lblCoName.Name = "lblCoName";
            lblCoName.Size = new Size(100, 23);
            lblCoName.TabIndex = 0;
            lblCoName.Text = "Company Name:";
            lblCoName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabpLogos
            // 
            tabpLogos.Controls.Add(btnRestoreDefault);
            tabpLogos.Controls.Add(btnSaveChanges);
            tabpLogos.Controls.Add(btnSelectLogo);
            tabpLogos.Controls.Add(pictureBox1);
            tabpLogos.Location = new Point(4, 24);
            tabpLogos.Name = "tabpLogos";
            tabpLogos.Padding = new Padding(3);
            tabpLogos.Size = new Size(395, 376);
            tabpLogos.TabIndex = 1;
            tabpLogos.Text = "Logo";
            tabpLogos.UseVisualStyleBackColor = true;
            // 
            // btnRestoreDefault
            // 
            btnRestoreDefault.Location = new Point(96, 217);
            btnRestoreDefault.Name = "btnRestoreDefault";
            btnRestoreDefault.Size = new Size(181, 23);
            btnRestoreDefault.TabIndex = 3;
            btnRestoreDefault.Text = "Restore Default";
            btnRestoreDefault.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(96, 188);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(181, 23);
            btnSaveChanges.TabIndex = 2;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnSelectLogo
            // 
            btnSelectLogo.Location = new Point(96, 159);
            btnSelectLogo.Name = "btnSelectLogo";
            btnSelectLogo.Size = new Size(181, 23);
            btnSelectLogo.TabIndex = 1;
            btnSelectLogo.Text = "Select Logo";
            btnSelectLogo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(91, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 126);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Save.Location = new Point(13, 467);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(153, 23);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Exit.Location = new Point(246, 467);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(153, 23);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(246, 438);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoad.Location = new Point(17, 438);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(153, 23);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 510);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Save);
            Controls.Add(tabsMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            Text = "SettingsForm";
            tabsMain.ResumeLayout(false);
            tabpAppSettings.ResumeLayout(false);
            tabpAppSettings.PerformLayout();
            tabpLogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabsMain;
        private TabPage tabpAppSettings;
        private TabPage tabpLogos;
        private Button btn_Save;
        private Button btn_Exit;
        private ComboBox comboLanguage;
        private Label lblLanguage;
        private TextBox txtWebsite;
        private Label lblWebsite;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtActivity;
        private Label lblActivity;
        private TextBox txtHandle;
        private Label lblHandle;
        private TextBox txtMobile;
        private Label lblMobile;
        private TextBox txtTel;
        private Label lblTel;
        private TextBox txtAdvertising;
        private Label lblAdvertising;
        private TextBox txtManager;
        private Label lblManager;
        private TextBox txtCoName;
        private Label lblCoName;
        private Button btnRestoreDefault;
        private Button btnSaveChanges;
        private Button btnSelectLogo;
        private PictureBox pictureBox1;
        private Button btnDelete;
        private Button btnLoad;
    }
}