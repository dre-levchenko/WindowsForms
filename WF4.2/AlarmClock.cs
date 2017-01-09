using System;
using System.Windows.Forms;
using System.Media;

namespace WF4._2
{
    public partial class AlarmClock : Form
    {
        private DateTime _alarmTime;
        private readonly SoundPlayer _alarmSound;

        public AlarmClock()
        {
            _alarmTime = new DateTime();
            _alarmSound = new SoundPlayer(@"Resources\ring.wav");

            InitializeComponent();
            timerClock.Start();
            clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void StartAlarmClocking()
        {
            alarmProgress.Value = 0;
            _alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)countHours.Value, (int)countMinutes.Value, 0);
            var tmp = _alarmTime - DateTime.Now;
            if (tmp.CompareTo(new TimeSpan(0)) == -1)
            {
                _alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, (int)countHours.Value, (int)countMinutes.Value, 0);
                tmp = _alarmTime - DateTime.Now;
            }
            alarmProgress.Maximum = (int)tmp.TotalSeconds;
        }

        private void ResetAlarmClocking()
        {
            alarmProgress.Value = 0;
            stopButton.Enabled = false;
            countHours.Enabled = true;
            countMinutes.Enabled = true;
            alarmTrigger.Enabled = true;

            alarmTrigger.Checked = false;
        }

        private void HideToTray()
        {
            this.ShowInTaskbar = false;
            alarmNotify.Visible = true;
            alarmNotify.ShowBalloonTip(500);
        }

        private void ShowFromTray()
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            alarmNotify.Visible = false;
        }



        private void OnCheckedChanged(object sender, EventArgs e)
        {
            if (alarmTrigger.Checked)
            {
                timerAlarm.Start();
                StartAlarmClocking();
            }
            else
            {
                timerAlarm.Stop();
                ResetAlarmClocking();
            }
        }

        private void OnAlarmTick(object sender, EventArgs e)
        {
            alarmProgress.PerformStep();

            if (_alarmTime.Hour == DateTime.Now.Hour && _alarmTime.Minute == DateTime.Now.Minute)
            {
                ShowFromTray();
                _alarmSound.PlayLooping();
                timerAlarm.Stop();
                stopButton.Enabled = true;
                countHours.Enabled = false;
                countMinutes.Enabled = false;
                alarmTrigger.Enabled = false;
            }
        }

        private void OnClockTick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void OnStopClick(object sender, EventArgs e)
        {
            _alarmSound.Stop();
            ResetAlarmClocking();
        }

        private void OnNumericValueChanged(object sender, EventArgs e)
        {
            if (alarmTrigger.Checked)
            {
                StartAlarmClocking();
            }
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideToTray();
            }
        }

        private void OnNotifyOpen(object sender, EventArgs e)
        {
            ShowFromTray();
        }

        private void OnNotifyExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnNotifyDoubleClick(object sender, EventArgs e)
        {
            ShowFromTray();
        }
    }
}
