namespace ChronoCount2
{
    partial class EditSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSettings));
            FilePathDisplay = new TextBox();
            label1 = new Label();
            SettingGB = new GroupBox();
            BackColourBorder = new Panel();
            BackColourDisplay = new TextBox();
            BackColourEdit = new Button();
            MidColourEdit = new Button();
            ForeColourEdit = new Button();
            label2 = new Label();
            BackColourLabel = new Label();
            MidColourBorder = new Panel();
            MidColourDisplay = new TextBox();
            MidColourLabel = new Label();
            ForeColourBorder = new Panel();
            ForeColourDisplay = new TextBox();
            ForeColourLabel = new Label();
            label3 = new Label();
            MaxPerPageDisplay = new TextBox();
            LightModeToggle = new CheckBox();
            EditSetting = new Button();
            RestoreDefaults = new Button();
            SettingGB.SuspendLayout();
            BackColourBorder.SuspendLayout();
            MidColourBorder.SuspendLayout();
            ForeColourBorder.SuspendLayout();
            SuspendLayout();
            // 
            // FilePathDisplay
            // 
            FilePathDisplay.BackColor = Color.Silver;
            FilePathDisplay.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilePathDisplay.Location = new Point(8, 266);
            FilePathDisplay.Margin = new Padding(4, 3, 4, 3);
            FilePathDisplay.Multiline = true;
            FilePathDisplay.Name = "FilePathDisplay";
            FilePathDisplay.ReadOnly = true;
            FilePathDisplay.Size = new Size(454, 46);
            FilePathDisplay.TabIndex = 11;
            FilePathDisplay.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 237);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 12;
            label1.Text = "FilePath:";
            // 
            // SettingGB
            // 
            SettingGB.Controls.Add(BackColourBorder);
            SettingGB.Controls.Add(BackColourEdit);
            SettingGB.Controls.Add(MidColourEdit);
            SettingGB.Controls.Add(FilePathDisplay);
            SettingGB.Controls.Add(ForeColourEdit);
            SettingGB.Controls.Add(label1);
            SettingGB.Controls.Add(label2);
            SettingGB.Controls.Add(BackColourLabel);
            SettingGB.Controls.Add(MidColourBorder);
            SettingGB.Controls.Add(MidColourLabel);
            SettingGB.Controls.Add(ForeColourBorder);
            SettingGB.Controls.Add(ForeColourLabel);
            SettingGB.Controls.Add(label3);
            SettingGB.Controls.Add(MaxPerPageDisplay);
            SettingGB.Controls.Add(LightModeToggle);
            SettingGB.Font = new Font("Consolas", 15.75F);
            SettingGB.Location = new Point(13, 127);
            SettingGB.Margin = new Padding(4, 3, 4, 3);
            SettingGB.Name = "SettingGB";
            SettingGB.Padding = new Padding(4, 3, 4, 3);
            SettingGB.Size = new Size(470, 326);
            SettingGB.TabIndex = 13;
            SettingGB.TabStop = false;
            SettingGB.Text = "Settings";
            // 
            // BackColourBorder
            // 
            BackColourBorder.BackColor = Color.Silver;
            BackColourBorder.Controls.Add(BackColourDisplay);
            BackColourBorder.Location = new Point(195, 191);
            BackColourBorder.Margin = new Padding(4, 3, 4, 3);
            BackColourBorder.Name = "BackColourBorder";
            BackColourBorder.Size = new Size(148, 33);
            BackColourBorder.TabIndex = 27;
            // 
            // BackColourDisplay
            // 
            BackColourDisplay.BackColor = Color.Beige;
            BackColourDisplay.BorderStyle = BorderStyle.None;
            BackColourDisplay.Font = new Font("Consolas", 15.75F);
            BackColourDisplay.Location = new Point(4, 4);
            BackColourDisplay.Margin = new Padding(4, 3, 4, 3);
            BackColourDisplay.Name = "BackColourDisplay";
            BackColourDisplay.ReadOnly = true;
            BackColourDisplay.Size = new Size(140, 25);
            BackColourDisplay.TabIndex = 17;
            // 
            // BackColourEdit
            // 
            BackColourEdit.BackColor = Color.White;
            BackColourEdit.FlatAppearance.BorderColor = Color.Black;
            BackColourEdit.FlatStyle = FlatStyle.Flat;
            BackColourEdit.Location = new Point(358, 191);
            BackColourEdit.Margin = new Padding(4, 3, 4, 3);
            BackColourEdit.Name = "BackColourEdit";
            BackColourEdit.Size = new Size(88, 33);
            BackColourEdit.TabIndex = 25;
            BackColourEdit.Text = "Edit";
            BackColourEdit.UseVisualStyleBackColor = false;
            BackColourEdit.Click += BackColourEdit_Click;
            // 
            // MidColourEdit
            // 
            MidColourEdit.BackColor = Color.White;
            MidColourEdit.FlatAppearance.BorderColor = Color.Black;
            MidColourEdit.FlatStyle = FlatStyle.Flat;
            MidColourEdit.Location = new Point(358, 152);
            MidColourEdit.Margin = new Padding(4, 3, 4, 3);
            MidColourEdit.Name = "MidColourEdit";
            MidColourEdit.Size = new Size(88, 33);
            MidColourEdit.TabIndex = 24;
            MidColourEdit.Text = "Edit";
            MidColourEdit.UseVisualStyleBackColor = false;
            MidColourEdit.Click += MidColourEdit_Click;
            // 
            // ForeColourEdit
            // 
            ForeColourEdit.BackColor = Color.White;
            ForeColourEdit.FlatAppearance.BorderColor = Color.Black;
            ForeColourEdit.FlatStyle = FlatStyle.Flat;
            ForeColourEdit.Location = new Point(358, 113);
            ForeColourEdit.Margin = new Padding(4, 3, 4, 3);
            ForeColourEdit.Name = "ForeColourEdit";
            ForeColourEdit.Size = new Size(88, 33);
            ForeColourEdit.TabIndex = 23;
            ForeColourEdit.Text = "Edit";
            ForeColourEdit.UseVisualStyleBackColor = false;
            ForeColourEdit.Click += ForeColourEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 242);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 13;
            label2.Text = "(Non Editable)";
            // 
            // BackColourLabel
            // 
            BackColourLabel.AutoSize = true;
            BackColourLabel.Font = new Font("Consolas", 18F);
            BackColourLabel.Location = new Point(32, 191);
            BackColourLabel.Margin = new Padding(4, 0, 4, 0);
            BackColourLabel.Name = "BackColourLabel";
            BackColourLabel.Size = new Size(155, 28);
            BackColourLabel.TabIndex = 22;
            BackColourLabel.Text = "BackColour:";
            // 
            // MidColourBorder
            // 
            MidColourBorder.BackColor = Color.Silver;
            MidColourBorder.Controls.Add(MidColourDisplay);
            MidColourBorder.Location = new Point(195, 152);
            MidColourBorder.Margin = new Padding(4, 3, 4, 3);
            MidColourBorder.Name = "MidColourBorder";
            MidColourBorder.Size = new Size(148, 33);
            MidColourBorder.TabIndex = 27;
            // 
            // MidColourDisplay
            // 
            MidColourDisplay.BackColor = Color.Beige;
            MidColourDisplay.BorderStyle = BorderStyle.None;
            MidColourDisplay.Font = new Font("Consolas", 15.75F);
            MidColourDisplay.Location = new Point(4, 4);
            MidColourDisplay.Margin = new Padding(4, 3, 4, 3);
            MidColourDisplay.Name = "MidColourDisplay";
            MidColourDisplay.ReadOnly = true;
            MidColourDisplay.Size = new Size(140, 25);
            MidColourDisplay.TabIndex = 17;
            // 
            // MidColourLabel
            // 
            MidColourLabel.AutoSize = true;
            MidColourLabel.Font = new Font("Consolas", 18F);
            MidColourLabel.Location = new Point(45, 152);
            MidColourLabel.Margin = new Padding(4, 0, 4, 0);
            MidColourLabel.Name = "MidColourLabel";
            MidColourLabel.Size = new Size(142, 28);
            MidColourLabel.TabIndex = 21;
            MidColourLabel.Text = "MidColour:";
            // 
            // ForeColourBorder
            // 
            ForeColourBorder.BackColor = Color.Silver;
            ForeColourBorder.Controls.Add(ForeColourDisplay);
            ForeColourBorder.Location = new Point(195, 113);
            ForeColourBorder.Margin = new Padding(4, 3, 4, 3);
            ForeColourBorder.Name = "ForeColourBorder";
            ForeColourBorder.Size = new Size(148, 33);
            ForeColourBorder.TabIndex = 26;
            // 
            // ForeColourDisplay
            // 
            ForeColourDisplay.BackColor = Color.Beige;
            ForeColourDisplay.BorderStyle = BorderStyle.None;
            ForeColourDisplay.Font = new Font("Consolas", 15.75F);
            ForeColourDisplay.Location = new Point(4, 4);
            ForeColourDisplay.Margin = new Padding(4, 3, 4, 3);
            ForeColourDisplay.Name = "ForeColourDisplay";
            ForeColourDisplay.ReadOnly = true;
            ForeColourDisplay.Size = new Size(140, 25);
            ForeColourDisplay.TabIndex = 17;
            // 
            // ForeColourLabel
            // 
            ForeColourLabel.AutoSize = true;
            ForeColourLabel.Font = new Font("Consolas", 18F);
            ForeColourLabel.Location = new Point(32, 113);
            ForeColourLabel.Margin = new Padding(4, 0, 4, 0);
            ForeColourLabel.Name = "ForeColourLabel";
            ForeColourLabel.Size = new Size(155, 28);
            ForeColourLabel.TabIndex = 20;
            ForeColourLabel.Text = "ForeColour:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 70);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 16;
            label3.Text = "Entries/Page:";
            // 
            // MaxPerPageDisplay
            // 
            MaxPerPageDisplay.BackColor = Color.Silver;
            MaxPerPageDisplay.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxPerPageDisplay.Location = new Point(195, 67);
            MaxPerPageDisplay.Margin = new Padding(4, 3, 4, 3);
            MaxPerPageDisplay.Name = "MaxPerPageDisplay";
            MaxPerPageDisplay.Size = new Size(60, 36);
            MaxPerPageDisplay.TabIndex = 15;
            // 
            // LightModeToggle
            // 
            LightModeToggle.AutoSize = true;
            LightModeToggle.CheckAlign = ContentAlignment.MiddleRight;
            LightModeToggle.FlatAppearance.BorderColor = Color.Black;
            LightModeToggle.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LightModeToggle.Location = new Point(45, 31);
            LightModeToggle.Margin = new Padding(4, 3, 4, 3);
            LightModeToggle.Name = "LightModeToggle";
            LightModeToggle.Size = new Size(161, 32);
            LightModeToggle.TabIndex = 14;
            LightModeToggle.Text = "Lite Mode:";
            LightModeToggle.UseVisualStyleBackColor = true;
            // 
            // EditSetting
            // 
            EditSetting.BackColor = Color.White;
            EditSetting.FlatAppearance.BorderColor = Color.Black;
            EditSetting.FlatStyle = FlatStyle.Flat;
            EditSetting.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditSetting.Location = new Point(13, 12);
            EditSetting.Margin = new Padding(4, 3, 4, 3);
            EditSetting.Name = "EditSetting";
            EditSetting.Size = new Size(470, 74);
            EditSetting.TabIndex = 14;
            EditSetting.Text = "Click to Edit Settings";
            EditSetting.UseVisualStyleBackColor = false;
            EditSetting.Click += EditSetting_Click;
            // 
            // RestoreDefaults
            // 
            RestoreDefaults.BackColor = Color.White;
            RestoreDefaults.FlatAppearance.BorderColor = Color.Black;
            RestoreDefaults.FlatStyle = FlatStyle.Flat;
            RestoreDefaults.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RestoreDefaults.Location = new Point(13, 92);
            RestoreDefaults.Margin = new Padding(4, 3, 4, 3);
            RestoreDefaults.Name = "RestoreDefaults";
            RestoreDefaults.Size = new Size(470, 29);
            RestoreDefaults.TabIndex = 15;
            RestoreDefaults.Text = "Restore to Default Settings";
            RestoreDefaults.UseVisualStyleBackColor = false;
            RestoreDefaults.Click += RestoreDefaults_Click;
            // 
            // EditSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(494, 461);
            Controls.Add(RestoreDefaults);
            Controls.Add(EditSetting);
            Controls.Add(SettingGB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditSettings";
            SettingGB.ResumeLayout(false);
            SettingGB.PerformLayout();
            BackColourBorder.ResumeLayout(false);
            BackColourBorder.PerformLayout();
            MidColourBorder.ResumeLayout(false);
            MidColourBorder.PerformLayout();
            ForeColourBorder.ResumeLayout(false);
            ForeColourBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox FilePathDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SettingGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox LightModeToggle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxPerPageDisplay;
        private System.Windows.Forms.Label ForeColourLabel;
        private System.Windows.Forms.TextBox ForeColourDisplay;
        private System.Windows.Forms.Label BackColourLabel;
        private System.Windows.Forms.Label MidColourLabel;
        private System.Windows.Forms.Button BackColourEdit;
        private System.Windows.Forms.Button MidColourEdit;
        private System.Windows.Forms.Button ForeColourEdit;
        private System.Windows.Forms.Button EditSetting;
        private System.Windows.Forms.Panel ForeColourBorder;
        private System.Windows.Forms.Panel BackColourBorder;
        private System.Windows.Forms.TextBox BackColourDisplay;
        private System.Windows.Forms.Panel MidColourBorder;
        private System.Windows.Forms.TextBox MidColourDisplay;
        private System.Windows.Forms.Button RestoreDefaults;
    }
}