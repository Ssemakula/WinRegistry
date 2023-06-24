namespace WinRegistry
{
    partial class Size2Reg
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
            panel_Size = new Panel();
            trackBar_height = new TrackBar();
            trackBar_width = new TrackBar();
            txt_Sizable = new TextBox();
            label1 = new Label();
            trackBar_XPanel = new TrackBar();
            trackBar_YPanel = new TrackBar();
            panel_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_XPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_YPanel).BeginInit();
            SuspendLayout();
            // 
            // panel_Size
            // 
            panel_Size.BorderStyle = BorderStyle.Fixed3D;
            panel_Size.Controls.Add(trackBar_height);
            panel_Size.Controls.Add(trackBar_width);
            panel_Size.Controls.Add(txt_Sizable);
            panel_Size.Location = new Point(12, 41);
            panel_Size.Name = "panel_Size";
            panel_Size.Size = new Size(776, 426);
            panel_Size.TabIndex = 13;
            // 
            // trackBar_height
            // 
            trackBar_height.AutoSize = false;
            trackBar_height.Location = new Point(3, 33);
            trackBar_height.Maximum = 361;
            trackBar_height.Minimum = 20;
            trackBar_height.Name = "trackBar_height";
            trackBar_height.Orientation = Orientation.Vertical;
            trackBar_height.RightToLeft = RightToLeft.Yes;
            trackBar_height.Size = new Size(27, 371);
            trackBar_height.TabIndex = 13;
            trackBar_height.TickStyle = TickStyle.None;
            trackBar_height.Value = 361;
            trackBar_height.ValueChanged += trackBar_height_ValueChanged;
            // 
            // trackBar_width
            // 
            trackBar_width.AutoSize = false;
            trackBar_width.Location = new Point(36, 3);
            trackBar_width.Maximum = 729;
            trackBar_width.Minimum = 20;
            trackBar_width.Name = "trackBar_width";
            trackBar_width.Size = new Size(735, 27);
            trackBar_width.TabIndex = 12;
            trackBar_width.TickStyle = TickStyle.None;
            trackBar_width.Value = 20;
            trackBar_width.ValueChanged += trackBar_width_ValueChanged;
            // 
            // txt_Sizable
            // 
            txt_Sizable.BackColor = SystemColors.Window;
            txt_Sizable.Location = new Point(29, 29);
            txt_Sizable.Multiline = true;
            txt_Sizable.Name = "txt_Sizable";
            txt_Sizable.ReadOnly = true;
            txt_Sizable.Size = new Size(20, 20);
            txt_Sizable.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 7);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 14;
            label1.Text = "Size Playing";
            // 
            // trackBar_XPanel
            // 
            trackBar_XPanel.AutoSize = false;
            trackBar_XPanel.Location = new Point(12, 615);
            trackBar_XPanel.Maximum = 251;
            trackBar_XPanel.Minimum = 12;
            trackBar_XPanel.Name = "trackBar_XPanel";
            trackBar_XPanel.RightToLeftLayout = true;
            trackBar_XPanel.Size = new Size(252, 27);
            trackBar_XPanel.TabIndex = 15;
            trackBar_XPanel.TickStyle = TickStyle.TopLeft;
            trackBar_XPanel.Value = 12;
            trackBar_XPanel.ValueChanged += trackBar_XPanel_ValueChanged;
            // 
            // trackBar_YPanel
            // 
            trackBar_YPanel.AutoSize = false;
            trackBar_YPanel.Location = new Point(1033, 30);
            trackBar_YPanel.Maximum = 181;
            trackBar_YPanel.Minimum = 41;
            trackBar_YPanel.Name = "trackBar_YPanel";
            trackBar_YPanel.Orientation = Orientation.Vertical;
            trackBar_YPanel.RightToLeft = RightToLeft.Yes;
            trackBar_YPanel.RightToLeftLayout = true;
            trackBar_YPanel.Size = new Size(27, 153);
            trackBar_YPanel.TabIndex = 16;
            trackBar_YPanel.Value = 181;
            trackBar_YPanel.ValueChanged += trackBar_YPanel_ValueChanged;
            // 
            // Size2Reg
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1072, 654);
            Controls.Add(trackBar_YPanel);
            Controls.Add(trackBar_XPanel);
            Controls.Add(label1);
            Controls.Add(panel_Size);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Size2Reg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Size2Reg";
            FormClosing += Size2Reg_FormClosing;
            Load += Size2Reg_Load;
            panel_Size.ResumeLayout(false);
            panel_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_height).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_width).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_XPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_YPanel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Size;
        private TrackBar trackBar_height;
        private TrackBar trackBar_width;
        private TextBox txt_Sizable;
        private Label label1;
        private TrackBar trackBar_XPanel;
        private TrackBar trackBar_YPanel;
    }
}