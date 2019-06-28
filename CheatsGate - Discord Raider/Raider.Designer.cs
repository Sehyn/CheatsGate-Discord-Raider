namespace CheatsGate___Discord_Raider
{
    partial class Raider
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raider));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Invite_ID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StopBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.RaidBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.Message_Send = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Channel_ID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RaidTimer = new System.Windows.Forms.Timer(this.components);
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Invite_ID
            // 
            this.Invite_ID.Depth = 0;
            this.Invite_ID.Hint = "Invite ID";
            this.Invite_ID.Location = new System.Drawing.Point(6, 19);
            this.Invite_ID.MaxLength = 32767;
            this.Invite_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Invite_ID.Name = "Invite_ID";
            this.Invite_ID.PasswordChar = '\0';
            this.Invite_ID.ReadOnly = false;
            this.Invite_ID.SelectedText = "";
            this.Invite_ID.SelectionLength = 0;
            this.Invite_ID.SelectionStart = 0;
            this.Invite_ID.Size = new System.Drawing.Size(442, 23);
            this.Invite_ID.TabIndex = 1;
            this.Invite_ID.TabStop = false;
            this.Invite_ID.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialFlatButton1);
            this.groupBox1.Controls.Add(this.StopBtn);
            this.groupBox1.Controls.Add(this.RaidBtn);
            this.groupBox1.Controls.Add(this.Message_Send);
            this.groupBox1.Controls.Add(this.Channel_ID);
            this.groupBox1.Controls.Add(this.Invite_ID);
            this.groupBox1.Location = new System.Drawing.Point(3, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CheatsGame - Interface";
            // 
            // StopBtn
            // 
            this.StopBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopBtn.Depth = 0;
            this.StopBtn.Icon = null;
            this.StopBtn.Location = new System.Drawing.Point(6, 139);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StopBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Primary = false;
            this.StopBtn.Size = new System.Drawing.Size(442, 28);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "STOP";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // RaidBtn
            // 
            this.RaidBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RaidBtn.Depth = 0;
            this.RaidBtn.Icon = null;
            this.RaidBtn.Location = new System.Drawing.Point(6, 108);
            this.RaidBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RaidBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RaidBtn.Name = "RaidBtn";
            this.RaidBtn.Primary = false;
            this.RaidBtn.Size = new System.Drawing.Size(442, 28);
            this.RaidBtn.TabIndex = 4;
            this.RaidBtn.Text = "RAID";
            this.RaidBtn.UseVisualStyleBackColor = true;
            this.RaidBtn.Click += new System.EventHandler(this.RaidBtn_Click);
            // 
            // Message_Send
            // 
            this.Message_Send.Depth = 0;
            this.Message_Send.Hint = "Message";
            this.Message_Send.Location = new System.Drawing.Point(6, 76);
            this.Message_Send.MaxLength = 32767;
            this.Message_Send.MouseState = MaterialSkin.MouseState.HOVER;
            this.Message_Send.Name = "Message_Send";
            this.Message_Send.PasswordChar = '\0';
            this.Message_Send.ReadOnly = false;
            this.Message_Send.SelectedText = "";
            this.Message_Send.SelectionLength = 0;
            this.Message_Send.SelectionStart = 0;
            this.Message_Send.Size = new System.Drawing.Size(442, 23);
            this.Message_Send.TabIndex = 3;
            this.Message_Send.TabStop = false;
            this.Message_Send.UseSystemPasswordChar = false;
            // 
            // Channel_ID
            // 
            this.Channel_ID.Depth = 0;
            this.Channel_ID.Hint = "Channel ID";
            this.Channel_ID.Location = new System.Drawing.Point(6, 47);
            this.Channel_ID.MaxLength = 32767;
            this.Channel_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Channel_ID.Name = "Channel_ID";
            this.Channel_ID.PasswordChar = '\0';
            this.Channel_ID.ReadOnly = false;
            this.Channel_ID.SelectedText = "";
            this.Channel_ID.SelectionLength = 0;
            this.Channel_ID.SelectionStart = 0;
            this.Channel_ID.Size = new System.Drawing.Size(442, 23);
            this.Channel_ID.TabIndex = 2;
            this.Channel_ID.TabStop = false;
            this.Channel_ID.UseSystemPasswordChar = false;
            // 
            // RaidTimer
            // 
            this.RaidTimer.Interval = 1000;
            this.RaidTimer.Tick += new System.EventHandler(this.RaidTimer_Tick);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(7, 173);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(442, 28);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "JOIN SERVER";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // Raider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raider";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "CheatsGame - Discord Raider";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Raider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Invite_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton RaidBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField Message_Send;
        private MaterialSkin.Controls.MaterialSingleLineTextField Channel_ID;
        private MaterialSkin.Controls.MaterialFlatButton StopBtn;
        private System.Windows.Forms.Timer RaidTimer;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

