namespace _5217_For_Better_Productivity
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTray = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblCyclesTxt = new System.Windows.Forms.Label();
            this.lblCycles = new System.Windows.Forms.Label();
            this.btnAbout = new MaterialSkin.Controls.MaterialFlatButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chkSounds = new MaterialSkin.Controls.MaterialCheckBox();
            this.iconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Roboto", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(7, 67);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(106, 116);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "0";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(21, 183);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(240, 36);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "minutes of work";
            // 
            // btnStart
            // 
            this.btnStart.Depth = 0;
            this.btnStart.Location = new System.Drawing.Point(27, 326);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Primary = true;
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTray
            // 
            this.btnTray.Depth = 0;
            this.btnTray.Location = new System.Drawing.Point(108, 326);
            this.btnTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTray.Name = "btnTray";
            this.btnTray.Primary = true;
            this.btnTray.Size = new System.Drawing.Size(75, 33);
            this.btnTray.TabIndex = 7;
            this.btnTray.Text = "Tray";
            this.btnTray.UseVisualStyleBackColor = true;
            this.btnTray.Click += new System.EventHandler(this.btnTray_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Depth = 0;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(189, 326);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.Primary = true;
            this.btnStop.Size = new System.Drawing.Size(75, 33);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(27, 370);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(158, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Today\'s Cycles";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCyclesTxt
            // 
            this.lblCyclesTxt.AutoSize = true;
            this.lblCyclesTxt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCyclesTxt.Location = new System.Drawing.Point(23, 240);
            this.lblCyclesTxt.Name = "lblCyclesTxt";
            this.lblCyclesTxt.Size = new System.Drawing.Size(157, 20);
            this.lblCyclesTxt.TabIndex = 12;
            this.lblCyclesTxt.Text = "Completed cycles:";
            // 
            // lblCycles
            // 
            this.lblCycles.AutoSize = true;
            this.lblCycles.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCycles.Location = new System.Drawing.Point(186, 240);
            this.lblCycles.Name = "lblCycles";
            this.lblCycles.Size = new System.Drawing.Size(19, 20);
            this.lblCycles.TabIndex = 13;
            this.lblCycles.Text = "0";
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = true;
            this.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbout.Depth = 0;
            this.btnAbout.Location = new System.Drawing.Point(27, 415);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Primary = false;
            this.btnAbout.Size = new System.Drawing.Size(57, 36);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // chkSounds
            // 
            this.chkSounds.AutoSize = true;
            this.chkSounds.Depth = 0;
            this.chkSounds.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkSounds.Location = new System.Drawing.Point(27, 280);
            this.chkSounds.Margin = new System.Windows.Forms.Padding(0);
            this.chkSounds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSounds.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSounds.Name = "chkSounds";
            this.chkSounds.Ripple = true;
            this.chkSounds.Size = new System.Drawing.Size(106, 30);
            this.chkSounds.TabIndex = 15;
            this.chkSounds.Text = "Play Sounds";
            this.chkSounds.UseVisualStyleBackColor = true;
            // 
            // iconTray
            // 
            this.iconTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("iconTray.Icon")));
            this.iconTray.Text = "5217 For Better Productivity";
            this.iconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.iconTray_MouseDoubleClick);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 460);
            this.Controls.Add(this.chkSounds);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblCycles);
            this.Controls.Add(this.lblCyclesTxt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTray);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Text = "5217 For Better Productivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnStart;
        private MaterialSkin.Controls.MaterialRaisedButton btnTray;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialRaisedButton btnStop;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private System.Windows.Forms.Label lblCyclesTxt;
        private System.Windows.Forms.Label lblCycles;
        private MaterialSkin.Controls.MaterialFlatButton btnAbout;
        private System.Windows.Forms.Timer timer2;
        private MaterialSkin.Controls.MaterialCheckBox chkSounds;
        private System.Windows.Forms.NotifyIcon iconTray;
    }
}

