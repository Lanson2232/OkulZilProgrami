using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulZil
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generalSettings settings = new generalSettings();
            
            settings.Show();
            MessageBox.Show("Lütfen ayarları eksiksiz ve doğru yaptığınızdan emin olunuz. Ayarların eksik ya da yanlış olması durumunda program düzgün çalışmayacaktır.", "Okul Zil Programı");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentAlertTrigger_Click(object sender, EventArgs e)
        {
            decimal value = Properties.Settings.Default.studentVolume;
            int volumeValue = Convert.ToInt32(value);

            Player.settings.volume = volumeValue;
            Player.URL = Properties.Settings.Default.studentAlert;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player.URL = null;
        }

        private void sarlıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal value = Properties.Settings.Default.teacherVolume;
            int volumeValue = Convert.ToInt32(value);

            Player.settings.volume = volumeValue;
            Player.URL = Properties.Settings.Default.teacherAlert;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal value = Properties.Settings.Default.exitVolume;
            int volumeValue = Convert.ToInt32(value);

            Player.settings.volume = volumeValue;
            Player.URL = Properties.Settings.Default.exitAlert;
        }

        private void pazartesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mondayLessons monday = new mondayLessons();
            
            monday.Show();
            MessageBox.Show("Lütfen saat ayalarını eksiksiz ve doğru giriniz.", "Okul Zil Programı");
        }
    }
}
