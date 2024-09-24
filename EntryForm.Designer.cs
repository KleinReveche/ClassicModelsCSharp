using ClassicModels.Properties;

namespace ClassicModels
{

    partial class EntryForm
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
            panelLeft = new Panel();
            ActionBar2 = new Panel();
            pictureBox1 = new PictureBox();
            ActionBar = new Panel();
            panelRight = new Panel();
            boxPassword = new ReaLTaiizor.Controls.HopeTextBox();
            boxUsername = new ReaLTaiizor.Controls.HopeTextBox();
            btnAction = new ReaLTaiizor.Controls.ForeverButton();
            lblPassword = new Label();
            lblUsername = new Label();
            lblClose = new Label();
            lblFormName = new Label();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(224, 62, 93);
            panelLeft.Controls.Add(ActionBar2);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(346, 627);
            panelLeft.TabIndex = 0;
            // 
            // ActionBar2
            // 
            ActionBar2.Location = new Point(0, 3);
            ActionBar2.Name = "ActionBar2";
            ActionBar2.Size = new Size(346, 39);
            ActionBar2.TabIndex = 2;
            ActionBar2.MouseDown += ActionBar_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.classicmodels;
            pictureBox1.Location = new Point(63, 210);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ActionBar
            // 
            ActionBar.Location = new Point(0, 3);
            ActionBar.Name = "ActionBar";
            ActionBar.Size = new Size(375, 39);
            ActionBar.TabIndex = 1;
            ActionBar.MouseDown += ActionBar_MouseDown;
            // 
            // panelRight
            // 
            panelRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRight.BackColor = Color.FromArgb(26, 17, 17);
            panelRight.Controls.Add(boxPassword);
            panelRight.Controls.Add(boxUsername);
            panelRight.Controls.Add(btnAction);
            panelRight.Controls.Add(ActionBar);
            panelRight.Controls.Add(lblPassword);
            panelRight.Controls.Add(lblUsername);
            panelRight.Controls.Add(lblClose);
            panelRight.Controls.Add(lblFormName);
            panelRight.Location = new Point(346, 0);
            panelRight.Margin = new Padding(4, 3, 4, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(430, 627);
            panelRight.TabIndex = 2;
            // 
            // boxPassword
            // 
            boxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxPassword.Font = new Font("Segoe UI", 12F);
            boxPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxPassword.Hint = "";
            boxPassword.Location = new Point(35, 323);
            boxPassword.MaxLength = 32767;
            boxPassword.Multiline = false;
            boxPassword.Name = "boxPassword";
            boxPassword.PasswordChar = '\0';
            boxPassword.ScrollBars = ScrollBars.None;
            boxPassword.SelectedText = "";
            boxPassword.SelectionLength = 0;
            boxPassword.SelectionStart = 0;
            boxPassword.Size = new Size(371, 38);
            boxPassword.TabIndex = 4;
            boxPassword.TabStop = false;
            boxPassword.UseSystemPasswordChar = true;
            boxPassword.KeyPress += boxPassword_KeyPress;
            // 
            // boxUsername
            // 
            boxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxUsername.BackColor = Color.FromArgb(29, 16, 15);
            boxUsername.BaseColor = Color.FromArgb(29, 16, 15);
            boxUsername.BorderColorA = Color.FromArgb(64, 158, 255);
            boxUsername.BorderColorB = Color.FromArgb(246, 221, 218);
            boxUsername.Font = new Font("Segoe UI", 12F);
            boxUsername.ForeColor = Color.FromArgb(255, 249, 249);
            boxUsername.Hint = "";
            boxUsername.Location = new Point(35, 242);
            boxUsername.MaxLength = 32767;
            boxUsername.Multiline = false;
            boxUsername.Name = "boxUsername";
            boxUsername.PasswordChar = '\0';
            boxUsername.ScrollBars = ScrollBars.None;
            boxUsername.SelectedText = "";
            boxUsername.SelectionLength = 0;
            boxUsername.SelectionStart = 0;
            boxUsername.Size = new Size(371, 38);
            boxUsername.TabIndex = 3;
            boxUsername.TabStop = false;
            boxUsername.UseSystemPasswordChar = false;
            // 
            // btnAction
            // 
            btnAction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAction.BackColor = Color.Transparent;
            btnAction.BaseColor = Color.FromArgb(229, 196, 146);
            btnAction.Font = new Font("Segoe UI", 12F);
            btnAction.Location = new Point(46, 391);
            btnAction.Name = "btnAction";
            btnAction.Rounded = true;
            btnAction.Size = new Size(351, 45);
            btnAction.TabIndex = 2;
            btnAction.Text = "Login";
            btnAction.TextColor = Color.FromArgb(65, 45, 5);
            btnAction.Click += btnAction_Click;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblPassword.Location = new Point(31, 298);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(255, 249, 249);
            lblUsername.Location = new Point(29, 215);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.FromArgb(255, 249, 249);
            lblClose.Location = new Point(385, 12);
            lblClose.Margin = new Padding(4, 0, 4, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(25, 30);
            lblClose.TabIndex = 0;
            lblClose.Text = "x";
            lblClose.Click += lblClose_Click;
            // 
            // lblFormName
            // 
            lblFormName.Anchor = AnchorStyles.None;
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormName.ForeColor = Color.FromArgb(255, 249, 249);
            lblFormName.Location = new Point(29, 157);
            lblFormName.Margin = new Padding(4, 0, 4, 0);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(77, 30);
            lblFormName.TabIndex = 0;
            lblFormName.Text = "Login";
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 627);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EntryForm";
            Icon = Resources.classicmodels_icon;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CC";
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblPassword;
        private Label lblClose;
        private Panel ActionBar;
        private Panel ActionBar2;
        private ReaLTaiizor.Controls.ForeverButton btnAction;
        private ReaLTaiizor.Controls.HopeTextBox boxUsername;
        private ReaLTaiizor.Controls.HopeTextBox boxPassword;
    }
}
