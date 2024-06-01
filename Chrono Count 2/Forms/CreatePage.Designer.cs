namespace ChronoCount2
{
    partial class CreatePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePage));
            GBcreate = new GroupBox();
            DateInput = new TextBox();
            ABStime = new Label();
            ABSname = new Label();
            NameInput = new TextBox();
            BTNCreate = new Button();
            GBcreate.SuspendLayout();
            SuspendLayout();
            // 
            // GBcreate
            // 
            GBcreate.Controls.Add(DateInput);
            GBcreate.Controls.Add(ABStime);
            GBcreate.Controls.Add(ABSname);
            GBcreate.Controls.Add(NameInput);
            GBcreate.Controls.Add(BTNCreate);
            GBcreate.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GBcreate.Location = new Point(16, 15);
            GBcreate.Margin = new Padding(6);
            GBcreate.Name = "GBcreate";
            GBcreate.Padding = new Padding(6);
            GBcreate.Size = new Size(520, 185);
            GBcreate.TabIndex = 9;
            GBcreate.TabStop = false;
            GBcreate.Text = "Create";
            // 
            // DateInput
            // 
            DateInput.BackColor = Color.Silver;
            DateInput.BorderStyle = BorderStyle.FixedSingle;
            DateInput.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateInput.Location = new Point(196, 73);
            DateInput.Margin = new Padding(4, 3, 4, 3);
            DateInput.MaxLength = 99;
            DateInput.Name = "DateInput";
            DateInput.Size = new Size(314, 39);
            DateInput.TabIndex = 3;
            // 
            // ABStime
            // 
            ABStime.AutoSize = true;
            ABStime.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ABStime.Location = new Point(9, 75);
            ABStime.Margin = new Padding(4, 0, 4, 0);
            ABStime.Name = "ABStime";
            ABStime.Size = new Size(179, 32);
            ABStime.TabIndex = 5;
            ABStime.Text = "Event Time:";
            // 
            // ABSname
            // 
            ABSname.AutoSize = true;
            ABSname.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ABSname.Location = new Point(9, 31);
            ABSname.Margin = new Padding(4, 0, 4, 0);
            ABSname.Name = "ABSname";
            ABSname.Size = new Size(179, 32);
            ABSname.TabIndex = 4;
            ABSname.Text = "Event Name:";
            // 
            // NameInput
            // 
            NameInput.BackColor = Color.Silver;
            NameInput.BorderStyle = BorderStyle.FixedSingle;
            NameInput.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameInput.Location = new Point(196, 29);
            NameInput.Margin = new Padding(4, 3, 4, 3);
            NameInput.MaxLength = 99;
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(314, 39);
            NameInput.TabIndex = 2;
            // 
            // BTNCreate
            // 
            BTNCreate.BackColor = Color.White;
            BTNCreate.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BTNCreate.FlatStyle = FlatStyle.Flat;
            BTNCreate.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNCreate.Location = new Point(9, 118);
            BTNCreate.Margin = new Padding(4, 3, 4, 3);
            BTNCreate.Name = "BTNCreate";
            BTNCreate.Size = new Size(501, 56);
            BTNCreate.TabIndex = 4;
            BTNCreate.Text = "Create";
            BTNCreate.UseVisualStyleBackColor = false;
            BTNCreate.Click += BTNCreate_Click;
            // 
            // CreatePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(554, 211);
            Controls.Add(GBcreate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreatePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePage";
            GBcreate.ResumeLayout(false);
            GBcreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal System.Windows.Forms.GroupBox GBcreate;
        internal System.Windows.Forms.TextBox DateInput;
        internal System.Windows.Forms.Label ABStime;
        internal System.Windows.Forms.Label ABSname;
        internal System.Windows.Forms.TextBox NameInput;
        internal System.Windows.Forms.Button BTNCreate;
    }
}