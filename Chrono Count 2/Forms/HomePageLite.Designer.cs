namespace ChronoCount2.CodeFiles
{
    partial class HomePageLite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageLite));
            PageDisplay = new Label();
            NowLabel = new Label();
            NowDisplay = new TextBox();
            RemoveBTN = new Button();
            CreateBTN = new Button();
            Display = new ListBox();
            TurnLeftBTN = new Button();
            TurnRightBTN = new Button();
            SettingsBTN = new Button();
            GameTime = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // PageDisplay
            // 
            PageDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PageDisplay.AutoSize = true;
            PageDisplay.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageDisplay.Location = new Point(239, 93);
            PageDisplay.Margin = new Padding(4, 0, 4, 0);
            PageDisplay.Name = "PageDisplay";
            PageDisplay.Size = new Size(59, 32);
            PageDisplay.TabIndex = 40;
            PageDisplay.Text = "#/#";
            // 
            // NowLabel
            // 
            NowLabel.AutoSize = true;
            NowLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NowLabel.Location = new Point(13, 9);
            NowLabel.Margin = new Padding(4, 0, 4, 0);
            NowLabel.Name = "NowLabel";
            NowLabel.Size = new Size(58, 24);
            NowLabel.TabIndex = 36;
            NowLabel.Text = "Now:";
            // 
            // NowDisplay
            // 
            NowDisplay.BackColor = Color.Silver;
            NowDisplay.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NowDisplay.Location = new Point(79, 6);
            NowDisplay.Margin = new Padding(4, 3, 4, 3);
            NowDisplay.Name = "NowDisplay";
            NowDisplay.ReadOnly = true;
            NowDisplay.Size = new Size(395, 32);
            NowDisplay.TabIndex = 35;
            NowDisplay.TabStop = false;
            // 
            // RemoveBTN
            // 
            RemoveBTN.BackColor = Color.White;
            RemoveBTN.FlatAppearance.BorderColor = Color.WhiteSmoke;
            RemoveBTN.FlatStyle = FlatStyle.Flat;
            RemoveBTN.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveBTN.Location = new Point(274, 44);
            RemoveBTN.Margin = new Padding(4, 3, 4, 3);
            RemoveBTN.Name = "RemoveBTN";
            RemoveBTN.Size = new Size(240, 46);
            RemoveBTN.TabIndex = 34;
            RemoveBTN.TabStop = false;
            RemoveBTN.Text = "Remove";
            RemoveBTN.UseVisualStyleBackColor = false;
            RemoveBTN.Click += RemoveBTN_Click;
            // 
            // CreateBTN
            // 
            CreateBTN.BackColor = Color.White;
            CreateBTN.FlatAppearance.BorderColor = Color.WhiteSmoke;
            CreateBTN.FlatStyle = FlatStyle.Flat;
            CreateBTN.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateBTN.Location = new Point(19, 44);
            CreateBTN.Margin = new Padding(4, 3, 4, 3);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(240, 46);
            CreateBTN.TabIndex = 33;
            CreateBTN.TabStop = false;
            CreateBTN.Text = "Create";
            CreateBTN.UseVisualStyleBackColor = false;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // Display
            // 
            Display.BackColor = Color.Silver;
            Display.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Display.FormattingEnabled = true;
            Display.ItemHeight = 24;
            Display.Location = new Point(19, 134);
            Display.Margin = new Padding(4, 3, 4, 3);
            Display.Name = "Display";
            Display.SelectionMode = SelectionMode.None;
            Display.Size = new Size(495, 28);
            Display.TabIndex = 32;
            Display.TabStop = false;
            // 
            // TurnLeftBTN
            // 
            TurnLeftBTN.BackColor = Color.White;
            TurnLeftBTN.BackgroundImage = (Image)resources.GetObject("TurnLeftBTN.BackgroundImage");
            TurnLeftBTN.BackgroundImageLayout = ImageLayout.Stretch;
            TurnLeftBTN.FlatAppearance.BorderColor = Color.WhiteSmoke;
            TurnLeftBTN.FlatStyle = FlatStyle.Flat;
            TurnLeftBTN.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TurnLeftBTN.Location = new Point(19, 96);
            TurnLeftBTN.Margin = new Padding(4, 3, 4, 3);
            TurnLeftBTN.Name = "TurnLeftBTN";
            TurnLeftBTN.Size = new Size(45, 32);
            TurnLeftBTN.TabIndex = 39;
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
            TurnRightBTN.Location = new Point(467, 96);
            TurnRightBTN.Margin = new Padding(4, 3, 4, 3);
            TurnRightBTN.Name = "TurnRightBTN";
            TurnRightBTN.Size = new Size(47, 32);
            TurnRightBTN.TabIndex = 38;
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
            SettingsBTN.Location = new Point(482, 6);
            SettingsBTN.Margin = new Padding(4, 3, 4, 3);
            SettingsBTN.Name = "SettingsBTN";
            SettingsBTN.Size = new Size(32, 32);
            SettingsBTN.TabIndex = 37;
            SettingsBTN.TabStop = false;
            SettingsBTN.UseVisualStyleBackColor = false;
            SettingsBTN.Click += SettingsBTN_Click;
            // 
            // GameTime
            // 
            GameTime.Interval = 500;
            GameTime.Tick += GameTime_Tick;
            // 
            // HomePageLite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(534, 182);
            Controls.Add(PageDisplay);
            Controls.Add(TurnLeftBTN);
            Controls.Add(TurnRightBTN);
            Controls.Add(SettingsBTN);
            Controls.Add(NowLabel);
            Controls.Add(NowDisplay);
            Controls.Add(RemoveBTN);
            Controls.Add(CreateBTN);
            Controls.Add(Display);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "HomePageLite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePageLite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label PageDisplay;
        internal System.Windows.Forms.Button TurnLeftBTN;
        internal System.Windows.Forms.Button TurnRightBTN;
        internal System.Windows.Forms.Button SettingsBTN;
        internal System.Windows.Forms.Label NowLabel;
        internal System.Windows.Forms.TextBox NowDisplay;
        internal System.Windows.Forms.Button RemoveBTN;
        internal System.Windows.Forms.Button CreateBTN;
        internal System.Windows.Forms.ListBox Display;
        private System.Windows.Forms.Timer GameTime;
    }
}