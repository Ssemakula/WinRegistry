namespace WinRegistry
{
    partial class LoginForm
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
            lbl_UserName = new Label();
            txt_UserName = new TextBox();
            txt_Date = new TextBox();
            lbl_Date = new Label();
            txt_FullName = new TextBox();
            lbl_FullName = new Label();
            btn_Save = new Button();
            btn_Close = new Button();
            btn_Cancel = new Button();
            btn_SaveLM = new Button();
            dtp_DateOf = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_UserName
            // 
            lbl_UserName.Location = new Point(25, 60);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(89, 23);
            lbl_UserName.TabIndex = 0;
            lbl_UserName.Text = "User Name";
            lbl_UserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(114, 60);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(182, 23);
            txt_UserName.TabIndex = 1;
            // 
            // txt_Date
            // 
            txt_Date.Location = new Point(114, 89);
            txt_Date.Name = "txt_Date";
            txt_Date.Size = new Size(182, 23);
            txt_Date.TabIndex = 3;
            // 
            // lbl_Date
            // 
            lbl_Date.Location = new Point(25, 89);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(89, 23);
            lbl_Date.TabIndex = 2;
            lbl_Date.Text = "Date";
            lbl_Date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_FullName
            // 
            txt_FullName.Location = new Point(114, 118);
            txt_FullName.Name = "txt_FullName";
            txt_FullName.Size = new Size(182, 23);
            txt_FullName.TabIndex = 5;
            // 
            // lbl_FullName
            // 
            lbl_FullName.Location = new Point(25, 118);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new Size(89, 23);
            lbl_FullName.TabIndex = 4;
            lbl_FullName.Text = "Full Name";
            lbl_FullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Save.Location = new Point(25, 237);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 6;
            btn_Save.Text = "Save CU";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Close.Location = new Point(221, 237);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(75, 23);
            btn_Close.TabIndex = 7;
            btn_Close.Text = "Exit";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Cancel.Location = new Point(123, 237);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 8;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_SaveLM
            // 
            btn_SaveLM.Location = new Point(25, 202);
            btn_SaveLM.Name = "btn_SaveLM";
            btn_SaveLM.Size = new Size(75, 23);
            btn_SaveLM.TabIndex = 9;
            btn_SaveLM.Text = "Save LM";
            btn_SaveLM.UseVisualStyleBackColor = true;
            btn_SaveLM.Click += btn_SaveLM_Click;
            // 
            // dtp_DateOf
            // 
            dtp_DateOf.Format = DateTimePickerFormat.Custom;
            dtp_DateOf.Location = new Point(114, 159);
            dtp_DateOf.Name = "dtp_DateOf";
            dtp_DateOf.Size = new Size(182, 23);
            dtp_DateOf.TabIndex = 10;
            // 
            // label1
            // 
            label1.Location = new Point(25, 159);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 11;
            label1.Text = "Full Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 278);
            Controls.Add(label1);
            Controls.Add(dtp_DateOf);
            Controls.Add(btn_SaveLM);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(txt_FullName);
            Controls.Add(lbl_FullName);
            Controls.Add(txt_Date);
            Controls.Add(lbl_Date);
            Controls.Add(txt_UserName);
            Controls.Add(lbl_UserName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_UserName;
        private TextBox txt_UserName;
        private TextBox txt_Date;
        private Label lbl_Date;
        private TextBox txt_FullName;
        private Label lbl_FullName;
        private Button btn_Save;
        private Button btn_Close;
        private Button btn_Cancel;
        private Button btn_SaveLM;
        private DateTimePicker dtp_DateOf;
        private Label label1;
    }
}