using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExynosBypassTool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer? components = null;

        private Label lblTitle;
        private GroupBox grpSamsung;
        private GroupBox grpUniversal;
        private GroupBox grpDisplay;
        private Button btnFRPExynosAll;
        private Button btnFRPTestMode;
        private Button btnFRPMtp;
        private Button btnFRPEdl;
        private Button btnMtkBypass;
        private Button btnMtkFormat;
        private Button btnFactoryReset;
        private TextBox txtLog;
        private Label lblPhonePlaceholder;
        private Panel leftColumn;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Form properties (some already set in constructor)
            this.Text = "GSM Prime & SamFw Ultimate Combo Tool v1.0";
            this.ClientSize = new Size(850, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(30, 30, 46);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.AutoScaleMode = AutoScaleMode.Font;

            // Title
            lblTitle = new Label();
            lblTitle.Text = "UNIFIED FRP & SYSTEM TOOLKIT";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 60;
            lblTitle.Padding = new Padding(0, 8, 0, 0);

            // Left column panel
            leftColumn = new Panel();
            leftColumn.Location = new Point(20, 70);
            leftColumn.Size = new Size(385, 545);
            leftColumn.BackColor = Color.Transparent;
            leftColumn.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Samsung group
            grpSamsung = new GroupBox();
            grpSamsung.Text = " Samsung Suite (SamFw Style) ";
            grpSamsung.ForeColor = Color.FromArgb(137, 180, 250);
            grpSamsung.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            grpSamsung.Location = new Point(0, 0);
            grpSamsung.Size = new Size(385, 290);

            // Buttons for Samsung group
            btnFRPExynosAll = CreateButton("Remove FRP (Exynos All Models)", new Point(20, 30), new Size(345, 40), Color.FromArgb(250, 179, 135));
            btnFRPExynosAll.Click += new EventHandler(this.BtnFRPExynosAll_Click);

            btnFRPTestMode = CreateButton("Remove FRP (Test Mode *#0*#)", new Point(20, 80), new Size(345, 40), Color.FromArgb(203, 166, 247));
            btnFRPTestMode.Click += new EventHandler(this.BtnFRPTestMode_Click);

            btnFRPMtp = CreateButton("Bypass FRP (MTP Mode)", new Point(20, 130), new Size(345, 40), Color.FromArgb(137, 180, 250));
            btnFRPMtp.Click += new EventHandler(this.BtnFRPMtp_Click);

            btnFRPEdl = CreateButton("Remove FRP (EDL Mode)", new Point(20, 180), new Size(345, 40), Color.FromArgb(137, 220, 235));
            btnFRPEdl.Click += new EventHandler(this.BtnFRPEdl_Click);

            btnFactoryReset = CreateButton("Factory Reset (MTP / ADB)", new Point(20, 230), new Size(345, 40), Color.FromArgb(243, 139, 168));
            btnFactoryReset.Click += new EventHandler(this.BtnFactoryReset_Click);

            grpSamsung.Controls.Add(btnFRPExynosAll);
            grpSamsung.Controls.Add(btnFRPTestMode);
            grpSamsung.Controls.Add(btnFRPMtp);
            grpSamsung.Controls.Add(btnFRPEdl);
            grpSamsung.Controls.Add(btnFactoryReset);

            // Universal (MTK) group
            grpUniversal = new GroupBox();
            grpUniversal.Text = " Universal MediaTek Suite ";
            grpUniversal.ForeColor = Color.FromArgb(166, 227, 161);
            grpUniversal.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            grpUniversal.Location = new Point(0, 305);
            grpUniversal.Size = new Size(385, 240);

            btnMtkBypass = CreateButton("MTK Auth Bypass", new Point(20, 40), new Size(345, 42), Color.FromArgb(166, 227, 161));
            btnMtkBypass.Click += new EventHandler(this.BtnMtkBypass_Click);

            btnMtkFormat = CreateButton("MTK Format / Safe Reset", new Point(20, 95), new Size(345, 42), Color.FromArgb(249, 226, 175));
            btnMtkFormat.Click += new EventHandler(this.BtnMtkFormat_Click);

            grpUniversal.Controls.Add(btnMtkBypass);
            grpUniversal.Controls.Add(btnMtkFormat);

            leftColumn.Controls.Add(grpSamsung);
            leftColumn.Controls.Add(grpUniversal);

            // Right column (display + logs)
            grpDisplay = new GroupBox();
            grpDisplay.Text = " Device Monitor Logs ";
            grpDisplay.ForeColor = Color.FromArgb(245, 194, 231);
            grpDisplay.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            grpDisplay.Location = new Point(425, 70);
            grpDisplay.Size = new Size(390, 545);
            grpDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            lblPhonePlaceholder = new Label();
            lblPhonePlaceholder.Text = "[ PHONE DISPLAY AREA ]\n(Connect device via USB)";
            lblPhonePlaceholder.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblPhonePlaceholder.ForeColor = Color.FromArgb(148, 156, 187);
            lblPhonePlaceholder.BackColor = Color.FromArgb(17, 17, 27);
            lblPhonePlaceholder.Location = new Point(20, 35);
            lblPhonePlaceholder.Size = new Size(350, 190);
            lblPhonePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            lblPhonePlaceholder.BorderStyle = BorderStyle.FixedSingle;

            txtLog = new TextBox();
            txtLog.Multiline = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.BackColor = Color.FromArgb(17, 17, 27);
            txtLog.ForeColor = Color.FromArgb(166, 227, 161);
            txtLog.Font = new Font("Consolas", 10f);
            txtLog.Location = new Point(20, 240);
            txtLog.Size = new Size(350, 285);
            txtLog.ReadOnly = true;
            txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Context menu for the log (Copy / Clear)
            ContextMenuStrip logContext = new ContextMenuStrip();
            logContext.Items.Add("Copy", null, (s, e) => { if (!string.IsNullOrEmpty(txtLog.Text)) Clipboard.SetText(txtLog.Text); });
            logContext.Items.Add("Clear", null, (s, e) => { txtLog.Clear(); });
            txtLog.ContextMenuStrip = logContext;

            grpDisplay.Controls.Add(lblPhonePlaceholder);
            grpDisplay.Controls.Add(txtLog);

            // Add top-level controls to the form
            this.Controls.Add(lblTitle);
            this.Controls.Add(leftColumn);
            this.Controls.Add(grpDisplay);
        }

        // Helper to create styled buttons consistently
        private Button CreateButton(string text, Point location, Size size, Color backColor)
        {
            var btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.BackColor = backColor;
            btn.ForeColor = Color.FromArgb(30, 30, 46);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = location;
            btn.Size = size;
            return btn;
        }
    }
}
