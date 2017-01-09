namespace WF4._2
{
    partial class AlarmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmClock));
            this.labelPresentTime = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.alarmGroup = new System.Windows.Forms.GroupBox();
            this.alarmTrigger = new System.Windows.Forms.CheckBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.countHours = new System.Windows.Forms.NumericUpDown();
            this.countMinutes = new System.Windows.Forms.NumericUpDown();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.alarmProgress = new System.Windows.Forms.ProgressBar();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.alarmNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.alarmNotifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMinutes)).BeginInit();
            this.alarmNotifyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPresentTime
            // 
            this.labelPresentTime.AutoSize = true;
            this.labelPresentTime.Location = new System.Drawing.Point(61, 22);
            this.labelPresentTime.Name = "labelPresentTime";
            this.labelPresentTime.Size = new System.Drawing.Size(46, 13);
            this.labelPresentTime.TabIndex = 0;
            this.labelPresentTime.Text = "Сейчас:";
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(135, 22);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(49, 13);
            this.clock.TabIndex = 1;
            this.clock.Text = "00:00:00";
            // 
            // alarmGroup
            // 
            this.alarmGroup.Controls.Add(this.alarmTrigger);
            this.alarmGroup.Controls.Add(this.labelMinutes);
            this.alarmGroup.Controls.Add(this.labelHours);
            this.alarmGroup.Controls.Add(this.countHours);
            this.alarmGroup.Controls.Add(this.countMinutes);
            this.alarmGroup.Location = new System.Drawing.Point(12, 55);
            this.alarmGroup.Name = "alarmGroup";
            this.alarmGroup.Size = new System.Drawing.Size(210, 125);
            this.alarmGroup.TabIndex = 2;
            this.alarmGroup.TabStop = false;
            this.alarmGroup.Text = "Сигнал в";
            // 
            // alarmTrigger
            // 
            this.alarmTrigger.Location = new System.Drawing.Point(62, 95);
            this.alarmTrigger.Name = "alarmTrigger";
            this.alarmTrigger.Size = new System.Drawing.Size(81, 17);
            this.alarmTrigger.TabIndex = 7;
            this.alarmTrigger.Text = "вкл / выкл";
            this.alarmTrigger.UseVisualStyleBackColor = true;
            this.alarmTrigger.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(135, 63);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(37, 13);
            this.labelMinutes.TabIndex = 6;
            this.labelMinutes.Text = "минут";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(136, 37);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(36, 13);
            this.labelHours.TabIndex = 5;
            this.labelHours.Text = "часов";
            // 
            // countHours
            // 
            this.countHours.Location = new System.Drawing.Point(28, 35);
            this.countHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.countHours.Name = "countHours";
            this.countHours.ReadOnly = true;
            this.countHours.Size = new System.Drawing.Size(88, 20);
            this.countHours.TabIndex = 3;
            this.countHours.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
            // 
            // countMinutes
            // 
            this.countMinutes.Location = new System.Drawing.Point(28, 61);
            this.countMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.countMinutes.Name = "countMinutes";
            this.countMinutes.ReadOnly = true;
            this.countMinutes.Size = new System.Drawing.Size(88, 20);
            this.countMinutes.TabIndex = 4;
            this.countMinutes.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.OnClockTick);
            // 
            // alarmProgress
            // 
            this.alarmProgress.Location = new System.Drawing.Point(12, 215);
            this.alarmProgress.Maximum = 0;
            this.alarmProgress.Name = "alarmProgress";
            this.alarmProgress.Size = new System.Drawing.Size(210, 23);
            this.alarmProgress.Step = 1;
            this.alarmProgress.TabIndex = 3;
            // 
            // timerAlarm
            // 
            this.timerAlarm.Interval = 1000;
            this.timerAlarm.Tick += new System.EventHandler(this.OnAlarmTick);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(12, 186);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(210, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Выключить";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.OnStopClick);
            // 
            // alarmNotify
            // 
            this.alarmNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.alarmNotify.BalloonTipText = "Я здесь.";
            this.alarmNotify.BalloonTipTitle = "Будильник";
            this.alarmNotify.ContextMenuStrip = this.alarmNotifyContextMenu;
            this.alarmNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("alarmNotify.Icon")));
            this.alarmNotify.Text = "Будильник";
            this.alarmNotify.DoubleClick += new System.EventHandler(this.OnNotifyDoubleClick);
            // 
            // alarmNotifyContextMenu
            // 
            this.alarmNotifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyOpen,
            this.toolStripSeparator1,
            this.notifyExit});
            this.alarmNotifyContextMenu.Name = "alarmNotifyContextMenu";
            this.alarmNotifyContextMenu.Size = new System.Drawing.Size(136, 54);
            // 
            // notifyOpen
            // 
            this.notifyOpen.Name = "notifyOpen";
            this.notifyOpen.Size = new System.Drawing.Size(135, 22);
            this.notifyOpen.Text = "Развернуть";
            this.notifyOpen.Click += new System.EventHandler(this.OnNotifyOpen);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // notifyExit
            // 
            this.notifyExit.Name = "notifyExit";
            this.notifyExit.Size = new System.Drawing.Size(135, 22);
            this.notifyExit.Text = "Выход";
            this.notifyExit.Click += new System.EventHandler(this.OnNotifyExit);
            // 
            // AlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 251);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.alarmProgress);
            this.Controls.Add(this.alarmGroup);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.labelPresentTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlarmClock";
            this.Text = "Будильник";
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.alarmGroup.ResumeLayout(false);
            this.alarmGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMinutes)).EndInit();
            this.alarmNotifyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPresentTime;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.GroupBox alarmGroup;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.NumericUpDown countHours;
        private System.Windows.Forms.NumericUpDown countMinutes;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.CheckBox alarmTrigger;
        private System.Windows.Forms.ProgressBar alarmProgress;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NotifyIcon alarmNotify;
        private System.Windows.Forms.ContextMenuStrip alarmNotifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem notifyOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem notifyExit;

    }
}

