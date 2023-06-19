namespace WinRegistry
{
    partial class SaveInRegistry
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
            btnBackCol = new Button();
            btnFrontCol = new Button();
            txt_TestText = new TextBox();
            colourDialogue = new ColorDialog();
            lbl_Forecolor = new Label();
            lbl_Backcolor = new Label();
            btn_Save = new Button();
            btn_LoadColors = new Button();
            txt_Fonts = new TextBox();
            btn_Fonts = new Button();
            fontDialog1 = new FontDialog();
            btn_SaveFont = new Button();
            btn_LoadFont = new Button();
            SuspendLayout();
            // 
            // btnBackCol
            // 
            btnBackCol.Location = new Point(55, 61);
            btnBackCol.Name = "btnBackCol";
            btnBackCol.Size = new Size(96, 23);
            btnBackCol.TabIndex = 0;
            btnBackCol.Text = "Back Colour";
            btnBackCol.UseVisualStyleBackColor = true;
            btnBackCol.Click += btnBackCol_Click;
            // 
            // btnFrontCol
            // 
            btnFrontCol.Location = new Point(157, 61);
            btnFrontCol.Name = "btnFrontCol";
            btnFrontCol.Size = new Size(95, 23);
            btnFrontCol.TabIndex = 1;
            btnFrontCol.Text = "Front Colour";
            btnFrontCol.UseVisualStyleBackColor = true;
            btnFrontCol.Click += btnFrontCol_Click;
            // 
            // txt_TestText
            // 
            txt_TestText.Location = new Point(258, 61);
            txt_TestText.Name = "txt_TestText";
            txt_TestText.Size = new Size(220, 23);
            txt_TestText.TabIndex = 2;
            txt_TestText.Text = "This is a test";
            // 
            // lbl_Forecolor
            // 
            lbl_Forecolor.Location = new Point(259, 91);
            lbl_Forecolor.Name = "lbl_Forecolor";
            lbl_Forecolor.Size = new Size(103, 23);
            lbl_Forecolor.TabIndex = 3;
            // 
            // lbl_Backcolor
            // 
            lbl_Backcolor.Location = new Point(368, 91);
            lbl_Backcolor.Name = "lbl_Backcolor";
            lbl_Backcolor.Size = new Size(110, 23);
            lbl_Backcolor.TabIndex = 4;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(56, 94);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(95, 23);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_LoadColors
            // 
            btn_LoadColors.Location = new Point(158, 94);
            btn_LoadColors.Name = "btn_LoadColors";
            btn_LoadColors.Size = new Size(95, 23);
            btn_LoadColors.TabIndex = 6;
            btn_LoadColors.Text = "Load Colours";
            btn_LoadColors.UseVisualStyleBackColor = true;
            btn_LoadColors.Click += btn_LoadColors_Click;
            // 
            // txt_Fonts
            // 
            txt_Fonts.Location = new Point(169, 147);
            txt_Fonts.Multiline = true;
            txt_Fonts.Name = "txt_Fonts";
            txt_Fonts.Size = new Size(309, 81);
            txt_Fonts.TabIndex = 7;
            txt_Fonts.Text = "This is a Font test";
            // 
            // btn_Fonts
            // 
            btn_Fonts.Location = new Point(55, 147);
            btn_Fonts.Name = "btn_Fonts";
            btn_Fonts.Size = new Size(95, 23);
            btn_Fonts.TabIndex = 8;
            btn_Fonts.Text = "Fonts";
            btn_Fonts.UseVisualStyleBackColor = true;
            btn_Fonts.Click += btn_Fonts_Click;
            // 
            // btn_SaveFont
            // 
            btn_SaveFont.Location = new Point(56, 176);
            btn_SaveFont.Name = "btn_SaveFont";
            btn_SaveFont.Size = new Size(95, 23);
            btn_SaveFont.TabIndex = 9;
            btn_SaveFont.Text = "Save Font";
            btn_SaveFont.UseVisualStyleBackColor = true;
            btn_SaveFont.Click += btn_SaveFont_Click;
            // 
            // btn_LoadFont
            // 
            btn_LoadFont.Location = new Point(56, 205);
            btn_LoadFont.Name = "btn_LoadFont";
            btn_LoadFont.Size = new Size(95, 23);
            btn_LoadFont.TabIndex = 10;
            btn_LoadFont.Text = "Load Font";
            btn_LoadFont.UseVisualStyleBackColor = true;
            btn_LoadFont.Click += btn_LoadFont_Click;
            // 
            // SaveInRegistry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 584);
            Controls.Add(btn_LoadFont);
            Controls.Add(btn_SaveFont);
            Controls.Add(btn_Fonts);
            Controls.Add(txt_Fonts);
            Controls.Add(btn_LoadColors);
            Controls.Add(btn_Save);
            Controls.Add(lbl_Backcolor);
            Controls.Add(lbl_Forecolor);
            Controls.Add(txt_TestText);
            Controls.Add(btnFrontCol);
            Controls.Add(btnBackCol);
            Name = "SaveInRegistry";
            Text = "SaveInRegistry";
            Load += SaveInRegistry_Load;
            Click += btn_LoadFont_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackCol;
        private Button btnFrontCol;
        private TextBox txt_TestText;
        private ColorDialog colourDialogue;
        private Label lbl_Forecolor;
        private Label lbl_Backcolor;
        private Button btn_Save;
        private Button btn_LoadColors;
        private TextBox txt_Fonts;
        private Button btn_Fonts;
        private FontDialog fontDialog1;
        private Button btn_SaveFont;
        private Button btn_LoadFont;
    }
}