using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using WMPLib;
using System.Data.SQLite;

namespace Alarm_O_clock
{
    public partial class Form1 : Form
    {
        private SQLiteConnection ConDB;

        Timer timer01 = new Timer();
        bool b = false;
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        //Старт проги
        private void Form1_Load(object sender, EventArgs e)
        {
            ConDB = new SQLiteConnection("Data Source=CapitalDB.db; Version=3");
            if (ConDB == null)
            {
            }
            ConDB.Open();

            off.Enabled = false;
            timer01.Interval = 60000;
            timer01.Tick += new EventHandler(timer1_Tick);
            timer01.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");
        }

        private void on_Click(object sender, EventArgs e)
        {
            if (b == false)
                {
                    AlarmTime.Text = maskedTextBox1.Text;
                    timer2.Start();
                    maskedTextBox1.Visible = false;
                    AlarmTime.Visible = true;
                    on.Text = "Убрать будильник";
                    b = true;
                }
            else if (b == true)
                {
                    AlarmTime.Text = "00:00";
                    timer2.Stop();
                    AlarmTime.Visible = false;
                    maskedTextBox1.Visible = true;
                    on.Text = "Завести";
                    b = false;
                }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TimeNow.Text == AlarmTime.Text)
                {
                    off.Enabled = true;
                    wmp.URL = "D/:Alarm.mp3";
                    wmp.controls.play();
            }
        }

        private void off_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
            off.Enabled = false;
            maskedTextBox1.Visible = true;
            AlarmTime.Visible = false;
            on.Text = "Завести";
            b = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    wmp.URL = "D:/Alarm.mp3";
        //    wmp.controls.play();
        }
    }
}
