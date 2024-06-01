namespace ChronoCount2
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            Display = new ListBox();
            CreateBTN = new Button();
            RemoveBTN = new Button();
            NowDisplay = new TextBox();
            NowLabel = new Label();
            GameTime = new System.Windows.Forms.Timer(components);
            PageDisplay = new Label();
            TurnLeftBTN = new Button();
            TurnRightBTN = new Button();
            SettingsBTN = new Button();
            SuspendLayout();
            // 
            // Display
            // 
            Display.BackColor = Color.Silver;
            Display.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Display.FormattingEnabled = true;
            Display.ItemHeight = 24;
            Display.Location = new Point(13, 160);
            Display.Margin = new Padding(4, 3, 4, 3);
            Display.Name = "Display";
            Display.Size = new Size(675, 28);
            Display.TabIndex = 22;
            Display.TabStop = false;
            // 
            // CreateBTN
            // 
            CreateBTN.BackColor = Color.White;
            CreateBTN.FlatAppearance.BorderColor = Color.WhiteSmoke;
            CreateBTN.FlatStyle = FlatStyle.Flat;
            CreateBTN.Font = new Font("Consolas", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateBTN.Location = new Point(13, 51);
            CreateBTN.Margin = new Padding(4, 3, 4, 3);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(335, 65);
            CreateBTN.TabIndex = 23;
            CreateBTN.TabStop = false;
            CreateBTN.Text = "Create";
            CreateBTN.UseVisualStyleBackColor = false;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // RemoveBTN
            // 
            RemoveBTN.BackColor = Color.White;
            RemoveBTN.FlatAppearance.BorderColor = Color.WhiteSmoke;
            RemoveBTN.FlatStyle = FlatStyle.Flat;
            RemoveBTN.Font = new Font("Consolas", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveBTN.Location = new Point(353, 51);
            RemoveBTN.Margin = new Padding(4, 3, 4, 3);
            RemoveBTN.Name = "RemoveBTN";
            RemoveBTN.Size = new Size(335, 65);
            RemoveBTN.TabIndex = 25;
            RemoveBTN.TabStop = false;
            RemoveBTN.Text = "Remove";
            RemoveBTN.UseVisualStyleBackColor = false;
            RemoveBTN.Click += RemoveBTN_Click;
            // 
            // NowDisplay
            // 
            NowDisplay.BackColor = Color.Silver;
            NowDisplay.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NowDisplay.Location = new Point(95, 6);
            NowDisplay.Margin = new Padding(4, 3, 4, 3);
            NowDisplay.Name = "NowDisplay";
            NowDisplay.ReadOnly = true;
            NowDisplay.Size = new Size(546, 39);
            NowDisplay.TabIndex = 26;
            NowDisplay.TabStop = false;
            // 
            // NowLabel
            // 
            NowLabel.AutoSize = true;
            NowLabel.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NowLabel.Location = new Point(13, 9);
            NowLabel.Margin = new Padding(4, 0, 4, 0);
            NowLabel.Name = "NowLabel";
            NowLabel.Size = new Size(74, 32);
            NowLabel.TabIndex = 27;
            NowLabel.Text = "Now:";
            // 
            // GameTime
            // 
            GameTime.Interval = 200;
            GameTime.Tick += GameTime_Tick;
            // 
            // PageDisplay
            // 
            PageDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PageDisplay.AutoSize = true;
            PageDisplay.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageDisplay.Location = new Point(322, 122);
            PageDisplay.Margin = new Padding(4, 0, 4, 0);
            PageDisplay.Name = "PageDisplay";
            PageDisplay.Size = new Size(59, 32);
            PageDisplay.TabIndex = 31;
            PageDisplay.Text = "#/#";
            // 
            // TurnLeftBTN
            // 
            TurnLeftBTN.BackColor = Color.White;
            TurnLeftBTN.BackgroundImage = Chrono_Count_2.Properties.Resources.LeftArrow;
            TurnLeftBTN.BackgroundImageLayout = ImageLayout.Stretch;
            TurnLeftBTN.FlatAppearance.BorderColor = Color.WhiteSmoke;
            TurnLeftBTN.FlatStyle = FlatStyle.Flat;
            TurnLeftBTN.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TurnLeftBTN.Location = new Point(13, 122);
            TurnLeftBTN.Margin = new Padding(4, 3, 4, 3);
            TurnLeftBTN.Name = "TurnLeftBTN";
            TurnLeftBTN.Size = new Size(47, 32);
            TurnLeftBTN.TabIndex = 30;
            TurnLeftBTN.TabStop = false;
            TurnLeftBTN.UseVisualStyleBackColor = false;
            TurnLeftBTN.Click += TurnLeftBTN_Click;
            // 
            // TurnRightBTN
            // 
            TurnRightBTN.BackColor = Color.White;
            TurnRightBTN.BackgroundImage = Chrono_Count_2.Properties.Resources.RightArrow;
            TurnRightBTN.BackgroundImageLayout = ImageLayout.Stretch;
            TurnRightBTN.FlatAppearance.BorderColor = Color.WhiteSmoke;
            TurnRightBTN.FlatStyle = FlatStyle.Flat;
            TurnRightBTN.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TurnRightBTN.Location = new Point(641, 122);
            TurnRightBTN.Margin = new Padding(4, 3, 4, 3);
            TurnRightBTN.Name = "TurnRightBTN";
            TurnRightBTN.Size = new Size(47, 32);
            TurnRightBTN.TabIndex = 29;
            TurnRightBTN.TabStop = false;
            TurnRightBTN.UseVisualStyleBackColor = false;
            TurnRightBTN.Click += TurnRightBTN_Click;
            // 
            // SettingsBTN
            // 
            SettingsBTN.BackColor = Color.White;
            SettingsBTN.BackgroundImage = Chrono_Count_2.Properties.Resources.Settings;
            SettingsBTN.BackgroundImageLayout = ImageLayout.Stretch;
            SettingsBTN.FlatAppearance.BorderColor = Color.WhiteSmoke;
            SettingsBTN.FlatStyle = FlatStyle.Flat;
            SettingsBTN.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsBTN.Location = new Point(649, 6);
            SettingsBTN.Margin = new Padding(4, 3, 4, 3);
            SettingsBTN.Name = "SettingsBTN";
            SettingsBTN.Size = new Size(39, 39);
            SettingsBTN.TabIndex = 28;
            SettingsBTN.TabStop = false;
            SettingsBTN.UseVisualStyleBackColor = false;
            SettingsBTN.Click += SettingsBTN_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(699, 206);
            Controls.Add(PageDisplay);
            Controls.Add(TurnLeftBTN);
            Controls.Add(TurnRightBTN);
            Controls.Add(SettingsBTN);
            Controls.Add(NowLabel);
            Controls.Add(NowDisplay);
            Controls.Add(RemoveBTN);
            Controls.Add(CreateBTN);
            Controls.Add(Display);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.ListBox Display;
        internal System.Windows.Forms.Button CreateBTN;
        internal System.Windows.Forms.Button RemoveBTN;
        internal System.Windows.Forms.TextBox NowDisplay;
        internal System.Windows.Forms.Label NowLabel;
        private System.Windows.Forms.Timer GameTime;
        internal System.Windows.Forms.Button SettingsBTN;
        internal System.Windows.Forms.Button TurnRightBTN;
        internal System.Windows.Forms.Button TurnLeftBTN;
        private System.Windows.Forms.Label PageDisplay;
    }
}

